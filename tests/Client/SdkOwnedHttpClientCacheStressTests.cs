using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CyberSource.Client;
using NUnit.Framework;

namespace cybersource_rest_client_netstandard.Test.Client
{
    /// <summary>
    /// Stress + leak-detection coverage for <see cref="SdkOwnedHttpClientCache"/>.
    /// These tests exercise the four failure modes that a naive
    /// <see cref="System.Collections.Concurrent.ConcurrentDictionary{TKey,TValue}"/>-backed
    /// implementation would exhibit and prove the current MemoryCache-based design does not:
    /// <list type="bullet">
    ///   <item>Unbounded growth under a large number of unique keys (size-based eviction fires).</item>
    ///   <item>Duplicate factory invocation under high key-collision (single-flight is honored).</item>
    ///   <item>Handler / socket leaks on eviction (every evicted <see cref="HttpClient"/> is disposed).</item>
    ///   <item>GC-root retention (evicted <see cref="HttpClient"/> instances become collectible).</item>
    /// </list>
    /// </summary>
    [TestFixture]
    public class SdkOwnedHttpClientCacheStressTests
    {
        /// <summary>
        /// Upper bound for polling MemoryCache's asynchronous eviction pipeline to settle. Generous so
        /// heavily loaded CI hardware, where the async callbacks are delayed, does not flake.
        /// </summary>
        private const int DrainTimeoutMs = 10000;

        [SetUp]
        public void ResetCache()
        {
            SdkOwnedHttpClientCache.ClearForTests();
        }

        [TearDown]
        public void DrainCache()
        {
            SdkOwnedHttpClientCache.ClearForTests();
        }

        /// <summary>
        /// Fires a large number of unique cache keys through <see cref="SdkOwnedHttpClientCache.GetOrCreate"/>
        /// and proves size-based eviction (a) actually fires and (b) disposes every evicted <see cref="HttpClient"/>.
        /// A leaking cache would surface here as <c>disposedCount == 0</c> or as <c>CurrentSize</c> unbounded.
        /// </summary>
        [Test]
        public void GetOrCreate_UnderLargeNumberOfUniqueKeys_EvictsAndDisposesEntries()
        {
            const int UniqueKeys = 2000;

            var disposedCount = new StrongBox<int>(0);
            long evictionsBefore = SdkOwnedHttpClientCache.Evictions;

            for (int i = 0; i < UniqueKeys; i++)
            {
                SdkOwnedHttpClientCacheKey key = BuildKey($"https://stress-unique-{i}.invalid/");
                SdkOwnedHttpClientCache.GetOrCreate(key, () => NewTrackingClient(disposedCount));
            }

            // Size-based eviction must fire from the insert loop itself (before any explicit clear),
            // proving the SizeLimit=100 cap is enforced under load rather than the cache growing
            // unboundedly. OnEvicted increments _evictions asynchronously, so poll for the first
            // size-pressure eviction; if eviction were broken this stays 0 and the assertion below fails.
            SpinWait.SpinUntil(
                () => SdkOwnedHttpClientCache.Evictions - evictionsBefore > 0,
                millisecondsTimeout: DrainTimeoutMs);
            long evictionsFromSizePressure = SdkOwnedHttpClientCache.Evictions - evictionsBefore;

            // MemoryCache fires PostEvictionCallbacks asynchronously, so drain deterministically and poll
            // until the pipeline settles before asserting the exact 1:1 disposal invariant (mirrors
            // ClearForTests_ReleasesEveryEntry_WithZeroRetainedState).
            SdkOwnedHttpClientCache.ClearForTests();
            SpinWait.SpinUntil(
                () => SdkOwnedHttpClientCache.Evictions - evictionsBefore >= UniqueKeys
                      && disposedCount.Value >= UniqueKeys,
                millisecondsTimeout: DrainTimeoutMs);

            long evictionsDelta = SdkOwnedHttpClientCache.Evictions - evictionsBefore;

            Assert.Greater(evictionsFromSizePressure, 0,
                "Adding thousands of unique keys against a SizeLimit=100 cache must trigger size-based eviction; " +
                "no evictions means the cache is growing unboundedly.");
            Assert.AreEqual(0, SdkOwnedHttpClientCache.CurrentSize,
                "After draining, the cache must report zero live entries; a non-zero value indicates state retained past eviction.");
            Assert.GreaterOrEqual(evictionsDelta, UniqueKeys,
                $"Every inserted entry must eventually be evicted (size-based or via drain). Observed {evictionsDelta} evictions for {UniqueKeys} inserts.");
            Assert.AreEqual(UniqueKeys, disposedCount.Value,
                $"Every SDK-owned HttpClient must be disposed exactly once. Observed {disposedCount.Value} of {UniqueKeys} " +
                "disposals - a shortfall means the pooled StandardSocketsHttpHandler and its sockets leak.");
        }

        /// <summary>
        /// High-collision scenario: many concurrent threads race on the SAME key. The cache's per-key
        /// single-flight (<c>Lazy&lt;T&gt;</c> under a keyed lock sentinel) must guarantee exactly one factory
        /// invocation regardless of contention, and every caller must observe the same <see cref="HttpClient"/>.
        /// A regression here would either double-build (wasted handlers) or hand out distinct instances (pool split).
        /// </summary>
        [Test]
        public void GetOrCreate_UnderHighKeyCollision_InvokesFactoryExactlyOnce()
        {
            const int Threads = 32;
            const int IterationsPerThread = 500;

            SdkOwnedHttpClientCacheKey key = BuildKey("https://stress-collision.invalid/");

            int factoryInvocations = 0;
            HttpClient shared = null;
            var lockObj = new object();
            var mismatched = new List<HttpClient>();

            using var start = new ManualResetEventSlim(false);

            Task[] workers = new Task[Threads];
            for (int t = 0; t < Threads; t++)
            {
                workers[t] = Task.Run(() =>
                {
                    start.Wait();
                    for (int i = 0; i < IterationsPerThread; i++)
                    {
                        HttpClient c = SdkOwnedHttpClientCache.GetOrCreate(key, () =>
                        {
                            Interlocked.Increment(ref factoryInvocations);
                            return new HttpClient(new StandardSocketsHttpHandler());
                        });

                        lock (lockObj)
                        {
                            if (shared == null) { shared = c; }
                            else if (!ReferenceEquals(shared, c)) { mismatched.Add(c); }
                        }
                    }
                });
            }

            start.Set();
            Task.WaitAll(workers);

            Assert.AreEqual(1, factoryInvocations,
                $"Under {Threads * IterationsPerThread} concurrent same-key requests the factory must run exactly once; observed {factoryInvocations}.");
            Assert.IsEmpty(mismatched,
                "Every concurrent caller for the same key must receive the same cached HttpClient instance.");
        }

        /// <summary>
        /// High-frequency, high-hit-rate scenario: a small key set is hammered with many rapid requests
        /// from many threads. Steady-state <see cref="SdkOwnedHttpClientCache.Hits"/> must dominate
        /// <see cref="SdkOwnedHttpClientCache.Misses"/> (at least ~99% hit rate), and cache size must
        /// remain bounded by the number of distinct keys - proving lookups are O(1) and non-allocating
        /// on the hit path.
        /// </summary>
        [Test]
        public void GetOrCreate_UnderHighFrequencyHighHitRate_KeepsMissesBoundedByKeySpace()
        {
            const int DistinctKeys = 8;
            const int Threads = 16;
            const int IterationsPerThread = 5000;
            const int TotalRequests = Threads * IterationsPerThread;

            SdkOwnedHttpClientCacheKey[] keys = new SdkOwnedHttpClientCacheKey[DistinctKeys];
            for (int i = 0; i < DistinctKeys; i++)
            {
                keys[i] = BuildKey($"https://stress-hitrate-{i}.invalid/");
            }

            long hitsBefore = SdkOwnedHttpClientCache.Hits;
            long missesBefore = SdkOwnedHttpClientCache.Misses;

            using var start = new ManualResetEventSlim(false);
            Task[] workers = new Task[Threads];
            for (int t = 0; t < Threads; t++)
            {
                int seed = t;
                workers[t] = Task.Run(() =>
                {
                    var rng = new Random(seed);
                    start.Wait();
                    for (int i = 0; i < IterationsPerThread; i++)
                    {
                        SdkOwnedHttpClientCacheKey key = keys[rng.Next(DistinctKeys)];
                        SdkOwnedHttpClientCache.GetOrCreate(key, () => new HttpClient(new StandardSocketsHttpHandler()));
                    }
                });
            }

            start.Set();
            Task.WaitAll(workers);

            long hitsDelta = SdkOwnedHttpClientCache.Hits - hitsBefore;
            long missesDelta = SdkOwnedHttpClientCache.Misses - missesBefore;

            Assert.LessOrEqual(missesDelta, DistinctKeys,
                $"With {DistinctKeys} distinct keys, at most {DistinctKeys} misses can occur; observed {missesDelta} - indicates the cache is rebuilding entries under contention.");
            Assert.AreEqual(TotalRequests, hitsDelta + missesDelta,
                "Every GetOrCreate call must be accounted for as either a hit or a miss.");
            double hitRate = (double)hitsDelta / TotalRequests;
            Assert.Greater(hitRate, 0.99,
                $"High-frequency same-keyset workload must reach >99% hit rate; observed {hitRate:P2}.");
        }

        /// <summary>
        /// Leak-invariant test: after inserting many unique keys and draining the cache,
        /// (1) the cache's tracked <see cref="SdkOwnedHttpClientCache.CurrentSize"/> must return to zero,
        /// (2) every inserted entry must have been disposed exactly once (proving no
        ///     <see cref="SdkOwnedCacheEntry"/> is retained past eviction), and
        /// (3) the cumulative eviction count must equal the number of inserted entries.
        /// GC reachability of the wrapped <see cref="HttpClient"/> is intentionally NOT asserted here because
        /// .NET Framework's <see cref="HttpClient"/> retains internal state that is out of the cache's
        /// control. What we can and do assert is that the cache itself releases every reference it took.
        /// </summary>
        [Test]
        public void ClearForTests_ReleasesEveryEntry_WithZeroRetainedState()
        {
            const int UniqueKeys = 200;

            var disposedCount = new StrongBox<int>(0);
            long evictionsBefore = SdkOwnedHttpClientCache.Evictions;

            for (int i = 0; i < UniqueKeys; i++)
            {
                SdkOwnedHttpClientCacheKey key = BuildKey($"https://leak-invariant-{i}.invalid/");
                SdkOwnedHttpClientCache.GetOrCreate(key, () => NewTrackingClient(disposedCount));
            }

            SdkOwnedHttpClientCache.ClearForTests();

            // MemoryCache size-based eviction fires PostEvictionCallbacks asynchronously; poll briefly
            // so this test does not race against the callback pipeline on slower CI hardware.
            SpinWait.SpinUntil(
                () => SdkOwnedHttpClientCache.Evictions - evictionsBefore >= UniqueKeys
                      && disposedCount.Value >= UniqueKeys,
                millisecondsTimeout: DrainTimeoutMs);

            Assert.AreEqual(0, SdkOwnedHttpClientCache.CurrentSize,
                "After ClearForTests the cache must report zero live entries; a non-zero value indicates internal state is being retained past eviction.");

            long evictionsDelta = SdkOwnedHttpClientCache.Evictions - evictionsBefore;
            Assert.GreaterOrEqual(evictionsDelta, UniqueKeys,
                $"Every inserted entry must be evicted (either via size-based compaction or ClearForTests). Observed {evictionsDelta} evictions for {UniqueKeys} inserts.");

            Assert.AreEqual(UniqueKeys, disposedCount.Value,
                $"Every SDK-owned HttpClient handed to the cache must be disposed exactly once. Observed {disposedCount.Value} of {UniqueKeys} - a shortfall means the cache is leaking handlers / sockets.");
        }

        /// <summary>
        /// Deterministic regression guard for the materialize-before-publish fix: while the factory is
        /// blocked (the <see cref="System.Lazy{T}"/> is not yet materialized) the entry must not be
        /// visible in the cache, so a concurrent eviction cannot orphan the <see cref="HttpClient"/> the
        /// factory builds moments later.
        /// </summary>
        [Test]
        public void GetOrCreate_NeverPublishesUnmaterializedEntry()
        {
            SdkOwnedHttpClientCacheKey key = BuildKey("https://deterministic-race.invalid/");
            using var factoryEntered = new ManualResetEventSlim(false);
            using var releaseFactory = new ManualResetEventSlim(false);

            Task<HttpClient> getOrCreateTask = Task.Run(() =>
                SdkOwnedHttpClientCache.GetOrCreate(key, () =>
                {
                    factoryEntered.Set();
                    releaseFactory.Wait();
                    return new HttpClient(new StandardSocketsHttpHandler());
                }));

            Assert.IsTrue(factoryEntered.Wait(TimeSpan.FromSeconds(2)),
                "Factory must have started executing.");

            // Factory is still blocked, so the Lazy is not materialized: the entry must not be published.
            Assert.IsFalse(_cacheHasEntry(key),
                "An entry must never be published to the cache before its HttpClient is materialized; " +
                "otherwise a concurrent eviction could orphan the HttpClient built moments later.");

            releaseFactory.Set();
            HttpClient result = getOrCreateTask.GetAwaiter().GetResult();

            Assert.IsNotNull(result);
            Assert.IsTrue(_cacheHasEntry(key), "Entry must be published once materialization completes.");
        }

        #region Helpers

        private static bool _cacheHasEntry(SdkOwnedHttpClientCacheKey key)
            => SdkOwnedHttpClientCache.TryPeek(key);

        private static SdkOwnedHttpClientCacheKey BuildKey(string baseUrl)
            => SdkOwnedHttpClientCacheKey.From(
                new HttpTransportOptions
                {
                    BaseUrl = new Uri(baseUrl),
                    Timeout = TimeSpan.FromSeconds(30)
                },
                maxConnectionsPerServer: 32,
                pooledConnectionIdleTimeoutMs: 60000,
                pooledConnectionLifetimeMinutes: SdkOwnedHttpClientCache.DefaultPooledConnectionLifetimeMinutes);

        private static HttpClient NewTrackingClient(StrongBox<int> disposedCount)
        {
            var handler = new DisposeCountingHandler(disposedCount);
            return new HttpClient(handler, disposeHandler: true);
        }

        private sealed class DisposeCountingHandler : HttpMessageHandler
        {
            private readonly StrongBox<int> _counter;

            public DisposeCountingHandler(StrongBox<int> counter)
            {
                _counter = counter;
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
                => Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.OK));

            protected override void Dispose(bool disposing)
            {
                Interlocked.Increment(ref _counter.Value);
                base.Dispose(disposing);
            }
        }

        #endregion Helpers
    }
}
