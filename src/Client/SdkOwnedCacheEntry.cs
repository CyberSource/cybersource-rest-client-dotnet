using System;
using System.Net.Http;
using System.Threading;

namespace CyberSource.Client
{
    /// <summary>
    /// Wraps the <see cref="HttpClient"/> cached in <see cref="SdkOwnedHttpClientCache"/> and guarantees
    /// exactly-once accounting + disposal regardless of whether the trigger is TTL eviction, size-based
    /// eviction, an explicit test clear, or a concurrent race between them.
    /// </summary>
    /// <remarks>
    /// <see cref="Microsoft.Extensions.Caching.Memory.MemoryCache"/> invokes
    /// <see cref="Microsoft.Extensions.Caching.Memory.PostEvictionCallbackRegistration.EvictionCallback"/>
    /// asynchronously via <c>Task.Factory.StartNew</c>. A test that removes an entry and immediately
    /// asserts disposal would therefore race the callback. This holder lets the caller ("ClearForTests")
    /// dispose synchronously and inline while still letting the natural async eviction path do the same
    /// work later whichever path wins the CAS is the one that runs, so counters are never double-bumped
    /// and the wrapped <see cref="RestClient"/> is never disposed twice.
    /// </remarks>
    internal sealed class SdkOwnedCacheEntry
    {
        private readonly Lazy<HttpClient> _lazy;
        private int _disposed;

        public SdkOwnedCacheEntry(Lazy<HttpClient> lazy)
        {
            _lazy = lazy ?? throw new ArgumentNullException(nameof(lazy));
        }

        /// <summary>The lazy-materialized <see cref="HttpClient"/>. Never null.</summary>
        public Lazy<HttpClient> Lazy => _lazy;

        /// <summary>
        /// Attempts to claim disposal. Returns <c>true</c> only for the first caller; subsequent
        /// callers observe <c>false</c> and must not repeat the disposal / accounting side effects.
        /// </summary>
        public bool TryClaimDisposal()
            => Interlocked.CompareExchange(ref _disposed, 1, 0) == 0;

        /// <summary>
        /// Disposes the cached <see cref="HttpClient"/> (and its owned handler and pooled TCP
        /// connections) if it was actually materialized. Safe to call multiple times.
        /// </summary>
        public void DisposeCachedClient()
        {
            if (!_lazy.IsValueCreated) { return; }

            try
            {
                _lazy.Value.Dispose();
            }
            catch
            {
                // A misbehaving HttpClient.Dispose implementation must not corrupt the cache.
            }
        }
    }
}
