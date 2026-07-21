using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSource.Client
{
    /// <summary>
    /// Defines methods for validating merchant credential configuration settings.
    /// Validates configuration for different authentication types including HTTP Signature, JWT, OAuth, and Mutual Auth.
    /// </summary>
    public interface IMerchantCredentialSettingsValidator
    {
        /// <summary>
        /// Validates mandatory merchant configuration settings that apply to all authentication types.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <exception cref="Exception">Thrown when mandatory configuration settings are invalid or missing.</exception>
        void ValidateMandatorySettings(IReadOnlyDictionary<string, string> configurationDictionary);

        /// <summary>
        /// Validates HTTP Signature authentication-specific configuration settings.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <exception cref="Exception">Thrown when HTTP Signature-specific settings are invalid or missing.</exception>
        void ValidateHttpSignatureSettings(IReadOnlyDictionary<string, string> configurationDictionary);

        /// <summary>
        /// Validates JWT (JSON Web Token) authentication-specific configuration settings.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <exception cref="Exception">Thrown when JWT-specific settings are invalid or missing.</exception>
        void ValidateJwtSettings(IReadOnlyDictionary<string, string> configurationDictionary);

        /// <summary>
        /// Validates OAuth authentication-specific configuration settings.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <exception cref="Exception">Thrown when OAuth-specific settings are invalid or missing.</exception>
        void ValidateOAuthSettings(IReadOnlyDictionary<string, string> configurationDictionary);

        /// <summary>
        /// Validates Mutual Auth authentication-specific configuration settings.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <exception cref="Exception">Thrown when Mutual Auth-specific settings are invalid or missing.</exception>
        void ValidateMutualAuthSettings(IReadOnlyDictionary<string, string> configurationDictionary);
    }

    /// <summary>
    /// Validates merchant credential configuration settings by delegating to the core authentication SDK validator.
    /// This sealed internal class acts as an adapter that wraps the core validation logic for use in the client layer.
    /// </summary>
    internal sealed class MerchantCredentialSettingsValidator : IMerchantCredentialSettingsValidator
    {
        private readonly AuthenticationSdk.core.IMerchantCredentialSettingsValidator _coreValidator;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantCredentialSettingsValidator"/> class.
        /// </summary>
        public MerchantCredentialSettingsValidator()
        {
            _coreValidator = new AuthenticationSdk.core.MerchantCredentialSettingsValidator();
        }

        /// <summary>
        /// Validates mandatory merchant configuration settings by delegating to the core validator.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <exception cref="Exception">Thrown when mandatory configuration settings are invalid or missing.</exception>
        public void ValidateMandatorySettings(IReadOnlyDictionary<string, string> configurationDictionary)
        {
            _coreValidator.ValidateMandatorySettings(configurationDictionary);
        }

        /// <summary>
        /// Validates HTTP Signature authentication-specific settings by delegating to the core validator.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <exception cref="Exception">Thrown when HTTP Signature-specific settings are invalid or missing.</exception>
        public void ValidateHttpSignatureSettings(IReadOnlyDictionary<string, string> configurationDictionary)
        {
            _coreValidator.ValidateHttpSignatureSettings(configurationDictionary);
        }

        /// <summary>
        /// Validates JWT authentication-specific settings by delegating to the core validator.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <exception cref="Exception">Thrown when JWT-specific settings are invalid or missing.</exception>
        public void ValidateJwtSettings(IReadOnlyDictionary<string, string> configurationDictionary)
        {
            _coreValidator.ValidateJwtSettings(configurationDictionary);
        }

        /// <summary>
        /// Validates OAuth authentication-specific settings by delegating to the core validator.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <exception cref="Exception">Thrown when OAuth-specific settings are invalid or missing.</exception>
        public void ValidateOAuthSettings(IReadOnlyDictionary<string, string> configurationDictionary)
        {
            _coreValidator.ValidateOAuthSettings(configurationDictionary);
        }

        /// <summary>
        /// Validates Mutual Auth authentication-specific settings by delegating to the core validator.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant configuration key-value pairs.</param>
        /// <exception cref="Exception">Thrown when Mutual Auth-specific settings are invalid or missing.</exception>
        public void ValidateMutualAuthSettings(IReadOnlyDictionary<string, string> configurationDictionary)
        {
            _coreValidator.ValidateMutualAuthSettings(configurationDictionary);
        }
    }
}
