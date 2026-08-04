using RestSharp;
using System;
using System.Threading;

namespace CyberSource.Client
{
    /// <summary>
    /// Wraps the <see cref="RestClient"/> cached in <see cref="SdkOwnedRestClientCache"/> and guarantees
    /// exactly-once accounting + disposal regardless of whether the trigger is TTL eviction, size-based
    /// eviction, an explicit test clear, or a concurrent race between them.
    /// </summary>
    /// <remarks>
    /// <see cref="Microsoft.Extensions.Caching.Memory.MemoryCache"/> invokes
    /// <see cref="Microsoft.Extensions.Caching.Memory.PostEvictionCallbackRegistration.EvictionCallback"/>
    /// asynchronously via <c>Task.Factory.StartNew</c>. A test that removes an entry and immediately
    /// asserts disposal would therefore race the callback. This holder lets the caller ("ClearForTests")
    /// dispose synchronously and inline while still letting the natural async eviction path do the same
    /// work later — whichever path wins the CAS is the one that runs, so counters are never double-bumped
    /// and the wrapped <see cref="RestClient"/> is never disposed twice.
    /// </remarks>
    internal sealed class SdkOwnedCacheEntry
    {
        private readonly Lazy<RestClient> _lazy;
        private int _disposed;

        public SdkOwnedCacheEntry(Lazy<RestClient> lazy)
        {
            _lazy = lazy ?? throw new ArgumentNullException(nameof(lazy));
        }

        /// <summary>The lazy-materialized <see cref="RestClient"/>. Never null.</summary>
        public Lazy<RestClient> Lazy => _lazy;

        /// <summary>
        /// Attempts to claim disposal. Returns <c>true</c> only for the first caller; subsequent
        /// callers observe <c>false</c> and must not repeat the disposal / accounting side effects.
        /// </summary>
        public bool TryClaimDisposal()
            => Interlocked.CompareExchange(ref _disposed, 1, 0) == 0;

        /// <summary>
        /// Disposes the cached <see cref="RestClient"/> if it was actually materialized. Safe to call
        /// even after <see cref="TryClaimDisposal"/> has returned <c>true</c> from another thread —
        /// this is a no-op in that case.
        /// </summary>
        public void DisposeCachedClient()
        {
            if (!_lazy.IsValueCreated) { return; }

            try
            {
                // Disposes the RestClient wrapper, which disposes the SDK-owned HttpClient, which
                // disposes the StandardSocketsHttpHandler and drains its pooled TCP connections.
                _lazy.Value.Dispose();
            }
            catch
            {
                // A misbehaving RestClient.Dispose implementation must not corrupt the cache.
            }
        }
    }
}
