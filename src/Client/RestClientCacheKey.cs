using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CyberSource.Client
{
    /// <summary>
    /// Deterministic, immutable cache key used by <see cref="SdkOwnedRestClientCache"/> to identify
    /// SDK-owned <see cref="RestClient"/> instances built from an identical set of transport settings.
    /// Two keys compare equal when the underlying <see cref="RestClientOptions"/> and the SDK's pooling
    /// parameters would produce a functionally identical <see cref="System.Net.Http.HttpClient"/>.
    /// </summary>
    /// <remarks>
    /// Proxy identity is derived from the concrete <see cref="IWebProxy"/> instance (its type + runtime
    /// identity hash) rather than from resolving a proxy URI. Credentials are keyed only by their
    /// runtime identity — no credential material (username, domain, or password hash) is retained here.
    /// </remarks>
    internal sealed class RestClientCacheKey : IEquatable<RestClientCacheKey>
    {
        private readonly string _baseUrl;
        private readonly IReadOnlyList<string> _clientCertificateThumbprints;
        private readonly string _proxyIdentity;
        private readonly int _proxyCredentialsIdentity;
        private readonly object _timeoutMs;
        private readonly string _userAgent;
        private readonly int _maxConnectionsPerServer;
        private readonly int _pooledConnectionIdleTimeoutMs;
        private readonly int _pooledConnectionLifetimeMinutes;
        private readonly int _hashCode;

        private RestClientCacheKey(
            string baseUrl,
            object timeoutMs,
            int maxConnectionsPerServer,
            int pooledConnectionIdleTimeoutMs,
            int pooledConnectionLifetimeMinutes,
            string proxyIdentity,
            int proxyCredentialsIdentity,
            IReadOnlyList<string> clientCertificateThumbprints,
            string userAgent)
        {
            _baseUrl = baseUrl;
            _timeoutMs = timeoutMs;
            _maxConnectionsPerServer = maxConnectionsPerServer;
            _pooledConnectionIdleTimeoutMs = pooledConnectionIdleTimeoutMs;
            _pooledConnectionLifetimeMinutes = pooledConnectionLifetimeMinutes;
            _proxyIdentity = proxyIdentity;
            _proxyCredentialsIdentity = proxyCredentialsIdentity;
            _clientCertificateThumbprints = clientCertificateThumbprints;
            _userAgent = userAgent;
            _hashCode = ComputeHashCode();
        }

        /// <summary>
        /// Builds a cache key from the caller's <see cref="RestClientOptions"/> and the pooling parameters
        /// that the SDK will use to construct a <see cref="System.Net.Http.SocketsHttpHandler"/>.
        /// Pooling parameters are required — passing incorrect values will silently mismatch cache entries.
        /// </summary>
        public static RestClientCacheKey From(
            RestClientOptions clientOptions,
            int maxConnectionsPerServer,
            int pooledConnectionIdleTimeoutMs,
            int pooledConnectionLifetimeMinutes)
        {
            string baseUrl = clientOptions?.BaseUrl?.AbsoluteUri;

            IReadOnlyList<string> thumbprints = ExtractThumbprints(clientOptions?.ClientCertificates);

            string proxyIdentity = null;
            int proxyCredentialsIdentity = 0;
            if (clientOptions?.Proxy != null)
            {
                // Key on the IWebProxy instance identity, not on resolving a URI. Doing GetProxy(...) on
                // every cache-miss can trigger DNS/PAC/environment I/O and is not required for uniqueness:
                // two references to the same IWebProxy instance are equivalent, distinct instances are not.
                proxyIdentity = clientOptions.Proxy.GetType().FullName + "@" + RuntimeHelpers.GetHashCode(clientOptions.Proxy);

                if (clientOptions.Proxy.Credentials != null)
                {
                    proxyCredentialsIdentity = RuntimeHelpers.GetHashCode(clientOptions.Proxy.Credentials);
                }
            }

            return new RestClientCacheKey(
                baseUrl,
                clientOptions?.Timeout,
                maxConnectionsPerServer,
                pooledConnectionIdleTimeoutMs,
                pooledConnectionLifetimeMinutes,
                proxyIdentity,
                proxyCredentialsIdentity,
                thumbprints,
                clientOptions?.UserAgent);
        }

        private static IReadOnlyList<string> ExtractThumbprints(X509CertificateCollection certificates)
        {
            if (certificates == null || certificates.Count == 0) { return null; }

            string[] thumbprints = new string[certificates.Count];
            for (int i = 0; i < certificates.Count; i++)
            {
                X509Certificate cert = certificates[i];
                if (cert is X509Certificate2 cert2 && !string.IsNullOrEmpty(cert2.Thumbprint))
                {
                    thumbprints[i] = cert2.Thumbprint;
                }
                else
                {
                    thumbprints[i] = cert?.GetCertHashString();
                }
            }
            return thumbprints;
        }

        public bool Equals(RestClientCacheKey other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            if (!string.Equals(_baseUrl, other._baseUrl, StringComparison.Ordinal)) return false;
            if (!string.Equals(_proxyIdentity, other._proxyIdentity, StringComparison.Ordinal)) return false;
            if (_proxyCredentialsIdentity != other._proxyCredentialsIdentity) return false;
            if (!string.Equals(_userAgent, other._userAgent, StringComparison.Ordinal)) return false;
            if (!object.Equals(_timeoutMs, other._timeoutMs)) return false;
            if (_maxConnectionsPerServer != other._maxConnectionsPerServer) return false;
            if (_pooledConnectionIdleTimeoutMs != other._pooledConnectionIdleTimeoutMs) return false;
            if (_pooledConnectionLifetimeMinutes != other._pooledConnectionLifetimeMinutes) return false;

            if (_clientCertificateThumbprints == null && other._clientCertificateThumbprints == null) return true;
            if (_clientCertificateThumbprints == null || other._clientCertificateThumbprints == null) return false;
            if (_clientCertificateThumbprints.Count != other._clientCertificateThumbprints.Count) return false;
            for (int i = 0; i < _clientCertificateThumbprints.Count; i++)
            {
                if (!string.Equals(_clientCertificateThumbprints[i], other._clientCertificateThumbprints[i], StringComparison.OrdinalIgnoreCase))
                    return false;
            }
            return true;
        }

        public override bool Equals(object obj) => Equals(obj as RestClientCacheKey);

        public override int GetHashCode() => _hashCode;

        private int ComputeHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 31 + (_baseUrl != null ? StringComparer.Ordinal.GetHashCode(_baseUrl) : 0);
                hash = hash * 31 + (_proxyIdentity != null ? StringComparer.Ordinal.GetHashCode(_proxyIdentity) : 0);
                hash = hash * 31 + _proxyCredentialsIdentity;
                hash = hash * 31 + (_userAgent != null ? StringComparer.Ordinal.GetHashCode(_userAgent) : 0);
                hash = hash * 31 + (_timeoutMs != null ? _timeoutMs.GetHashCode() : 0);
                hash = hash * 31 + _maxConnectionsPerServer;
                hash = hash * 31 + _pooledConnectionIdleTimeoutMs;
                hash = hash * 31 + _pooledConnectionLifetimeMinutes;
                if (_clientCertificateThumbprints != null)
                {
                    for (int i = 0; i < _clientCertificateThumbprints.Count; i++)
                    {
                        string tp = _clientCertificateThumbprints[i];
                        hash = hash * 31 + (tp != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(tp) : 0);
                    }
                }
                return hash;
            }
        }
    }
}
