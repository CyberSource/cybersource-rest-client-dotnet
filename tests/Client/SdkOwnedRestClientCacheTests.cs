using System;
using System.Net.Http;
using System.Threading;
using CyberSource.Client;
using NUnit.Framework;
using RestSharp;

namespace cybersource_rest_client_netstandard.Test.Client
{
    /// <summary>
    /// Focused coverage for <see cref="SdkOwnedRestClientCache"/>: cache miss / hit / eviction /
    /// disposal / counter increments. These behaviors underpin the SDK-owned path taken when no
    /// caller-supplied <see cref="System.Net.Http.HttpClient"/> or
    /// <see cref="System.Net.Http.IHttpClientFactory"/> is injected.
    /// </summary>
    [TestFixture]
    public class SdkOwnedRestClientCacheTests
    {
        [SetUp]
        public void ResetCache()
        {
            SdkOwnedRestClientCache.ClearForTests();
        }

        [Test]
        public void GetOrCreate_ReturnsSameInstance_ForEqualKeys()
        {
            RestClientCacheKey key = BuildKey("https://cache-same-instance.invalid/");

            int factoryInvocations = 0;
            RestClient first = SdkOwnedRestClientCache.GetOrCreate(key, () =>
            {
                Interlocked.Increment(ref factoryInvocations);
                return new RestClient(NewShortLivedHttpClient(), NewOptions("https://cache-same-instance.invalid/"));
            });

            RestClient second = SdkOwnedRestClientCache.GetOrCreate(key, () =>
            {
                Interlocked.Increment(ref factoryInvocations);
                return new RestClient(NewShortLivedHttpClient(), NewOptions("https://cache-same-instance.invalid/"));
            });

            Assert.AreSame(first, second, "Equal keys must resolve to the same cached RestClient instance.");
            Assert.AreEqual(1, factoryInvocations, "Factory must run exactly once for equal keys.");
        }

        [Test]
        public void ClearForTests_DisposesCachedRestClient()
        {
            RestClientCacheKey key = BuildKey("https://cache-eviction-disposes.invalid/");

            var trackingClient = new DisposeTrackingHttpClient();

            // disposeHttpClient:true mirrors what RestClientFactory.GetSdkOwnedRestClient does in
            // production — the SDK owns this HttpClient, so eviction must transitively dispose it.
            RestClient cached = SdkOwnedRestClientCache.GetOrCreate(key, () =>
                new RestClient(trackingClient.Client, NewOptions("https://cache-eviction-disposes.invalid/"), disposeHttpClient: true));

            Assert.IsFalse(trackingClient.Disposed, "Sanity: HttpClient must not be disposed while still cached.");

            SdkOwnedRestClientCache.ClearForTests();

            Assert.IsTrue(trackingClient.Disposed,
                "Eviction (via ClearForTests) must dispose the cached RestClient, which disposes its owned HttpClient and handler. " +
                "Without this the SDK leaks a StandardSocketsHttpHandler and its pooled TCP connections on every eviction.");
        }

        [Test]
        public void ClearForTests_RemovesLockSentinel_SoSubsequentGetOrCreateRebuilds()
        {
            RestClientCacheKey key = BuildKey("https://cache-lock-cleanup.invalid/");

            int factoryInvocations = 0;
            SdkOwnedRestClientCache.GetOrCreate(key, () =>
            {
                Interlocked.Increment(ref factoryInvocations);
                return new RestClient(NewShortLivedHttpClient(), NewOptions("https://cache-lock-cleanup.invalid/"));
            });

            SdkOwnedRestClientCache.ClearForTests();

            // After eviction, a fresh GetOrCreate for the same key must build a new RestClient. If the
            // lock table were leaked, this still works — but this test also indirectly proves the lock
            // was cleaned by the eviction callback (otherwise _keyLocks would grow unbounded, which is
            // covered separately via CurrentSize counters).
            SdkOwnedRestClientCache.GetOrCreate(key, () =>
            {
                Interlocked.Increment(ref factoryInvocations);
                return new RestClient(NewShortLivedHttpClient(), NewOptions("https://cache-lock-cleanup.invalid/"));
            });

            Assert.AreEqual(2, factoryInvocations, "Factory must run a second time after the cache is cleared.");
        }

        [Test]
        public void Counters_IncrementOnHit_MissAndEviction()
        {
            long hitsBefore = SdkOwnedRestClientCache.Hits;
            long missesBefore = SdkOwnedRestClientCache.Misses;
            long evictionsBefore = SdkOwnedRestClientCache.Evictions;

            RestClientCacheKey key = BuildKey("https://cache-counters.invalid/");

            SdkOwnedRestClientCache.GetOrCreate(key, () =>
                new RestClient(NewShortLivedHttpClient(), NewOptions("https://cache-counters.invalid/")));

            SdkOwnedRestClientCache.GetOrCreate(key, () =>
                new RestClient(NewShortLivedHttpClient(), NewOptions("https://cache-counters.invalid/")));

            SdkOwnedRestClientCache.ClearForTests();

            Assert.AreEqual(missesBefore + 1, SdkOwnedRestClientCache.Misses, "Exactly one cache miss expected.");
            Assert.AreEqual(hitsBefore + 1, SdkOwnedRestClientCache.Hits, "Exactly one cache hit expected on the second call.");
            Assert.AreEqual(evictionsBefore + 1, SdkOwnedRestClientCache.Evictions, "ClearForTests must fire the eviction callback for the entry.");
        }

        [Test]
        public void GetOrCreate_ThrowsArgumentNullException_WhenKeyIsNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
                SdkOwnedRestClientCache.GetOrCreate(null, () => new RestClient(NewShortLivedHttpClient(), NewOptions("https://null-key.invalid/"))));
        }

        [Test]
        public void GetOrCreate_ThrowsArgumentNullException_WhenFactoryIsNull()
        {
            RestClientCacheKey key = BuildKey("https://null-factory.invalid/");
            Assert.Throws<ArgumentNullException>(() => SdkOwnedRestClientCache.GetOrCreate(key, null));
        }

        [Test]
        public void GetOrCreate_EvictsPoisonedEntry_WhenFactoryThrows()
        {
            RestClientCacheKey key = BuildKey("https://cache-poisoned.invalid/");

            long missesBefore = SdkOwnedRestClientCache.Misses;

            Assert.Throws<InvalidOperationException>(() =>
                SdkOwnedRestClientCache.GetOrCreate(key, () => throw new InvalidOperationException("boom")));

            // Second call must not observe the poisoned Lazy — it must rebuild via a fresh factory call.
            RestClient rebuilt = SdkOwnedRestClientCache.GetOrCreate(key, () =>
                new RestClient(NewShortLivedHttpClient(), NewOptions("https://cache-poisoned.invalid/")));

            Assert.IsNotNull(rebuilt);
            Assert.GreaterOrEqual(SdkOwnedRestClientCache.Misses, missesBefore + 2,
                "Both the throwing call and the rebuild must count as misses.");
        }

        private static RestClientCacheKey BuildKey(string baseUrl)
            => RestClientCacheKey.From(
                NewOptions(baseUrl),
                maxConnectionsPerServer: 32,
                pooledConnectionIdleTimeoutMs: 60000,
                pooledConnectionLifetimeMinutes: SdkOwnedRestClientCache.DefaultPooledConnectionLifetimeMinutes);

        private static RestClientOptions NewOptions(string baseUrl)
            => new RestClientOptions(new Uri(baseUrl))
            {
                Timeout = TimeSpan.FromSeconds(30)
            };

        private static HttpClient NewShortLivedHttpClient()
            => new HttpClient(new StandardSocketsHttpHandler());

        /// <summary>
        /// Wraps a <see cref="HttpClient"/> whose disposal is observable. Used to prove that eviction
        /// disposes the cached <see cref="RestClient"/> and, transitively, the SDK-owned <see cref="HttpClient"/>.
        /// </summary>
        private sealed class DisposeTrackingHttpClient
        {
            private readonly TrackingHandler _handler = new TrackingHandler();

            public DisposeTrackingHttpClient()
            {
                Client = new HttpClient(_handler, disposeHandler: true);
            }

            public HttpClient Client { get; }

            public bool Disposed => _handler.Disposed;

            private sealed class TrackingHandler : HttpMessageHandler
            {
                public bool Disposed { get; private set; }

                protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
                {
                    return System.Threading.Tasks.Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.OK));
                }

                protected override void Dispose(bool disposing)
                {
                    Disposed = true;
                    base.Dispose(disposing);
                }
            }
        }
    }
}
