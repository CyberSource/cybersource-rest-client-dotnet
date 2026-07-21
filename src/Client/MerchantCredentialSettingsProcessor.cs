using AuthenticationSdk.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSource.Client
{
    /// <summary>
    /// Defines methods for creating merchant credential settings based on authentication type.
    /// Handles validation and factory-based creation of credential settings for various authentication mechanisms.
    /// </summary>
    public interface IMerchantCredentialSettingsProcessor
    {
        /// <summary>
        /// Creates merchant credential settings with only mandatory configuration values.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <returns>A merchant credential settings instance populated with mandatory configuration values.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configurationDictionary is null.</exception>
        /// <exception cref="Exception">Thrown when validation of mandatory settings fails.</exception>
        IMerchantCredentialSettings CreateMandatorySettings(IReadOnlyDictionary<string, string> configurationDictionary);

        /// <summary>
        /// Creates merchant credential settings for HTTP Signature authentication.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <returns>A merchant credential settings instance configured for HTTP Signature authentication.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configurationDictionary is null.</exception>
        /// <exception cref="Exception">Thrown when validation of mandatory or HTTP Signature settings fails.</exception>
        IMerchantCredentialSettings CreateHttpSignatureSettings(IReadOnlyDictionary<string, string> configurationDictionary);

        /// <summary>
        /// Creates merchant credential settings for JWT (JSON Web Token) authentication.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <returns>A merchant credential settings instance configured for JWT authentication.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configurationDictionary is null.</exception>
        /// <exception cref="Exception">Thrown when validation of mandatory or JWT settings fails.</exception>
        IMerchantCredentialSettings CreateJwtSettings(IReadOnlyDictionary<string, string> configurationDictionary);

        /// <summary>
        /// Creates merchant credential settings for OAuth authentication.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <returns>A merchant credential settings instance configured for OAuth authentication.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configurationDictionary is null.</exception>
        /// <exception cref="Exception">Thrown when validation of mandatory or OAuth settings fails.</exception>
        IMerchantCredentialSettings CreateOAuthSettings(IReadOnlyDictionary<string, string> configurationDictionary);

        /// <summary>
        /// Creates merchant credential settings for Mutual Auth authentication.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <returns>A merchant credential settings instance configured for Mutual Auth authentication.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configurationDictionary is null.</exception>
        /// <exception cref="Exception">Thrown when validation of mandatory or Mutual Auth settings fails.</exception>
        IMerchantCredentialSettings CreateMutualAuthSettings(IReadOnlyDictionary<string, string> configurationDictionary);
    }

    /// <summary>
    /// Processes merchant credential configuration by coordinating validation and factory creation.
    /// This sealed internal class implements the processor pattern to ensure configuration validity before creating credential settings.
    /// </summary>
    internal sealed class MerchantCredentialSettingsProcessor : IMerchantCredentialSettingsProcessor
    {
        private readonly MerchantCredentialSettingsFactory _factory;
        private readonly MerchantCredentialSettingsValidator _validator;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantCredentialSettingsProcessor"/> class.
        /// </summary>
        /// <param name="factory">The factory responsible for creating merchant credential settings instances.</param>
        /// <param name="validator">The validator responsible for validating merchant credential configuration.</param>
        /// <exception cref="ArgumentNullException">Thrown when factory or validator is null.</exception>
        public MerchantCredentialSettingsProcessor(
            MerchantCredentialSettingsFactory factory,
            MerchantCredentialSettingsValidator validator)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        /// <summary>
        /// Creates merchant credential settings with only mandatory configuration values.
        /// Validates mandatory settings and delegates to the factory for settings creation.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <returns>A merchant credential settings instance populated with mandatory configuration values.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configurationDictionary is null.</exception>
        /// <exception cref="Exception">Thrown when validation of mandatory settings fails.</exception>
        public IMerchantCredentialSettings CreateMandatorySettings(IReadOnlyDictionary<string, string> configurationDictionary)
        {
            if (configurationDictionary == null) throw new ArgumentNullException(nameof(configurationDictionary));
            _validator.ValidateMandatorySettings(configurationDictionary);
            var settings = _factory.CreateMandatorySettings(configurationDictionary);
            return settings;
        }

        /// <summary>
        /// Creates merchant credential settings for HTTP Signature authentication.
        /// Validates both mandatory and HTTP Signature-specific settings before creation.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <returns>A merchant credential settings instance configured for HTTP Signature authentication.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configurationDictionary is null.</exception>
        /// <exception cref="Exception">Thrown when validation of mandatory or HTTP Signature settings fails.</exception>
        public IMerchantCredentialSettings CreateHttpSignatureSettings(IReadOnlyDictionary<string, string> configurationDictionary)
        {
            if (configurationDictionary == null) throw new ArgumentNullException(nameof(configurationDictionary));
            _validator.ValidateMandatorySettings(configurationDictionary);
            _validator.ValidateHttpSignatureSettings(configurationDictionary);
            var settings = _factory.CreateMandatorySettings(configurationDictionary);
            settings = _factory.CreateHttpSignatureSettings(settings, configurationDictionary);
            return settings;
        }

        /// <summary>
        /// Creates merchant credential settings for JWT (JSON Web Token) authentication.
        /// Validates both mandatory and JWT-specific settings before creation.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <returns>A merchant credential settings instance configured for JWT authentication.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configurationDictionary is null.</exception>
        /// <exception cref="Exception">Thrown when validation of mandatory or JWT settings fails.</exception>
        public IMerchantCredentialSettings CreateJwtSettings(IReadOnlyDictionary<string, string> configurationDictionary)
        {
            if (configurationDictionary == null) throw new ArgumentNullException(nameof(configurationDictionary));
            _validator.ValidateMandatorySettings(configurationDictionary);
            _validator.ValidateJwtSettings(configurationDictionary);
            var settings = _factory.CreateMandatorySettings(configurationDictionary);
            settings = _factory.CreateJwtSettings(settings, configurationDictionary);
            return settings;
        }

        /// <summary>
        /// Creates merchant credential settings for OAuth authentication.
        /// Validates both mandatory and OAuth-specific settings before creation.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <returns>A merchant credential settings instance configured for OAuth authentication.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configurationDictionary is null.</exception>
        /// <exception cref="Exception">Thrown when validation of mandatory or OAuth settings fails.</exception>
        public IMerchantCredentialSettings CreateOAuthSettings(IReadOnlyDictionary<string, string> configurationDictionary)
        {
            if (configurationDictionary == null) throw new ArgumentNullException(nameof(configurationDictionary));
            _validator.ValidateMandatorySettings(configurationDictionary);
            _validator.ValidateOAuthSettings(configurationDictionary);
            var settings = _factory.CreateMandatorySettings(configurationDictionary);
            settings = _factory.CreateOAuthSettings(settings, configurationDictionary);
            return settings;
        }

        /// <summary>
        /// Creates merchant credential settings for Mutual Auth authentication.
        /// Validates both mandatory and Mutual Auth-specific settings before creation.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <returns>A merchant credential settings instance configured for Mutual Auth authentication.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configurationDictionary is null.</exception>
        /// <exception cref="Exception">Thrown when validation of mandatory or Mutual Auth settings fails.</exception>
        public IMerchantCredentialSettings CreateMutualAuthSettings(IReadOnlyDictionary<string, string> configurationDictionary)
        {
            if (configurationDictionary == null) throw new ArgumentNullException(nameof(configurationDictionary));
            _validator.ValidateMandatorySettings(configurationDictionary);
            _validator.ValidateMutualAuthSettings(configurationDictionary);
            var settings = _factory.CreateMandatorySettings(configurationDictionary);
            settings = _factory.CreateMutualAuthSettings(settings, configurationDictionary);
            return settings;
        }
    }
}
