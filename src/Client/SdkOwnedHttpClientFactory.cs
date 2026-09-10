using AuthenticationSdk.util;
using System;
using System.Net.Http;

namespace CyberSource.Client
{
    /// <summary>
    /// Dispatches <see cref="HttpClient"/> resolution across the three supported transport-ownership modes,
    /// reading the caller's injection preferences from <see cref="IMerchantNetworkSettings"/>.
    /// </summary>
    /// <remarks>
    /// Precedence (highest first):
    /// <list type="number">
    ///   <item>A caller-supplied <see cref="HttpClient"/> — wrapped directly, never cached or disposed by the SDK.</item>
    ///   <item>A caller-supplied <see cref="IHttpClientFactory"/> — <see cref="IHttpClientFactory.CreateClient(string)"/>
    ///         is called per request; the resolved client is never cached or disposed by the SDK (the factory owns
    ///         handler pooling and lifetime).</item>
    ///   <item>Neither is supplied — an SDK-owned <see cref="HttpClient" /> built via <see cref="SdkHttpMessageHandlerBuilder"/>
    ///         is used.</item>
    /// </list>
    /// </remarks>
    internal static class SdkOwnedHttpClientFactory
    {
        /// <summary>
        /// Resolves an <see cref="HttpClient"/> for the supplied
        /// <paramref name="merchantNetworkSettings"/> and <paramref name="transportOptions"/>.
        /// </summary>
        internal static HttpClient GetHttpClient(
            IMerchantNetworkSettings merchantNetworkSettings,
            HttpTransportOptions transportOptions)
        {
            if (transportOptions == null) { throw new ArgumentNullException(nameof(transportOptions)); }

            HttpClient injectedHttpClient = merchantNetworkSettings?.HttpClient;
            IHttpClientFactory injectedHttpClientFactory = merchantNetworkSettings?.HttpClientFactory;

            // (1) Caller-owned HttpClient — bypass cache and never dispose by the SDK.
            // Handler / proxy / cert / poolsettings on the merchant network settings are ignored
            // because the caller configured their own HttpMessageHandler and owns its lifetime.
            if (injectedHttpClient != null)
            {
                return injectedHttpClient;
            }

            // (2) Caller-owned IHttpClientFactory — resolve per call. The factory handles handler pooling and
            // rotation; the returned HttpClient must not be disposed by the SDK.
            if (injectedHttpClientFactory != null)
            {
                return injectedHttpClientFactory.CreateClient();
            }

            // (3) SDK-managed path — MemoryCache-backed pooling with TTL/size-based eviction and disposal.
            if (merchantNetworkSettings == null)
            {
                throw new ArgumentNullException(nameof(merchantNetworkSettings),
                    "SDK-owned HttpClient path requires an IMerchantNetworkSettings to read pooling parameters. " +
                    "Supply an IMerchantNetworkSettings, or inject an HttpClient / IHttpClientFactory on it.");
            }

            return GetSdkOwnedHttpClient(merchantNetworkSettings, transportOptions);
        }

        private static HttpClient GetSdkOwnedHttpClient(IMerchantNetworkSettings merchantNetworkSettings, HttpTransportOptions transportOptions)
        {
            int maxConnectionsPerServer = SdkHttpMessageHandlerBuilder.ParseIntOrDefault(
                merchantNetworkSettings.MaxConnectionPoolSize,
                SdkHttpMessageHandlerBuilder.ParseIntOrDefault(Constants.DefaultMaxConnectionPoolSize, defaultValue: 100));

            int pooledConnectionIdleTimeoutMs = SdkHttpMessageHandlerBuilder.ParseIntOrDefault(
                merchantNetworkSettings.KeepAliveTime,
                SdkHttpMessageHandlerBuilder.ParseIntOrDefault(Constants.DefaultKeepAliveTime, defaultValue: 60000));

            int pooledConnectionLifetimeMinutes = SdkOwnedHttpClientCache.DefaultPooledConnectionLifetimeMinutes;

            SdkOwnedHttpClientCacheKey key = SdkOwnedHttpClientCacheKey.From(
                transportOptions,
                maxConnectionsPerServer,
                pooledConnectionIdleTimeoutMs,
                pooledConnectionLifetimeMinutes);

            return SdkOwnedHttpClientCache.GetOrCreate(key, () =>
                SdkHttpMessageHandlerBuilder.Build(
                    transportOptions,
                    maxConnectionsPerServer,
                    pooledConnectionIdleTimeoutMs,
                    pooledConnectionLifetimeMinutes));
        }

        /// <summary>
        /// Test-only hook: drains the SDK-owned cache and disposes every pooled <see cref="HttpClient"/>.
        /// </summary>
        internal static void ClearForTests() => SdkOwnedHttpClientCache.ClearForTests();
    }
}
