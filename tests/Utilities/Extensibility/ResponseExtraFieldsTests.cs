using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using NUnit.Framework;
using CyberSource.Utilities.Extensibility;
using CyberSource.Utilities.Serialization;

namespace cybersource_rest_client_netstandard.Test.Utilities.Extensibility
{
    /// <summary>
    /// End-to-end RESPONSE path: deserialize a JSON response body the same way
    /// <c>ApiClient.Deserialize</c> does, then read unmapped fields via GetExtraField.
    /// Covers BOTH capture mechanisms:
    ///  - native [JsonExtensionData] capture for public-ctor models, and
    ///  - ProtectedConstructorConverter.CaptureOverflow for required-field (protected
    ///    [JsonConstructor]) models, which the native path does not handle.
    /// </summary>
    [TestFixture]
    public class ResponseExtraFieldsTests
    {
        // Mirrors ApiClient.deserializationSettings exactly: Web defaults +
        // WhenWritingNull + the protected-ctor factory + the coercion converters.
        private static readonly JsonSerializerOptions ReadOpts =
            new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new ProtectedConstructorConverterFactory(),
                    new StringOrNumberConverter(),
                    new BooleanOrStringConverter()
                }
            };

        private static T Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json, ReadOpts);

        // Mirrors ApiClient.serializationSettings for the request (write) path.
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

        // ── Test doubles ───────────────────────────────────────────────────────────

        private class Widget
        {
            public string Name { get; set; }
            public int Size { get; set; }
        }

        // Public-ctor model -> native [JsonExtensionData] capture path.
        private class RespModel : ModelExtensions
        {
            [JsonPropertyName("amount")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public int? Amount { get; set; }

            [JsonPropertyName("currency")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public string Currency { get; set; }

            [JsonPropertyName("nested")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public RespNested Nested { get; set; }
        }

        private class RespNested : ModelExtensions
        {
            [JsonPropertyName("code")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public string Code { get; set; }
        }

        // Required-field model -> protected [JsonConstructor] triggers the converter,
        // and CaptureOverflow (NOT native) must populate the extension store.
        private class RespRequiredModel : ModelExtensions
        {
            [JsonPropertyName("code")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public string Code { get; set; }

            [JsonPropertyName("amount")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public int? Amount { get; set; }

            [JsonPropertyName("child")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public RespRequiredChild Child { get; set; }

            [JsonConstructor]
            protected RespRequiredModel() { }
        }

        private class RespRequiredChild : ModelExtensions
        {
            [JsonPropertyName("sku")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public string Sku { get; set; }

            [JsonConstructor]
            protected RespRequiredChild() { }
        }

        // Backward-compatibility model pair. Same wire contract, two SDK versions.
        // OLD SDK: 'merchantCategoryCode' is NOT a typed property (unknown field).
        private class OrderV1 : ModelExtensions
        {
            [JsonPropertyName("amount")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public int? Amount { get; set; }
        }

        // NEW SDK: the same wire field has since been promoted to a typed property.
        private class OrderV2 : ModelExtensions
        {
            [JsonPropertyName("amount")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public int? Amount { get; set; }

            [JsonPropertyName("merchantCategoryCode")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public string MerchantCategoryCode { get; set; }
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  Native capture path (public-ctor models)
        // ══════════════════════════════════════════════════════════════════════════

        [Test]
        public void Native_TypedFieldsBound_AndUnmappedScalarCaptured()
        {
            const string json = "{\"amount\":100,\"currency\":\"USD\",\"riskScore\":42}";
            var r = Deserialize<RespModel>(json);

            Assert.AreEqual(100, r.Amount);            // typed
            Assert.AreEqual("USD", r.Currency);        // typed
            Assert.AreEqual(42, r.GetExtraField<int>("riskScore")); // unmapped -> store
        }

        [Test]
        public void Native_UnmappedObject_ReadableAsPocoAndJsonElement()
        {
            const string json = "{\"amount\":1,\"widget\":{\"name\":\"gear\",\"size\":5}}";
            var r = Deserialize<RespModel>(json);

            var w = r.GetExtraField<Widget>("widget");
            Assert.IsNotNull(w);
            Assert.AreEqual("gear", w.Name);
            Assert.AreEqual(5, w.Size);

            var el = r.GetExtraField<JsonElement>("widget");
            Assert.AreEqual(JsonValueKind.Object, el.ValueKind);
            Assert.AreEqual(5, el.GetProperty("size").GetInt32());
        }

        [Test]
        public void Native_UnmappedArray_ReadableAsList()
        {
            const string json = "{\"tags\":[\"a\",\"b\",\"c\"]}";
            var r = Deserialize<RespModel>(json);

            var tags = r.GetExtraField<List<string>>("tags");
            CollectionAssert.AreEqual(new[] { "a", "b", "c" }, tags);
        }

        [Test]
        public void Native_NestedModel_UnmappedFieldCapturedOnNested()
        {
            const string json = "{\"nested\":{\"code\":\"ABC\",\"partnerSku\":\"XYZ\"}}";
            var r = Deserialize<RespModel>(json);

            Assert.AreEqual("ABC", r.Nested.Code);                                  // typed on nested
            Assert.AreEqual("XYZ", r.Nested.GetExtraField<string>("partnerSku"));   // unmapped on nested
        }

        [Test]
        public void Native_MultipleUnmappedFields_AllCaptured()
        {
            const string json = "{\"amount\":1,\"a\":\"x\",\"b\":2,\"c\":true}";
            var r = Deserialize<RespModel>(json);

            Assert.AreEqual("x", r.GetExtraField<string>("a"));
            Assert.AreEqual(2, r.GetExtraField<int>("b"));
            Assert.IsTrue(r.GetExtraField<bool>("c"));
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  Converter capture path (required-field / protected-ctor models)
        // ══════════════════════════════════════════════════════════════════════════

        [Test]
        public void Converter_RequiredModel_TypedBound_AndUnmappedCaptured()
        {
            const string json = "{\"code\":\"ABC\",\"amount\":7,\"extra\":\"hello\"}";
            var r = Deserialize<RespRequiredModel>(json);

            Assert.AreEqual("ABC", r.Code);      // typed (PopulateProperties)
            Assert.AreEqual(7, r.Amount);        // typed
            Assert.AreEqual("hello", r.GetExtraField<string>("extra")); // CaptureOverflow
        }

        [Test]
        public void Converter_RequiredModel_UnmappedObjectAsPoco()
        {
            const string json = "{\"code\":\"ABC\",\"widget\":{\"name\":\"gear\",\"size\":9}}";
            var r = Deserialize<RespRequiredModel>(json);

            var w = r.GetExtraField<Widget>("widget");
            Assert.IsNotNull(w);
            Assert.AreEqual("gear", w.Name);
            Assert.AreEqual(9, w.Size);
        }

        [Test]
        public void Converter_RequiredModel_NestedRequiredChild_UnmappedCaptured()
        {
            const string json =
                "{\"code\":\"ABC\",\"child\":{\"sku\":\"S1\",\"note\":\"n\"}}";
            var r = Deserialize<RespRequiredModel>(json);

            Assert.AreEqual("S1", r.Child.Sku);                              // typed on nested
            Assert.AreEqual("n", r.Child.GetExtraField<string>("note"));     // unmapped on nested
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  Coercion on the response path (G7) — symmetric string<->number / string<->bool
        // ══════════════════════════════════════════════════════════════════════════

        [Test]
        public void Response_NumberReadAsString_Coerces()
        {
            const string json = "{\"score\":95}";
            var r = Deserialize<RespModel>(json);

            Assert.AreEqual("95", r.GetExtraField<string>("score")); // number -> string
            Assert.AreEqual(95, r.GetExtraField<int>("score"));
        }

        [Test]
        public void Response_StringReadAsNumberAndBool_Coerces()
        {
            const string json = "{\"score\":\"95\",\"flag\":\"true\"}";
            var r = Deserialize<RespModel>(json);

            Assert.AreEqual(95, r.GetExtraField<int>("score"));  // string -> number
            Assert.IsTrue(r.GetExtraField<bool>("flag"));        // string -> bool
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  Edge cases
        // ══════════════════════════════════════════════════════════════════════════

        [Test]
        public void Response_UnmappedKeyCasing_IsExact()
        {
            const string json = "{\"widgetCount\":3}";
            var r = Deserialize<RespModel>(json);

            Assert.AreEqual(3, r.GetExtraField<int>("widgetCount")); // exact wire name
            Assert.AreEqual(0, r.GetExtraField<int>("WidgetCount")); // ordinal store -> absent
            Assert.IsFalse(r.TryGetExtraField<int>("WIDGETCOUNT", out _));
        }

        [Test]
        public void Response_UnmappedNull_ReadsAsNullOrDefault()
        {
            const string json = "{\"amount\":1,\"foo\":null}";
            var r = Deserialize<RespModel>(json);

            Assert.IsNull(r.GetExtraField<string>("foo"));            // null string
            Assert.IsFalse(r.TryGetExtraField<int>("foo", out _));    // null -> int: not materializable
        }

        [Test]
        public void Response_TryGetExtraField_PresentAndAbsent()
        {
            const string json = "{\"note\":\"hello\"}";
            var r = Deserialize<RespModel>(json);

            Assert.IsTrue(r.TryGetExtraField<string>("note", out var value));
            Assert.AreEqual("hello", value);
            Assert.IsFalse(r.TryGetExtraField<string>("missing", out _));
        }

        [Test]
        public void Response_NoExtraFields_StoreIsEmpty()
        {
            const string json = "{\"amount\":1,\"currency\":\"USD\"}";
            var r = Deserialize<RespModel>(json);

            Assert.IsTrue(r.ExtensionData == null || r.ExtensionData.Count == 0);
        }

        // ══════════════════════════════════════════════════════════════════════════
        //  Backward compatibility — a field unknown in an older SDK becomes a typed
        //  property in a newer SDK. The SAME wire JSON and the SAME user code
        //  (GetExtraField / SetExtraField) must keep working across the upgrade.
        // ══════════════════════════════════════════════════════════════════════════

        // The newer service returns a field the old SDK model does not know about.
        private const string OrderWireJson = "{\"amount\":100,\"merchantCategoryCode\":\"5999\"}";

        [Test]
        public void Bwc_Response_OldSdk_UnknownField_ReadViaGetExtraField()
        {
            // Old SDK: the field is unmapped, captured into the overflow store.
            var r = Deserialize<OrderV1>(OrderWireJson);

            Assert.AreEqual(100, r.Amount);
            Assert.AreEqual("5999", r.GetExtraField<string>("merchantCategoryCode"));
        }

        [Test]
        public void Bwc_Response_NewSdk_SameUserCode_StillWorks_ViaTypedFallback()
        {
            // New SDK: the field is now a typed property. The user's ORIGINAL code
            // (GetExtraField) must still return the value via FR-6 typed fallback.
            var r = Deserialize<OrderV2>(OrderWireJson);

            Assert.AreEqual("5999", r.MerchantCategoryCode);                       // typed binding
            Assert.AreEqual("5999", r.GetExtraField<string>("merchantCategoryCode")); // unchanged user code
            // The value is NOT duplicated into the overflow store.
            Assert.IsTrue(r.ExtensionData == null ||
                          !r.ExtensionData.ContainsKey("merchantCategoryCode"));
        }

        [Test]
        public void Bwc_Request_OldSdk_SetExtraField_EmitsField()
        {
            // Old SDK: user injects an unknown field; it serializes into the body.
            var r = new OrderV1 { Amount = 100 };
            r.SetExtraField("merchantCategoryCode", "5999");

            var json = Serialize(r);
            StringAssert.Contains("\"amount\":100", json);
            StringAssert.Contains("\"merchantCategoryCode\":\"5999\"", json);
        }

        [Test]
        public void Bwc_Request_NewSdk_SameUserCode_WritesThrough_NoDuplicateKey()
        {
            // New SDK: same user code. SetExtraField now writes through to the typed
            // property; serialization must emit the field exactly once (no conflict,
            // no duplicate key) and produce byte-identical JSON to the old SDK.
            var r = new OrderV2 { Amount = 100 };
            r.SetExtraField("merchantCategoryCode", "5999");

            Assert.AreEqual("5999", r.MerchantCategoryCode); // wrote through

            var json = Serialize(r);
            StringAssert.Contains("\"merchantCategoryCode\":\"5999\"", json);
            // Exactly one occurrence of the field.
            Assert.AreEqual(
                json.IndexOf("merchantCategoryCode", StringComparison.Ordinal),
                json.LastIndexOf("merchantCategoryCode", StringComparison.Ordinal));
        }
    }
}
