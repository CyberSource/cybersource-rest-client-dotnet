using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Options;

namespace CyberSource.Utilities.Serialization
{
    /// <summary>
    /// <see cref="IPostConfigureOptions{TOptions}"/> implementation that applies the SDK's
    /// mandatory PBL-model deserialization invariants on top of any consumer-supplied
    /// <see cref="SdkPblDeserializerOptions.Options"/>. Runs last in the options pipeline so the
    /// SDK's invariants always win over consumer post-configures.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The invariants forced here mirror what
    /// <c>CyberSource.Client.ApiClient.MergePblModelDeserializerOptions</c> historically applied:
    /// <list type="bullet">
    /// <item><description><see cref="JsonSerializerOptions.PropertyNamingPolicy"/> is forced to
    /// a <see cref="CustomContractResolver"/>. The PBL model requires this policy;
    /// letting the caller replace it would break deserialization.</description></item>
    /// <item><description><see cref="JsonSerializerOptions.DefaultIgnoreCondition"/> is forced to
    /// <see cref="JsonIgnoreCondition.WhenWritingNull"/>.</description></item>
    /// <item><description>The set of converters required to deserialize the PBL model
    /// (<see cref="ProtectedConstructorConverterFactory"/>, <see cref="StringOrNumberConverter"/>,
    /// <see cref="BooleanOrStringConverter"/>) is layered in idempotently.</description></item>
    /// </list>
    /// </para>
    /// </remarks>
    internal sealed class SdkPblDeserializerOptionsPostConfigure : IPostConfigureOptions<SdkPblDeserializerOptions>
    {
        /// <summary>
        /// Applies the SDK PBL-deserialization invariants to the supplied
        /// <see cref="SdkPblDeserializerOptions"/> instance.
        /// </summary>
        /// <param name="name">The options instance name (ignored).</param>
        /// <param name="options">The options instance to post-configure. When
        /// <see cref="SdkPblDeserializerOptions.Options"/> is <c>null</c>, a fresh
        /// <see cref="JsonSerializerOptions"/> is created before the invariants are applied.</param>
        public void PostConfigure(string name, SdkPblDeserializerOptions options)
        {
            if (options == null) { return; }

            options.Options ??= new JsonSerializerOptions();

            var target = options.Options;
            Apply(target);
        }

        /// <summary>
        /// Applies the SDK PBL-deserialization invariants to a raw <see cref="JsonSerializerOptions"/>
        /// instance. Exposed internally so the non-DI construction path can reuse the exact same
        /// invariant list without duplication.
        /// </summary>
        internal static void Apply(JsonSerializerOptions target)
        {
            if (target == null) { return; }

            target.PropertyNamingPolicy = new CustomContractResolver();
            target.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;

            AddConverterIfMissing(target, () => new ProtectedConstructorConverterFactory());
            AddConverterIfMissing(target, () => new StringOrNumberConverter());
            AddConverterIfMissing(target, () => new BooleanOrStringConverter());
        }

        private static void AddConverterIfMissing<TConverter>(JsonSerializerOptions target, Func<TConverter> factory)
            where TConverter : JsonConverter
        {
            var converterType = typeof(TConverter);
            if (!target.Converters.Any(existing => existing.GetType() == converterType))
            {
                target.Converters.Add(factory());
            }
        }
    }
}
