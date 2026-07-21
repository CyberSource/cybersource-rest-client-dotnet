using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CyberSource.Client
{
    /// <summary>
    /// Provides extension methods for configuring Message Level Encryption (MLE) options on an IConfiguration instance.
    /// These methods allow fluent configuration of MLE settings including request encryption and response decryption.
    /// </summary>
    public static class ConfigurationMLEExtensions
    {
        /// <summary>
        /// Adds Message Level Encryption (MLE) options to the configuration.
        /// Configures both request and response MLE settings including certificate paths, private keys, and API-specific MLE control mappings.
        /// </summary>
        /// <param name="configuration">The configuration instance to add MLE options to. Must implement IMutableConfiguration.</param>
        /// <param name="configurationDictionary">A dictionary containing MLE configuration values including request certificate path, response private key path, and MLE KID.</param>
        /// <param name="mapToControlMLEonAPI">Optional dictionary mapping API operation names to MLE control settings. Supports formats:
        /// "true"/"false" for request MLE only, or "requestMLE::responseMLE" for both request and response MLE control per API.
        /// If null, global MLE configuration settings are used for all APIs.</param>
        /// <param name="responseMlePrivateKey">Optional pre-loaded asymmetric private key for decrypting MLE responses. If provided, this takes precedence over loading from file path.</param>
        /// <returns>The same configuration instance for method chaining.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configuration or configurationDictionary is null.</exception>
        /// <exception cref="ArgumentException">Thrown when configuration does not implement IMutableConfiguration.</exception>
        public static IConfiguration AddMLEOptions(
                    this IConfiguration configuration,
                    IReadOnlyDictionary<string, string> configurationDictionary,
                    Dictionary<string, string> mapToControlMLEonAPI = null,
                    AsymmetricAlgorithm responseMlePrivateKey = null)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            if (configurationDictionary == null)
            {
                throw new ArgumentNullException(nameof(configurationDictionary));
            }

            if (!(configuration is IMutableConfiguration mutable))
            {
                throw new ArgumentException("Configuration must be mutable to add HTTP signature credentials.", nameof(configuration));
            }

            var processor = new MerchantMLESettingsProcessor(new MerchantMLESettingsFactory(), new MerchantMLESettingsValidator());

            var newMLESettings = processor.CreateMLESettings(configurationDictionary, mapToControlMLEonAPI, responseMlePrivateKey);

            mutable.AddMLESettings(newMLESettings);

            return configuration;
        }
    }
}
