using AuthenticationSdk.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSource.Client
{
    /// <summary>
    /// Defines the contract for creating and configuring merchant credential settings.
    /// </summary>
    /// <remarks>
    /// This factory interface provides a facade for building merchant credential settings
    /// through a fluent-like builder pattern, supporting multiple authentication methods.
    /// </remarks>
    public interface IMerchantCredentialSettingsFactory
    {
        /// <summary>
        /// Creates merchant credential settings from legacy merchant settings.
        /// </summary>
        /// <param name="merchantLegacySettings">The legacy merchant settings containing configuration data.</param>
        /// <returns>An <see cref="IMerchantCredentialSettings"/> instance created from the legacy settings.</returns>
        IMerchantCredentialSettings Create(IMerchantLegacySettings merchantLegacySettings);

        /// <summary>
        /// Creates merchant credential settings with mandatory fields populated.
        /// </summary>
        /// <param name="normalizedFields">A read-only dictionary containing normalized configuration fields required for mandatory settings.</param>
        /// <returns>An <see cref="IMerchantCredentialSettings"/> instance with mandatory fields configured.</returns>
        IMerchantCredentialSettings CreateMandatorySettings(IReadOnlyDictionary<string, string> normalizedFields);

        /// <summary>
        /// Adds HTTP signature credentials to the provided merchant credential settings.
        /// </summary>
        /// <param name="settings">The existing merchant credential settings to extend.</param>
        /// <param name="normalizedFields">A read-only dictionary containing normalized configuration fields for HTTP signature authentication.</param>
        /// <returns>The updated <see cref="IMerchantCredentialSettings"/> instance with HTTP signature credentials added.</returns>
        IMerchantCredentialSettings CreateHttpSignatureSettings(IMerchantCredentialSettings settings, IReadOnlyDictionary<string, string> normalizedFields);

        /// <summary>
        /// Adds JWT credentials to the provided merchant credential settings.
        /// </summary>
        /// <param name="settings">The existing merchant credential settings to extend.</param>
        /// <param name="normalizedFields">A read-only dictionary containing normalized configuration fields for JWT authentication.</param>
        /// <returns>The updated <see cref="IMerchantCredentialSettings"/> instance with JWT credentials added.</returns>
        IMerchantCredentialSettings CreateJwtSettings(IMerchantCredentialSettings settings, IReadOnlyDictionary<string, string> normalizedFields);

        /// <summary>
        /// Adds OAuth credentials to the provided merchant credential settings.
        /// </summary>
        /// <param name="settings">The existing merchant credential settings to extend.</param>
        /// <param name="normalizedFields">A read-only dictionary containing normalized configuration fields for OAuth authentication.</param>
        /// <returns>The updated <see cref="IMerchantCredentialSettings"/> instance with OAuth credentials added.</returns>
        IMerchantCredentialSettings CreateOAuthSettings(IMerchantCredentialSettings settings, IReadOnlyDictionary<string, string> normalizedFields);

        /// <summary>
        /// Adds mutual authentication credentials to the provided merchant credential settings.
        /// </summary>
        /// <param name="settings">The existing merchant credential settings to extend.</param>
        /// <param name="normalizedFields">A read-only dictionary containing normalized configuration fields for mutual authentication.</param>
        /// <returns>The updated <see cref="IMerchantCredentialSettings"/> instance with mutual authentication credentials added.</returns>
        IMerchantCredentialSettings CreateMutualAuthSettings(IMerchantCredentialSettings settings, IReadOnlyDictionary<string, string> normalizedFields);
    }

    /// <summary>
    /// Factory implementation for creating and configuring merchant credential settings.
    /// </summary>
    /// <remarks>
    /// This sealed class provides concrete implementations for the <see cref="IMerchantCredentialSettingsFactory"/> interface,
    /// enabling the creation and configuration of merchant credentials using various authentication methods.
    /// </remarks>
    internal sealed class MerchantCredentialSettingsFactory : IMerchantCredentialSettingsFactory
    {
        /// <summary>
        /// Creates merchant credential settings from legacy merchant settings.
        /// </summary>
        /// <param name="merchantLegacySettings">The legacy merchant settings containing the configuration dictionary.</param>
        /// <returns>An <see cref="IMerchantCredentialSettings"/> instance created from the legacy settings' configuration dictionary.</returns>
        public IMerchantCredentialSettings Create(IMerchantLegacySettings merchantLegacySettings)
        {
            return new MerchantCredentialSettings(merchantLegacySettings.MerchantConfigDictionaryObj);
        }

        /// <summary>
        /// Creates merchant credential settings with mandatory fields from normalized configuration fields.
        /// </summary>
        /// <param name="normalizedFields">A read-only dictionary containing normalized configuration fields.</param>
        /// <returns>An <see cref="IMerchantCredentialSettings"/> instance with mandatory fields configured.</returns>
        public IMerchantCredentialSettings CreateMandatorySettings(IReadOnlyDictionary<string, string> normalizedFields)
        {
            return new MerchantCredentialSettings(normalizedFields, true);
        }

        /// <summary>
        /// Adds HTTP signature authentication credentials to the provided settings.
        /// </summary>
        /// <param name="settings">The merchant credential settings to extend with HTTP signature credentials.</param>
        /// <param name="normalizedFields">A read-only dictionary containing normalized configuration fields for HTTP signature authentication.</param>
        /// <returns>The updated settings with HTTP signature credentials added.</returns>
        public IMerchantCredentialSettings CreateHttpSignatureSettings(IMerchantCredentialSettings settings, IReadOnlyDictionary<string, string> normalizedFields)
        {
            return settings.AddHttpSignatureCredentials(normalizedFields);
        }

        /// <summary>
        /// Adds JWT authentication credentials to the provided settings.
        /// </summary>
        /// <param name="settings">The merchant credential settings to extend with JWT credentials.</param>
        /// <param name="normalizedFields">A read-only dictionary containing normalized configuration fields for JWT authentication.</param>
        /// <returns>The updated settings with JWT credentials added.</returns>
        public IMerchantCredentialSettings CreateJwtSettings(IMerchantCredentialSettings settings, IReadOnlyDictionary<string, string> normalizedFields)
        {
            return settings.AddJwtCredentials(normalizedFields);
        }

        /// <summary>
        /// Adds OAuth authentication credentials to the provided settings.
        /// </summary>
        /// <param name="settings">The merchant credential settings to extend with OAuth credentials.</param>
        /// <param name="normalizedFields">A read-only dictionary containing normalized configuration fields for OAuth authentication.</param>
        /// <returns>The updated settings with OAuth credentials added.</returns>
        public IMerchantCredentialSettings CreateOAuthSettings(IMerchantCredentialSettings settings, IReadOnlyDictionary<string, string> normalizedFields)
        {
            return settings.AddOAuthCredentials(normalizedFields);
        }

        /// <summary>
        /// Adds mutual authentication credentials to the provided settings.
        /// </summary>
        /// <param name="settings">The merchant credential settings to extend with mutual authentication credentials.</param>
        /// <param name="normalizedFields">A read-only dictionary containing normalized configuration fields for mutual authentication.</param>
        /// <returns>The updated settings with mutual authentication credentials added.</returns>
        public IMerchantCredentialSettings CreateMutualAuthSettings(IMerchantCredentialSettings settings, IReadOnlyDictionary<string, string> normalizedFields)
        {
            return settings.AddMutualAuthCredentials(normalizedFields);
        }
    }
}
