using AuthenticationSdk.core;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CyberSource.Client
{
    /// <summary>
    /// Defines methods for processing and creating Message Level Encryption (MLE) settings.
    /// Coordinates validation and factory-based creation of MLE configuration.
    /// </summary>
    public interface IMerchantMLESettingsProcessor
    {
        /// <summary>
        /// Creates MLE settings from configuration dictionary with optional API-specific MLE mappings and private key.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant MLE configuration key-value pairs.</param>
        /// <param name="mapToControlMLEonAPI">Optional dictionary mapping API operation names to MLE control settings in formats "requestMLE::responseMLE" or "requestMLE".</param>
        /// <param name="responseMlePrivateKey">Optional pre-loaded asymmetric private key for decrypting MLE responses.</param>
        /// <returns>A merchant MLE settings instance configured with the provided parameters.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configurationDictionary is null.</exception>
        /// <exception cref="Exception">Thrown when validation of MLE settings fails.</exception>
        IMerchantMLESettings CreateMLESettings(IReadOnlyDictionary<string, string> configurationDictionary, Dictionary<string, string> mapToControlMLEonAPI = null, AsymmetricAlgorithm responseMlePrivateKey = null);
    }

    /// <summary>
    /// Processes merchant MLE configuration by coordinating validation and factory creation.
    /// This sealed internal class implements the processor pattern to ensure MLE configuration validity before creating settings.
    /// </summary>
    internal sealed class MerchantMLESettingsProcessor : IMerchantMLESettingsProcessor
    {
        private readonly MerchantMLESettingsFactory _factory;
        private readonly MerchantMLESettingsValidator _validator;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantMLESettingsProcessor"/> class.
        /// </summary>
        /// <param name="factory">The factory responsible for creating merchant MLE settings instances.</param>
        /// <param name="validator">The validator responsible for validating merchant MLE configuration.</param>
        /// <exception cref="ArgumentNullException">Thrown when factory or validator is null.</exception>
        public MerchantMLESettingsProcessor(MerchantMLESettingsFactory factory, MerchantMLESettingsValidator validator)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        /// <summary>
        /// Creates MLE settings after validating the configuration.
        /// Validates MLE settings including request and response configuration, private keys, and API-specific mappings,
        /// then delegates to the factory for settings creation.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant MLE configuration key-value pairs.</param>
        /// <param name="mapToControlMLEonAPI">Optional dictionary mapping API operation names to MLE control settings. Supports formats:
        /// "true"/"false" for request MLE only, or "requestMLE::responseMLE" for both request and response MLE control per API.</param>
        /// <param name="responseMlePrivateKey">Optional pre-loaded asymmetric private key for decrypting MLE responses. If provided, takes precedence over file path.</param>
        /// <returns>A new MLE settings instance configured with the validated configuration.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configurationDictionary is null.</exception>
        /// <exception cref="Exception">Thrown when validation of MLE settings fails, including:
        /// - Invalid or missing MLE configuration
        /// - Invalid private key configuration
        /// - Invalid mapToControlMLEonAPI format or values
        /// - Missing required MLE properties
        /// </exception>
        public IMerchantMLESettings CreateMLESettings(
                    IReadOnlyDictionary<string, string> configurationDictionary,
                    Dictionary<string, string> mapToControlMLEonAPI = null,
                    AsymmetricAlgorithm responseMlePrivateKey = null)
        {
            if (configurationDictionary == null) throw new ArgumentNullException(nameof(configurationDictionary));
            _validator.ValidateMLESettings(configurationDictionary, mapToControlMLEonAPI, responseMlePrivateKey);
            var settings = _factory.CreateMLESettings(configurationDictionary, mapToControlMLEonAPI, responseMlePrivateKey);
            return settings;
        }
    }
}
