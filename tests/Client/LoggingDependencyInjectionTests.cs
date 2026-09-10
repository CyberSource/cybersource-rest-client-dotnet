using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Utilities.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using NUnit.Framework;

namespace cybersource_rest_client_netstandard.Test.Client
{
    /// <summary>
    /// Verifies the dependency-injection path that allows callers to supply a custom
    /// <see cref="ILoggerFactory"/> through <see cref="Configuration"/> and have it flow into
    /// <see cref="MerchantLegacySettings"/>, <see cref="MerchantNetworkSettings"/>,
    /// <see cref="ApiClient"/>, and the <see cref="ApiBase"/>-derived API clients.
    /// </summary>
    [TestFixture]
    public class LoggingDependencyInjectionTests
    {
        #region Configuration dictionary constructor (user-facing DI entry point)

        [Test]
        public void Configuration_DictionaryConstructor_StoresInjectedLoggerFactoryOnLegacySettings()
        {
            var loggerFactory = new RecordingLoggerFactory();

            var config = new Configuration(
                merchConfigDictObj: CreateValidMerchantConfig(),
                loggerFactory: loggerFactory);

            Assert.AreSame(loggerFactory, config.MerchantLegacySettings.LoggerFactory);
        }

        [Test]
        public void Configuration_DictionaryConstructor_PropagatesInjectedFactoryToNetworkSettings()
        {
            var loggerFactory = new RecordingLoggerFactory();

            // The MerchantNetworkSettings constructor creates its logger from the injected factory,
            // so a recorded category for that type proves the factory was propagated and used.
            var config = new Configuration(
                merchConfigDictObj: CreateValidMerchantConfig(),
                loggerFactory: loggerFactory);

            Assert.IsNotNull(config.MerchantNetworkSettings);
            Assert.IsTrue(
                loggerFactory.CreatedCategories.Any(c => c.Contains(nameof(MerchantNetworkSettings))),
                "Injected ILoggerFactory was not used to create the MerchantNetworkSettings logger.");
        }

        [Test]
        public void Configuration_DictionaryConstructor_DefaultsToNullLoggerFactory_WhenNoneInjected()
        {
            var config = new Configuration(merchConfigDictObj: CreateValidMerchantConfig());

            Assert.AreSame(NullLoggerFactory.Instance, config.MerchantLegacySettings.LoggerFactory);
        }

        #endregion Configuration dictionary constructor (user-facing DI entry point)

        #region MerchantLegacySettings

        [Test]
        public void MerchantLegacySettings_UsesInjectedFactory_ForLazyLogger()
        {
            var loggerFactory = new RecordingLoggerFactory();
            var settings = new MerchantLegacySettings { LoggerFactory = loggerFactory };

            // Logger is created lazily on first access from the injected factory.
            var logger = settings.Logger;

            Assert.IsNotNull(logger);
            Assert.AreSame(loggerFactory, settings.LoggerFactory);
            Assert.IsTrue(
                loggerFactory.CreatedCategories.Any(c => c.Contains(nameof(MerchantLegacySettings))),
                "Injected ILoggerFactory was not used to create the MerchantLegacySettings logger.");
        }

        [Test]
        public void MerchantLegacySettings_DefaultsToNullLoggerFactory_WhenNoneInjected()
        {
            var settings = new MerchantLegacySettings();

            Assert.AreSame(NullLoggerFactory.Instance, settings.LoggerFactory);
        }

        #endregion MerchantLegacySettings

        #region MerchantNetworkSettings

        [Test]
        public void MerchantNetworkSettings_UsesInjectedFactory_ForLogger()
        {
            var loggerFactory = new RecordingLoggerFactory();

            var settings = new MerchantNetworkSettings(new Dictionary<string, string>(), loggerFactory);

            Assert.IsNotNull(settings.Logger);
            Assert.IsTrue(
                loggerFactory.CreatedCategories.Any(c => c.Contains(nameof(MerchantNetworkSettings))),
                "Injected ILoggerFactory was not used to create the MerchantNetworkSettings logger.");
        }

        [Test]
        public void MerchantNetworkSettings_DefaultsToNullLogger_WhenNoFactoryInjected()
        {
            var settings = new MerchantNetworkSettings(new Dictionary<string, string>());

            Assert.AreSame(NullLogger<MerchantNetworkSettings>.Instance, settings.Logger);
        }

        #endregion MerchantNetworkSettings

        #region ApiClient

        [Test]
        public void ApiClient_UsesInjectedLoggerFactory_FromConfiguration()
        {
            var loggerFactory = new RecordingLoggerFactory();
            var config = CreateConfiguration(loggerFactory);

            var apiClient = new ApiClient(config);

            Assert.AreSame(loggerFactory, GetPrivateField(apiClient, "loggerFactory"));
            Assert.IsTrue(
                loggerFactory.CreatedCategories.Any(c => c.Contains(nameof(ApiClient))),
                "Injected ILoggerFactory was not used to create the ApiClient logger.");
        }

        [Test]
        public void ApiClient_FallsBackToNullLoggerFactory_WhenNoneInjected()
        {
            var config = new Configuration(
                merchantCredentialSettings: null,
                merchantMLESettings: null,
                merchantNetworkSettings: null,
                merchantLegacySettings: null);

            var apiClient = new ApiClient(config);

            Assert.AreSame(NullLoggerFactory.Instance, GetPrivateField(apiClient, "loggerFactory"));
        }

        #endregion ApiClient

        #region ApiBase (derived API clients)

        [Test]
        public void ApiBase_UsesInjectedLoggerFactory_FromConfiguration()
        {
            var loggerFactory = new RecordingLoggerFactory();
            var config = CreateConfiguration(loggerFactory);

            var api = new TestableApi(config);

            Assert.AreSame(loggerFactory, api.CapturedLoggerFactory);
            Assert.IsTrue(
                loggerFactory.CreatedCategories.Any(c => c.Contains(nameof(ApiBase))),
                "Injected ILoggerFactory was not used to create the ApiBase logger.");
        }

        [Test]
        public void ApiBase_FallsBackToNullLoggerFactory_WhenNoneInjected()
        {
            // A default MerchantLegacySettings exposes NullLoggerFactory.Instance as its factory.
            var config = new Configuration(
                merchantCredentialSettings: null,
                merchantMLESettings: null,
                merchantNetworkSettings: null,
                merchantLegacySettings: new MerchantLegacySettings());

            var api = new TestableApi(config);

            Assert.AreSame(NullLoggerFactory.Instance, api.CapturedLoggerFactory);
        }

        #endregion ApiBase (derived API clients)

        #region Container-based constructor injection (EnsureLoggerFactory + pure-DI ctor)

        [Test]
        public void EnsureLoggerFactory_RegistersLoggerFactoryFallback_WhenNonePreviouslyRegistered()
        {
            var services = new ServiceCollection();
            services.EnsureLoggerFactory();

            using var provider = services.BuildServiceProvider();

            var resolved = provider.GetRequiredService<ILoggerFactory>();
            Assert.AreSame(NullLoggerFactory.Instance, resolved);
        }

        [Test]
        public void EnsureLoggerFactory_PreservesPreviouslyRegisteredLoggerFactory()
        {
            var caller = new RecordingLoggerFactory();

            var services = new ServiceCollection();
            services.AddSingleton<ILoggerFactory>(caller);
            services.EnsureLoggerFactory();

            using var provider = services.BuildServiceProvider();

            Assert.AreSame(caller, provider.GetRequiredService<ILoggerFactory>(),
                "TryAddSingleton must not replace an existing ILoggerFactory registration.");
        }

        [Test]
        public void EnsureLoggerFactory_IsIdempotent()
        {
            var services = new ServiceCollection();
            services.EnsureLoggerFactory();
            services.EnsureLoggerFactory();

            var descriptors = services.Where(d => d.ServiceType == typeof(ILoggerFactory)).ToList();
            Assert.AreEqual(1, descriptors.Count,
                "EnsureLoggerFactory must not stack duplicate ILoggerFactory registrations.");
        }

        [Test]
        public void Configuration_ContainerCtor_AppliesInjectedLoggerFactoryToLegacyAndNetworkSettings()
        {
            var loggerFactory = new RecordingLoggerFactory();
            var legacy = new MerchantLegacySettings();
            var network = new MerchantNetworkSettings(new Dictionary<string, string>());

            var config = new Configuration(
                merchantCredentialSettings: null,
                merchantMLESettings: null,
                merchantNetworkSettings: network,
                merchantLegacySettings: legacy,
                serializerOptionsMonitor: null,
                deserializerOptionsMonitor: null,
                loggerFactory: loggerFactory,
                httpClientFactory: null);

            Assert.AreSame(loggerFactory, config.MerchantLegacySettings.LoggerFactory,
                "Container-injected ILoggerFactory must flow into MerchantLegacySettings.");
            Assert.IsTrue(
                loggerFactory.CreatedCategories.Any(c => c.Contains(nameof(MerchantNetworkSettings))),
                "Container-injected ILoggerFactory must be used to create the MerchantNetworkSettings logger.");
        }

        [Test]
        public void Configuration_ContainerCtor_FallsBackToNullLoggerFactory_WhenNullInjected()
        {
            var legacy = new MerchantLegacySettings { LoggerFactory = new RecordingLoggerFactory() };
            var network = new MerchantNetworkSettings(new Dictionary<string, string>());

            var config = new Configuration(
                merchantCredentialSettings: null,
                merchantMLESettings: null,
                merchantNetworkSettings: network,
                merchantLegacySettings: legacy,
                serializerOptionsMonitor: null,
                deserializerOptionsMonitor: null,
                loggerFactory: null,
                httpClientFactory: null);

            Assert.AreSame(NullLoggerFactory.Instance, config.MerchantLegacySettings.LoggerFactory,
                "A null ILoggerFactory must fall back to NullLoggerFactory.Instance.");
        }

        [Test]
        public void Configuration_ContainerCtor_ResolvesLoggerFactoryFromContainer()
        {
            var services = new ServiceCollection();
            services.AddSerialization();
            services.EnsureLoggerFactory();

            using var provider = services.BuildServiceProvider();

            var legacy = new MerchantLegacySettings();
            var network = new MerchantNetworkSettings(new Dictionary<string, string>());

            var config = new Configuration(
                merchantCredentialSettings: null,
                merchantMLESettings: null,
                merchantNetworkSettings: network,
                merchantLegacySettings: legacy,
                serializerOptionsMonitor: provider.GetRequiredService<IOptionsMonitor<SdkSerializerOptions>>(),
                deserializerOptionsMonitor: provider.GetRequiredService<IOptionsMonitor<SdkDeserializerOptions>>(),
                loggerFactory: provider.GetRequiredService<ILoggerFactory>(),
                httpClientFactory: null);

            Assert.AreSame(NullLoggerFactory.Instance, config.MerchantLegacySettings.LoggerFactory);
        }

        #endregion Container-based constructor injection (EnsureLoggerFactory + pure-DI ctor)

        #region Helpers

        private static Configuration CreateConfiguration(ILoggerFactory loggerFactory)
        {
            var legacy = new MerchantLegacySettings { LoggerFactory = loggerFactory };

            return new Configuration(
                merchantCredentialSettings: null,
                merchantMLESettings: null,
                merchantNetworkSettings: null,
                merchantLegacySettings: legacy);
        }

        /// <summary>
        /// Builds a minimal, filesystem-free merchant configuration dictionary that satisfies the
        /// mandatory credential validation performed by the dictionary-based <see cref="Configuration"/>
        /// constructor. JWT with a shared secret (HS256) is used because it requires no key files.
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

        private static object GetPrivateField(object instance, string fieldName)
        {
            var field = instance.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
            Assert.IsNotNull(field, $"Instance field '{fieldName}' was not found on {instance.GetType().Name}.");
            return field.GetValue(instance);
        }

        /// <summary>
        /// Minimal concrete <see cref="ApiBase"/> used to observe the protected logging fields that
        /// derived API clients inherit. Protected members are accessible from a derived type.
        /// </summary>
        private sealed class TestableApi : ApiBase
        {
            public TestableApi(IConfiguration configuration) : base(configuration)
            {
            }

            public ILoggerFactory CapturedLoggerFactory => loggerFactory;
        }

        /// <summary>
        /// An <see cref="ILoggerFactory"/> test double that records the category names it is asked to
        /// create loggers for, proving that an injected factory is actually consumed.
        /// </summary>
        private sealed class RecordingLoggerFactory : ILoggerFactory
        {
            public List<string> CreatedCategories { get; } = new List<string>();

            public ILogger CreateLogger(string categoryName)
            {
                CreatedCategories.Add(categoryName);
                return NullLogger.Instance;
            }

            public void AddProvider(ILoggerProvider provider)
            {
            }

            public void Dispose()
            {
            }
        }

        #endregion Helpers
    }
}
