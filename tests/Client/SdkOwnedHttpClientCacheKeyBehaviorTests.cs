using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using CyberSource.Client;
using NUnit.Framework;

namespace cybersource_rest_client_netstandard.Test.Client
{
    /// <summary>
    /// Feature-level coverage for the four collaborators that drive SDK-owned HttpClient reuse:
    /// <see cref="HttpTransportOptions"/>, <see cref="SdkOwnedHttpClientCacheKey"/>,
    /// <see cref="SdkOwnedHttpClientCache"/> and <see cref="SdkOwnedHttpClientFactory"/>.
    /// The end-to-end assertion is: two calls into <see cref="SdkOwnedHttpClientFactory.GetHttpClient"/>
    /// return the same <see cref="HttpClient"/> instance iff the derived
    /// <see cref="SdkOwnedHttpClientCacheKey"/>s are equal. Every field that participates in the key
    /// is varied here to attest that behavior.
    /// </summary>
    [TestFixture]
    public class SdkOwnedHttpClientCacheKeyBehaviorTests
    {
        [SetUp]
        public void ResetCache()
        {
            SdkOwnedHttpClientFactory.ClearForTests();
        }

        #region HttpTransportOptions

        [Test]
        public void HttpTransportOptions_StoresAllTransportFields()
        {
            var proxy = new WebProxy("http://proxy.invalid:8080");
            var certs = new X509CertificateCollection();

            var options = new HttpTransportOptions
            {
                BaseUrl = new Uri("https://opts.invalid/"),
                Timeout = TimeSpan.FromSeconds(42),
                UserAgent = "ua-test",
                Proxy = proxy,
                ClientCertificates = certs
            };

            Assert.AreEqual(new Uri("https://opts.invalid/"), options.BaseUrl);
            Assert.AreEqual(TimeSpan.FromSeconds(42), options.Timeout);
            Assert.AreEqual("ua-test", options.UserAgent);
            Assert.AreSame(proxy, options.Proxy);
            Assert.AreSame(certs, options.ClientCertificates);
        }

        #endregion HttpTransportOptions

        #region SdkOwnedHttpClientCacheKey � equality across every keyed field

        [Test]
        public void CacheKey_EqualOptions_ProduceEqualKeys()
        {
            SdkOwnedHttpClientCacheKey a = KeyFor(NewOptions("https://key-eq.invalid/"));
            SdkOwnedHttpClientCacheKey b = KeyFor(NewOptions("https://key-eq.invalid/"));

            Assert.AreEqual(a, b);
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode(),
                "Equal keys must produce equal hash codes � otherwise MemoryCache lookups miss.");
        }

        [Test]
        public void CacheKey_DifferentBaseUrl_ProducesDifferentKey()
        {
            SdkOwnedHttpClientCacheKey a = KeyFor(NewOptions("https://a.invalid/"));
            SdkOwnedHttpClientCacheKey b = KeyFor(NewOptions("https://b.invalid/"));

            Assert.That(b, Is.Not.EqualTo(a));
        }

        [Test]
        public void CacheKey_DifferentTimeout_ProducesDifferentKey()
        {
            HttpTransportOptions o1 = NewOptions("https://timeout.invalid/");
            o1.Timeout = TimeSpan.FromSeconds(10);
            HttpTransportOptions o2 = NewOptions("https://timeout.invalid/");
            o2.Timeout = TimeSpan.FromSeconds(30);

            Assert.That(KeyFor(o2), Is.Not.EqualTo(KeyFor(o1)));
        }

        [Test]
        public void CacheKey_DifferentUserAgent_ProducesDifferentKey()
        {
            HttpTransportOptions o1 = NewOptions("https://ua.invalid/"); o1.UserAgent = "ua-1";
            HttpTransportOptions o2 = NewOptions("https://ua.invalid/"); o2.UserAgent = "ua-2";

            Assert.That(KeyFor(o2), Is.Not.EqualTo(KeyFor(o1)));
        }

        [Test]
        public void CacheKey_SameProxyInstance_ProducesEqualKey_DifferentProxyInstance_ProducesDifferentKey()
        {
            var sharedProxy = new WebProxy("http://shared-proxy.invalid:8080");

            HttpTransportOptions o1 = NewOptions("https://proxy.invalid/"); o1.Proxy = sharedProxy;
            HttpTransportOptions o2 = NewOptions("https://proxy.invalid/"); o2.Proxy = sharedProxy;
            HttpTransportOptions o3 = NewOptions("https://proxy.invalid/"); o3.Proxy = new WebProxy("http://shared-proxy.invalid:8080");

            Assert.AreEqual(KeyFor(o1), KeyFor(o2), "Same IWebProxy instance must key-equal.");
            Assert.That(KeyFor(o3), Is.Not.EqualTo(KeyFor(o1)), "Distinct IWebProxy instances must key-differ, even with identical URIs.");
        }

        [Test]
        public void CacheKey_DifferentPoolingParameters_ProduceDifferentKeys()
        {
            HttpTransportOptions o = NewOptions("https://pool.invalid/");

            SdkOwnedHttpClientCacheKey baseline = SdkOwnedHttpClientCacheKey.From(o, 32, 60000, 10);
            SdkOwnedHttpClientCacheKey diffMax = SdkOwnedHttpClientCacheKey.From(o, 64, 60000, 10);
            SdkOwnedHttpClientCacheKey diffIdle = SdkOwnedHttpClientCacheKey.From(o, 32, 30000, 10);
            SdkOwnedHttpClientCacheKey diffLife = SdkOwnedHttpClientCacheKey.From(o, 32, 60000, 20);

            Assert.That(diffMax, Is.Not.EqualTo(baseline));
            Assert.That(diffIdle, Is.Not.EqualTo(baseline));
            Assert.That(diffLife, Is.Not.EqualTo(baseline));
        }

        [Test]
        public void CacheKey_NullOptions_YieldsStableEqualKeys()
        {
            SdkOwnedHttpClientCacheKey a = SdkOwnedHttpClientCacheKey.From(null, 32, 60000, 10);
            SdkOwnedHttpClientCacheKey b = SdkOwnedHttpClientCacheKey.From(null, 32, 60000, 10);

            Assert.AreEqual(a, b);
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }

        #endregion SdkOwnedHttpClientCacheKey � equality across every keyed field

        #region SdkOwnedHttpClientFactory � end-to-end pooling driven by the cache key

        [Test]
        public void Factory_SameTransportOptions_ReturnSameCachedHttpClient()
        {
            HttpTransportOptions options = NewOptions("https://factory-same.invalid/");
            IMerchantNetworkSettings settings = NewSettings();

            HttpClient first = SdkOwnedHttpClientFactory.GetHttpClient(settings, options);
            HttpClient second = SdkOwnedHttpClientFactory.GetHttpClient(settings, options);

            Assert.AreSame(first, second, "Identical transport + pooling parameters must reuse the pooled HttpClient.");
        }

        [Test]
        public void Factory_DifferentBaseUrl_ReturnsDifferentHttpClient()
        {
            IMerchantNetworkSettings settings = NewSettings();

            HttpClient a = SdkOwnedHttpClientFactory.GetHttpClient(settings, NewOptions("https://factory-a.invalid/"));
            HttpClient b = SdkOwnedHttpClientFactory.GetHttpClient(settings, NewOptions("https://factory-b.invalid/"));

            Assert.AreNotSame(a, b);
        }

        [Test]
        public void Factory_DifferentTimeoutOrUserAgent_ReturnDifferentHttpClient()
        {
            IMerchantNetworkSettings settings = NewSettings();

            HttpTransportOptions oT1 = NewOptions("https://factory-vary.invalid/"); oT1.Timeout = TimeSpan.FromSeconds(10);
            HttpTransportOptions oT2 = NewOptions("https://factory-vary.invalid/"); oT2.Timeout = TimeSpan.FromSeconds(20);
            Assert.AreNotSame(
                SdkOwnedHttpClientFactory.GetHttpClient(settings, oT1),
                SdkOwnedHttpClientFactory.GetHttpClient(settings, oT2),
                "Varying Timeout must produce a distinct pooled HttpClient.");

            HttpTransportOptions oU1 = NewOptions("https://factory-vary-ua.invalid/"); oU1.UserAgent = "sdk-A";
            HttpTransportOptions oU2 = NewOptions("https://factory-vary-ua.invalid/"); oU2.UserAgent = "sdk-B";
            Assert.AreNotSame(
                SdkOwnedHttpClientFactory.GetHttpClient(settings, oU1),
                SdkOwnedHttpClientFactory.GetHttpClient(settings, oU2),
                "Varying UserAgent must produce a distinct pooled HttpClient.");
        }

        [Test]
        public void Factory_DifferentPoolingSettings_ReturnDifferentHttpClient()
        {
            HttpTransportOptions options = NewOptions("https://factory-pool.invalid/");

            HttpClient defaultPool = SdkOwnedHttpClientFactory.GetHttpClient(NewSettings(), options);

            MerchantNetworkSettings biggerPool = NewSettings();
            biggerPool.MaxConnectionPoolSize = "500";
            HttpClient bigger = SdkOwnedHttpClientFactory.GetHttpClient(biggerPool, options);

            MerchantNetworkSettings shorterKeepAlive = NewSettings();
            shorterKeepAlive.KeepAliveTime = "1000";
            HttpClient shorter = SdkOwnedHttpClientFactory.GetHttpClient(shorterKeepAlive, options);

            Assert.AreNotSame(defaultPool, bigger,
                "MaxConnectionPoolSize is part of the cache key; a distinct value must yield a distinct pooled HttpClient.");
            Assert.AreNotSame(defaultPool, shorter,
                "KeepAliveTime is part of the cache key; a distinct value must yield a distinct pooled HttpClient.");
        }

        [Test]
        public void Factory_SameProxyInstance_SharesHttpClient_DifferentProxyInstance_DoesNot()
        {
            var sharedProxy = new WebProxy("http://proxy.invalid:8080");

            HttpTransportOptions o1 = NewOptions("https://factory-proxy.invalid/"); o1.Proxy = sharedProxy;
            HttpTransportOptions o2 = NewOptions("https://factory-proxy.invalid/"); o2.Proxy = sharedProxy;
            HttpTransportOptions o3 = NewOptions("https://factory-proxy.invalid/"); o3.Proxy = new WebProxy("http://proxy.invalid:8080");

            IMerchantNetworkSettings settings = NewSettings();

            HttpClient c1 = SdkOwnedHttpClientFactory.GetHttpClient(settings, o1);
            HttpClient c2 = SdkOwnedHttpClientFactory.GetHttpClient(settings, o2);
            HttpClient c3 = SdkOwnedHttpClientFactory.GetHttpClient(settings, o3);

            Assert.AreSame(c1, c2, "Reusing the same IWebProxy instance must keep the pooled HttpClient shared.");
            Assert.AreNotSame(c1, c3, "A distinct IWebProxy instance must yield a distinct pooled HttpClient, even at the same URI.");
        }

        #endregion SdkOwnedHttpClientFactory � end-to-end pooling driven by the cache key

        #region Helpers

        private static HttpTransportOptions NewOptions(string baseUrl)
            => new HttpTransportOptions
            {
                BaseUrl = new Uri(baseUrl),
                Timeout = TimeSpan.FromSeconds(30),
                UserAgent = "cybs-rest-sdk-dotnet-cache-key-tests"
            };

        private static SdkOwnedHttpClientCacheKey KeyFor(HttpTransportOptions options)
            => SdkOwnedHttpClientCacheKey.From(
                options,
                maxConnectionsPerServer: 32,
                pooledConnectionIdleTimeoutMs: 60000,
                pooledConnectionLifetimeMinutes: SdkOwnedHttpClientCache.DefaultPooledConnectionLifetimeMinutes);

        private static MerchantNetworkSettings NewSettings()
            => new MerchantNetworkSettings(new Dictionary<string, string>());

        #endregion Helpers
    }
}
