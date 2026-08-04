using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using CyberSource.Utilities.Extensibility;
using Microsoft.Extensions.Options;

namespace CyberSource.Utilities.Serialization
{
    /// <summary>
    /// <see cref="IPostConfigureOptions{TOptions}"/> implementation that applies the SDK's
    /// mandatory serialization invariants on top of any consumer-supplied
    /// <see cref="SdkSerializerOptions.Options"/>. Runs last in the options pipeline so the SDK's
    /// invariants always win over consumer post-configures.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The invariants forced here mirror what
    /// <c>CyberSource.Client.ApiClient.MergeSerializerOptions</c> historically applied when the
    /// caller supplied their own <see cref="JsonSerializerOptions"/>:
    /// <list type="bullet">
    /// <item><description><see cref="JsonSerializerOptions.DefaultIgnoreCondition"/> is forced to
    /// <see cref="JsonIgnoreCondition.WhenWritingNull"/>.</description></item>
    /// <item><description><see cref="JsonSerializerOptions.TypeInfoResolver"/> is forced to a new
    /// <see cref="DefaultJsonTypeInfoResolver"/> carrying
    /// <see cref="ModelExtensions.EnforceExtraFieldConflicts"/> so
    /// the conflict guard applies graph-wide regardless of any resolver the caller registered.</description></item>
    /// <item><description>The set of converters required to serialize CyberSource models
    /// (<see cref="ProtectedConstructorConverterFactory"/>, <see cref="StringOrNumberConverter"/>,
    /// <see cref="BooleanOrStringConverter"/>) is layered in idempotently — an existing converter
    /// of the same type is left alone so consumer customizations are preserved.</description></item>
    /// </list>
    /// </para>
    /// <para>
    /// The <paramref name="name"/> is ignored: the wrapper type is SDK-owned, so any named or
    /// unnamed instance of <see cref="SdkSerializerOptions"/> receives the same SDK invariants.
    /// </para>
    /// </remarks>
    internal sealed class SdkSerializerOptionsPostConfigure : IPostConfigureOptions<SdkSerializerOptions>
    {
        /// <summary>
        /// Applies the SDK serialization invariants to the supplied
        /// <see cref="SdkSerializerOptions"/> instance.
        /// </summary>
        /// <param name="name">The options instance name (ignored).</param>
        /// <param name="options">The options instance to post-configure. When
        /// <see cref="SdkSerializerOptions.Options"/> is <c>null</c>, a fresh
        /// <see cref="JsonSerializerOptions"/> is created before the invariants are applied.</param>
        public void PostConfigure(string name, SdkSerializerOptions options)
        {
            if (options == null) { return; }

            options.Options ??= new JsonSerializerOptions(JsonSerializerDefaults.Web);

            var target = options.Options;
            Apply(target);
        }

        /// <summary>
        /// Applies the SDK serialization invariants to a raw <see cref="JsonSerializerOptions"/>
        /// instance. Exposed internally so the non-DI construction path (which builds a
        /// <see cref="JsonSerializerOptions"/> directly without going through the options pipeline)
        /// can reuse the exact same invariant list without duplication.
        /// </summary>
        internal static void Apply(JsonSerializerOptions target)
        {
            if (target == null) { return; }

            target.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;

            // Force the SDK's TypeInfoResolver so EnforceExtraFieldConflicts runs graph-wide,
            // regardless of any resolver the caller registered.
            target.TypeInfoResolver = new DefaultJsonTypeInfoResolver
            {
                Modifiers = { ModelExtensions.EnforceExtraFieldConflicts }
            };

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
