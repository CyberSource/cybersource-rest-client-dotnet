using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using CyberSource.Client;
using CyberSource.Utilities.Extensibility;
using CyberSource.Utilities.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NUnit.Framework;

namespace cybersource_rest_client_netstandard.Test.Client
{
    /// <summary>
    /// Verifies JSON serialization behavior and the dependency-injection path that allows callers to
    /// supply custom <see cref="JsonSerializerOptions"/> through
    /// <see cref="MerchantNetworkSettings"/> / <see cref="Configuration"/> into the <see cref="ApiClient"/>.
    /// </summary>
    [TestFixture]
    public class SerializationDependencyInjectionTests
    {
        #region Dependency Injection wiring

        [Test]
        public void AddSerializationOptions_AppliesOptionsToNetworkSettings()
        {
            var settings = new MerchantNetworkSettings(new Dictionary<string, string>());
            var options = new JsonSerializerOptions();

            IMerchantNetworkSettings result = settings.AddSerializationOptions(options);

            Assert.AreSame(options, settings.SerializationOptions);
            Assert.AreSame(settings, result);
        }

        [Test]
        public void AddDeserializationOptions_AppliesOptionsToNetworkSettings()
        {
            var settings = new MerchantNetworkSettings(new Dictionary<string, string>());
            var options = new JsonSerializerOptions();

            IMerchantNetworkSettings result = settings.AddDeserializationOptions(options);

            Assert.AreSame(options, settings.DeserializationOptions);
            Assert.AreSame(settings, result);
        }

        [Test]
        public void Configuration_DirectInjection_PropagatesSerializerOptionsToNetworkSettings()
        {
            var serializationOptions = new JsonSerializerOptions();
            var deserializationOptions = new JsonSerializerOptions();

            var network = new MerchantNetworkSettings(new Dictionary<string, string>());
            network.AddSerializationOptions(serializationOptions);
            network.AddDeserializationOptions(deserializationOptions);

            var config = new Configuration(
                merchantCredentialSettings: null,
                merchantMLESettings: null,
                merchantNetworkSettings: network,
                merchantLegacySettings: null);

            Assert.AreSame(serializationOptions, config.MerchantNetworkSettings.SerializationOptions);
            Assert.AreSame(deserializationOptions, config.MerchantNetworkSettings.DeserializationOptions);
        }

        #endregion Dependency Injection wiring

        #region Serialization behavior

        [Test]
        public void ApiClient_Serialize_UsesInjectedSerializationOptions()
        {
            // Default (non-Web) options keep property names in PascalCase, which is distinct from
            // the SDK's default Web (camelCase) options - proving the injected options are honored.
            var injectedOptions = new JsonSerializerOptions();
            var apiClient = CreateApiClient(serializationOptions: injectedOptions);

            var json = apiClient.Serialize(new SampleModel { Amount = "10", Currency = "USD" });

            StringAssert.Contains("\"Amount\"", json);
            Assert.IsFalse(json.Contains("\"amount\""));
        }

        [Test]
        public void ApiClient_Serialize_FallsBackToSdkDefaults_WhenNoOptionsInjected()
        {
            var apiClient = CreateApiClient(serializationOptions: null);

            var json = apiClient.Serialize(new SampleModel { Amount = "10", Currency = null });

            // SDK default = Web options (camelCase) + ignore-null-when-writing.
            StringAssert.Contains("\"amount\"", json);
            Assert.IsFalse(json.Contains("\"Amount\""));
            Assert.IsFalse(json.Contains("currency"));
        }

        [Test]
        public void ApiClient_Serialize_ReturnsNull_ForNullInput()
        {
            var apiClient = CreateApiClient(serializationOptions: null);

            Assert.IsNull(apiClient.Serialize(null));
        }

        #endregion Serialization behavior

        #region Effective deserializer options resolution

        [Test]
        public void ApiClient_EffectiveDeserializationOptions_CloneInjectedOptionsAndApplyInvariants()
        {
            var injectedOptions = new JsonSerializerOptions();
            var apiClient = CreateApiClient(deserializationOptions: injectedOptions);

            var effective = GetPrivateOptions(apiClient, "_deserializationSettings");

            // The deserialization track now mirrors the serialization track: when the caller
            // supplies a seed the SDK clones it and applies its invariants, rather than returning
            // the seed instance verbatim. This guarantees SdkDeserializerOptionsPostConfigure runs
            // regardless of whether any consumer post-configures were registered.
            Assert.AreNotSame(injectedOptions, effective);
            Assert.AreEqual(JsonIgnoreCondition.WhenWritingNull, effective.DefaultIgnoreCondition);
        }

        [Test]
        public void ApiClient_FallsBackToSdkDeserializerDefaults_WhenNoOptionsInjected()
        {
            var apiClient = CreateApiClient(deserializationOptions: null);

            var effective = GetPrivateOptions(apiClient, "_deserializationSettings");
            var sdkDefault = GetStaticOptions("deserializationSettings");

            Assert.AreSame(sdkDefault, effective);
        }

        [Test]
        public void ApiClient_PblDeserializerOptions_MergeInjectedCallerOptions()
        {
            var injectedOptions = new JsonSerializerOptions();
            injectedOptions.Converters.Add(new MarkerStringConverter());

            var apiClient = CreateApiClient(deserializationOptions: injectedOptions);

            var pblOptions = GetPrivateOptions(apiClient, "_pblModelDeserializerOptions");

            // The PBL options are a merged copy - not the caller instance - that preserves the
            // caller's converters while layering on the PBL naming policy required by the SDK.
            Assert.AreNotSame(injectedOptions, pblOptions);
            Assert.IsTrue(pblOptions.Converters.Any(c => c is MarkerStringConverter));
            Assert.IsNotNull(pblOptions.PropertyNamingPolicy);
        }

        [Test]
        public void ApiClient_PblDeserializerOptions_UseSdkDefaults_WhenNoOptionsInjected()
        {
            var apiClient = CreateApiClient(deserializationOptions: null);

            var pblOptions = GetPrivateOptions(apiClient, "_pblModelDeserializerOptions");
            var sdkPblDefault = GetStaticOptions("pblModelDeserializerOptions");

            Assert.AreSame(sdkPblDefault, pblOptions);
        }

        #endregion Effective deserializer options resolution

        #region Post-configure pipeline (fluent extensions)

        [Test]
        public void ApiClient_SerializationPostConfigure_RunsBeforeSdkInvariants()
        {
            var network = new MerchantNetworkSettings(new Dictionary<string, string>());
            network.AddSerializationPostConfigure(o => o.WriteIndented = true);

            var apiClient = CreateApiClient(network);
            var effective = GetPrivateOptions(apiClient, "_serializationSettings");

            // Consumer post-configure was honored.
            Assert.IsTrue(effective.WriteIndented);
            // SDK invariants still applied on top.
            Assert.AreEqual(JsonIgnoreCondition.WhenWritingNull, effective.DefaultIgnoreCondition);
            Assert.IsNotNull(effective.TypeInfoResolver);
            Assert.IsTrue(effective.Converters.Any(c => c.GetType().Name == "ProtectedConstructorConverterFactory"));
        }

        [Test]
        public void ApiClient_SerializationPostConfigure_CannotOverrideSdkTypeInfoResolver()
        {
            var network = new MerchantNetworkSettings(new Dictionary<string, string>());
            // Consumer attempts to null out the resolver — the SDK invariant must overwrite this.
            network.AddSerializationPostConfigure(o => o.TypeInfoResolver = null);

            var apiClient = CreateApiClient(network);
            var effective = GetPrivateOptions(apiClient, "_serializationSettings");

            Assert.IsNotNull(effective.TypeInfoResolver,
                "SdkSerializerOptionsPostConfigure must run after consumer callbacks and re-force the TypeInfoResolver.");
        }

        [Test]
        public void ApiClient_DeserializationPostConfigure_RunsBeforeSdkInvariants()
        {
            var network = new MerchantNetworkSettings(new Dictionary<string, string>());
            network.AddDeserializationOptions(new JsonSerializerOptions());
            network.AddDeserializationPostConfigure(o => o.PropertyNameCaseInsensitive = true);

            var apiClient = CreateApiClient(network);
            var effective = GetPrivateOptions(apiClient, "_deserializationSettings");

            Assert.IsTrue(effective.PropertyNameCaseInsensitive);
            Assert.AreEqual(JsonIgnoreCondition.WhenWritingNull, effective.DefaultIgnoreCondition);
            Assert.IsTrue(effective.Converters.Any(c => c.GetType().Name == "ProtectedConstructorConverterFactory"));
        }

        [Test]
        public void ApiClient_PblDeserialization_ForcesNamingPolicy_EvenWhenGeneralDeserializerPostConfigureClearsIt()
        {
            // Consumers cannot post-configure the PBL track directly (the SdkPblDeserializerOptions
            // wrapper is internal and no fluent PBL surface exists). The PBL options are derived
            // from the general DeserializationOptions and the SDK's PBL invariants are applied on
            // top. Even if the consumer sets PropertyNamingPolicy = null on the general track,
            // the PBL track must keep the required CustomContractResolver.
            var network = new MerchantNetworkSettings(new Dictionary<string, string>());
            network.AddDeserializationOptions(new JsonSerializerOptions { PropertyNamingPolicy = null });

            var apiClient = CreateApiClient(network);
            var pblOptions = GetPrivateOptions(apiClient, "_pblModelDeserializerOptions");

            Assert.IsInstanceOf<CustomContractResolver>(pblOptions.PropertyNamingPolicy,
                "SdkPblDeserializerOptionsPostConfigure.Apply must force CustomContractResolver on the derived PBL options.");
        }

        [Test]
        public void ApiClient_PostConfigure_DoesNotCrossContaminateTracks()
        {
            // A consumer post-configure on the serialization track must not affect the
            // deserialization track's effective options, and vice versa. This is the core
            // "separation of serialization and deserialization" invariant.
            var network = new MerchantNetworkSettings(new Dictionary<string, string>());
            network.AddSerializationPostConfigure(o => o.WriteIndented = true);

            var apiClient = CreateApiClient(network);
            var serialization = GetPrivateOptions(apiClient, "_serializationSettings");
            var deserialization = GetPrivateOptions(apiClient, "_deserializationSettings");

            Assert.IsTrue(serialization.WriteIndented);
            Assert.IsFalse(deserialization.WriteIndented,
                "Serialization-only customization leaked into the deserialization options instance.");
            Assert.AreNotSame(serialization, deserialization);
        }

        #endregion Post-configure pipeline (fluent extensions)

        #region DI wiring (IServiceCollection / IOptionsMonitor)

        [Test]
        public void AddSerialization_RegistersSerializerAndDeserializerWrappersAndPostConfigures()
        {
            var services = new ServiceCollection();
            services.AddSerialization();

            using var provider = services.BuildServiceProvider();

            Assert.IsNotNull(provider.GetRequiredService<IOptionsMonitor<SdkSerializerOptions>>());
            Assert.IsNotNull(provider.GetRequiredService<IOptionsMonitor<SdkDeserializerOptions>>());

            // Each exposed track has exactly one SDK post-configure registered. The PBL track is
            // intentionally not exposed through DI: it is derived from SdkDeserializerOptions at
            // ApiClient construction time and its invariants are applied directly by the SDK.
            Assert.AreEqual(1, provider.GetServices<IPostConfigureOptions<SdkSerializerOptions>>().Count());
            Assert.AreEqual(1, provider.GetServices<IPostConfigureOptions<SdkDeserializerOptions>>().Count());
        }

        [Test]
        public void AddSerialization_IsIdempotent()
        {
            var services = new ServiceCollection();
            services.AddSerialization();
            services.AddSerialization();

            using var provider = services.BuildServiceProvider();

            // Duplicates must not accumulate.
            Assert.AreEqual(1, provider.GetServices<IPostConfigureOptions<SdkSerializerOptions>>().Count());
            Assert.AreEqual(1, provider.GetServices<IPostConfigureOptions<SdkDeserializerOptions>>().Count());
        }

        [Test]
        public void OptionsMonitor_AppliesConsumerPostConfigureBeforeSdkInvariants()
        {
            // Consumer PostConfigure calls issued BEFORE AddSerialization are
            // guaranteed to run first in the pipeline, so the SDK's IPostConfigureOptions runs
            // last and wins any conflict on the monitor's CurrentValue.Options.
            //
            // (Callers who register consumer PostConfigures AFTER AddSerialization
            //  see the opposite ordering on the raw monitor value; ApiClient defensively re-
            //  applies the SDK invariants when it reads the monitor to make that ordering
            //  concern invisible to end users. See
            //  ApiClient_MonitorConsumerPostConfigureAfter_SdkStillWins.)
            var services = new ServiceCollection();
            services.PostConfigure<SdkSerializerOptions>(o => o.Options.WriteIndented = true);
            services.PostConfigure<SdkSerializerOptions>(o => o.Options.TypeInfoResolver = null);
            services.AddSerialization();

            using var provider = services.BuildServiceProvider();
            var monitor = provider.GetRequiredService<IOptionsMonitor<SdkSerializerOptions>>();
            var effective = monitor.CurrentValue.Options;

            Assert.IsTrue(effective.WriteIndented, "Consumer post-configure was not honored.");
            Assert.IsNotNull(effective.TypeInfoResolver, "SDK post-configure must run last and re-force the resolver.");
            Assert.AreEqual(JsonIgnoreCondition.WhenWritingNull, effective.DefaultIgnoreCondition);
        }

        [Test]
        public void ApiClient_MonitorConsumerPostConfigureAfter_SdkStillWins()
        {
            // Consumer registers PostConfigure AFTER AddSerialization — the raw options
            // pipeline runs their callback last (and would clobber the SDK invariants), but
            // ApiClient defensively re-applies the invariants when consuming the monitor.
            var services = new ServiceCollection();
            services.AddSerialization();
            services.PostConfigure<SdkSerializerOptions>(o => o.Options.TypeInfoResolver = null);

            using var provider = services.BuildServiceProvider();
            var monitor = provider.GetRequiredService<IOptionsMonitor<SdkSerializerOptions>>();

            var network = new MerchantNetworkSettings(new Dictionary<string, string>());
            network.AddSdkOptionsMonitors(serializerOptionsMonitor: monitor);

            var apiClient = CreateApiClient(network);
            var effective = GetPrivateOptions(apiClient, "_serializationSettings");

            Assert.IsNotNull(effective.TypeInfoResolver,
                "ApiClient must defensively re-apply SDK invariants when reading from the monitor.");
        }

        [Test]
        public void ApiClient_WhenMonitorSupplied_UsesMonitorCurrentValueOptions()
        {
            var services = new ServiceCollection();
            services.AddSerialization();
            services.PostConfigure<SdkDeserializerOptions>(o => o.Options.PropertyNameCaseInsensitive = true);

            using var provider = services.BuildServiceProvider();
            var monitor = provider.GetRequiredService<IOptionsMonitor<SdkDeserializerOptions>>();

            var network = new MerchantNetworkSettings(new Dictionary<string, string>());
            network.AddSdkOptionsMonitors(deserializerOptionsMonitor: monitor);

            var apiClient = CreateApiClient(network);
            var effective = GetPrivateOptions(apiClient, "_deserializationSettings");

            Assert.AreSame(monitor.CurrentValue.Options, effective,
                "ApiClient must use the monitor's CurrentValue.Options verbatim when a monitor is supplied.");
            Assert.IsTrue(effective.PropertyNameCaseInsensitive);
        }

        [Test]
        public void ApiClient_MonitorTracks_StayIndependent()
        {
            var services = new ServiceCollection();
            services.AddSerialization();
            services.PostConfigure<SdkSerializerOptions>(o => o.Options.WriteIndented = true);

            using var provider = services.BuildServiceProvider();
            var serializerMonitor = provider.GetRequiredService<IOptionsMonitor<SdkSerializerOptions>>();
            var deserializerMonitor = provider.GetRequiredService<IOptionsMonitor<SdkDeserializerOptions>>();

            var network = new MerchantNetworkSettings(new Dictionary<string, string>());
            network.AddSdkOptionsMonitors(
                serializerOptionsMonitor: serializerMonitor,
                deserializerOptionsMonitor: deserializerMonitor);

            var apiClient = CreateApiClient(network);
            var serialization = GetPrivateOptions(apiClient, "_serializationSettings");
            var deserialization = GetPrivateOptions(apiClient, "_deserializationSettings");

            Assert.AreNotSame(serialization, deserialization);
            Assert.IsTrue(serialization.WriteIndented);
            Assert.IsFalse(deserialization.WriteIndented);
        }

        [Test]
        public void ApiClient_PblFallsBackToDeserializerMonitor_WhenPblMonitorAbsent()
        {
            // Consumer only registers post-configures for the general deserializer track. The
            // Configuration constructor (per user requirement) no longer accepts a PBL monitor
            // parameter, so ApiClient must derive the PBL options from the general deserializer
            // monitor: clone CurrentValue.Options and apply the SDK's PBL invariants on top.
            var services = new ServiceCollection();
            services.AddSerialization();
            services.PostConfigure<SdkDeserializerOptions>(o => o.Options.PropertyNameCaseInsensitive = true);

            using var provider = services.BuildServiceProvider();
            var deserializerMonitor = provider.GetRequiredService<IOptionsMonitor<SdkDeserializerOptions>>();

            var network = new MerchantNetworkSettings(new Dictionary<string, string>());
            network.AddSdkOptionsMonitors(deserializerOptionsMonitor: deserializerMonitor);

            var apiClient = CreateApiClient(network);
            var deserialization = GetPrivateOptions(apiClient, "_deserializationSettings");
            var pbl = GetPrivateOptions(apiClient, "_pblModelDeserializerOptions");

            // Caller customization from the general track is inherited by PBL.
            Assert.IsTrue(pbl.PropertyNameCaseInsensitive);

            // PBL is a clone, not the shared instance - mutating PBL invariants (naming policy)
            // must never leak into the general deserializer options that the caller keeps using.
            Assert.AreNotSame(deserialization, pbl,
                "PBL options must be a clone of the general deserializer monitor value to avoid PropertyNamingPolicy corruption.");

            // The SDK's PBL invariants are applied on top of the clone: PBL forces
            // CustomContractResolver as its PropertyNamingPolicy.
            Assert.IsInstanceOf<CustomContractResolver>(pbl.PropertyNamingPolicy,
                "SdkPblDeserializerOptionsPostConfigure must run on the derived PBL options and force CustomContractResolver.");

            // The general deserializer track keeps its own naming policy (the SDK's
            // SdkDeserializerOptionsPostConfigure applies JsonNamingPolicy.CamelCase there).
            // Crucially it must NOT be a CustomContractResolver, i.e. the PBL invariants must
            // not have leaked back into the shared general-deserializer options instance.
            Assert.IsNotInstanceOf<CustomContractResolver>(deserialization.PropertyNamingPolicy,
                "General deserializer options must not be mutated by PBL invariants.");
        }

        #endregion DI wiring (IServiceCollection / IOptionsMonitor)

        #region ModelExtensions bridge

        [Test]
        public void ApiClient_Construction_SyncsDeserializerOptionsIntoModelExtensions()
        {
            var injected = new JsonSerializerOptions();
            CreateApiClient(deserializationOptions: injected);

            // After ApiClient construction the SDK invariants have been layered on top of the
            // caller's options (the deserialization track now mirrors the serialization track and
            // always clones + Apply when a seed is supplied), so the resulting effective
            // deserializer options are a new instance — but ModelExtensions must still see the
            // *same* instance that ApiClient uses, and that instance must carry the SDK invariants.
            Assert.IsNotNull(ModelExtensions.EffectiveDeserializerOptions);
            Assert.AreNotSame(injected, ModelExtensions.EffectiveDeserializerOptions,
                "The SDK must clone the caller's deserialization options before applying its invariants.");
            Assert.AreEqual(JsonIgnoreCondition.WhenWritingNull,
                ModelExtensions.EffectiveDeserializerOptions.DefaultIgnoreCondition,
                "SDK deserializer invariants must be applied to the cloned options.");
        }

        [Test]
        public void ApiClient_Construction_SyncsSerializerOptionsIntoModelExtensions()
        {
            var injected = new JsonSerializerOptions();
            CreateApiClient(serializationOptions: injected);

            // After ApiClient construction the SDK invariants have been layered on top of the
            // caller's options, so the resulting effective serializer options are a new instance —
            // but ModelExtensions must still see the *same* instance that ApiClient uses.
            var effectiveSerializer = typeof(ModelExtensions)
                .GetProperty("EffectiveSerializerOptions", BindingFlags.Static | BindingFlags.NonPublic)
                ?.GetValue(null) as JsonSerializerOptions;

            Assert.IsNotNull(effectiveSerializer);
            // Sanity: SDK invariants applied so ExtensionSerializerOptions is NOT the fallback.
            Assert.AreEqual(JsonIgnoreCondition.WhenWritingNull, effectiveSerializer.DefaultIgnoreCondition);
        }

        [TearDown]
        public void ResetModelExtensionsHooks()
        {
            // These static hooks are process-wide; other tests must not observe leaks.
            ModelExtensions.SetDeserializerOptions(null);
            ModelExtensions.SetSerializerOptions(null);
        }

        #endregion ModelExtensions bridge

        #region Helpers

        private static ApiClient CreateApiClient(MerchantNetworkSettings network)
        {
            var config = new Configuration(
                merchantCredentialSettings: null,
                merchantMLESettings: null,
                merchantNetworkSettings: network,
                merchantLegacySettings: null);

            return new ApiClient(config);
        }

        private static ApiClient CreateApiClient(
            JsonSerializerOptions serializationOptions = null,
            JsonSerializerOptions deserializationOptions = null)
        {
            var network = new MerchantNetworkSettings(new Dictionary<string, string>());

            if (serializationOptions != null)
            {
                network.AddSerializationOptions(serializationOptions);
            }

            if (deserializationOptions != null)
            {
                network.AddDeserializationOptions(deserializationOptions);
            }

            var config = new Configuration(
                merchantCredentialSettings: null,
                merchantMLESettings: null,
                merchantNetworkSettings: network,
                merchantLegacySettings: null);

            return new ApiClient(config);
        }

        private static JsonSerializerOptions GetPrivateOptions(ApiClient client, string fieldName)
        {
            var field = typeof(ApiClient).GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
            Assert.IsNotNull(field, $"Instance field '{fieldName}' was not found on ApiClient.");
            return (JsonSerializerOptions)field.GetValue(client);
        }

        private static JsonSerializerOptions GetStaticOptions(string fieldName)
        {
            var field = typeof(ApiClient).GetField(fieldName, BindingFlags.Static | BindingFlags.NonPublic);
            Assert.IsNotNull(field, $"Static field '{fieldName}' was not found on ApiClient.");
            return (JsonSerializerOptions)field.GetValue(null);
        }

        private sealed class SampleModel
        {
            public string Amount { get; set; }

            public string Currency { get; set; }
        }

        private sealed class MarkerStringConverter : JsonConverter<string>
        {
            public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
                => reader.GetString();

            public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
                => writer.WriteStringValue(value);
        }

        #endregion Helpers
    }
}
