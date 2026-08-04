using RestSharp;
using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace CyberSource.Client
{
    /// <summary>
    /// Builds a fully configured <see cref="StandardSocketsHttpHandler"/> and its wrapping
    /// <see cref="HttpClient"/> for the SDK-owned transport path. This is a pure builder — it never
    /// caches, disposes, or shares the returned instances.
    /// </summary>
    /// <remarks>
    /// When <see cref="RestClientOptions.Proxy"/> is <c>null</c>, the resulting handler leaves the
    /// framework's default proxy behavior in place (system / environment proxy). Callers who want
    /// "no proxy" must explicitly set <see cref="RestClientOptions.Proxy"/> to a proxy that returns
    /// the request URI unchanged, or configure the process default accordingly.
    /// </remarks>
    internal static class SdkHttpMessageHandlerBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="HttpClient"/> backed by a <see cref="StandardSocketsHttpHandler"/>
        /// configured with the supplied pooling parameters and the proxy / client-certificate settings
        /// carried by <paramref name="restClientOptions"/>.
        /// </summary>
        public static HttpClient Build(
            RestClientOptions restClientOptions,
            int maxConnectionsPerServer,
            int pooledConnectionIdleTimeoutMs,
            int pooledConnectionLifetimeMinutes)
        {
            if (restClientOptions == null) { throw new ArgumentNullException(nameof(restClientOptions)); }

            StandardSocketsHttpHandler handler = new StandardSocketsHttpHandler
            {
                MaxConnectionsPerServer = maxConnectionsPerServer,
                PooledConnectionIdleTimeout = TimeSpan.FromMilliseconds(pooledConnectionIdleTimeoutMs),
                PooledConnectionLifetime = TimeSpan.FromMinutes(pooledConnectionLifetimeMinutes)
            };

            ApplyProxy(handler, restClientOptions.Proxy);
            ApplyClientCertificates(handler, restClientOptions.ClientCertificates);

            HttpClient httpClient = new HttpClient(handler)
            {
                // RestClientOptions.Timeout is nullable — use Timeout.InfiniteTimeSpan as the documented
                // fallback so a null value cannot crash the SDK-owned build path (was InvalidOperationException).
                Timeout = restClientOptions.Timeout ?? Timeout.InfiniteTimeSpan
            };

            if (!string.IsNullOrWhiteSpace(restClientOptions.UserAgent))
            {
                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(restClientOptions.UserAgent);
            }

            return httpClient;
        }

        internal static void ApplyProxy(StandardSocketsHttpHandler handler, IWebProxy proxy)
        {
            if (proxy != null)
            {
                handler.Proxy = proxy;
                handler.UseProxy = true;
            }
            // When proxy is null we deliberately leave StandardSocketsHttpHandler.UseProxy at its
            // default (true) so system / environment proxy resolution keeps working for callers that
            // relied on it before HttpClient DI existed.
        }

        internal static void ApplyClientCertificates(StandardSocketsHttpHandler handler, X509CertificateCollection clientCertificates)
        {
            if (clientCertificates == null || clientCertificates.Count == 0) { return; }

            // SslOptions.ClientCertificates is null by default; initialize it before adding
            // so the supplied client certificates are actually applied to the handler.
            if (handler.SslOptions.ClientCertificates == null)
            {
                handler.SslOptions.ClientCertificates = new X509CertificateCollection();
            }

            for (int i = 0; i < clientCertificates.Count; i++)
            {
                X509Certificate cert = clientCertificates[i];

                // Skip null entries to prevent NullReferenceException
                if (cert == null) { continue; }

                // If already an X509Certificate2 with a valid thumbprint, use directly
                if (cert is X509Certificate2 cert2 && !string.IsNullOrEmpty(cert2.Thumbprint))
                {
                    handler.SslOptions.ClientCertificates.Add(cert2);
                }
                else
                {
                    try
                    {
                        handler.SslOptions.ClientCertificates.Add(new X509Certificate2(cert));
                    }
                    catch
                    {
                        // Skip certificates that cannot be converted to X509Certificate2
                        // (e.g., malformed or incompatible certificate data)
                        continue;
                    }
                }
            }
        }

        /// <summary>
        /// Parses a merchant-configuration integer value using invariant culture, returning the supplied
        /// default when the value is null, empty, or not a valid integer.
        /// </summary>
        public static int ParseIntOrDefault(string value, int defaultValue)
        {
            if (string.IsNullOrWhiteSpace(value)) { return defaultValue; }
            return int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out int parsed)
                ? parsed
                : defaultValue;
        }
    }
}
