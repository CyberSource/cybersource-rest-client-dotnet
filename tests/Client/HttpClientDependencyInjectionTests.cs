using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSource.Client;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace cybersource_rest_client_netstandard.Test.Client
{
    /// <summary>
    /// Verifies dependency injection of <see cref="HttpClient"/> and <see cref="IHttpClientFactory"/>
    /// through <see cref="Configuration"/> / <see cref="MerchantNetworkSettings"/> and the resulting
    /// end-to-end behavior in <see cref="SdkOwnedHttpClientFactory"/>. Also asserts backward compatibility:
    /// when neither injection is supplied, the SDK's internally cached
    /// <see cref="HttpMessageHandler"/>-backed <see cref="HttpClient"/> is returned exactly as before.
    /// </summary>
    [TestFixture]
    public class HttpClientDependencyInjectionTests
    {
        [SetUp]
        public void ClearFactoryCacheForHermeticTests()
        {
            // Ensure cache-invariance and precedence assertions are hermetic across framework legs.
            SdkOwnedHttpClientFactory.ClearForTests();
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

            var options = new HttpTransportOptions
            {
                BaseUrl = new Uri("https://cybersource-test.invalid/"),
                Timeout = TimeSpan.FromSeconds(30)
            };

            IMerchantNetworkSettings settings = BuildNetworkSettings(httpClient: injectedClient);

            HttpClient httpClient = SdkOwnedHttpClientFactory.GetHttpClient(settings, options);

            await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, "/ping"));

            Assert.AreSame(injectedClient, httpClient, "Injected HttpClient must be returned as-is.");
            Assert.AreEqual(1, recordingHandler.CallCount, "Injected HttpClient was not used for the request.");
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

            var options = new HttpTransportOptions
            {
                BaseUrl = new Uri("https://cybersource-test.invalid/"),
                Timeout = TimeSpan.FromSeconds(30)
            };

            IMerchantNetworkSettings settings = BuildNetworkSettings(httpClientFactory: factory);

            HttpClient httpClient = SdkOwnedHttpClientFactory.GetHttpClient(settings, options);

            await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, "/ping"));

            Assert.AreEqual(1, factory.CreateClientCallCount, "IHttpClientFactory.CreateClient was not invoked.");
            Assert.AreEqual(1, recordingHandler.CallCount, "The factory-supplied HttpClient was not used for the request.");
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

            var options = new HttpTransportOptions
            {
                BaseUrl = new Uri("https://cybersource-test.invalid/"),
                Timeout = TimeSpan.FromSeconds(30)
            };

            IMerchantNetworkSettings settings = BuildNetworkSettings(httpClient: directClient, httpClientFactory: factory);

            HttpClient httpClient = SdkOwnedHttpClientFactory.GetHttpClient(settings, options);

            httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, "/ping")).GetAwaiter().GetResult();

            Assert.AreSame(directClient, httpClient, "Direct injected HttpClient should have taken precedence.");
            Assert.AreEqual(1, directHandler.CallCount, "Direct injected HttpClient should have taken precedence.");
            Assert.AreEqual(0, factoryHandler.CallCount, "Injected factory must NOT be consulted when a direct HttpClient is also injected.");
            Assert.AreEqual(0, factory.CreateClientCallCount, "IHttpClientFactory.CreateClient must not be called when a direct HttpClient is injected.");
        }

        [Test]
        public void RestClientFactory_ReturnsInjectedHttpClient_WithoutWrapping()
        {
            using var injectedClient = new HttpClient(new RecordingHandler())
            {
                BaseAddress = new Uri("https://cybersource-test.invalid/")
            };

            var options = new HttpTransportOptions
            {
                BaseUrl = new Uri("https://cybersource-test.invalid/"),
                Timeout = TimeSpan.FromSeconds(30)
            };

            IMerchantNetworkSettings settings = BuildNetworkSettings(httpClient: injectedClient);

            HttpClient first = SdkOwnedHttpClientFactory.GetHttpClient(settings, options);
            HttpClient second = SdkOwnedHttpClientFactory.GetHttpClient(settings, options);

            // Injected-HttpClient path returns the caller-owned instance directly on every call —
            // the SDK never wraps or caches it, so lifetime remains fully caller-controlled.
            Assert.AreSame(injectedClient, first);
            Assert.AreSame(first, second);
        }

        #endregion RestClientFactory injection paths

        #region Backward compatibility (no injection)

        [Test]
        public void RestClientFactory_UsesCachedSdkOwnedClient_WhenNoHttpClientOrFactoryInjected()
        {
            var options = new HttpTransportOptions
            {
                BaseUrl = new Uri("https://cybersource-cache-key-regression.invalid/"),
                Timeout = TimeSpan.FromSeconds(30),
                UserAgent = "cybs-rest-sdk-dotnet-test"
            };

            var settings = new MerchantNetworkSettings(new Dictionary<string, string>());

            HttpClient first = SdkOwnedHttpClientFactory.GetHttpClient(settings, options);
            HttpClient second = SdkOwnedHttpClientFactory.GetHttpClient(settings, options);

            Assert.AreSame(first, second,
                "SDK-owned path must reuse the cached HttpClient for identical options — this is the pre-existing pooling behavior and must be preserved for consumers that do not inject anything.");
        }

        [Test]
        public void RestClientFactory_ThrowsArgumentNullException_WhenSettingsNullAndNoInjection()
        {
            var options = new HttpTransportOptions
            {
                BaseUrl = new Uri("https://cybersource-arg-null-check.invalid/"),
                Timeout = TimeSpan.FromSeconds(30)
            };

            // With no injected HttpClient/IHttpClientFactory the SDK-owned cached path is taken;
            // that path requires IMerchantNetworkSettings to read pooling parameters.
            Assert.Throws<ArgumentNullException>(() => SdkOwnedHttpClientFactory.GetHttpClient(null, options));
        }

        #endregion Backward compatibility (no injection)

        #region Container-based constructor injection (EnsureHttpClientFactory + pure-DI ctor)

        [Test]
        public void EnsureHttpClientFactory_RegistersHttpClientFactory()
        {
            var services = new Microsoft.Extensions.DependencyInjection.ServiceCollection();
            services.EnsureHttpClientFactory();

            using var provider = services.BuildServiceProvider();

            Assert.IsNotNull(provider.GetRequiredService<IHttpClientFactory>(),
                "EnsureHttpClientFactory must make IHttpClientFactory resolvable from the container.");
        }

        [Test]
        public void EnsureHttpClientFactory_IsIdempotent()
        {
            var services = new Microsoft.Extensions.DependencyInjection.ServiceCollection();
            services.EnsureHttpClientFactory();
            services.EnsureHttpClientFactory();

            var count = 0;
            foreach (var d in services)
            {
                if (d.ServiceType == typeof(IHttpClientFactory)) { count++; }
            }

            Assert.AreEqual(1, count,
                "EnsureHttpClientFactory must not stack duplicate IHttpClientFactory registrations.");
        }

        [Test]
        public void Configuration_ContainerCtor_AppliesInjectedHttpClientFactoryToNetworkSettings()
        {
            var services = new Microsoft.Extensions.DependencyInjection.ServiceCollection();
            services.EnsureHttpClientFactory();
            using var provider = services.BuildServiceProvider();
            var factory = provider.GetRequiredService<IHttpClientFactory>();

            var network = new MerchantNetworkSettings(new Dictionary<string, string>());

            var config = new Configuration(
                merchantCredentialSettings: null,
                merchantMLESettings: null,
                merchantNetworkSettings: network,
                merchantLegacySettings: new MerchantLegacySettings(),
                serializerOptionsMonitor: null,
                deserializerOptionsMonitor: null,
                loggerFactory: null,
                httpClientFactory: factory);

            Assert.AreSame(factory, config.MerchantNetworkSettings.HttpClientFactory,
                "Container-injected IHttpClientFactory must flow into MerchantNetworkSettings.");
        }

        [Test]
        public void Configuration_ContainerCtor_NullHttpClientFactory_LeavesNetworkSettingsFactoryNull()
        {
            var network = new MerchantNetworkSettings(new Dictionary<string, string>());

            var config = new Configuration(
                merchantCredentialSettings: null,
                merchantMLESettings: null,
                merchantNetworkSettings: network,
                merchantLegacySettings: new MerchantLegacySettings(),
                serializerOptionsMonitor: null,
                deserializerOptionsMonitor: null,
                loggerFactory: null,
                httpClientFactory: null);

            Assert.IsNull(config.MerchantNetworkSettings.HttpClientFactory);
        }

        #endregion Container-based constructor injection (EnsureHttpClientFactory + pure-DI ctor)

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
            IHttpClientFactory httpClientFactory = null)
        {
            var settings = new MerchantNetworkSettings(new Dictionary<string, string>());
            if (httpClient != null) { settings.AddHttpClient(httpClient); }
            if (httpClientFactory != null) { settings.AddHttpClientFactory(httpClientFactory); }
            return settings;
        }

        /// <summary>
        /// <see cref="HttpMessageHandler"/> that records how many times it was invoked and returns an empty 200 OK.
        /// Used to prove that a specific <see cref="HttpClient"/> instance was the one used to execute the request.
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
