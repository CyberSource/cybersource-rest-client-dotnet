using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSource.Client;
using NUnit.Framework;
using RestSharp;

namespace cybersource_rest_client_netstandard.Test.Client
{
    /// <summary>
    /// Verifies dependency injection of <see cref="HttpClient"/> and <see cref="IHttpClientFactory"/>
    /// through <see cref="Configuration"/> / <see cref="MerchantNetworkSettings"/> and the resulting
    /// end-to-end behavior in <see cref="RestClientFactory"/>. Also asserts backward compatibility:
    /// when neither injection is supplied, the SDK's internally cached
    /// <see cref="System.Net.Http.HttpMessageHandler"/>-backed <see cref="RestClient"/> is returned
    /// exactly as before.
    /// </summary>
    [TestFixture]
    public class HttpClientDependencyInjectionTests
    {
        [SetUp]
        public void ClearFactoryCacheForHermeticTests()
        {
            // Ensure cache-invariance and precedence assertions are hermetic across framework legs.
            RestClientFactory.ClearForTests();
        }

        #region Fluent extension methods

        [Test]
        public void AddHttpClient_AppliesHttpClientToNetworkSettings()
        {
            var settings = new MerchantNetworkSettings(new Dictionary<string, string>());
            using var httpClient = new HttpClient();

            IMerchantNetworkSettings result = settings.AddHttpClient(httpClient);

            Assert.AreSame(httpClient, settings.HttpClient);
            Assert.AreSame(settings, result);
        }

        [Test]
        public void AddHttpClientFactory_AppliesFactoryAndNameToNetworkSettings()
        {
            var settings = new MerchantNetworkSettings(new Dictionary<string, string>());
            var factory = new StubHttpClientFactory();

            IMerchantNetworkSettings result = settings.AddHttpClientFactory(factory);

            Assert.AreSame(factory, settings.HttpClientFactory);
            Assert.AreSame(settings, result);
        }

        [Test]
        public void AddHttpClientFactory_LeavesNameNull_WhenNotSpecified()
        {
            var settings = new MerchantNetworkSettings(new Dictionary<string, string>());
            var factory = new StubHttpClientFactory();

            settings.AddHttpClientFactory(factory);

            Assert.AreSame(factory, settings.HttpClientFactory);
        }

        #endregion Fluent extension methods

        #region Configuration dictionary constructor (user-facing DI entry point)

        [Test]
        public void Configuration_DictionaryConstructor_StoresInjectedHttpClientOnNetworkSettings()
        {
            using var httpClient = new HttpClient();

            var config = new Configuration(
                merchConfigDictObj: CreateValidMerchantConfig(),
                httpClient: httpClient);

            Assert.AreSame(httpClient, config.MerchantNetworkSettings.HttpClient);
            Assert.IsNull(config.MerchantNetworkSettings.HttpClientFactory);
        }

        [Test]
        public void Configuration_DictionaryConstructor_StoresInjectedFactoryAndNameOnNetworkSettings()
        {
            var factory = new StubHttpClientFactory();

            var config = new Configuration(
                merchConfigDictObj: CreateValidMerchantConfig(),
                httpClientFactory: factory);

            Assert.IsNull(config.MerchantNetworkSettings.HttpClient);
            Assert.AreSame(factory, config.MerchantNetworkSettings.HttpClientFactory);
        }

        [Test]
        public void Configuration_DictionaryConstructor_LeavesHttpClientAndFactoryNull_WhenNoneInjected()
        {
            var config = new Configuration(merchConfigDictObj: CreateValidMerchantConfig());

            Assert.IsNull(config.MerchantNetworkSettings.HttpClient);
            Assert.IsNull(config.MerchantNetworkSettings.HttpClientFactory);
        }

        #endregion Configuration dictionary constructor (user-facing DI entry point)

        #region RestClientFactory injection paths

        [Test]
        public async Task RestClientFactory_UsesInjectedHttpClient_WhenProvided()
        {
            var recordingHandler = new RecordingHandler();
            using var injectedClient = new HttpClient(recordingHandler)
            {
                BaseAddress = new Uri("https://cybersource-test.invalid/")
            };

            var options = new RestClientOptions(new Uri("https://cybersource-test.invalid/"))
            {
                Timeout = TimeSpan.FromSeconds(30)
            };

            IMerchantNetworkSettings settings = BuildNetworkSettings(httpClient: injectedClient);

            RestClient restClient = RestClientFactory.GetRestClient(settings, options);

            await restClient.ExecuteAsync(new RestRequest("/ping"));

            Assert.AreEqual(1, recordingHandler.CallCount, "Injected HttpClient was not used by RestSharp for the request.");
        }

        [Test]
        public async Task RestClientFactory_UsesInjectedFactory_WhenFactoryProvided()
        {
            var recordingHandler = new RecordingHandler();
            using var factoryOwnedClient = new HttpClient(recordingHandler)
            {
                BaseAddress = new Uri("https://cybersource-test.invalid/")
            };
            var factory = new StubHttpClientFactory
            {
                ClientToReturn = factoryOwnedClient
            };

            var options = new RestClientOptions(new Uri("https://cybersource-test.invalid/"))
            {
                Timeout = TimeSpan.FromSeconds(30)
            };

            IMerchantNetworkSettings settings = BuildNetworkSettings(httpClientFactory: factory, httpClientName: "cybersource");

            RestClient restClient = RestClientFactory.GetRestClient(settings, options);

            await restClient.ExecuteAsync(new RestRequest("/ping"));

            Assert.AreEqual(1, factory.CreateClientCallCount, "IHttpClientFactory.CreateClient was not invoked.");
            Assert.AreEqual("cybersource", factory.LastRequestedName, "IHttpClientFactory.CreateClient received the wrong logical name.");
            Assert.AreEqual(1, recordingHandler.CallCount, "The factory-supplied HttpClient was not used by RestSharp for the request.");
        }

        [Test]
        public void RestClientFactory_HttpClientTakesPrecedenceOverFactory_WhenBothProvided()
        {
            var directHandler = new RecordingHandler();
            using var directClient = new HttpClient(directHandler)
            {
                BaseAddress = new Uri("https://cybersource-test.invalid/")
            };

            var factoryHandler = new RecordingHandler();
            using var factoryClient = new HttpClient(factoryHandler)
            {
                BaseAddress = new Uri("https://cybersource-test.invalid/")
            };
            var factory = new StubHttpClientFactory { ClientToReturn = factoryClient };

            var options = new RestClientOptions(new Uri("https://cybersource-test.invalid/"))
            {
                Timeout = TimeSpan.FromSeconds(30)
            };

            IMerchantNetworkSettings settings = BuildNetworkSettings(httpClient: directClient, httpClientFactory: factory);

            RestClient restClient = RestClientFactory.GetRestClient(settings, options);

            restClient.ExecuteAsync(new RestRequest("/ping")).GetAwaiter().GetResult();

            Assert.AreEqual(1, directHandler.CallCount, "Direct injected HttpClient should have taken precedence.");
            Assert.AreEqual(0, factoryHandler.CallCount, "Injected factory must NOT be consulted when a direct HttpClient is also injected.");
            Assert.AreEqual(0, factory.CreateClientCallCount, "IHttpClientFactory.CreateClient must not be called when a direct HttpClient is injected.");
        }

        [Test]
        public async Task RestClientFactory_DoesNotDisposeInjectedHttpClient_WhenRestClientDisposed()
        {
            var recordingHandler = new RecordingHandler();
            using var injectedClient = new HttpClient(recordingHandler)
            {
                BaseAddress = new Uri("https://cybersource-test.invalid/")
            };

            var options = new RestClientOptions(new Uri("https://cybersource-test.invalid/"))
            {
                Timeout = TimeSpan.FromSeconds(30)
            };

            IMerchantNetworkSettings settings = BuildNetworkSettings(httpClient: injectedClient);

            RestClient restClient = RestClientFactory.GetRestClient(settings, options);

            restClient.Dispose();

            // If the SDK had disposed the injected HttpClient, subsequent use would throw
            // ObjectDisposedException. This second request through a new RestClient wrapper
            // proves the injected client remains fully usable after the previous RestClient
            // wrapper was disposed.
            RestClient secondWrapper = RestClientFactory.GetRestClient(settings, options);

            await secondWrapper.ExecuteAsync(new RestRequest("/ping"));

            Assert.AreEqual(1, recordingHandler.CallCount);
        }

        [Test]
        public void RestClientFactory_DoesNotCacheAcrossCalls_WhenHttpClientInjected()
        {
            using var injectedClient = new HttpClient(new RecordingHandler())
            {
                BaseAddress = new Uri("https://cybersource-test.invalid/")
            };

            var options = new RestClientOptions(new Uri("https://cybersource-test.invalid/"))
            {
                Timeout = TimeSpan.FromSeconds(30)
            };

            IMerchantNetworkSettings settings = BuildNetworkSettings(httpClient: injectedClient);

            RestClient first = RestClientFactory.GetRestClient(settings, options);
            RestClient second = RestClientFactory.GetRestClient(settings, options);

            Assert.AreNotSame(first, second,
                "Injected-HttpClient path must not cache RestClient wrappers; caching them would tie their lifetime to the caller-owned HttpClient in a way the SDK cannot manage.");
        }

        #endregion RestClientFactory injection paths

        #region Backward compatibility (no injection)

        [Test]
        public void RestClientFactory_UsesCachedSdkOwnedClient_WhenNoHttpClientOrFactoryInjected()
        {
            var options = new RestClientOptions(new Uri("https://cybersource-cache-key-regression.invalid/"))
            {
                Timeout = TimeSpan.FromSeconds(30),
                UserAgent = "cybs-rest-sdk-dotnet-test"
            };

            var settings = new MerchantNetworkSettings(new Dictionary<string, string>());

            RestClient first = RestClientFactory.GetRestClient(settings, options);
            RestClient second = RestClientFactory.GetRestClient(settings, options);

            Assert.AreSame(first, second,
                "SDK-owned path must reuse the cached RestClient for identical options — this is the pre-existing pooling behavior and must be preserved for consumers that do not inject anything.");
        }

        [Test]
        public void RestClientFactory_ThrowsArgumentNullException_WhenSettingsNullAndNoInjection()
        {
            var options = new RestClientOptions(new Uri("https://cybersource-arg-null-check.invalid/"))
            {
                Timeout = TimeSpan.FromSeconds(30)
            };

            // With no injected HttpClient/IHttpClientFactory the SDK-owned cached path is taken;
            // that path requires IMerchantNetworkSettings to read pooling parameters.
            Assert.Throws<ArgumentNullException>(() => RestClientFactory.GetRestClient(null, options));
        }

        #endregion Backward compatibility (no injection)

        #region Helpers

        /// <summary>
        /// Builds a minimal, filesystem-free merchant configuration dictionary that satisfies the mandatory
        /// credential validation performed by the dictionary-based <see cref="Configuration"/> constructor.
        /// JWT with a shared secret (HS256) is used because it requires no key files.
        /// </summary>
        private static Dictionary<string, string> CreateValidMerchantConfig()
        {
            return new Dictionary<string, string>
            {
                { "authenticationType", "JWT" },
                { "merchantID", "test_merchant" },
                { "runEnvironment", "apitest.cybersource.com" },
                { "jwtKeyType", "SHARED_SECRET" },
                { "merchantKeyId", "test_key_id" },
                { "merchantsecretKey", "cnVuX2Vudmlyb25tZW50X3NoYXJlZF9zZWNyZXQ=" }
            };
        }

        private static IMerchantNetworkSettings BuildNetworkSettings(
            HttpClient httpClient = null,
            IHttpClientFactory httpClientFactory = null,
            string httpClientName = null)
        {
            var settings = new MerchantNetworkSettings(new Dictionary<string, string>());
            if (httpClient != null) { settings.AddHttpClient(httpClient); }
            if (httpClientFactory != null) { settings.AddHttpClientFactory(httpClientFactory); }
            return settings;
        }

        /// <summary>
        /// <see cref="HttpMessageHandler"/> that records how many times it was invoked and returns an empty 200 OK.
        /// Used to prove that a specific <see cref="HttpClient"/> instance was the one used to execute a RestSharp request.
        /// </summary>
        private sealed class RecordingHandler : HttpMessageHandler
        {
            private int _callCount;

            public int CallCount => _callCount;

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                Interlocked.Increment(ref _callCount);
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(string.Empty)
                });
            }
        }

        /// <summary>
        /// Minimal <see cref="IHttpClientFactory"/> test double that records how many times <see cref="CreateClient(string)"/>
        /// was invoked and with which logical name, and returns a caller-supplied <see cref="HttpClient"/>.
        /// </summary>
        private sealed class StubHttpClientFactory : IHttpClientFactory
        {
            public HttpClient ClientToReturn { get; set; }

            public int CreateClientCallCount { get; private set; }

            public string LastRequestedName { get; private set; }

            public HttpClient CreateClient(string name)
            {
                CreateClientCallCount++;
                LastRequestedName = name;
                return ClientToReturn ?? new HttpClient();
            }
        }

        #endregion Helpers
    }
}
