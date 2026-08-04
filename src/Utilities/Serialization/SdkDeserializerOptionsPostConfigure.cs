using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Options;

namespace CyberSource.Utilities.Serialization
{
    /// <summary>
    /// <see cref="IPostConfigureOptions{TOptions}"/> implementation that applies the SDK's
    /// mandatory deserialization invariants on top of any consumer-supplied
    /// <see cref="SdkDeserializerOptions.Options"/>. Runs last in the options pipeline so the
    /// SDK's invariants always win over consumer post-configures.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The invariants forced here match the SDK's static <c>deserializationSettings</c> defaults:
    /// <list type="bullet">
    /// <item><description><see cref="JsonSerializerOptions.DefaultIgnoreCondition"/> is forced to
    /// <see cref="JsonIgnoreCondition.WhenWritingNull"/>.</description></item>
    /// <item><description>The set of converters required to deserialize CyberSource models
    /// (<see cref="ProtectedConstructorConverterFactory"/>, <see cref="StringOrNumberConverter"/>,
    /// <see cref="BooleanOrStringConverter"/>) is layered in idempotently — an existing converter
    /// of the same type is left alone so consumer customizations are preserved.</description></item>
    /// </list>
    /// </para>
    /// <para>
    /// Unlike <see cref="SdkSerializerOptionsPostConfigure"/>, the
    /// <see cref="JsonSerializerOptions.TypeInfoResolver"/> is deliberately not forced here: the
    /// conflict guard is a serialize-time invariant and would be inert on the read path.
    /// </para>
    /// </remarks>
    internal sealed class SdkDeserializerOptionsPostConfigure : IPostConfigureOptions<SdkDeserializerOptions>
    {
        /// <summary>
        /// Applies the SDK deserialization invariants to the supplied
        /// <see cref="SdkDeserializerOptions"/> instance.
        /// </summary>
        /// <param name="name">The options instance name (ignored).</param>
        /// <param name="options">The options instance to post-configure. When
        /// <see cref="SdkDeserializerOptions.Options"/> is <c>null</c>, a fresh
        /// <see cref="JsonSerializerOptions"/> is created before the invariants are applied.</param>
        public void PostConfigure(string name, SdkDeserializerOptions options)
        {
            if (options == null) { return; }

            options.Options ??= new JsonSerializerOptions(JsonSerializerDefaults.Web);

            var target = options.Options;
            Apply(target);
        }

        /// <summary>
        /// Applies the SDK deserialization invariants to a raw <see cref="JsonSerializerOptions"/>
        /// instance. Exposed internally so the non-DI construction path can reuse the exact same
        /// invariant list without duplication.
        /// </summary>
        internal static void Apply(JsonSerializerOptions target)
        {
            if (target == null) { return; }

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
