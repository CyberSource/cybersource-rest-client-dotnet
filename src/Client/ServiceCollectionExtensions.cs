using System;
using CyberSource.Utilities.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace CyberSource.Client
{
    /// <summary>
    /// <see cref="IServiceCollection"/> registration helpers for the SDK's serialization pipeline.
    /// </summary>
    /// <remarks>
    /// These helpers exist so hosts using
    /// <c>Microsoft.Extensions.DependencyInjection</c> can wire the SDK's JSON options pipeline
    /// through the standard <see cref="IOptions{TOptions}"/> / <see cref="IOptionsMonitor{TOptions}"/>
    /// contracts without touching the direct-construction surface
    /// (<see cref="MerchantNetworkSettingsExtensions"/>). Non-DI callers can ignore this class
    /// entirely and keep using the fluent extensions on <see cref="IMerchantNetworkSettings"/>.
    /// </remarks>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers the SDK-owned JSON options wrapper types
        /// (<see cref="SdkSerializerOptions"/>, <see cref="SdkDeserializerOptions"/>) with the
        /// options pipeline and appends the SDK's mandatory
        /// <see cref="IPostConfigureOptions{TOptions}"/> implementations so the SDK invariants
        /// always run last (and therefore always win over consumer post-configures).
        /// </summary>
        /// <remarks>
        /// <para>
        /// After calling this method, consumers can customize either track through the standard
        /// options API — e.g.
        /// <c>services.PostConfigure&lt;SdkSerializerOptions&gt;(o =&gt; o.Options.WriteIndented = true)</c>
        /// or <c>services.Configure&lt;SdkDeserializerOptions&gt;(o =&gt; ...)</c>. All such callbacks
        /// run BEFORE the SDK invariants, so the SDK's mandatory converters, ignore-conditions, and
        /// (for the serializer) type-info resolver are always applied on top.
        /// </para>
        /// <para>
        /// The PBL (Payment-Links) model deserialization track intentionally has no consumer
        /// post-configure surface: its options are derived from
        /// <see cref="SdkDeserializerOptions"/> at <see cref="ApiClient"/> construction time, and
        /// the PBL-only invariants (naming policy, ignore condition, required converters) are
        /// layered on top by the SDK. Consumer customizations of the general deserialization track
        /// automatically flow into the PBL track through this derivation.
        /// </para>
        /// <para>
        /// This method is idempotent: repeated invocations do not stack duplicate registrations
        /// because <see cref="ServiceCollectionDescriptorExtensions.TryAddEnumerable(IServiceCollection, ServiceDescriptor)"/>
        /// filters by service-plus-implementation-type identity.
        /// </para>
        /// </remarks>
        /// <param name="services">The service collection to register into.</param>
        /// <returns>The same <paramref name="services"/> instance for chaining.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="services"/> is <c>null</c>.</exception>
        public static IServiceCollection AddSerialization(this IServiceCollection services)
        {
            if (services == null) { throw new ArgumentNullException(nameof(services)); }

            // AddOptions<T> makes IOptions<T> / IOptionsMonitor<T> resolvable and unlocks the
            // PostConfigure / Configure fluent surface for each wrapper.
            services.AddOptions<SdkSerializerOptions>();
            services.AddOptions<SdkDeserializerOptions>();

            // Append the SDK's mandatory post-configures. TryAddEnumerable filters on
            // (service, implementation) pairs so repeat calls to AddSerialization
            // do not stack duplicates.
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<SdkSerializerOptions>, SdkSerializerOptionsPostConfigure>());
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<SdkDeserializerOptions>, SdkDeserializerOptionsPostConfigure>());

            return services;
        }
    }
}
