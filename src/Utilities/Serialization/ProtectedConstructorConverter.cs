using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using CyberSource.Utilities.Extensibility;

namespace CyberSource.Utilities.Serialization
{
    internal class ProtectedConstructorConverter<T> : JsonConverter<T>
    {
        public override T Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return default;
            }

            using var doc = JsonDocument.ParseValue(ref reader);

            // Get the protected constructor.
            var ctor = ProtectedConstructorConverterFactory
                .GetProtectedJsonConstructor(typeof(T));

            if (ctor == null)
            {
                throw new JsonException(
                    $"Type {typeof(T)} has no suitable non-public constructor."
                );
            }

            // Create instance.
            T instance;
            var parameters = ctor.GetParameters();

            if (parameters.Length == 0)
            {
                // Parameterless constructor.
                instance = (T)ctor.Invoke(null);
            }
            else
            {
                // Constructor with parameters - match by name.
                var properties = typeof(T).GetProperties(
                    BindingFlags.Public | BindingFlags.Instance
                );
                var args = new object[parameters.Length];

                for (int i = 0; i < parameters.Length; i++)
                {
                    var param = parameters[i];

                    // Resolve the expected JSON name the same way Write does so
                    // policy-mapped / [JsonPropertyName] names round-trip.
                    var expectedName = GetJsonParameterName(param, properties, options);

                    if (TryGetJsonProperty(doc.RootElement, expectedName, options, out var jsonValue))
                    {
                        args[i] = JsonSerializer.Deserialize(
                            jsonValue.GetRawText(),
                            param.ParameterType,
                            options
                        );
                    }
                    else if (param.HasDefaultValue)
                    {
                        args[i] = param.DefaultValue;
                    }
                    else
                    {
                        args[i] = param.ParameterType.IsValueType
                            ? Activator.CreateInstance(param.ParameterType)
                            : null;
                    }
                }

                instance = (T)ctor.Invoke(args);
            }

            // Populate remaining properties not set by constructor.
            PopulateProperties(instance, doc.RootElement, options);

            // Capture any JSON fields that map to no typed property into the hidden
            // extension store. Native [JsonExtensionData] capture does not fire on this
            // converter path, so we do it here for required-field models.
            CaptureOverflow(instance, doc.RootElement, options);

            return instance;
        }

        private void CaptureOverflow(
            T instance,
            JsonElement element,
            JsonSerializerOptions options)
        {
            if (!(instance is ModelExtensions em)) return;
            if (element.ValueKind != JsonValueKind.Object) return;

            // Build the set of known wire names using the SAME resolution as
            // PopulateProperties, so it is correct under any naming policy (Web
            // camelCase or the PBL CustomContractResolver).
            var known = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var prop in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                // The extension store is not a wire field. Everything else PopulateProperties
                // can bind by name (it ignores JsonIgnore on read), so include it in the
                // known set to avoid double-capturing a field into the overflow store.
                if (prop.GetCustomAttribute<JsonExtensionDataAttribute>() != null) continue;
                known.Add(GetJsonPropertyName(prop, options));
            }

            foreach (var jp in element.EnumerateObject())
            {
                if (known.Contains(jp.Name)) continue;

                if (em.ExtensionData == null)
                    em.ExtensionData = new Dictionary<string, JsonElement>(StringComparer.Ordinal);

                // Indexer (NOT .Add): a duplicate property name in the response would make
                // Dictionary.Add throw; last-wins is safe. Clone so values outlive the JsonDocument.
                em.ExtensionData[jp.Name] = jp.Value.Clone();
            }
        }

        private void PopulateProperties(
            T instance,
            JsonElement element,
            JsonSerializerOptions options)
        {
            var properties = typeof(T).GetProperties(
                BindingFlags.Public | BindingFlags.Instance
            );

            foreach (var propInfo in properties)
            {
                if (!propInfo.CanWrite)
                    continue;

                // Resolve the expected JSON name the same way Write does so
                // policy-mapped / [JsonPropertyName] names round-trip.
                var expectedName = GetJsonPropertyName(propInfo, options);

                if (TryGetJsonProperty(element, expectedName, options, out var jsonValue))
                {
                    var value = JsonSerializer.Deserialize(
                        jsonValue.GetRawText(),
                        propInfo.PropertyType,
                        options
                    );

                    propInfo.SetValue(instance, value);
                }
            }
        }

        /// <summary>
        /// Resolves the JSON property name for a CLR property, honoring
        /// <see cref="JsonPropertyNameAttribute"/> first and then
        /// <see cref="JsonSerializerOptions.PropertyNamingPolicy"/>.
        /// </summary>
        private static string GetJsonPropertyName(
            PropertyInfo prop,
            JsonSerializerOptions options)
        {
            var jsonPropAttr = prop.GetCustomAttribute<JsonPropertyNameAttribute>();
            if (jsonPropAttr != null)
            {
                return jsonPropAttr.Name;
            }

            return options.PropertyNamingPolicy?.ConvertName(prop.Name) ?? prop.Name;
        }

        /// <summary>
        /// Determines whether a value equals the default for its type, used to honor
        /// <see cref="JsonIgnoreCondition.WhenWritingDefault"/> on write. Reference types
        /// default to null; value types default to their zero value.
        /// </summary>
        private static bool IsDefaultValue(object value, Type type)
        {
            if (value == null)
            {
                return true;
            }

            if (type.IsValueType)
            {
                return value.Equals(Activator.CreateInstance(type));
            }

            return false;
        }

        /// <summary>
        /// Resolves the JSON name for a constructor parameter. When a matching
        /// CLR property exists its mapping (including <see cref="JsonPropertyNameAttribute"/>)
        /// is used; otherwise the naming policy is applied to the parameter name.
        /// </summary>
        private static string GetJsonParameterName(
            ParameterInfo param,
            PropertyInfo[] properties,
            JsonSerializerOptions options)
        {
            var matchingProp = properties.FirstOrDefault(p =>
                p.Name.Equals(param.Name, StringComparison.OrdinalIgnoreCase));

            if (matchingProp != null)
            {
                return GetJsonPropertyName(matchingProp, options);
            }

            return options.PropertyNamingPolicy?.ConvertName(param.Name) ?? param.Name;
        }

        /// <summary>
        /// Finds a JSON property by its resolved name. The match honors
        /// <see cref="JsonSerializerOptions.PropertyNameCaseInsensitive"/>.
        /// </summary>
        private static bool TryGetJsonProperty(
            JsonElement element,
            string expectedName,
            JsonSerializerOptions options,
            out JsonElement value)
        {
            // Fast path: exact (case-sensitive) match.
            if (element.TryGetProperty(expectedName, out value))
            {
                return true;
            }

            if (options.PropertyNameCaseInsensitive)
            {
                foreach (var jsonProp in element.EnumerateObject())
                {
                    if (jsonProp.Name.Equals(expectedName, StringComparison.OrdinalIgnoreCase))
                    {
                        value = jsonProp.Value;
                        return true;
                    }
                }
            }

            value = default;
            return false;
        }

        public override void Write(
            Utf8JsonWriter writer,
            T value,
            JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            var properties = typeof(T).GetProperties(
                BindingFlags.Public | BindingFlags.Instance
            );

            foreach (var prop in properties)
            {
                if (!prop.CanRead)
                    continue;

                // The [JsonExtensionData] overflow store is not a normal wire property; it is
                // flattened as top-level members after this loop, not emitted as a nested
                // "extensionData" object.
                if (prop.GetCustomAttribute<JsonExtensionDataAttribute>() != null)
                    continue;

                // Honor [JsonIgnore]. Only an UNCONDITIONAL ignore (Condition = Always, which
                // is also the default when no Condition is given) removes the property
                // outright; a conditional ignore is evaluated against the value below.
                // (Bug fix: previously ANY [JsonIgnore] was skipped, including the
                // [JsonIgnore(Condition = WhenWritingDefault)] every generated model carries,
                // which dropped every property on this write path.)
                var ignoreAttr = prop.GetCustomAttribute<JsonIgnoreAttribute>();
                if (ignoreAttr != null && ignoreAttr.Condition == JsonIgnoreCondition.Always)
                    continue;

                var propValue = prop.GetValue(value);

                // Effective ignore condition: the property's own [JsonIgnore(Condition)] wins,
                // otherwise the serializer-wide DefaultIgnoreCondition.
                var effectiveCondition = ignoreAttr != null
                    ? ignoreAttr.Condition
                    : options.DefaultIgnoreCondition;

                if (effectiveCondition == JsonIgnoreCondition.WhenWritingNull && propValue == null)
                    continue;

                if (effectiveCondition == JsonIgnoreCondition.WhenWritingDefault &&
                    IsDefaultValue(propValue, prop.PropertyType))
                    continue;

                // Resolve the JSON name ([JsonPropertyName] first, then naming policy)
                // so reads and writes stay symmetric.
                var name = GetJsonPropertyName(prop, options);

                writer.WritePropertyName(name);
                JsonSerializer.Serialize(writer, propValue, prop.PropertyType, options);
            }

            // Flatten the [JsonExtensionData] overflow store as top-level members (NFR-3),
            // mirroring how the native serializer writes extension data.
            if (value is ModelExtensions extensible && extensible.ExtensionData != null)
            {
                foreach (var extra in extensible.ExtensionData)
                {
                    writer.WritePropertyName(extra.Key);
                    extra.Value.WriteTo(writer);
                }
            }

            writer.WriteEndObject();
        }
    }
}
