using System;
using System.Net.Http;
using System.Threading;
using CyberSource.Client;
using NUnit.Framework;

namespace cybersource_rest_client_netstandard.Test.Client
{
    /// <summary>
    /// Focused coverage for <see cref="SdkOwnedHttpClientCache"/>: cache miss / hit / eviction /
    /// disposal / counter increments. These behaviors underpin the SDK-owned path taken when no
    /// caller-supplied <see cref="HttpClient"/> or <see cref="IHttpClientFactory"/> is injected.
    /// </summary>
    [TestFixture]
    public class SdkOwnedRestClientCacheTests
    {
        [SetUp]
        public void ResetCache()
        {
            SdkOwnedHttpClientCache.ClearForTests();
        }

        [Test]
        public void GetOrCreate_ReturnsSameInstance_ForEqualKeys()
        {
            SdkOwnedHttpClientCacheKey key = BuildKey("https://cache-same-instance.invalid/");

            int factoryInvocations = 0;
            HttpClient first = SdkOwnedHttpClientCache.GetOrCreate(key, () =>
            {
                Interlocked.Increment(ref factoryInvocations);
                return NewShortLivedHttpClient();
            });

            HttpClient second = SdkOwnedHttpClientCache.GetOrCreate(key, () =>
            {
                Interlocked.Increment(ref factoryInvocations);
                return NewShortLivedHttpClient();
            });

            Assert.AreSame(first, second, "Equal keys must resolve to the same cached HttpClient instance.");
            Assert.AreEqual(1, factoryInvocations, "Factory must run exactly once for equal keys.");
        }

        [Test]
        public void ClearForTests_DisposesCachedHttpClient()
        {
            SdkOwnedHttpClientCacheKey key = BuildKey("https://cache-eviction-disposes.invalid/");

            var trackingClient = new DisposeTrackingHttpClient();

            HttpClient cached = SdkOwnedHttpClientCache.GetOrCreate(key, () => trackingClient.Client);

            Assert.IsFalse(trackingClient.Disposed, "Sanity: HttpClient must not be disposed while still cached.");

            SdkOwnedHttpClientCache.ClearForTests();

            Assert.IsTrue(trackingClient.Disposed,
                "Eviction (via ClearForTests) must dispose the cached HttpClient, which disposes its owned handler and pooled TCP connections. " +
                "Without this the SDK leaks a StandardSocketsHttpHandler on every eviction.");
        }

        [Test]
        public void ClearForTests_RemovesLockSentinel_SoSubsequentGetOrCreateRebuilds()
        {
            SdkOwnedHttpClientCacheKey key = BuildKey("https://cache-lock-cleanup.invalid/");

            int factoryInvocations = 0;
            SdkOwnedHttpClientCache.GetOrCreate(key, () =>
            {
                Interlocked.Increment(ref factoryInvocations);
                return NewShortLivedHttpClient();
            });

            SdkOwnedHttpClientCache.ClearForTests();

            SdkOwnedHttpClientCache.GetOrCreate(key, () =>
            {
                Interlocked.Increment(ref factoryInvocations);
                return NewShortLivedHttpClient();
            });

            Assert.AreEqual(2, factoryInvocations, "Factory must run a second time after the cache is cleared.");
        }

        [Test]
        public void Counters_IncrementOnHit_MissAndEviction()
        {
            long hitsBefore = SdkOwnedHttpClientCache.Hits;
            long missesBefore = SdkOwnedHttpClientCache.Misses;
            long evictionsBefore = SdkOwnedHttpClientCache.Evictions;

            SdkOwnedHttpClientCacheKey key = BuildKey("https://cache-counters.invalid/");

            SdkOwnedHttpClientCache.GetOrCreate(key, NewShortLivedHttpClient);
            SdkOwnedHttpClientCache.GetOrCreate(key, NewShortLivedHttpClient);

            SdkOwnedHttpClientCache.ClearForTests();

            Assert.AreEqual(missesBefore + 1, SdkOwnedHttpClientCache.Misses, "Exactly one cache miss expected.");
            Assert.AreEqual(hitsBefore + 1, SdkOwnedHttpClientCache.Hits, "Exactly one cache hit expected on the second call.");
            Assert.AreEqual(evictionsBefore + 1, SdkOwnedHttpClientCache.Evictions, "ClearForTests must fire the eviction callback for the entry.");
        }

        [Test]
        public void GetOrCreate_ThrowsArgumentNullException_WhenKeyIsNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
                SdkOwnedHttpClientCache.GetOrCreate(null, NewShortLivedHttpClient));
        }

        [Test]
        public void GetOrCreate_ThrowsArgumentNullException_WhenFactoryIsNull()
        {
            SdkOwnedHttpClientCacheKey key = BuildKey("https://null-factory.invalid/");
            Assert.Throws<ArgumentNullException>(() => SdkOwnedHttpClientCache.GetOrCreate(key, null));
        }

        [Test]
        public void GetOrCreate_EvictsPoisonedEntry_WhenFactoryThrows()
        {
            SdkOwnedHttpClientCacheKey key = BuildKey("https://cache-poisoned.invalid/");

            long missesBefore = SdkOwnedHttpClientCache.Misses;

            Assert.Throws<InvalidOperationException>(() =>
                SdkOwnedHttpClientCache.GetOrCreate(key, () => throw new InvalidOperationException("boom")));

            HttpClient rebuilt = SdkOwnedHttpClientCache.GetOrCreate(key, NewShortLivedHttpClient);

            Assert.IsNotNull(rebuilt);
            Assert.GreaterOrEqual(SdkOwnedHttpClientCache.Misses, missesBefore + 2,
                "Both the throwing call and the rebuild must count as misses.");
        }

        private static SdkOwnedHttpClientCacheKey BuildKey(string baseUrl)
            => SdkOwnedHttpClientCacheKey.From(
                NewOptions(baseUrl),
                maxConnectionsPerServer: 32,
                pooledConnectionIdleTimeoutMs: 60000,
                pooledConnectionLifetimeMinutes: SdkOwnedHttpClientCache.DefaultPooledConnectionLifetimeMinutes);

        private static HttpTransportOptions NewOptions(string baseUrl)
            => new HttpTransportOptions
            {
                BaseUrl = new Uri(baseUrl),
                Timeout = TimeSpan.FromSeconds(30)
            };

        private static HttpClient NewShortLivedHttpClient()
            => new HttpClient(new StandardSocketsHttpHandler());

        /// <summary>
        /// Wraps an <see cref="HttpClient"/> whose disposal is observable. Used to prove that eviction
        /// disposes the cached SDK-owned <see cref="HttpClient"/>.
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
