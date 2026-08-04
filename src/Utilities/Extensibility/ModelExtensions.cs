using CyberSource.Utilities.Serialization;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace CyberSource.Utilities.Extensibility
{
    /// <summary>
    /// Abstract base for all generated models. Carries a hidden System.Text.Json
    /// extension-data store and the public API to read/write fields that are not
    /// mapped to typed properties.
    /// </summary>
    /// <remarks>
    /// Casing contract: the overflow <see cref="ExtensionData"/> store is
    /// case-SENSITIVE (ordinal), mirroring how the deserializer captures raw JSON
    /// members and how distinct JSON member names must stay distinct. A name that maps
    /// to a typed property, however, is resolved case-INSENSITIVELY through
    /// <see cref="TypeJsonMap"/> and normalized to that property's canonical wire name
    /// (<see cref="GetCanonicalJsonName"/>) on BOTH write (<see cref="SetExtraField"/>)
    /// and read (<see cref="GetExtraField{TValue}"/>). The store comparer, the map
    /// comparer, and the serialize-time guard key therefore all agree: mapped names are
    /// casing-proof; purely unmapped extra-field keys are matched verbatim.
    /// </remarks>
    public abstract class ModelExtensions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelExtensions"/> class.
        /// </summary>
        protected ModelExtensions() { }

        /// <summary>
        /// Overflow store for unmapped JSON fields. Public because
        /// <see cref="JsonExtensionDataAttribute"/> requires it, but hidden from
        /// IntelliSense and generated docs. Not part of the supported API.
        /// </summary>
        /// <remarks>
        /// Equality policy: this overflow store DOES participate in the generated
        /// <c>Equals</c>/<c>GetHashCode</c> via <see cref="ExtraFieldsEqual"/> /
        /// <see cref="GetExtraFieldsHashCode"/>. Because <see cref="JsonElement"/> has no
        /// built-in value equality, extra fields are compared by SEMANTIC JSON value-equality
        /// (objects member-wise/order-independent, arrays in order, numbers by value). So two
        /// models are equal only when their typed properties AND their extra fields match, and
        /// <c>ToString()</c>/<c>ToJson()</c> surface the (masked) store for diagnostics.
        /// </remarks>
        [JsonExtensionData]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Dictionary<string, JsonElement> ExtensionData { get; set; }

        /// <summary>
        /// Renders this object's extra-field (overflow) store as masked diagnostic lines for
        /// <c>ToString()</c>, so extension data receives the same sensitive-value masking that
        /// declared properties get. Returns an empty string when there are no
        /// extra fields. <c>ToJson()</c> already masks extra fields via the JSON-body walker.
        /// </summary>
        protected string ToStringExtraFields() =>
            SensitiveFieldMaskingUtility.MaskExtraFields(ExtensionData);

        /// <summary>
        /// Value-equality over the overflow (extra-field) store: two models' stores are
        /// equal when they have the same keys (ordinal) and each value is semantically
        /// equal JSON. Called by the generated <c>Equals</c> so extra fields
        /// participate in equality alongside the typed properties.
        /// </summary>
        protected bool ExtraFieldsEqual(ModelExtensions other)
        {
            if (other == null) { return false; }

            var a = ExtensionData;
            var b = other.ExtensionData;

            int countA = a == null ? 0 : a.Count;
            int countB = b == null ? 0 : b.Count;

            if (countA != countB) { return false; }
            if (countA == 0) { return true; }

            foreach (var kv in a)
            {
                if (!b.TryGetValue(kv.Key, out var bv)) { return false; }       // ordinal keys
                if (!JsonElementDeepEquals(kv.Value, bv)) { return false; }
            }
            return true;
        }

        /// <summary>
        /// Order-independent value-hash over the overflow store, consistent with
        /// <see cref="ExtraFieldsEqual"/>. Returns 0 when there are no extra
        /// fields so a model without extension data hashes exactly as the declared
        /// properties alone would.
        /// </summary>
        protected int GetExtraFieldsHashCode()
        {
            var store = ExtensionData;
            if (store == null || store.Count == 0) { return 0; }

            int hash = 0;
            unchecked
            {
                foreach (var kv in store) // sum => independent of key enumeration order
                {
                    hash += (kv.Key.GetHashCode() * 397) ^ JsonElementDeepHash(kv.Value);
                }
            }
            return hash;
        }

        /// <summary>
        /// Semantic value-equality for two <see cref="JsonElement"/> values: objects are
        /// compared member-wise and order-independently, arrays element-wise in order, and
        /// numbers by numeric value (so <c>1.0</c> equals <c>1</c>). <see cref="JsonElement"/>
        /// has no built-in value equality, so this is required for extra-field equality (G5).
        /// </summary>
        private static bool JsonElementDeepEquals(JsonElement a, JsonElement b)
        {
            if (a.ValueKind != b.ValueKind) { return false; }

            switch (a.ValueKind)
            {
                case JsonValueKind.Object:
                    {
                        int countA = 0;

                        foreach (var prop in a.EnumerateObject())
                        {
                            countA++;
                            if (!b.TryGetProperty(prop.Name, out var bVal)) { return false; } // ordinal
                            if (!JsonElementDeepEquals(prop.Value, bVal)) { return false; }
                        }

                        int countB = 0;
                        foreach (var unused in b.EnumerateObject()) { countB++; }
                        return countA == countB;
                    }
                case JsonValueKind.Array:
                    {
                        if (a.GetArrayLength() != b.GetArrayLength()) { return false; }

                        var ea = a.EnumerateArray();
                        var eb = b.EnumerateArray();

                        while (ea.MoveNext() && eb.MoveNext())
                        {
                            if (!JsonElementDeepEquals(ea.Current, eb.Current)) { return false; }
                        }
                        return true;
                    }
                case JsonValueKind.String:
                    {
                        return string.Equals(a.GetString(), b.GetString(), StringComparison.Ordinal);
                    }
                case JsonValueKind.Number:
                    {
                        if (a.TryGetDecimal(out var da) && b.TryGetDecimal(out var db)) { return da == db; }
                        if (a.TryGetDouble(out var fa) && b.TryGetDouble(out var fb)) { return fa == fb; }

                        return string.Equals(a.GetRawText(), b.GetRawText(), StringComparison.Ordinal);
                    }
                case JsonValueKind.True:
                case JsonValueKind.False:
                case JsonValueKind.Null:
                case JsonValueKind.Undefined:
                    {
                        return true; // ValueKind already matched above
                    }
                default:
                    {
                        return string.Equals(a.GetRawText(), b.GetRawText(), StringComparison.Ordinal);
                    }
            }
        }

        /// <summary>
        /// Deep value-hash for a <see cref="JsonElement"/>, consistent with
        /// <see cref="JsonElementDeepEquals"/> (object member order does not affect the hash;
        /// numbers hash by numeric value so <c>1.0</c> and <c>1</c> agree).
        /// </summary>
        private static int JsonElementDeepHash(JsonElement e)
        {
            unchecked
            {
                switch (e.ValueKind)
                {
                    case JsonValueKind.Object:
                        {
                            int ho = 17;

                            foreach (var p in e.EnumerateObject()) // sum => order-independent
                            {
                                ho += (p.Name.GetHashCode() * 31) ^ JsonElementDeepHash(p.Value);
                            }
                            return ho;
                        }
                    case JsonValueKind.Array:
                        {
                            int ha = 19;

                            foreach (var item in e.EnumerateArray())
                            {
                                ha = ha * 31 + JsonElementDeepHash(item);
                            }
                            return ha;
                        }
                    case JsonValueKind.String:
                        {
                            var s = e.GetString();
                            return s == null ? 0 : s.GetHashCode();
                        }
                    case JsonValueKind.Number:
                        {
                            if (e.TryGetDecimal(out var d)) { return d.GetHashCode(); }
                            if (e.TryGetDouble(out var f)) { return f.GetHashCode(); }
                            return e.GetRawText().GetHashCode();
                        }
                    case JsonValueKind.True: { return 1; }
                    case JsonValueKind.False: { return 0; }
                    case JsonValueKind.Null:
                    case JsonValueKind.Undefined: { return -1; }
                    default: { return e.GetRawText().GetHashCode(); }
                }
            }
        }


        /// <summary>
        /// Options used when SERIALIZING caller-supplied values INTO the overflow store
        /// (<see cref="SetExtraField"/> and the write half of the read round-trip).
        /// Matches the wire policy: Web defaults (camelCase names, case-insensitive
        /// reads, AllowReadingFromString) + WhenWritingNull.
        /// </summary>
        /// <remarks>
        /// Includes <see cref="StringOrNumberConverter"/> / <see cref="BooleanOrStringConverter"/>
        /// so their <c>Write</c> methods participate on the write side (e.g. a caller-supplied
        /// numeric value flows through the same converter surface as model serialization).
        /// Kept separate from <see cref="ExtensionDeserializerOptions"/> so future changes
        /// to the write policy (naming, ignore-condition, extra write-only converters) can
        /// be made without affecting the read path.
        /// </remarks>
        internal static readonly JsonSerializerOptions ExtensionSerializerOptions =
            new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new StringOrNumberConverter(),
                    new BooleanOrStringConverter()
                }
            };

        /// <summary>
        /// Options used when DESERIALIZING values OUT OF the overflow store
        /// (<see cref="GetExtraField{TValue}"/> / <see cref="TryGetExtraField{TValue}"/>,
        /// including the read-back half of the typed-property fallback round-trip).
        /// Matches the wire policy: Web defaults (case-insensitive reads,
        /// AllowReadingFromString) + WhenWritingNull.
        /// </summary>
        /// <remarks>
        /// Includes the read-path converters (<see cref="StringOrNumberConverter"/> /
        /// <see cref="BooleanOrStringConverter"/>) so extra-field coercion matches model
        /// deserialization: both string&lt;-&gt;number and string&lt;-&gt;bool coerce symmetrically.
        /// Kept separate from <see cref="ExtensionSerializerOptions"/> so future changes to
        /// the read policy (extra read-only converters, tolerant number handling, custom
        /// naming policies for materialized POCOs) can be made without affecting the write
        /// path. Currently mirrors the writer options to keep the split behavior-preserving.
        /// This is the SDK default and is used as the fallback when no consumer-provided
        /// options have been registered via <see cref="SetDeserializerOptions"/>.
        /// </remarks>
        internal static readonly JsonSerializerOptions ExtensionDeserializerOptions =
            new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new StringOrNumberConverter(),
                    new BooleanOrStringConverter()
                }
            };

        // ──────────────────────────────────────────────────────────────────────────
        //  Consumer-provided deserializer options (injection surface)
        //  Backs the read path (GetExtraField / TryGetExtraField) so callers who
        //  supply their own JsonSerializerOptions through the configuration surface
        //  (IMerchantNetworkSettings.DeserializationOptions) have those options
        //  honored when materializing values out of the overflow store.
        //  Null means "no consumer override" -> the read path falls back to the
        //  SDK default ExtensionDeserializerOptions above.
        //  Volatile so writes from ApiClient construction are immediately visible
        //  to reader threads without additional synchronization.
        // ──────────────────────────────────────────────────────────────────────────
        private static volatile JsonSerializerOptions _consumerDeserializerOptions;

        // ──────────────────────────────────────────────────────────────────────────
        //  Consumer-provided serializer options (injection surface)
        //  Backs the write path (SetExtraField and the write half of the read
        //  round-trip in GetExtraField) so callers who supply their own
        //  JsonSerializerOptions through the configuration surface
        //  (IMerchantNetworkSettings.SerializationOptions) have those options
        //  honored when materializing caller-supplied values INTO the overflow store.
        //  Null means "no consumer override" -> the write path falls back to the
        //  SDK default ExtensionSerializerOptions above.
        //  Volatile so writes from ApiClient construction are immediately visible
        //  to reader threads without additional synchronization. Intentionally
        //  distinct from _consumerDeserializerOptions so serialization and
        //  deserialization tracks stay separate.
        // ──────────────────────────────────────────────────────────────────────────
        private static volatile JsonSerializerOptions _consumerSerializerOptions;

        /// <summary>
        /// Registers consumer-supplied <see cref="JsonSerializerOptions"/> for the extra-field
        /// read path used by <see cref="GetExtraField{TValue}"/> and <see cref="TryGetExtraField{TValue}"/>.
        /// When set to a non-null value, those options are used verbatim when materializing
        /// values out of the overflow store; when set to <c>null</c>, the read path falls back
        /// to the SDK default <see cref="ExtensionDeserializerOptions"/>.
        /// </summary>
        /// <param name="options">
        /// The consumer-provided options to use for extra-field reads, or <c>null</c> to clear
        /// a previously registered override and revert to the SDK default.
        /// </param>
        /// <remarks>
        /// This is the sole injection surface for consumer deserializer options on the
        /// overflow-store read path. The SDK invokes it from <see cref="ApiClient"/> during
        /// construction with the value threaded through
        /// <see cref="IMerchantNetworkSettings.DeserializationOptions"/> so extra-field reads
        /// on generated models honor the same options that <see cref="ApiClient.Deserialize"/>
        /// uses. The write path (<see cref="SetExtraField"/>) has its own independent injection
        /// surface via <see cref="SetSerializerOptions"/> and is not affected by this setter.
        /// </remarks>
        public static void SetDeserializerOptions(JsonSerializerOptions options)
        {
            _consumerDeserializerOptions = options;
        }

        /// <summary>
        /// Registers consumer-supplied <see cref="JsonSerializerOptions"/> for the extra-field
        /// write path used by <see cref="SetExtraField(string, object)"/> and the write half of
        /// the typed-property fallback round-trip in <see cref="GetExtraField{TValue}"/>.
        /// When set to a non-null value, those options are used verbatim when serializing
        /// caller-supplied values into the overflow store; when set to <c>null</c>, the write
        /// path falls back to the SDK default <see cref="ExtensionSerializerOptions"/>.
        /// </summary>
        /// <param name="options">
        /// The consumer-provided options to use for extra-field writes, or <c>null</c> to clear
        /// a previously registered override and revert to the SDK default.
        /// </param>
        /// <remarks>
        /// Companion to <see cref="SetDeserializerOptions"/> for the write path. The SDK invokes
        /// it from <see cref="ApiClient"/> during construction with the value threaded through
        /// <see cref="IMerchantNetworkSettings.SerializationOptions"/> so extra-field writes on
        /// generated models honor the same options that <see cref="ApiClient.Serialize"/> uses.
        /// Kept intentionally distinct from <see cref="SetDeserializerOptions"/> so
        /// serialization and deserialization can be customized independently.
        /// </remarks>
        public static void SetSerializerOptions(JsonSerializerOptions options)
        {
            _consumerSerializerOptions = options;
        }

        /// <summary>
        /// The effective <see cref="JsonSerializerOptions"/> used by the extra-field read path:
        /// consumer-provided options when registered via <see cref="SetDeserializerOptions"/>,
        /// otherwise the SDK default <see cref="ExtensionDeserializerOptions"/>.
        /// </summary>
        internal static JsonSerializerOptions EffectiveDeserializerOptions =>
            _consumerDeserializerOptions ?? ExtensionDeserializerOptions;

        /// <summary>
        /// The effective <see cref="JsonSerializerOptions"/> used by the extra-field write path:
        /// consumer-provided options when registered via <see cref="SetSerializerOptions"/>,
        /// otherwise the SDK default <see cref="ExtensionSerializerOptions"/>.
        /// </summary>
        internal static JsonSerializerOptions EffectiveSerializerOptions =>
            _consumerSerializerOptions ?? ExtensionSerializerOptions;

        // ──────────────────────────────────────────────────────────────────────────
        //  JSON name-map helper
        //  The single reflection surface that backs SetExtraField / GetExtraField /
        //  TryGetExtraField. It maps a field's CANONICAL JSON wire name to the CLR
        //  PropertyInfo that owns it. Three members make up the surface and must be
        //  used together; do not reintroduce ad-hoc reflection elsewhere:
        //    • GetJsonNameMap(Type)      -> cached "canonical JSON name -> PropertyInfo"
        //    • TypeJsonMap               -> instance shortcut: GetJsonNameMap(GetType())
        //    • GetCanonicalJsonName(prop)-> a property's canonical wire name
        //  Two correctness rules the surface guarantees:
        //    (1) keyed on the RUNTIME type (GetType()), so subclass properties
        //        are included and a subclass field write-through works.
        //    (2) EXCLUDES [JsonIgnore] (Always) properties — they are never on the wire,
        //        so they must not shadow an extra field of the same JSON name.
        //  The map comparer is OrdinalIgnoreCase and keys are canonical names, so it
        //  agrees with the case-sensitive (ordinal) overflow store and the
        //  serialize-time guard keyed on JsonPropertyInfo.Name (see the casing
        //  contract in the class remarks).
        // ──────────────────────────────────────────────────────────────────────────

        // Per-type "canonical JSON name -> PropertyInfo" cache. Built once
        // per concrete runtime type so subclass properties are included.
        private static readonly ConcurrentDictionary<Type, Dictionary<string, PropertyInfo>> _maps =
            new ConcurrentDictionary<Type, Dictionary<string, PropertyInfo>>();

        // Resolved against the runtime type so overrides/subclasses are honored.
        private Dictionary<string, PropertyInfo> TypeJsonMap => GetJsonNameMap(GetType());

        /// <summary>
        /// Returns the cached canonical-JSON-name to <see cref="PropertyInfo"/> map for a
        /// type. Keyed on the supplied (runtime) type so subclass properties
        /// are included; excludes <c>[JsonIgnore]</c> (Always) properties.
        /// </summary>
        internal static Dictionary<string, PropertyInfo> GetJsonNameMap(Type type) =>
            _maps.GetOrAdd(type, BuildJsonNameMap);

        private static Dictionary<string, PropertyInfo> BuildJsonNameMap(Type type)
        {
            // Case-insensitive to mirror Web-defaults read behavior; canonical keys
            // are stored so the serialize-time guard (keyed on JsonPropertyInfo.Name)
            // and this map agree.
            var map = new Dictionary<string, PropertyInfo>(StringComparer.OrdinalIgnoreCase);

            foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                // Never treat the extension store as a field.
                if (prop.GetCustomAttribute<JsonExtensionDataAttribute>() != null) { continue; }

                // Skip only properties that are NEVER on the wire ([JsonIgnore] with the
                // default Always condition). Conditional ignores (WhenWritingDefault/Null),
                // which every generated property carries, ARE wire fields and must map.
                var ignore = prop.GetCustomAttribute<JsonIgnoreAttribute>();
                if (ignore != null && ignore.Condition == JsonIgnoreCondition.Always) { continue; }

                map[GetCanonicalJsonName(prop)] = prop; // derived hides base by name
            }

            return map;
        }

        /// <summary>
        /// Canonical wire name for a property: explicit [JsonPropertyName] wins,
        /// otherwise the Web-defaults camelCase policy is applied.
        /// </summary>
        internal static string GetCanonicalJsonName(PropertyInfo prop)
        {
            var attr = prop.GetCustomAttribute<JsonPropertyNameAttribute>();
            return attr != null
                ? attr.Name
                : JsonNamingPolicy.CamelCase.ConvertName(prop.Name);
        }

        /// <summary>
        /// Sends a field by its JSON name, at this object's level. Unmapped names go
        /// to the overflow store; mapped names follow the conflict policy.
        /// </summary>
        public void SetExtraField(string jsonPropertyName, object value)
        {
            if (string.IsNullOrEmpty(jsonPropertyName))
            {
                throw new ArgumentNullException(nameof(jsonPropertyName));
            }

            // (1) Not in the model -> straight to the overflow store. No typed property
            // can collide with this name, so it is emitted exactly once.
            if (!TypeJsonMap.TryGetValue(jsonPropertyName, out var prop))
            {
                // Null means "absent": clear any prior value and never emit a null key.
                // (Mirrors the mapped-name null branch below; WhenWritingNull does NOT
                // filter [JsonExtensionData] values, so a stored null would otherwise be
                // written as "name":null.)
                if (value == null)
                {
                    if (ExtensionData != null) { ExtensionData.Remove(jsonPropertyName); }
                    return;
                }

                if (ExtensionData == null)
                {
                    ExtensionData = new Dictionary<string, JsonElement>(StringComparer.Ordinal);
                }

                ExtensionData[jsonPropertyName] =
                    JsonSerializer.SerializeToElement(value, EffectiveSerializerOptions);
                return;
            }

            // Normalize to the property's canonical JSON name so the serialize-time
            // guard and the overflow store agree on one key.
            string name = GetCanonicalJsonName(prop);

            // (2a) Already set on the model (non-null) -> reject. Overriding via
            // SetExtraField is only allowed while the typed property is null.
            if (prop.CanRead && prop.GetValue(this) != null)
            {
                throw new InvalidOperationException(
                    $"'{name}' is already set on the model and cannot be set again via SetExtraField.");
            }

            // (2-null) Null value on a mapped name -> clear the typed property; never
            // store a colliding null in the overflow store.
            if (value == null)
            {
                if (prop.CanWrite) { prop.SetValue(this, null); }
                if (ExtensionData != null) { ExtensionData.Remove(name); }
                return;
            }

            // (2b) Same / assignable type -> write THROUGH to the typed property so the
            // value gets normal object semantics. IsInstanceOfType handles int->int?,
            // derived->base, etc.
            Type target = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
            if (prop.CanWrite && target.IsInstanceOfType(value))
            {
                prop.SetValue(this, value);
                if (ExtensionData != null) { ExtensionData.Remove(name); } // one name -> one place
                return;
            }

            // (2c) Different type -> datatype override. Stored raw; on write the
            // (still-null) typed property is skipped and this value wins.
            if (ExtensionData == null)
            {
                ExtensionData = new Dictionary<string, JsonElement>(StringComparer.Ordinal);
            }

            ExtensionData[name] = JsonSerializer.SerializeToElement(value, EffectiveSerializerOptions);
        }

        /// <summary>
        /// Reads a field by its JSON name and materializes it as <typeparamref name="TValue"/>.
        /// Falls back to a typed property of the same JSON name. Returns
        /// <c>default</c> when absent.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <typeparamref name="TValue"/> can be any type System.Text.Json can produce from
        /// the stored value: primitives and value types (<see cref="string"/>, numeric
        /// types, <see cref="bool"/>, <see cref="System.DateTime"/>, <see cref="System.Guid"/>,
        /// enums, their <c>Nullable&lt;T&gt;</c> forms), collections (arrays,
        /// <c>List&lt;T&gt;</c>, <c>Dictionary&lt;string,T&gt;</c>), model/POCO classes
        /// (including nested <see cref="ExtensibleModel"/> types), and raw
        /// <see cref="System.Text.Json.JsonElement"/>.
        /// </para>
        /// <para>
        /// Why this is generic and there is intentionally NO non-generic
        /// <c>object GetExtraField(string)</c> overload: unmapped values live in the store
        /// as JSON only (<see cref="System.Text.Json.JsonElement"/>), and JSON does not carry
        /// the originating CLR type (there is no <c>$type</c> discriminator). The caller is the
        /// only party that knows the intended type, so it must be supplied via
        /// <typeparamref name="TValue"/>. A non-generic version could not reconstruct a model
        /// class for an unmapped field; the best it could do is return a
        /// <see cref="System.Text.Json.JsonElement"/> for objects/arrays and guessed boxed
        /// primitives otherwise (e.g. an ambiguous <c>int</c> vs <c>long</c> vs <c>decimal</c>
        /// for a JSON number), and its return type would flip unpredictably between a real
        /// model and a <see cref="System.Text.Json.JsonElement"/> depending on the value.
        /// For raw access, request <c>GetExtraField&lt;JsonElement&gt;(name)</c> explicitly.
        /// </para>
        /// </remarks>
        public TValue GetExtraField<TValue>(string jsonPropertyName)
        {
            if (string.IsNullOrEmpty(jsonPropertyName))
            {
                throw new ArgumentNullException(nameof(jsonPropertyName));
            }

            // If the name maps to a typed property, probe the store under the canonical
            // key so a case-mismatched override is still found (design G3).
            PropertyInfo prop;
            string key = TypeJsonMap.TryGetValue(jsonPropertyName, out prop)
                ? GetCanonicalJsonName(prop)
                : jsonPropertyName;

            // 1) Unmapped/override value captured in the store (O(1)).
            if (ExtensionData != null && ExtensionData.TryGetValue(key, out var element))
            {
                return element.Deserialize<TValue>(EffectiveDeserializerOptions);
            }

            // 2) Mapped fallback: a typed property exists for this JSON name.
            if (prop != null)
            {
                var raw = prop.GetValue(this);

                if (raw == null) { return default; }
                if (raw is TValue typed) { return typed; }

                // Round-trip through JSON for type coercion ("95" -> int, etc.).
                return JsonSerializer
                    .SerializeToElement(raw, EffectiveSerializerOptions)
                    .Deserialize<TValue>(EffectiveDeserializerOptions);
            }

            // 3) Absent -> default(T), no throw.
            return default;
        }

        /// <summary>
        /// Non-throwing variant of <see cref="GetExtraField{TValue}"/>. Returns
        /// <c>false</c> (and <c>default</c>) when the field is absent or cannot be
        /// materialized as <typeparamref name="TValue"/>.
        /// </summary>
        public bool TryGetExtraField<TValue>(string jsonPropertyName, out TValue value)
        {
            try
            {
                string key = TypeJsonMap.TryGetValue(jsonPropertyName, out PropertyInfo prop)
                    ? GetCanonicalJsonName(prop)
                    : jsonPropertyName;

                if ((ExtensionData != null && ExtensionData.ContainsKey(key)) || prop != null)
                {
                    value = GetExtraField<TValue>(jsonPropertyName);
                    return true;
                }
            }
            catch
            {
                /* fall through to default/false */
            }

            value = default;
            return false;
        }

        /// <summary>
        /// <see cref="IJsonTypeInfoResolver"/> modifier that throws at serialization
        /// time when a JSON field is set BOTH as a typed property and via
        /// <see cref="SetExtraField"/> (the "assigned after override" case that
        /// SetExtraField cannot observe). Register on the serialize options.
        /// </summary>
        public static void EnforceExtraFieldConflicts(JsonTypeInfo typeInfo)
        {
            if (typeInfo.Kind != JsonTypeInfoKind.Object) { return; }

            foreach (var prop in typeInfo.Properties)
            {
                var jsonName = prop.Name;                 // canonical wire name
                var inner = prop.ShouldSerialize;         // preserve WhenWritingNull/Default

                prop.ShouldSerialize = (obj, val) =>
                {
                    if (val != null &&
                        obj is ModelExtensions em &&
                        em.ExtensionData != null &&
                        em.ExtensionData.TryGetValue(jsonName, out var ext) &&
                        ext.ValueKind != JsonValueKind.Null)
                    {
                        throw new InvalidOperationException(
                            $"Conflicting values for JSON field '{jsonName}': it is set both as a " +
                            "typed property and via SetExtraField. Provide only one.");
                    }

                    return inner != null ? inner(obj, val) : val != null;
                };
            }
        }
    }
}
