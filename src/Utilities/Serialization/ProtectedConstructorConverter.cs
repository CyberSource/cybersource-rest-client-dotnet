using System;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CyberSource.Utilities.Serialization
{
    public class ProtectedConstructorConverter<T> : JsonConverter<T>
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

            return instance;
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

                // Check for [JsonIgnore].
                if (prop.GetCustomAttribute<JsonIgnoreAttribute>() != null)
                    continue;

                var propValue = prop.GetValue(value);

                // Apply ignore conditions.
                if (options.DefaultIgnoreCondition ==
                    JsonIgnoreCondition.WhenWritingNull && propValue == null)
                {
                    continue;
                }

                // Resolve the JSON name ([JsonPropertyName] first, then naming policy)
                // so reads and writes stay symmetric.
                var name = GetJsonPropertyName(prop, options);

                writer.WritePropertyName(name);
                JsonSerializer.Serialize(writer, propValue, prop.PropertyType, options);
            }

            writer.WriteEndObject();
        }
    }
}
