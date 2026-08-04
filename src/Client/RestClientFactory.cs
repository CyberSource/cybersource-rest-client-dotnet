using AuthenticationSdk.util;
using RestSharp;
using System;
using System.Net.Http;

namespace CyberSource.Client
{
    /// <summary>
    /// Dispatches <see cref="RestClient"/> creation across the three supported transport-ownership modes,
    /// reading the caller's injection preferences from <see cref="IMerchantNetworkSettings"/>.
    /// </summary>
    /// <remarks>
    /// Precedence (highest first):
    /// <list type="number">
    ///   <item>A caller-supplied <see cref="HttpClient"/> — wrapped directly, never cached or disposed by the SDK.</item>
    ///   <item>A caller-supplied <see cref="IHttpClientFactory"/> — <see cref="IHttpClientFactory.CreateClient(string)"/>
    ///         is called per request; the resolved client is never cached or disposed by the SDK (the factory owns
    ///         handler pooling and lifetime).</item>
    ///   <item>Neither is supplied — the SDK's internally managed <see cref="StandardSocketsHttpHandler"/>-backed
    ///         cache (see <see cref="SdkOwnedRestClientCache"/>) is used.</item>
    /// </list>
    /// <para>
    /// Handler / cache / proxy / certificate construction lives in <see cref="SdkHttpMessageHandlerBuilder"/> and
    /// <see cref="SdkOwnedRestClientCache"/>. This class is intentionally kept small and side-effect-free.
    /// </para>
    /// </remarks>
    internal static class RestClientFactory
    {
        /// <summary>
        /// Resolves a <see cref="RestClient"/> for the supplied <paramref name="merchantNetworkSettings"/> and
        /// <paramref name="restClientOptions"/>. HTTP-transport DI values are read from the settings object.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="restClientOptions"/> is <c>null</c>, or <paramref name="merchantNetworkSettings"/> is
        /// <c>null</c> and the caller-supplied HTTP transport values are both absent (the SDK-owned cached path
        /// requires the network settings to read pooling parameters).
        /// </exception>
        internal static RestClient GetRestClient(
            IMerchantNetworkSettings merchantNetworkSettings,
            RestClientOptions restClientOptions)
        {
            if (restClientOptions == null) { throw new ArgumentNullException(nameof(restClientOptions)); }

            HttpClient injectedHttpClient = merchantNetworkSettings?.HttpClient;
            IHttpClientFactory injectedHttpClientFactory = merchantNetworkSettings?.HttpClientFactory;

            // (1) Caller-owned HttpClient — bypass cache and never dispose. Handler / proxy / cert / pool
            // settings on the merchant network settings are ignored because the caller configured their own
            // HttpMessageHandler and owns its lifetime.
            if (injectedHttpClient != null)
            {
                return new RestClient(injectedHttpClient, restClientOptions, disposeHttpClient: false);
            }

            // (2) Caller-owned IHttpClientFactory — resolve per call. The factory handles handler pooling and
            // rotation; the returned HttpClient must not be disposed by the SDK.
            if (injectedHttpClientFactory != null)
            {
                HttpClient resolvedClient = injectedHttpClientFactory.CreateClient();

                return new RestClient(resolvedClient, restClientOptions, disposeHttpClient: false);
            }

            // (3) SDK-managed path — MemoryCache-backed pooling with TTL/size-based eviction and disposal.
            if (merchantNetworkSettings == null)
            {
                throw new ArgumentNullException(nameof(merchantNetworkSettings),
                    "SDK-owned RestClient path requires an IMerchantNetworkSettings to read pooling parameters. " +
                    "Supply an IMerchantNetworkSettings, or inject an HttpClient / IHttpClientFactory on it.");
            }

            return GetSdkOwnedRestClient(merchantNetworkSettings, restClientOptions);
        }

        private static RestClient GetSdkOwnedRestClient(IMerchantNetworkSettings merchantNetworkSettings, RestClientOptions restClientOptions)
        {
            int maxConnectionsPerServer = SdkHttpMessageHandlerBuilder.ParseIntOrDefault(
                merchantNetworkSettings.MaxConnectionPoolSize,
                SdkHttpMessageHandlerBuilder.ParseIntOrDefault(Constants.DefaultMaxConnectionPoolSize, defaultValue: 100));

            int pooledConnectionIdleTimeoutMs = SdkHttpMessageHandlerBuilder.ParseIntOrDefault(
                merchantNetworkSettings.KeepAliveTime,
                SdkHttpMessageHandlerBuilder.ParseIntOrDefault(Constants.DefaultKeepAliveTime, defaultValue: 60000));

            int pooledConnectionLifetimeMinutes = SdkOwnedRestClientCache.DefaultPooledConnectionLifetimeMinutes;

            RestClientCacheKey key = RestClientCacheKey.From(
                restClientOptions,
                maxConnectionsPerServer,
                pooledConnectionIdleTimeoutMs,
                pooledConnectionLifetimeMinutes);

            return SdkOwnedRestClientCache.GetOrCreate(key, () =>
            {
                HttpClient httpClient = SdkHttpMessageHandlerBuilder.Build(
                    restClientOptions,
                    maxConnectionsPerServer,
                    pooledConnectionIdleTimeoutMs,
                    pooledConnectionLifetimeMinutes);

                // disposeHttpClient:true is required — the SDK constructed this HttpClient and its
                // handler, so when the cache evicts (TTL / size-based / test clear) and disposes the
                // RestClient wrapper, RestSharp must in turn dispose the HttpClient, otherwise the
                // StandardSocketsHttpHandler and its pooled TCP connections leak on every eviction.
                return new RestClient(httpClient, restClientOptions, disposeHttpClient: true);
            });
        }

        /// <summary>
        /// Test-only hook: drains the SDK-owned cache and disposes every pooled <see cref="RestClient"/>.
        /// Production code should rely on the natural TTL / size-based eviction path.
        /// </summary>
        internal static void ClearForTests() => SdkOwnedRestClientCache.ClearForTests();
    }
}
