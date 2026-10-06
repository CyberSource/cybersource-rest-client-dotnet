// Regression tests for the JsonCompactor fix in commit a0f3918d
// ("Added catch block in JsonCompactor in case of JsonException due to simple string data").
//
// Before the fix, CompactJsonForPrinting invoked JsonDocument.Parse on any non-empty
// input; a plain (non-JSON) string produced a JsonException that propagated to callers
// and disrupted logging/printing paths. The fix wraps the parse+serialize in a
// try/catch(JsonException) and returns the original input unchanged when the payload
// is not valid JSON.

using System.Text.Json;
using CyberSource.Utilities.Serialization;
using NUnit.Framework;

namespace CyberSource.Test.Serialization
{
    [TestFixture]
    public class JsonCompactorTests
    {
        // --- Non-JSON / malformed input: must be returned unchanged, no exception. ---

        [Test]
        public void CompactJsonForPrinting_PlainString_IsReturnedUnchanged()
        {
            const string input = "not a json payload";

            string result = JsonCompactor.CompactJsonForPrinting(input);

            Assert.AreEqual(input, result);
        }

        [Test]
        public void CompactJsonForPrinting_MalformedJson_IsReturnedUnchanged()
        {
            const string input = "{ \"unterminated\": ";

            string result = JsonCompactor.CompactJsonForPrinting(input);

            Assert.AreEqual(input, result);
        }

        [Test]
        public void CompactJsonForPrinting_PlainString_DoesNotThrow()
        {
            Assert.DoesNotThrow(() => JsonCompactor.CompactJsonForPrinting("plain text"));
        }

        // --- Guard for pre-fix short-circuit behavior on empty / whitespace input. ---

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        [TestCase("\t\r\n")]
        public void CompactJsonForPrinting_NullOrWhitespace_IsReturnedUnchanged(string? input)
        {
            string result = JsonCompactor.CompactJsonForPrinting(input!);

            Assert.AreEqual(input, result);
        }

        // --- Happy path: valid JSON is still compacted. The fix must not regress this. ---

        [Test]
        public void CompactJsonForPrinting_IndentedJsonObject_IsCompacted()
        {
            const string input = @"{
                ""a"": 1,
                ""b"": ""two""
            }";

            string result = JsonCompactor.CompactJsonForPrinting(input);

            Assert.AreEqual("{\"a\":1,\"b\":\"two\"}", result);
        }

        [Test]
        public void CompactJsonForPrinting_IndentedJsonArray_IsCompacted()
        {
            const string input = "[\n  1,\n  2,\n  3\n]";

            string result = JsonCompactor.CompactJsonForPrinting(input);

            Assert.AreEqual("[1,2,3]", result);
        }

        [Test]
        public void CompactJsonForPrinting_QuotedJsonString_IsCompacted()
        {
            // A JSON string literal is valid JSON (a root-level string value). It must
            // go through the compacting path, not the catch fallback.
            const string input = "  \"hello\"  ";

            string result = JsonCompactor.CompactJsonForPrinting(input);

            Assert.AreEqual("\"hello\"", result);
        }
    }
}
