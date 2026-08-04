using Microsoft.Extensions.Caching.Memory;
using RestSharp;
using System;
using System.Collections.Concurrent;
using System.Threading;

namespace CyberSource.Client
{
    /// <summary>
    /// Pools SDK-owned <see cref="RestClient"/> instances (each wrapping a <see cref="System.Net.Http.HttpClient"/>
    /// backed by a shared <see cref="StandardSocketsHttpHandler"/>). Entries expire via TTL
    /// (<see cref="DefaultSlidingExpirationMinutes"/> sliding, <see cref="DefaultAbsoluteExpirationHours"/>
    /// absolute) and are capped at <see cref="DefaultSizeLimit"/> entries.
    /// </summary>
    /// <remarks>
    /// Every eviction (TTL, size-based, or explicit <see cref="ClearForTests"/>) fires a
    /// <see cref="PostEvictionCallback"/> that disposes the cached <see cref="RestClient"/> — which
    /// disposes its <see cref="System.Net.Http.HttpClient"/> and the underlying
    /// <see cref="StandardSocketsHttpHandler"/> — and removes the entry's lock sentinel from the
    /// per-key lock table. Without this callback, evicted entries silently leak the handler and its
    /// pooled TCP connections, and the lock table grows unbounded.
    /// </remarks>
    internal static class SdkOwnedRestClientCache
    {
        /// <summary>Maximum number of cached <see cref="RestClient"/> instances before size-based eviction kicks in.</summary>
        private const int DefaultSizeLimit = 100;

        /// <summary>Sliding-expiration window for an idle cache entry.</summary>
        private const int DefaultSlidingExpirationMinutes = 20;

        /// <summary>Hard absolute expiration for any cache entry, regardless of recent use.</summary>
        private const int DefaultAbsoluteExpirationHours = 4;

        /// <summary>Maximum lifetime (in minutes) of a pooled connection inside the shared <see cref="StandardSocketsHttpHandler"/>.</summary>
        internal const int DefaultPooledConnectionLifetimeMinutes = 10;

        private static readonly MemoryCache _cache = new MemoryCache(new MemoryCacheOptions { SizeLimit = DefaultSizeLimit });

        private static readonly ConcurrentDictionary<RestClientCacheKey, LockSentinel> _keyLocks =
            new ConcurrentDictionary<RestClientCacheKey, LockSentinel>();

        private static long _hits;
        private static long _misses;
        private static long _evictions;
        private static long _currentSize;

        /// <summary>Cumulative number of cache hits (materialized from an existing entry).</summary>
        internal static long Hits => Interlocked.Read(ref _hits);

        /// <summary>Cumulative number of cache misses (a new <see cref="RestClient"/> was built).</summary>
        internal static long Misses => Interlocked.Read(ref _misses);

        /// <summary>Cumulative number of evicted entries (TTL, size-based, or explicit clear).</summary>
        internal static long Evictions => Interlocked.Read(ref _evictions);

        /// <summary>Approximate current number of live cache entries (updated in the add / evict paths).</summary>
        internal static long CurrentSize => Interlocked.Read(ref _currentSize);

        /// <summary>
        /// Returns a pooled <see cref="RestClient"/> for the given <paramref name="key"/>, building a
        /// new one on cache miss using the supplied factory. Concurrent callers for the same key share
        /// a single <see cref="Lazy{T}"/> instance and therefore build exactly once.
        /// </summary>
        public static RestClient GetOrCreate(RestClientCacheKey key, Func<RestClient> factory)
        {
            if (key == null) { throw new ArgumentNullException(nameof(key)); }
            if (factory == null) { throw new ArgumentNullException(nameof(factory)); }

            if (_cache.TryGetValue(key, out SdkOwnedCacheEntry cachedEntry))
            {
                Interlocked.Increment(ref _hits);
                return MaterializeOrEvict(key, cachedEntry);
            }

            LockSentinel keyLock = _keyLocks.GetOrAdd(key, static _ => new LockSentinel());

            lock (keyLock)
            {
                if (_cache.TryGetValue(key, out cachedEntry))
                {
                    Interlocked.Increment(ref _hits);
                    return MaterializeOrEvict(key, cachedEntry);
                }

                Lazy<RestClient> lazy = new Lazy<RestClient>(
                    factory,
                    LazyThreadSafetyMode.ExecutionAndPublication);

                SdkOwnedCacheEntry entry = new SdkOwnedCacheEntry(lazy);

                MemoryCacheEntryOptions entryOptions = new MemoryCacheEntryOptions
                {
                    Size = 1,
                    SlidingExpiration = TimeSpan.FromMinutes(DefaultSlidingExpirationMinutes),
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(DefaultAbsoluteExpirationHours)
                };
                entryOptions.PostEvictionCallbacks.Add(new PostEvictionCallbackRegistration
                {
                    EvictionCallback = OnEvicted
                });

                _cache.Set(key, entry, entryOptions);
                Interlocked.Increment(ref _currentSize);
                Interlocked.Increment(ref _misses);

                return MaterializeOrEvict(key, entry);
            }
        }

        /// <summary>
        /// Materializes the cached <see cref="Lazy{T}"/>. On factory failure, the entry is removed
        /// (which fires <see cref="OnEvicted"/> and cleans up the lock sentinel) and the original
        /// exception is rethrown so callers see the true failure.
        /// </summary>
        private static RestClient MaterializeOrEvict(RestClientCacheKey key, SdkOwnedCacheEntry entry)
        {
            try
            {
                return entry.Lazy.Value;
            }
            catch
            {
                // Remove poisoned entry; OnEvicted will run (async) — but the lock sentinel is also
                // removed here so subsequent callers can retry cleanly without waiting for the callback.
                _cache.Remove(key);
                _keyLocks.TryRemove(key, out _);
                throw;
            }
        }

        /// <summary>
        /// Removes and disposes every cached entry. Intended for test isolation only — production code
        /// should rely on the natural TTL. Safe to call concurrently with normal access; new callers
        /// after this method returns will simply repopulate the cache.
        /// </summary>
        /// <remarks>
        /// <see cref="MemoryCache"/> fires <see cref="PostEvictionCallbackRegistration.EvictionCallback"/>
        /// asynchronously, so relying on it for test-visible disposal would race. Instead this method
        /// snapshots the live keys, atomically claims disposal on each <see cref="SdkOwnedCacheEntry"/>,
        /// disposes the <see cref="RestClient"/> inline, and only then removes the cache entry. The
        /// async <see cref="OnEvicted"/> that fires afterward observes <c>TryClaimDisposal</c> == false
        /// and becomes a no-op, so counters and disposal happen exactly once regardless of ordering.
        /// </remarks>
        internal static void ClearForTests()
        {
            RestClientCacheKey[] keys = System.Linq.Enumerable.ToArray(_keyLocks.Keys);
            foreach (RestClientCacheKey key in keys)
            {
                if (_cache.TryGetValue(key, out SdkOwnedCacheEntry entry) && entry.TryClaimDisposal())
                {
                    entry.DisposeCachedClient();
                    Interlocked.Decrement(ref _currentSize);
                    Interlocked.Increment(ref _evictions);
                    _keyLocks.TryRemove(key, out _);
                }
                _cache.Remove(key);
            }

            // Belt-and-suspenders: drain anything that slipped past the snapshot (e.g. entries added
            // between snapshotting _keyLocks and iterating above). Its async OnEvicted will still run
            // through TryClaimDisposal, so no double-counting occurs.
            _cache.Compact(1.0);
        }

        private static void OnEvicted(object key, object? value, EvictionReason reason, object? state)
        {
            if (!(value is SdkOwnedCacheEntry entry)) { return; }

            if (!entry.TryClaimDisposal())
            {
                // ClearForTests already handled this entry inline; do nothing so counters do not
                // double-count and Dispose is not called twice on the wrapped RestClient.
                return;
            }

            if (key is RestClientCacheKey typedKey)
            {
                _keyLocks.TryRemove(typedKey, out _);
            }

            Interlocked.Decrement(ref _currentSize);
            Interlocked.Increment(ref _evictions);

            entry.DisposeCachedClient();
        }

        private sealed class LockSentinel
        {
        }
    }
}
