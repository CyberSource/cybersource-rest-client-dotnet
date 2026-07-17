using AuthenticationSdk.core;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CyberSource.Client
{
    /// <summary>
    /// Defines methods for creating Message Level Encryption (MLE) settings instances.
    /// Provides factory methods to create MLE settings from different configuration sources.
    /// </summary>
    public interface IMerchantMLESettingsFactory
    {
        /// <summary>
        /// Creates MLE settings from legacy merchant settings.
        /// </summary>
        /// <param name="merchantLegacySettings">The legacy merchant settings containing merchant configuration dictionary.</param>
        /// <param name="mapToControlMLEonAPI">Optional dictionary mapping API operation names to MLE control settings in formats "requestMLE::responseMLE" or "requestMLE".</param>
        /// <param name="responseMlePrivateKey">Optional pre-loaded asymmetric private key for decrypting MLE responses.</param>
        /// <returns>A merchant MLE settings instance created from the legacy settings.</returns>
        public IMerchantMLESettings Create(IMerchantLegacySettings merchantLegacySettings, Dictionary<string, string> mapToControlMLEonAPI = null, AsymmetricAlgorithm responseMlePrivateKey = null);

        /// <summary>
        /// Creates MLE settings from normalized configuration fields.
        /// </summary>
        /// <param name="normalizedFields">A dictionary containing normalized merchant configuration key-value pairs that have already been validated.</param>
        /// <param name="mapToControlMLEonAPI">A dictionary mapping API operation names to MLE control settings in formats "requestMLE::responseMLE" or "requestMLE".</param>
        /// <param name="responseMlePrivateKey">Optional pre-loaded asymmetric private key for decrypting MLE responses.</param>
        /// <returns>A merchant MLE settings instance created from the normalized fields without re-validation.</returns>
        IMerchantMLESettings CreateMLESettings(IReadOnlyDictionary<string, string> normalizedFields, Dictionary<string, string> mapToControlMLEonAPI, AsymmetricAlgorithm responseMlePrivateKey);
    }

    /// <summary>
    /// Factory for creating Message Level Encryption (MLE) settings instances.
    /// This sealed internal class provides methods to create MLE settings from various configuration sources.
    /// </summary>
    internal sealed class MerchantMLESettingsFactory : IMerchantMLESettingsFactory
    {
        /// <summary>
        /// Creates MLE settings from legacy merchant settings.
        /// Extracts the merchant configuration dictionary from legacy settings and creates a new MLE settings instance.
        /// </summary>
        /// <param name="merchantLegacySettings">The legacy merchant settings containing the merchant configuration dictionary.</param>
        /// <param name="mapToControlMLEonAPI">Optional dictionary mapping API operation names to MLE control settings. Supports formats "requestMLE::responseMLE" or "requestMLE".</param>
        /// <param name="responseMlePrivateKey">Optional pre-loaded asymmetric private key for decrypting MLE responses.</param>
        /// <returns>A new MLE settings instance configured with the provided parameters.</returns>
        public IMerchantMLESettings Create(IMerchantLegacySettings merchantLegacySettings, Dictionary<string, string> mapToControlMLEonAPI = null, AsymmetricAlgorithm responseMlePrivateKey = null)
        {
            return new MerchantMLESettings(merchantLegacySettings.MerchantConfigDictionaryObj, mapToControlMLEonAPI, responseMlePrivateKey);
        }

        /// <summary>
        /// Creates MLE settings from normalized configuration fields without re-validation.
        /// Used when configuration has already been validated by the processor.
        /// </summary>
        /// <param name="normalizedFields">A dictionary containing normalized merchant MLE configuration key-value pairs that have already been validated.</param>
        /// <param name="mapToControlMLEonAPI">A dictionary mapping API operation names to MLE control settings. Supports formats "requestMLE::responseMLE" or "requestMLE".</param>
        /// <param name="responseMlePrivateKey">Optional pre-loaded asymmetric private key for decrypting MLE responses.</param>
        /// <returns>A new MLE settings instance with validation skipped (isValidated=true).</returns>
        public IMerchantMLESettings CreateMLESettings(IReadOnlyDictionary<string, string> normalizedFields, Dictionary<string, string> mapToControlMLEonAPI, AsymmetricAlgorithm responseMlePrivateKey)
        {
            return new MerchantMLESettings(normalizedFields, mapToControlMLEonAPI, responseMlePrivateKey, true);
        }
    }
}