// Regression tests for EPS-43512:
// System.Text.Json silently skips properties whose setter is non-public unless
// the property is bound through a [JsonConstructor] parameter or carries
// [JsonInclude]. The generated CyberSource models expose several response-only
// fields (e.g. offset/limit/count/total on list DTOs) with `private set`, which
// caused merchant-side pagination to break ("cannot enumerate customer payment
// instruments"). The fix adds [JsonInclude] to each affected member.
//
// These tests guard the fix on two levels:
//   1. Behavior:  deserializing a representative payload actually populates
//                 the previously-dropped properties.
//   2. Invariant: no future model regresses by declaring a JSON-mapped
//                 property with a non-public setter and no [JsonInclude].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using CyberSource.Model;
using NUnit.Framework;

namespace CyberSource.Test.Serialization
{
    [TestFixture]
    public class JsonIncludePrivateSetterTests
    {
        private static readonly JsonSerializerOptions Options =
            new JsonSerializerOptions(JsonSerializerDefaults.Web);

        /// <summary>
        /// Deserializing a PaymentInstrumentList1 payload must populate offset/limit/count/total.
        /// Before the fix these round-tripped as null because the private setters were invisible
        /// to System.Text.Json.
        /// </summary>
        [Test]
        public void PaymentInstrumentList1_PrivateSetterProperties_ArePopulatedFromJson()
        {
            const string json = @"{
                ""offset"": 0,
                ""limit"": 20,
                ""count"": 3,
                ""total"": 42
            }";

            var result = JsonSerializer.Deserialize<PaymentInstrumentList1>(json, Options);

            Assert.IsNotNull(result);
            Assert.AreEqual(0,  result!.Offset, "Offset was dropped during deserialization.");
            Assert.AreEqual(20, result.Limit,   "Limit was dropped during deserialization.");
            Assert.AreEqual(3,  result.Count,   "Count was dropped during deserialization.");
            Assert.AreEqual(42, result.Total,   "Total was dropped during deserialization.");
        }

        /// <summary>
        /// Invariant sweep: every public instance property in the CyberSource.Model namespace that
        /// participates in the JSON contract (has [JsonPropertyName]) and whose setter is non-public
        /// must also carry [JsonInclude], unless it is bound through a [JsonConstructor] parameter.
        /// This catches new/regenerated models that reintroduce the original defect.
        /// </summary>
        [Test]
        public void AllModels_JsonMappedPropertiesWithNonPublicSetter_HaveJsonInclude()
        {
            var modelAssembly = typeof(PaymentInstrumentList1).Assembly;
            var offenders = new List<string>();

            foreach (var type in modelAssembly.GetTypes()
                         .Where(t => t.IsClass
                                     && !t.IsAbstract
                                     && t.Namespace == "CyberSource.Model"))
            {
                var ctorBoundNames = GetJsonConstructorParameterNames(type);

                foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    if (prop.GetCustomAttribute<JsonPropertyNameAttribute>() is null)
                        continue;

                    var setter = prop.SetMethod;
                    if (setter is null || setter.IsPublic)
                        continue;

                    if (prop.GetCustomAttribute<JsonIncludeAttribute>() is not null)
                        continue;

                    // A property populated via a [JsonConstructor] parameter (matched by name,
                    // case-insensitive as STJ does) does not need [JsonInclude].
                    if (ctorBoundNames.Contains(prop.Name))
                        continue;

                    offenders.Add($"{type.FullName}.{prop.Name}");
                }
            }

            Assert.IsEmpty(
                offenders,
                "The following JSON-mapped properties have a non-public setter but no [JsonInclude]. "
                + "System.Text.Json will silently drop their values on deserialization:"
                + Environment.NewLine
                + string.Join(Environment.NewLine, offenders));
        }

        private static HashSet<string> GetJsonConstructorParameterNames(Type type)
        {
            var ctor = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance)
                           .FirstOrDefault(c => c.GetCustomAttribute<JsonConstructorAttribute>() is not null);

            if (ctor is null)
                return new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            return new HashSet<string>(
                ctor.GetParameters().Select(p => p.Name ?? string.Empty),
                StringComparer.OrdinalIgnoreCase);
        }
    }
}
