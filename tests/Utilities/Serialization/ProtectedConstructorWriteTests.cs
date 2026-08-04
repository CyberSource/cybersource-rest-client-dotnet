using System.Text.Json;
using System.Text.Json.Serialization;
using NUnit.Framework;
using CyberSource.Utilities.Extensibility;
using CyberSource.Utilities.Serialization;

namespace cybersource_rest_client_netstandard.Test.Utilities.Serialization
{
    /// <summary>
    /// Covers the latent <see cref="ProtectedConstructorConverter{T}"/> WRITE path.
    /// Generated models carry <c>[JsonIgnore(Condition = WhenWritingDefault)]</c> on every
    /// property; the previous Write loop skipped ANY <c>[JsonIgnore]</c> unconditionally,
    /// which dropped every property. These tests pin the corrected behaviour:
    ///  - set (non-default) properties are emitted,
    ///  - default-valued properties under WhenWritingDefault are omitted,
    ///  - the [JsonExtensionData] overflow store is flattened as top-level members.
    /// </summary>
    [TestFixture]
    public class ProtectedConstructorWriteTests
    {
        // Mirrors a generated required-field model: protected [JsonConstructor] (triggers the
        // converter) plus a public ctor for test construction.
        private class WriteModel : ModelExtensions
        {
            [JsonPropertyName("code")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public string Code { get; set; }

            [JsonPropertyName("amount")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public int? Amount { get; set; }

            [JsonConstructor]
            protected WriteModel() { }

            public WriteModel(string code, int? amount)
            {
                Code = code;
                Amount = amount;
            }
        }

        // Options that route through the protected-ctor converter on write.
        private static readonly JsonSerializerOptions WriteOpts =
            new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Converters = { new ProtectedConstructorConverterFactory() }
            };

        private static string Serialize(object o) => JsonSerializer.Serialize(o, WriteOpts);

        [Test]
        public void SetProperties_AreEmitted_NotDroppedByJsonIgnore()
        {
            var model = new WriteModel("ABC", 5);

            var json = Serialize(model);

            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            Assert.AreEqual("ABC", root.GetProperty("code").GetString());
            Assert.AreEqual(5, root.GetProperty("amount").GetInt32());
        }

        [Test]
        public void DefaultValuedProperty_IsOmitted_UnderWhenWritingDefault()
        {
            var model = new WriteModel(null, 7);

            var json = Serialize(model);

            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            Assert.IsFalse(root.TryGetProperty("code", out _)); // null -> omitted
            Assert.AreEqual(7, root.GetProperty("amount").GetInt32());
        }

        [Test]
        public void ExtensionData_IsFlattened_AsTopLevelMembers()
        {
            var model = new WriteModel("ABC", null);
            model.SetExtraField("riskScore", 42);

            var json = Serialize(model);

            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            Assert.AreEqual("ABC", root.GetProperty("code").GetString());
            Assert.AreEqual(42, root.GetProperty("riskScore").GetInt32()); // flattened, top-level
            Assert.IsFalse(root.TryGetProperty("extensionData", out _)); // not nested
            Assert.IsFalse(root.TryGetProperty("ExtensionData", out _));
        }
    }
}
