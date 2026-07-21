using AuthenticationSdk.util;
using Microsoft.Extensions.Caching.Memory;
using RestSharp;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.Caching;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MemoryCache = Microsoft.Extensions.Caching.Memory.MemoryCache;

namespace CyberSource.Client
{
    internal static class RestClientFactory
    {
        private static readonly MemoryCache _cache = new MemoryCache(new MemoryCacheOptions { SizeLimit = 100 });

        private static readonly ConcurrentDictionary<RestClientCacheKey, object> _keyLocks = new ConcurrentDictionary<RestClientCacheKey, object>();

        internal static RestClient GetRestClient(IMerchantNetworkSettings merchantNetworkSettings, RestClientOptions restClientOptions)
        {
            if (restClientOptions == null) { throw new ArgumentNullException(nameof(restClientOptions)); }

            int maxConnectionsPerServer = merchantNetworkSettings?.MaxConnectionPoolSize != null
                ? int.Parse(merchantNetworkSettings.MaxConnectionPoolSize)
                : int.Parse(Constants.DefaultMaxConnectionPoolSize);

            int pooledConnectionIdleTimeoutMs = merchantNetworkSettings?.KeepAliveTime != null
                ? int.Parse(merchantNetworkSettings.KeepAliveTime)
                : int.Parse(Constants.DefaultKeepAliveTime);

            int pooledConnectionLifetimeMinutes = 10;

            RestClientCacheKey key = RestClientCacheKey.From(restClientOptions, maxConnectionsPerServer, pooledConnectionIdleTimeoutMs, pooledConnectionLifetimeMinutes);

            if (_cache.TryGetValue(key, out Lazy<RestClient> cachedLazy))
            {
                return GetOrRebuildOnFailure(key, cachedLazy);
            }

            object keyLock = _keyLocks.GetOrAdd(key, k => new object());

            lock (keyLock)
            {
                if (_cache.TryGetValue(key, out cachedLazy))
                {
                    return GetOrRebuildOnFailure(key, cachedLazy);
                }

                Lazy<RestClient> lazy = new Lazy<RestClient>(
                    () =>
                    {
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
                            Timeout = (TimeSpan)restClientOptions.Timeout
                        };

                        if (!string.IsNullOrWhiteSpace(restClientOptions.UserAgent))
                        {
                            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(restClientOptions.UserAgent);
                        }

                        return new RestClient(httpClient, restClientOptions);
                    }, System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);

                MemoryCacheEntryOptions entryOptions = new MemoryCacheEntryOptions
                {
                    Size = 1,
                    SlidingExpiration = TimeSpan.FromMinutes(20),
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(4)
                };

                _cache.Set(key, lazy, entryOptions);

                return GetOrRebuildOnFailure(key, lazy);
            }
        }

        internal static void Clear()
        {
            _cache.Compact(1.0);
            _keyLocks.Clear();
        }

        private static RestClient GetOrRebuildOnFailure(RestClientCacheKey key, Lazy<RestClient> lazy)
        {
            try
            {
                return lazy.Value;
            }
            catch
            {
                _cache.Remove(key);
                throw;
            }
            finally
            {
                object existing;
                if (!_cache.TryGetValue(key, out existing))
                {
                    object removed;
                    _keyLocks.TryRemove(key, out removed);
                }
            }
        }

        private static void ApplyProxy(StandardSocketsHttpHandler handler, IWebProxy proxy)
        {
            if (proxy != null)
            {
                handler.Proxy = proxy;
                handler.UseProxy = true;
            }
        }

        private static void ApplyClientCertificates(StandardSocketsHttpHandler handler, X509CertificateCollection clientCertificates)
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
                // Otherwise, attempt to convert to X509Certificate2 for edge cases
                else if (cert != null)
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

        private sealed class RestClientCacheKey : IEquatable<RestClientCacheKey>
        {
            private readonly string _baseUrl;
            private readonly string[] _clientCertificateThumbprints;
            private readonly string _proxyKey;
            private readonly string _proxyCredentialsDigest;
            private readonly object _timeoutMs;
            private readonly string _userAgent;
            private readonly int _maxConnectionsPerServer;
            private readonly int _pooledConnectionIdleTimeoutMs;
            private readonly int _pooledConnectionLifetimeMinutes;
            private readonly int _hashCode;

            private RestClientCacheKey(string baseUrl, object timeoutMs, int maxConnectionsPerServer, int pooledConnectionIdleTimeoutMs, int pooledConnectionLifetimeMinutes, string proxyKey, string proxyCredentialsDigest, string[] clientCertificateThumbprints, string userAgent)
            {
                _baseUrl = baseUrl;
                _timeoutMs = timeoutMs;
                _maxConnectionsPerServer = maxConnectionsPerServer;
                _pooledConnectionIdleTimeoutMs = pooledConnectionIdleTimeoutMs;
                _pooledConnectionLifetimeMinutes = pooledConnectionLifetimeMinutes;
                _proxyKey = proxyKey;
                _proxyCredentialsDigest = proxyCredentialsDigest;
                _clientCertificateThumbprints = clientCertificateThumbprints;
                _userAgent = userAgent;
                _hashCode = ComputeHashCode();
            }

            public static RestClientCacheKey From(RestClientOptions clientOptions, int maxConnectionsPerServer = 0, int pooledConnectionIdleTimeoutMs = 0, int pooledConnectionLifetimeMinutes = 0)
            {
                string baseUrl = clientOptions?.BaseUrl?.AbsoluteUri;

                string[] thumbprints = null;
                if (clientOptions?.ClientCertificates != null && clientOptions.ClientCertificates.Count > 0)
                {
                    thumbprints = new string[clientOptions.ClientCertificates.Count];
                    for (int i = 0; i < clientOptions.ClientCertificates.Count; i++)
                    {
                        X509Certificate cert = clientOptions.ClientCertificates[i];
                        if (cert is X509Certificate2 cert2 && !string.IsNullOrEmpty(cert2.Thumbprint))
                        {
                            thumbprints[i] = cert2.Thumbprint;
                        }
                        else
                        {
                            thumbprints[i] = cert?.GetCertHashString();
                        }
                    }
                }

                string proxyKey = null;
                string proxyCredentialsDigest = null;
                if (clientOptions?.Proxy != null)
                {
                    try
                    {
                        // Resolve against the actual BaseUrl when available, otherwise a
                        // deterministic sentinel, so two IWebProxy instances configured the
                        // same way produce the same key.
                        Uri probe = clientOptions.BaseUrl ?? new Uri("https://cybersource-cache-key.invalid");
                        Uri resolved = clientOptions.Proxy.GetProxy(probe);
                        proxyKey = resolved != null
                            ? resolved.AbsoluteUri
                            : clientOptions.Proxy.GetType().FullName;
                    }
                    catch
                    {
                        proxyKey = clientOptions.Proxy.GetType().FullName;
                    }

                    proxyCredentialsDigest = ComputeProxyCredentialsDigest(clientOptions.Proxy.Credentials);
                }

                return new RestClientCacheKey(
                    baseUrl,
                    clientOptions?.Timeout,
                    maxConnectionsPerServer,
                    pooledConnectionIdleTimeoutMs,
                    pooledConnectionLifetimeMinutes,
                    proxyKey,
                    proxyCredentialsDigest,
                    thumbprints,
                    clientOptions?.UserAgent);
            }

            private static string ComputeProxyCredentialsDigest(ICredentials credentials)
            {
                if (!(credentials is NetworkCredential nc)) { return null; }
                
                string userPart = (nc.UserName ?? string.Empty) + "|" + (nc.Domain ?? string.Empty);
                if (string.IsNullOrEmpty(nc.Password)) { return userPart; }
                
                // Hash password so it is NOT retained in plain text in cache key
                return userPart + "|" + ComputeSha256Hex(nc.Password);
            }

            private static string ComputeSha256Hex(string input)
            {
                using (var sha = SHA256.Create())
                {
                    byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                    var hex = new StringBuilder(bytes.Length * 2);
                    foreach (byte b in bytes)
                        hex.Append(b.ToString("x2"));
                    return hex.ToString();
                }
            }

            public bool Equals(RestClientCacheKey other)
            {
                if (other is null) return false;
                if (ReferenceEquals(this, other)) return true;

                if (!string.Equals(_baseUrl, other._baseUrl, StringComparison.Ordinal)) return false;
                if (!string.Equals(_proxyKey, other._proxyKey, StringComparison.Ordinal)) return false;
                if (!string.Equals(_proxyCredentialsDigest, other._proxyCredentialsDigest, StringComparison.Ordinal)) return false;
                if (!string.Equals(_userAgent, other._userAgent, StringComparison.Ordinal)) return false;
                if (!object.Equals(_timeoutMs, other._timeoutMs)) return false;
                if (_maxConnectionsPerServer != other._maxConnectionsPerServer) return false;
                if (_pooledConnectionIdleTimeoutMs != other._pooledConnectionIdleTimeoutMs) return false;
                if (_pooledConnectionLifetimeMinutes != other._pooledConnectionLifetimeMinutes) return false;

                if (_clientCertificateThumbprints == null && other._clientCertificateThumbprints == null) return true;
                if (_clientCertificateThumbprints == null || other._clientCertificateThumbprints == null) return false;
                if (_clientCertificateThumbprints.Length != other._clientCertificateThumbprints.Length) return false;
                for (int i = 0; i < _clientCertificateThumbprints.Length; i++)
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
                    hash = hash * 31 + (_proxyKey != null ? StringComparer.Ordinal.GetHashCode(_proxyKey) : 0);
                    hash = hash * 31 + (_proxyCredentialsDigest != null ? StringComparer.Ordinal.GetHashCode(_proxyCredentialsDigest) : 0);
                    hash = hash * 31 + (_userAgent != null ? StringComparer.Ordinal.GetHashCode(_userAgent) : 0);
                    hash = hash * 31 + (_timeoutMs != null ? _timeoutMs.GetHashCode() : 0);
                    hash = hash * 31 + _maxConnectionsPerServer;
                    hash = hash * 31 + _pooledConnectionIdleTimeoutMs;
                    hash = hash * 31 + _pooledConnectionLifetimeMinutes;
                    if (_clientCertificateThumbprints != null)
                    {
                        foreach (string tp in _clientCertificateThumbprints)
                        {
                            hash = hash * 31 + (tp != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(tp) : 0);
                        }
                    }
                    return hash;
                }
            }
        }
    }
}