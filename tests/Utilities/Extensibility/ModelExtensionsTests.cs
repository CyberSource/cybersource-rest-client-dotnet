using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using NUnit.Framework;
using CyberSource.Utilities.Extensibility;

namespace cybersource_rest_client_netstandard.Test.Utilities.Extensibility
{
    [TestFixture]
    public class ModelExtensionsTests
    {
        // ── Test doubles that mimic a generated model (post Phase-5 regeneration) ──
        // A generated model derives from ModelExtensions and decorates each property
        // with [JsonPropertyName] + [JsonIgnore(WhenWritingDefault)].
        private class FakeNested : ModelExtensions
        {
            [JsonPropertyName("code")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public string Code { get; set; }
        }

        private class FakeRequest : ModelExtensions
        {
            [JsonPropertyName("amount")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public int? Amount { get; set; }

            [JsonPropertyName("currency")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public string Currency { get; set; }

            [JsonPropertyName("clientReferenceInformation")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public FakeNested ClientReferenceInformation { get; set; }
        }

        // Mirrors ApiClient.serializationSettings: Web defaults + WhenWritingNull +
        // the serialize-time conflict guard registered graph-wide.
        private static readonly JsonSerializerOptions WriteOpts =
            new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = new DefaultJsonTypeInfoResolver
                {
                    Modifiers = { ModelExtensions.EnforceExtraFieldConflicts }
                }
            };

        private static string Serialize(object o) => JsonSerializer.Serialize(o, WriteOpts);

        // ── (1) Unmapped field → goes to the overflow store and is emitted ──────────
        [Test]
        public void SetExtraField_Unmapped_AppearsInJson()
        {
            var r = new FakeRequest { Amount = 100 };
            r.SetExtraField("merchantNote", "hello");

            var json = Serialize(r);

            StringAssert.Contains("\"amount\":100", json);
            StringAssert.Contains("\"merchantNote\":\"hello\"", json);
        }

        // ── (2b) Mapped, property null, same/assignable type → WRITES THROUGH ───────
        [Test]
        public void SetExtraField_MappedSameType_WritesThroughToProperty()
        {
            var r = new FakeRequest();

            r.SetExtraField("currency", "USD"); // string -> string property
            r.SetExtraField("amount", 100);     // int -> int? property (IsInstanceOfType)

            Assert.AreEqual("USD", r.Currency);
            Assert.AreEqual(100, r.Amount);
            // Value lives in the typed property, NOT the store.
            Assert.IsTrue(r.ExtensionData == null || !r.ExtensionData.ContainsKey("currency"));
            Assert.IsTrue(r.ExtensionData == null || !r.ExtensionData.ContainsKey("amount"));
        }

        // ── (2c) Mapped, property null, DIFFERENT type → datatype override ──────────
        [Test]
        public void SetExtraField_MappedDifferentType_OverridesDatatype()
        {
            var r = new FakeRequest();

            r.SetExtraField("amount", "95"); // Amount is int?, value is string -> override

            Assert.IsNull(r.Amount);                       // typed property untouched
            var json = Serialize(r);
            StringAssert.Contains("\"amount\":\"95\"", json); // emitted as a STRING
        }

        // ── (2a) Mapped, property already non-null → THROW at SetExtraField ─────────
        [Test]
        public void SetExtraField_PropertyAlreadySet_Throws()
        {
            var r = new FakeRequest { Amount = 100 };

            var ex = Assert.Throws<InvalidOperationException>(
                () => r.SetExtraField("amount", "95"));
            StringAssert.Contains("already set", ex.Message);
        }

        // ── Guard: typed property assigned AFTER an override → THROW at serialize ───
        [Test]
        public void Serialize_ConflictAfterOverride_Throws()
        {
            var r = new FakeRequest();
            r.SetExtraField("amount", "95"); // override stored (Amount still null)
            r.Amount = 95;                   // direct assignment -> both now non-null

            var ex = Assert.Throws<InvalidOperationException>(() => Serialize(r));
            StringAssert.Contains("Conflicting values", ex.Message);
        }

        // ── (2-null) Null value clears the property AND removes any prior override ──
        [Test]
        public void SetExtraField_Null_ClearsOverride()
        {
            var r = new FakeRequest();
            r.SetExtraField("amount", "95"); // override stored
            r.SetExtraField("amount", null); // clear

            var json = Serialize(r);
            StringAssert.DoesNotContain("amount", json); // nothing emitted
        }

        // ── FR-2: GetExtraField reads back, with type coercion ─────────────────────
        [Test]
        public void GetExtraField_ReadsOverrideWithCoercion()
        {
            var r = new FakeRequest();
            r.SetExtraField("amount", "95");

            Assert.AreEqual("95", r.GetExtraField<string>("amount")); // raw
            Assert.AreEqual(95, r.GetExtraField<int>("amount"));      // "95" -> int
        }

        // ── FR-6: GetExtraField falls back to a typed property when unmapped-store empty ──
        [Test]
        public void GetExtraField_FallsBackToTypedProperty()
        {
            var r = new FakeRequest { Currency = "EUR" };

            Assert.AreEqual("EUR", r.GetExtraField<string>("currency"));
            Assert.IsFalse(r.TryGetExtraField<string>("doesNotExist", out _));
        }

        // ── FR-1 "any depth": nested ModelExtensions carries its own extra field ───
        [Test]
        public void SetExtraField_OnNested_AppearsInNestedJson()
        {
            var r = new FakeRequest
            {
                ClientReferenceInformation = new FakeNested { Code = "ABC" }
            };
            r.ClientReferenceInformation.SetExtraField("partnerSku", "XYZ");

            var json = Serialize(r);

            StringAssert.Contains("\"code\":\"ABC\"", json);
            StringAssert.Contains("\"partnerSku\":\"XYZ\"", json);
        }

        // ── Resolution is by JSON NAME, not CLR property name ──────────────────────
        // Links     -> [JsonPropertyName("_links")] -> wire name "_links"
        // SdkLinks  -> [JsonPropertyName("links")]  -> wire name "links"
        // Cc        -> no attribute                  -> camelCase fallback "cc"
        private class LinksModel : ModelExtensions
        {
            [JsonPropertyName("_links")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public string Links { get; set; }

            [JsonPropertyName("links")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public string SdkLinks { get; set; }

            public string Cc { get; set; } // no [JsonPropertyName] -> "cc"
        }

        [Test]
        public void SetExtraField_ResolvesByJsonName_NotClrName()
        {
            var m = new LinksModel();

            m.SetExtraField("_links", "gb");    // matches [JsonPropertyName("_links")] -> Links
            m.SetExtraField("links", "gb1");    // matches [JsonPropertyName("links")]  -> SdkLinks
            m.SetExtraField("sdkLinks", "gb2"); // no JSON property "sdkLinks"          -> overflow store
            m.SetExtraField("cc", "gb3");       // camelCase("Cc") == "cc"              -> Cc

            // Typed properties resolved by their JSON names:
            Assert.AreEqual("gb", m.Links);
            Assert.AreEqual("gb1", m.SdkLinks);
            Assert.AreEqual("gb3", m.Cc);

            // The CLR name "sdkLinks" is NOT a JSON name here -> it stays unmapped:
            Assert.IsNotNull(m.ExtensionData);
            Assert.IsTrue(m.ExtensionData.ContainsKey("sdkLinks"));
            Assert.AreEqual("gb2", m.GetExtraField<string>("sdkLinks"));

            // And the wire JSON reflects all four correctly:
            var json = Serialize(m);
            StringAssert.Contains("\"_links\":\"gb\"", json);
            StringAssert.Contains("\"links\":\"gb1\"", json);
            StringAssert.Contains("\"cc\":\"gb3\"", json);
            StringAssert.Contains("\"sdkLinks\":\"gb2\"", json);
        }

        // ── A MAPPED field matches case-insensitively and writes the CANONICAL name ─
        // "Code", "CODE", "CoDe" all resolve to the same property, and on the wire the
        // canonical [JsonPropertyName("code")] is emitted regardless of input casing.
        [TestCase("code")]
        [TestCase("Code")]
        [TestCase("CODE")]
        [TestCase("CoDe")]
        public void SetExtraField_MappedField_IsCaseInsensitive_AndWritesCanonicalName(string fieldName)
        {
            var r = new FakeNested();
            r.SetExtraField(fieldName, "ABC");

            // Resolved to the typed property regardless of input casing:
            Assert.AreEqual("ABC", r.Code);

            // Wire always carries the single canonical key "code" (not the input casing):
            var json = Serialize(r);
            StringAssert.Contains("\"code\":\"ABC\"", json);
            StringAssert.DoesNotContain("\"Code\"", json);
            StringAssert.DoesNotContain("\"CODE\"", json);
            StringAssert.DoesNotContain("\"CoDe\"", json);
        }

        // ── An UNMAPPED field is emitted VERBATIM (casing is preserved, no camelCase) ─
        // The overflow store writes keys exactly as supplied, so "Code" stays "Code".
        [Test]
        public void SetExtraField_UnmappedField_PreservesExactCasing()
        {
            var r = new FakeRequest { Amount = 100 };
            r.SetExtraField("Code", "ABC"); // no "Code"/"code" property on FakeRequest

            var json = Serialize(r);
            StringAssert.Contains("\"Code\":\"ABC\"", json);   // verbatim, capital C
            StringAssert.DoesNotContain("\"code\":\"ABC\"", json); // NOT camelCased
        }

        // ── Two different casings of an UNMAPPED name are TWO DISTINCT keys ──────────
        // The store uses an ordinal (case-sensitive) comparer, so casing variants do
        // not collide and both survive onto the wire.
        [Test]
        public void SetExtraField_UnmappedDifferentCasings_AreDistinctKeys()
        {
            var r = new FakeRequest { Amount = 100 };
            r.SetExtraField("Code", "one");
            r.SetExtraField("code", "two");

            var json = Serialize(r);
            StringAssert.Contains("\"Code\":\"one\"", json);
            StringAssert.Contains("\"code\":\"two\"", json);
        }

        // ── (#1) Argument validation: null/empty name throws ───────────────────────
        [TestCase(arguments: new object?[] { null })]
        [TestCase("")]
        public void SetExtraField_NullOrEmptyName_Throws(string? name)
        {
            var r = new FakeRequest();
            Assert.Throws<ArgumentNullException>(() => r.SetExtraField(name, "x"));
        }

        [TestCase(arguments: new object?[] { null })]
        [TestCase("")]
        public void GetExtraField_NullOrEmptyName_Throws(string? name)
        {
            var r = new FakeRequest();
            Assert.Throws<ArgumentNullException>(() => r.GetExtraField<string>(name));
        }

        // ── (#2) Re-setting an UNMAPPED name is last-write-wins (one key) ───────────
        [Test]
        public void SetExtraField_UnmappedSetTwice_LastWriteWins()
        {
            var r = new FakeRequest();
            r.SetExtraField("note", "a");
            r.SetExtraField("note", "b");

            var json = Serialize(r);
            StringAssert.Contains("\"note\":\"b\"", json);
            StringAssert.DoesNotContain("\"a\"", json);
            Assert.AreEqual("b", r.GetExtraField<string>("note"));
        }

        // ── (#3) Override → write-through: a later assignable value moves into the
        //         typed property and drops the store override ────────────────────────
        [Test]
        public void SetExtraField_OverrideThenAssignableType_MovesToProperty()
        {
            var r = new FakeRequest();
            r.SetExtraField("amount", "95"); // string override (Amount still null)
            r.SetExtraField("amount", 95);   // int -> int? : write-through

            Assert.AreEqual(95, r.Amount);
            Assert.IsTrue(r.ExtensionData == null || !r.ExtensionData.ContainsKey("amount"));

            var json = Serialize(r);
            StringAssert.Contains("\"amount\":95", json);   // numeric, once
            StringAssert.DoesNotContain("\"amount\":\"95\"", json);
        }

        // ── (#4) You CANNOT null-out an already-set typed property via SetExtraField ─
        // The "already set" guard runs before the null branch, so this throws.
        [Test]
        public void SetExtraField_NullOnAlreadySetProperty_Throws()
        {
            var r = new FakeRequest { Amount = 100 };

            var ex = Assert.Throws<InvalidOperationException>(
                () => r.SetExtraField("amount", null));
            StringAssert.Contains("already set", ex.Message);
        }

        // ── (#5) UNMAPPED + null value -> field is ABSENT from the request JSON ─────
        [Test]
        public void SetExtraField_UnmappedNull_NotEmitted()
        {
            var r = new FakeRequest { Amount = 100 };
            r.SetExtraField("foo", null);

            var json = Serialize(r);
            StringAssert.DoesNotContain("foo", json);
            StringAssert.Contains("\"amount\":100", json);
        }

        // ── (#5b) Setting null clears a previously-stored UNMAPPED override ─────────
        [Test]
        public void SetExtraField_UnmappedNull_ClearsPriorValue()
        {
            var r = new FakeRequest();
            r.SetExtraField("foo", "bar"); // stored
            r.SetExtraField("foo", null);  // cleared

            var json = Serialize(r);
            StringAssert.DoesNotContain("foo", json);
            Assert.IsTrue(r.ExtensionData == null || !r.ExtensionData.ContainsKey("foo"));
        }

        // ── (#6) A non-primitive UNMAPPED value round-trips as a nested JSON object ─
        [Test]
        public void SetExtraField_ComplexValue_SerializesAsObject()
        {
            var r = new FakeRequest();
            r.SetExtraField("meta", new Dictionary<string, object>
            {
                ["a"] = 1,
                ["b"] = "two"
            });

            var json = Serialize(r);
            StringAssert.Contains("\"meta\":{", json);
            StringAssert.Contains("\"a\":1", json);
            StringAssert.Contains("\"b\":\"two\"", json);
        }

        // ── (#7) GetExtraField on an absent field returns default(T), no throw ──────
        [Test]
        public void GetExtraField_Absent_ReturnsDefault()
        {
            var r = new FakeRequest();
            Assert.AreEqual(0, r.GetExtraField<int>("nope"));
            Assert.IsNull(r.GetExtraField<string>("nope"));
        }

        // ── (#8) TryGetExtraField success path returns true + value ────────────────
        [Test]
        public void TryGetExtraField_Present_ReturnsTrueAndValue()
        {
            var r = new FakeRequest();
            r.SetExtraField("note", "hello");

            Assert.IsTrue(r.TryGetExtraField<string>("note", out var value));
            Assert.AreEqual("hello", value);
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  GetExtraField<T> — return-type coverage
        // ══════════════════════════════════════════════════════════════════════════

        private enum Color { Red, Green, Blue }

        private class Widget
        {
            public string Name { get; set; }
            public int Size { get; set; }
        }

        // Mirrors ApiClient.deserializationSettings closely enough for native
        // [JsonExtensionData] capture: Web defaults + WhenWritingNull.
        private static readonly JsonSerializerOptions ReadOpts =
            new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

        private static T Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json, ReadOpts);

        // ── Unmapped primitive read straight from the store ────────────────────────
        [Test]
        public void GetExtraField_UnmappedString_FromStore()
        {
            var r = new FakeRequest();
            r.SetExtraField("note", "hello");

            Assert.AreEqual("hello", r.GetExtraField<string>("note"));
        }

        // ── Numeric coercion from a string store value (AllowReadingFromString) ─────
        [Test]
        public void GetExtraField_CoercesStringToNumber()
        {
            var r = new FakeRequest();
            r.SetExtraField("count", "95"); // stored as a JSON string

            Assert.AreEqual(95, r.GetExtraField<int>("count"));
            Assert.AreEqual(95L, r.GetExtraField<long>("count"));
            Assert.AreEqual(95m, r.GetExtraField<decimal>("count"));
        }

        // ── Boolean read (actual bool). NOTE the asymmetry below. ──────────────────
        [Test]
        public void GetExtraField_ReadsBool()
        {
            var r = new FakeRequest();
            r.SetExtraField("flag", true); // actual bool

            Assert.IsTrue(r.GetExtraField<bool>("flag"));
        }

        // ── Coercion is SYMMETRIC after G7: string<->bool both work ────────────────
        // (ExtensionSerializerOptions includes the read-path BooleanOrStringConverter.)
        [Test]
        public void GetExtraField_CoercesStringToBool()
        {
            var r = new FakeRequest();
            r.SetExtraField("flag", "true"); // stored as a JSON string

            Assert.IsTrue(r.GetExtraField<bool>("flag"));
            Assert.IsTrue(r.TryGetExtraField<bool>("flag", out var v) && v);
        }

        // ── Value types: enum, Guid, DateTime ──────────────────────────────────────
        [Test]
        public void GetExtraField_ReadsEnumGuidDateTime()
        {
            var r = new FakeRequest();
            var id = Guid.NewGuid();
            var when = new DateTime(2026, 6, 26, 10, 30, 0, DateTimeKind.Utc);

            r.SetExtraField("color", Color.Green);
            r.SetExtraField("id", id);
            r.SetExtraField("when", when);

            Assert.AreEqual(Color.Green, r.GetExtraField<Color>("color"));
            Assert.AreEqual(id, r.GetExtraField<Guid>("id"));
            Assert.AreEqual(when, r.GetExtraField<DateTime>("when").ToUniversalTime());
        }

        // ── Nullable<T> read ───────────────────────────────────────────────────────
        [Test]
        public void GetExtraField_ReadsNullable()
        {
            var r = new FakeRequest();
            r.SetExtraField("count", 7);

            int? value = r.GetExtraField<int?>("count");
            Assert.AreEqual(7, value);
            Assert.IsNull(r.GetExtraField<int?>("absent"));
        }

        // ── Model/POCO class: set typed object, read it back as the same POCO type ─
        [Test]
        public void GetExtraField_ComplexObject_ReturnsTypedPoco()
        {
            var r = new FakeRequest();
            r.SetExtraField("widget", new Widget { Name = "gear", Size = 5 });

            var w = r.GetExtraField<Widget>("widget");
            Assert.IsNotNull(w);
            Assert.AreEqual("gear", w.Name);
            Assert.AreEqual(5, w.Size);
        }

        // ── Collections: List<T> and Dictionary<string,T> ─────────────────────────
        [Test]
        public void GetExtraField_ReadsCollections()
        {
            var r = new FakeRequest();
            r.SetExtraField("tags", new[] { "a", "b", "c" });
            r.SetExtraField("meta", new Dictionary<string, int> { ["x"] = 1, ["y"] = 2 });

            var tags = r.GetExtraField<List<string>>("tags");
            CollectionAssert.AreEqual(new[] { "a", "b", "c" }, tags);

            var meta = r.GetExtraField<Dictionary<string, int>>("meta");
            Assert.AreEqual(1, meta["x"]);
            Assert.AreEqual(2, meta["y"]);
        }

        // ── Raw access: GetExtraField<JsonElement> hands back the token ────────────
        [Test]
        public void GetExtraField_AsJsonElement_ReturnsRawToken()
        {
            var r = new FakeRequest();
            r.SetExtraField("widget", new Widget { Name = "gear", Size = 5 });

            var el = r.GetExtraField<JsonElement>("widget");
            Assert.AreEqual(JsonValueKind.Object, el.ValueKind);
            Assert.AreEqual("gear", el.GetProperty("name").GetString());
            Assert.AreEqual(5, el.GetProperty("size").GetInt32());
        }

        // ── Gotcha: GetExtraField<object> returns a boxed JsonElement, not a POCO ──
        [Test]
        public void GetExtraField_AsObject_ReturnsBoxedJsonElement()
        {
            var r = new FakeRequest();
            r.SetExtraField("widget", new Widget { Name = "gear", Size = 5 });

            object value = r.GetExtraField<object>("widget");
            Assert.IsInstanceOf<JsonElement>(value);
        }

        // ── Store value WINS over an (unset) typed property of the same JSON name ──
        [Test]
        public void GetExtraField_StoreOverrideWins_OverNullTypedProperty()
        {
            var r = new FakeRequest();
            r.SetExtraField("amount", "95"); // datatype override; Amount (int?) stays null

            Assert.IsNull(r.Amount);
            Assert.AreEqual("95", r.GetExtraField<string>("amount")); // reads the store
            Assert.AreEqual(95, r.GetExtraField<int>("amount"));      // coerced from store
        }

        // ── FR-6: typed-property fallback, with symmetric coercion (G7) ───────────
        [Test]
        public void GetExtraField_TypedPropertyFallback_WithCoercion()
        {
            var r = new FakeRequest { Amount = 95 };

            Assert.AreEqual(95, r.GetExtraField<int>("amount"));      // same type -> live value
            Assert.AreEqual("95", r.GetExtraField<string>("amount")); // number -> string (G7)
        }

        // ── A mapped property set but null -> returns default, not the store ───────
        [Test]
        public void GetExtraField_MappedPropertyNull_ReturnsDefault()
        {
            var r = new FakeRequest(); // Currency is null, no store entry
            Assert.IsNull(r.GetExtraField<string>("currency"));
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  GetExtraField<T> — RESPONSE (deserialize) path
        //  Native [JsonExtensionData] capture stores unmapped fields as JsonElement
        //  under the exact wire name; GetExtraField reads them just like set values.
        // ══════════════════════════════════════════════════════════════════════════

        [Test]
        public void GetExtraField_FromResponseJson_ReadsUnmappedPrimitive()
        {
            const string json = "{\"amount\":100,\"currency\":\"USD\",\"riskScore\":42}";
            var r = Deserialize<FakeRequest>(json);

            Assert.AreEqual(100, r.Amount);          // typed property bound
            Assert.AreEqual("USD", r.Currency);
            Assert.AreEqual(42, r.GetExtraField<int>("riskScore")); // unmapped -> store
        }

        [Test]
        public void GetExtraField_FromResponseJson_ReadsUnmappedObjectAsPoco()
        {
            const string json = "{\"amount\":100,\"widget\":{\"name\":\"gear\",\"size\":5}}";
            var r = Deserialize<FakeRequest>(json);

            var w = r.GetExtraField<Widget>("widget");
            Assert.IsNotNull(w);
            Assert.AreEqual("gear", w.Name);
            Assert.AreEqual(5, w.Size);

            // ...and the raw token is available too.
            var el = r.GetExtraField<JsonElement>("widget");
            Assert.AreEqual(JsonValueKind.Object, el.ValueKind);
        }

        [Test]
        public void GetExtraField_FromResponseJson_NestedUnmappedField()
        {
            const string json =
                "{\"clientReferenceInformation\":{\"code\":\"ABC\",\"partnerSku\":\"XYZ\"}}";
            var r = Deserialize<FakeRequest>(json);

            Assert.AreEqual("ABC", r.ClientReferenceInformation.Code);          // typed
            Assert.AreEqual("XYZ",
                r.ClientReferenceInformation.GetExtraField<string>("partnerSku")); // unmapped on nested
        }

        [Test]
        public void GetExtraField_FromResponseJson_KeyCasingIsExactForUnmapped()
        {
            const string json = "{\"widgetCount\":3}";
            var r = Deserialize<FakeRequest>(json);

            Assert.AreEqual(3, r.GetExtraField<int>("widgetCount")); // exact wire name
            // Unmapped store is ordinal: a different casing is simply absent.
            Assert.AreEqual(0, r.GetExtraField<int>("WidgetCount"));
            Assert.IsFalse(r.TryGetExtraField<int>("WIDGETCOUNT", out _));
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  Read/write name-casing symmetry for MAPPED names (design G3)
        //  Casing contract: the overflow store is case-SENSITIVE (ordinal), but a
        //  name that maps to a typed property is resolved case-INSENSITIVELY through
        //  TypeJsonMap and normalized to the property's canonical wire name on BOTH
        //  write and read. So a datatype override stored under the canonical key is
        //  found no matter what casing the caller reads with — it must NOT fall
        //  through to the (still-null) typed property and return default.
        // ══════════════════════════════════════════════════════════════════════════

        // ── Mapped datatype override is readable regardless of read casing ─────────
        [TestCase("amount")]
        [TestCase("Amount")]
        [TestCase("AMOUNT")]
        [TestCase("AmOuNt")]
        public void GetExtraField_MappedOverride_IsCaseInsensitive(string readName)
        {
            var r = new FakeRequest();
            r.SetExtraField("amount", "95"); // override stored under canonical "amount"

            Assert.IsNull(r.Amount);                              // typed property still null
            Assert.AreEqual("95", r.GetExtraField<string>(readName)); // store override wins
            Assert.AreEqual(95, r.GetExtraField<int>(readName));      // coerced from the store
            Assert.IsTrue(r.TryGetExtraField<string>(readName, out var v) && v == "95");
        }

        // ── Mapped override written with odd casing is still found on canonical read ─
        [Test]
        public void GetExtraField_MappedOverrideWrittenWithOddCasing_FoundByCanonicalRead()
        {
            var r = new FakeRequest();
            r.SetExtraField("AMOUNT", "95"); // mapped name (any casing) -> canonical "amount"

            Assert.AreEqual("95", r.GetExtraField<string>("amount"));
            Assert.AreEqual("95", r.GetExtraField<string>("Amount"));
        }

        // ── Typed-property fallback is also case-insensitive for mapped names ──────
        [TestCase("currency")]
        [TestCase("Currency")]
        [TestCase("CURRENCY")]
        public void GetExtraField_MappedTypedFallback_IsCaseInsensitive(string readName)
        {
            var r = new FakeRequest { Currency = "EUR" }; // no store entry; typed value only

            Assert.AreEqual("EUR", r.GetExtraField<string>(readName));
            Assert.IsTrue(r.TryGetExtraField<string>(readName, out var v) && v == "EUR");
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  JSON name-map helper — the reflection surface (design G4)
        //  Two correctness rules the surface must guarantee:
        //    (1) keyed on the RUNTIME type, so a subclass's own properties are mapped
        //        and SetExtraField write-through reaches them;
        //    (2) [JsonIgnore] (Always) properties are EXCLUDED, so they never shadow an
        //        extra field of the same JSON name.
        // ══════════════════════════════════════════════════════════════════════════

        // A subclass that adds its own mapped property on top of FakeRequest.
        private class FakeRequestSubclass : FakeRequest
        {
            [JsonPropertyName("loyaltyId")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public string LoyaltyId { get; set; }
        }

        // ── Rule 1: a subclass property is resolved (runtime-type keying) ──────────
        [Test]
        public void NameMap_SubclassProperty_WritesThroughToTypedProperty()
        {
            var r = new FakeRequestSubclass();
            r.SetExtraField("loyaltyId", "L-1"); // subclass-only mapped name

            // Resolved to the subclass typed property, NOT dumped into the store.
            Assert.AreEqual("L-1", r.LoyaltyId);
            Assert.IsTrue(r.ExtensionData == null || !r.ExtensionData.ContainsKey("loyaltyId"));

            // Inherited base property still resolves through the runtime-type map too.
            r.SetExtraField("amount", 100);
            Assert.AreEqual(100, r.Amount);

            var json = Serialize(r);
            StringAssert.Contains("\"loyaltyId\":\"L-1\"", json);
            StringAssert.Contains("\"amount\":100", json);
        }

        // ── Rule 1: GetJsonNameMap is keyed on the type it is given ────────────────
        // (Observed via behavior: the base type does NOT know the subclass-only name,
        // so on a base instance it routes to the overflow store; on the subclass it
        // write-throughs to the typed property.)
        [Test]
        public void NameMap_IsKeyedOnRuntimeType_IncludesSubclassProps()
        {
            var baseInstance = new FakeRequest();
            baseInstance.SetExtraField("loyaltyId", "L-1"); // unknown to base -> overflow
            Assert.IsNotNull(baseInstance.ExtensionData);
            Assert.IsTrue(baseInstance.ExtensionData.ContainsKey("loyaltyId"));

            var subInstance = new FakeRequestSubclass();
            subInstance.SetExtraField("loyaltyId", "L-1"); // known to subclass -> typed
            Assert.AreEqual("L-1", subInstance.LoyaltyId);
            Assert.IsTrue(subInstance.ExtensionData == null ||
                          !subInstance.ExtensionData.ContainsKey("loyaltyId"));
        }

        // A model with a [JsonIgnore] (Always) property that is never on the wire.
        private class IgnoredFieldModel : ModelExtensions
        {
            [JsonPropertyName("amount")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public int? Amount { get; set; }

            [JsonIgnore] // default condition == Always -> never serialized
            public string InternalNote { get; set; }
        }

        // ── Rule 2: a [JsonIgnore] property is excluded from the map ───────────────
        // (Observed via behavior: setting its JSON name does NOT write-through to the
        // ignored CLR property — it routes to the overflow store instead; see
        // NameMap_IgnoredPropertyName_RoutesToOverflowStore below.)

        // ── Rule 2: setting that JSON name routes to the overflow store (not the
        //           ignored CLR property) and so DOES reach the wire ────────────────
        [Test]
        public void NameMap_IgnoredPropertyName_RoutesToOverflowStore()
        {
            var m = new IgnoredFieldModel();
            m.SetExtraField("internalNote", "note-on-wire");

            // The ignored property is untouched; the value lives in the overflow store.
            Assert.IsNull(m.InternalNote);
            Assert.IsNotNull(m.ExtensionData);
            Assert.IsTrue(m.ExtensionData.ContainsKey("internalNote"));

            // And it is emitted as an extra field, exactly as supplied.
            var json = Serialize(m);
            StringAssert.Contains("\"internalNote\":\"note-on-wire\"", json);
        }

        // ── Rule 2: the [JsonIgnore] CLR property itself never serializes ──────────
        [Test]
        public void NameMap_IgnoredProperty_NeverSerializes()
        {
            var m = new IgnoredFieldModel { Amount = 5, InternalNote = "secret-internal" };

            var json = Serialize(m);
            StringAssert.Contains("\"amount\":5", json);
            StringAssert.DoesNotContain("internalNote", json);
            StringAssert.DoesNotContain("secret-internal", json);
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  ToString() extra-field masking (design G1)
        //  Mimics the regenerated modelGeneric.mustache ToString(), which appends
        //  ToStringExtraFields() so the overflow store gets the same masking that
        //  declared properties and ToJson() already receive.
        // ══════════════════════════════════════════════════════════════════════════

        private class FakeToStringModel : ModelExtensions
        {
            [JsonPropertyName("amount")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public int? Amount { get; set; }

            // Reproduces the generated ToString() body: declared properties first,
            // then the masked overflow store.
            public override string ToString()
            {
                var sb = new System.Text.StringBuilder();
                sb.Append("class FakeToStringModel {\n");
                if (Amount != null) sb.Append("  Amount: ").Append(Amount.ToString()).Append("\n");
                sb.Append(ToStringExtraFields());
                sb.Append("}\n");
                return sb.ToString();
            }
        }

        [Test]
        public void ToString_RendersUnmappedExtraField()
        {
            var r = new FakeToStringModel { Amount = 100 };
            r.SetExtraField("merchantNote", "hello");

            var s = r.ToString();
            StringAssert.Contains("  Amount: 100\n", s);
            StringAssert.Contains("  merchantNote: hello\n", s);
        }

        [Test]
        public void ToString_MasksSensitiveExtraField()
        {
            var r = new FakeToStringModel();
            r.SetExtraField("password", "s3cr3t!");

            var s = r.ToString();
            StringAssert.Contains("  password: ***\n", s);
            StringAssert.DoesNotContain("s3cr3t!", s);
        }

        [Test]
        public void ToString_MasksNestedSensitiveExtraField()
        {
            var r = new FakeToStringModel();
            r.SetExtraField("card", new Dictionary<string, object> { ["number"] = "4111111111111111" });

            var s = r.ToString();
            StringAssert.DoesNotContain("4111111111111111", s);
            StringAssert.Contains("***", s);
        }

        [Test]
        public void ToString_NoExtraFields_AddsNothing()
        {
            var r = new FakeToStringModel { Amount = 100 };

            var s = r.ToString();
            Assert.AreEqual("class FakeToStringModel {\n  Amount: 100\n}\n", s);
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  Equals / GetHashCode INCLUDE the overflow store (design G5)
        //  Decision: equality is value-based over the typed (declared) properties AND
        //  the [JsonExtensionData] overflow store. Extra fields are compared by SEMANTIC
        //  JSON value-equality (objects member-wise/order-independent, arrays in order,
        //  numbers by value), since JsonElement has no built-in value equality.
        //  This double mimics the regenerated modelGeneric.mustache Equals/GetHashCode,
        //  which lead with ExtraFieldsEqual(other) and fold GetExtraFieldsHashCode() in.
        // ══════════════════════════════════════════════════════════════════════════

        private class FakeEquatableModel : ModelExtensions, IEquatable<FakeEquatableModel>
        {
            [JsonPropertyName("amount")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public int? Amount { get; set; }

            public override bool Equals(object obj) => Equals(obj as FakeEquatableModel);

            // Declared properties AND the overflow store both participate (G5).
            public bool Equals(FakeEquatableModel other)
            {
                if (other == null) return false;
                return ExtraFieldsEqual(other) &&
                       (this.Amount == other.Amount ||
                        this.Amount != null && this.Amount.Equals(other.Amount));
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    int hash = 41;
                    if (this.Amount != null) hash = hash * 59 + this.Amount.GetHashCode();
                    hash = hash * 59 + GetExtraFieldsHashCode();
                    return hash;
                }
            }

            // Mirrors the regenerated ToString(): declared props then the masked store.
            public override string ToString()
            {
                var sb = new System.Text.StringBuilder();
                sb.Append("class FakeEquatableModel {\n");
                if (Amount != null) sb.Append("  Amount: ").Append(Amount.ToString()).Append("\n");
                sb.Append(ToStringExtraFields());
                sb.Append("}\n");
                return sb.ToString();
            }
        }

        // ── No extra fields on either side -> equal (declared props only) ──────────
        [Test]
        public void Equals_NoExtraFields_Equal()
        {
            var a = new FakeEquatableModel { Amount = 100 };
            var b = new FakeEquatableModel { Amount = 100 };

            Assert.IsTrue(a.Equals(b));
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }

        // ── Same declared + same extra fields -> EQUAL and same hash ───────────────
        [Test]
        public void Equals_SameExtraFields_Equal()
        {
            var a = new FakeEquatableModel { Amount = 100 };
            var b = new FakeEquatableModel { Amount = 100 };
            a.SetExtraField("merchantNote", "vip");
            b.SetExtraField("merchantNote", "vip");

            Assert.IsTrue(a.Equals(b));
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }

        // ── Same declared, DIFFERENT extra-field value -> NOT equal ────────────────
        [Test]
        public void Equals_DifferentExtraFieldValue_NotEqual()
        {
            var a = new FakeEquatableModel { Amount = 100 };
            var b = new FakeEquatableModel { Amount = 100 };
            a.SetExtraField("merchantNote", "vip");
            b.SetExtraField("merchantNote", "regular");

            Assert.IsFalse(a.Equals(b));
        }

        // ── Extra field present on only one side -> NOT equal ──────────────────────
        [Test]
        public void Equals_ExtraFieldOnlyOnOne_NotEqual()
        {
            var a = new FakeEquatableModel { Amount = 100 };
            var b = new FakeEquatableModel { Amount = 100 };
            b.SetExtraField("merchantNote", "vip");

            Assert.IsFalse(a.Equals(b));
            Assert.IsFalse(b.Equals(a));
        }

        // ── Different declared values -> NOT equal (sanity: declared still matters) ─
        [Test]
        public void Equals_DiffersOnDeclaredProperty_NotEqual()
        {
            var a = new FakeEquatableModel { Amount = 100 };
            var b = new FakeEquatableModel { Amount = 200 };

            Assert.IsFalse(a.Equals(b));
        }

        // ── Semantic compare: nested object, member ORDER does not matter ──────────
        [Test]
        public void Equals_NestedObjectMemberOrderIndependent_Equal()
        {
            var a = Deserialize<FakeEquatableModel>("{\"amount\":1,\"meta\":{\"x\":1,\"y\":2}}");
            var b = Deserialize<FakeEquatableModel>("{\"amount\":1,\"meta\":{\"y\":2,\"x\":1}}");

            Assert.IsTrue(a.Equals(b));
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }

        // ── Semantic compare: array ORDER matters ──────────────────────────────────
        [Test]
        public void Equals_ArrayOrderMatters_NotEqual()
        {
            var a = Deserialize<FakeEquatableModel>("{\"tags\":[\"a\",\"b\"]}");
            var b = Deserialize<FakeEquatableModel>("{\"tags\":[\"b\",\"a\"]}");

            Assert.IsFalse(a.Equals(b));
        }

        // ── Semantic compare: numbers by value (1.0 == 1), formatting ignored ──────
        [Test]
        public void Equals_NumberFormattingIgnored_Equal()
        {
            var a = Deserialize<FakeEquatableModel>("{\"ratio\":1.0}");
            var b = Deserialize<FakeEquatableModel>("{\"ratio\":1}");

            Assert.IsTrue(a.Equals(b));
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }

        // ── Semantic compare: a number override vs a string override differ ────────
        [Test]
        public void Equals_NumberVsStringValue_NotEqual()
        {
            var a = new FakeEquatableModel();
            var b = new FakeEquatableModel();
            a.SetExtraField("amountOverride", 95);    // JSON number
            b.SetExtraField("amountOverride", "95");  // JSON string

            Assert.IsFalse(a.Equals(b));
        }

        // ── Extra-field KEYS are case-sensitive (ordinal store) -> NOT equal ───────
        [Test]
        public void Equals_ExtraFieldKeyCasingDiffers_NotEqual()
        {
            var a = new FakeEquatableModel();
            var b = new FakeEquatableModel();
            a.SetExtraField("note", "x");
            b.SetExtraField("Note", "x");

            Assert.IsFalse(a.Equals(b));
        }

        // ── ToString() still surfaces the store (now equal models render the same) ─
        [Test]
        public void ToString_ReflectsOverflowStore()
        {
            var a = new FakeEquatableModel { Amount = 100 };
            var b = new FakeEquatableModel { Amount = 100 };
            a.SetExtraField("merchantNote", "vip");
            b.SetExtraField("merchantNote", "vip");

            Assert.IsTrue(a.Equals(b));
            Assert.AreEqual(a.ToString(), b.ToString());
            StringAssert.Contains("merchantNote: vip", a.ToString());
        }
    }
}
