using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CyberSource.Client
{
    /// <summary>
    /// Defines methods for validating merchant Message Level Encryption (MLE) configuration settings.
    /// </summary>
    public interface IMerchantMLESettingsValidator
    {
        /// <summary>
        /// Validates all MLE (Message Level Encryption) configuration settings.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant MLE configuration key-value pairs.</param>
        /// <param name="mapToControlMLEonAPI">A dictionary mapping API operation names to MLE control settings in formats "requestMLE::responseMLE" or "requestMLE".</param>
        /// <param name="responseMlePrivateKey">Optional pre-loaded asymmetric private key for decrypting MLE responses.</param>
        /// <exception cref="Exception">Thrown when MLE configuration is invalid or required settings are missing.</exception>
        void ValidateMLESettings(IReadOnlyDictionary<string, string> configurationDictionary, IDictionary<string, string> mapToControlMLEonAPI, AsymmetricAlgorithm responseMlePrivateKey = null);
    }

    /// <summary>
    /// Validates merchant MLE configuration settings by delegating to the core authentication SDK validator.
    /// This sealed internal class acts as an adapter that wraps the core MLE validation logic for use in the client layer.
    /// </summary>
    internal sealed class MerchantMLESettingsValidator : IMerchantMLESettingsValidator
    {
        private readonly AuthenticationSdk.core.IMerchantMLESettingsValidator _coreValidator;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantMLESettingsValidator"/> class.
        /// Creates an instance of the core MLE settings validator for delegation.
        /// </summary>
        public MerchantMLESettingsValidator()
        {
            _coreValidator = new AuthenticationSdk.core.MerchantMLESettingsValidator();
        }

        /// <summary>
        /// Validates MLE settings by delegating to the core validator.
        /// Performs comprehensive validation of request MLE, response MLE, private key configuration, 
        /// certificate paths, and API-specific MLE control mappings.
        /// </summary>
        /// <param name="configurationDictionary">A dictionary containing merchant MLE configuration key-value pairs.</param>
        /// <param name="mapToControlMLEonAPI">A dictionary mapping API operation names to MLE control settings. Supports formats:
        /// "true"/"false" for request MLE only, or "requestMLE::responseMLE" for both request and response MLE control per API.</param>
        /// <param name="responseMlePrivateKey">Optional pre-loaded asymmetric private key for decrypting MLE responses. If provided, takes precedence over file path.</param>
        /// <exception cref="Exception">Thrown when MLE configuration is invalid, including:
        /// - Required MLE configuration is missing or invalid
        /// - Both responseMlePrivateKey object and responseMlePrivateKeyFilePath are provided
        /// - Private key file path does not exist or is not accessible
        /// - responseMleKID is missing when required
        /// - mapToControlMLEonAPI contains invalid values or formats
        /// </exception>
        public void ValidateMLESettings(IReadOnlyDictionary<string, string> configurationDictionary, IDictionary<string, string> mapToControlMLEonAPI, AsymmetricAlgorithm responseMlePrivateKey = null)
        {
            _coreValidator.ValidateMLESettings(configurationDictionary, mapToControlMLEonAPI, responseMlePrivateKey);
        }
    }
}