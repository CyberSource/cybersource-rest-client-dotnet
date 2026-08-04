using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CyberSource.Utilities.Serialization;
using Microsoft.Extensions.Options;
using NetworkKeys = AuthenticationSdk.core.MerchantConfigurationKeys.MerchantNetworkSettingsKeys;

namespace CyberSource.Client
{
    public static class MerchantNetworkSettingsExtensions
    {
        public static IMerchantNetworkSettings AddSerializationOptions(this IMerchantNetworkSettings settings, JsonSerializerOptions options)
        {
            if (settings is IMutableMerchantNetworkSettings mutableSettings)
            {
                mutableSettings.SetSerializationOptions(options);
            }

            return settings;
        }

        public static IMerchantNetworkSettings AddDeserializationOptions(this IMerchantNetworkSettings settings, JsonSerializerOptions options)
        {
            if (settings is IMutableMerchantNetworkSettings mutableSettings)
            {
                mutableSettings.SetDeserializationOptions(options);
            }

            return settings;
        }

        /// <summary>
        /// Appends a consumer-supplied post-configure callback that will be applied to the
        /// <see cref="JsonSerializerOptions"/> used for request-payload serialization by
        /// <see cref="ApiClient.Serialize(object)"/> AND for the extra-field write path in
        /// <see cref="CyberSource.Utilities.Extensibility.ModelExtensions.SetExtraField(string, object)"/>.
        /// </summary>
        /// <remarks>
        /// Post-configures are invoked in insertion order at <see cref="ApiClient"/> construction
        /// time; the SDK's mandatory serialization invariants (<c>DefaultIgnoreCondition</c>, the
        /// <c>EnforceExtraFieldConflicts</c> resolver, and required converters) run afterwards so
        /// they always win over consumer customizations. This is the direct-construction analogue
        /// of registering an <see cref="IPostConfigureOptions{TOptions}"/> for
        /// <see cref="SdkSerializerOptions"/> in a DI container.
        /// </remarks>
        public static IMerchantNetworkSettings AddSerializationPostConfigure(this IMerchantNetworkSettings settings, Action<JsonSerializerOptions> postConfigure)
        {
            if (settings is IMutableMerchantNetworkSettings mutableSettings)
            {
                mutableSettings.AddSerializationPostConfigure(postConfigure);
            }

            return settings;
        }

        /// <summary>
        /// Appends a consumer-supplied post-configure callback that will be applied to the
        /// <see cref="JsonSerializerOptions"/> used for response-payload deserialization by
        /// <see cref="ApiClient.Deserialize(RestSharp.RestResponse, System.Type)"/> AND for the
        /// extra-field read path in
        /// <see cref="CyberSource.Utilities.Extensibility.ModelExtensions.GetExtraField{TValue}(string)"/>.
        /// </summary>
        /// <remarks>
        /// Post-configures are invoked in insertion order at <see cref="ApiClient"/> construction
        /// time; the SDK's mandatory deserialization invariants run afterwards so they always win
        /// over consumer customizations. This is the direct-construction analogue of registering
        /// an <see cref="IPostConfigureOptions{TOptions}"/> for <see cref="SdkDeserializerOptions"/>
        /// in a DI container.
        /// </remarks>
        public static IMerchantNetworkSettings AddDeserializationPostConfigure(this IMerchantNetworkSettings settings, Action<JsonSerializerOptions> postConfigure)
        {
            if (settings is IMutableMerchantNetworkSettings mutableSettings)
            {
                mutableSettings.AddDeserializationPostConfigure(postConfigure);
            }

            return settings;
        }

        /// <summary>
        /// Attaches DI-resolved <see cref="IOptionsMonitor{TOptions}"/> instances for the SDK's
        /// serialization and deserialization JSON options wrappers. When any monitor is non-<c>null</c>,
        /// the SDK reads <c>CurrentValue.Options</c> from it at <see cref="ApiClient"/> construction time
        /// (all consumer and SDK <see cref="IPostConfigureOptions{TOptions}"/> callbacks have
        /// already run through the options pipeline) and ignores the direct-injection surface
        /// (<see cref="IMerchantNetworkSettings.SerializationOptions"/> /
        /// <see cref="IMerchantNetworkSettings.DeserializationOptions"/> plus their post-configure
        /// lists) for that track. The PBL deserialization track is derived from
        /// <see cref="IMerchantNetworkSettings.DeserializerOptionsMonitor"/>.
        /// </summary>
        public static IMerchantNetworkSettings AddSdkOptionsMonitors(
            this IMerchantNetworkSettings settings,
            IOptionsMonitor<SdkSerializerOptions> serializerOptionsMonitor = null,
            IOptionsMonitor<SdkDeserializerOptions> deserializerOptionsMonitor = null)
        {
            if (settings is IMutableMerchantNetworkSettings mutableSettings)
            {
                mutableSettings.SetSerializerOptionsMonitor(serializerOptionsMonitor);
                mutableSettings.SetDeserializerOptionsMonitor(deserializerOptionsMonitor);
            }

            return settings;
        }

        /// <summary>
        /// Attaches a caller-owned <see cref="HttpClient"/> to the network settings. When set, RestSharp will use this
        /// client for all outgoing requests and the SDK will not dispose it. Passing <c>null</c> clears the injection
        /// and restores the SDK-managed HttpClient behavior.
        /// </summary>
        public static IMerchantNetworkSettings AddHttpClient(this IMerchantNetworkSettings settings, HttpClient httpClient)
        {
            if (settings is IMutableMerchantNetworkSettings mutableSettings)
            {
                mutableSettings.SetHttpClient(httpClient);
            }

            return settings;
        }

        /// <summary>
        /// Attaches an <see cref="IHttpClientFactory"/> to the network settings so the SDK can resolve an
        /// <see cref="HttpClient"/> per request. Only consulted when <see cref="IMerchantNetworkSettings.HttpClient"/>
        /// is <c>null</c>.
        /// </summary>
        public static IMerchantNetworkSettings AddHttpClientFactory(this IMerchantNetworkSettings settings, IHttpClientFactory httpClientFactory)
        {
            if (settings is IMutableMerchantNetworkSettings mutableSettings)
            {
                mutableSettings.SetHttpClientFactory(httpClientFactory);
            }

            return settings;
        }
    }
}
