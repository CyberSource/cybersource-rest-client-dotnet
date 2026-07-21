using AuthenticationSdk.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSource.Client
{
    /// <summary>
    /// Defines the contract for CyberSource SDK configuration settings.
    /// Exposes properties for accessing merchant credentials, MLE settings, network settings, and legacy configuration.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets the merchant credential settings containing authentication credentials for CyberSource API requests.
        /// Includes merchant ID, API keys, JWT configuration, OAuth tokens, and other authentication-related properties.
        /// </summary>
        IMerchantCredentialSettings MerchantCredentialSettings { get; }

        /// <summary>
        /// Gets the merchant MLE (Message Level Encryption) settings for request and response encryption.
        /// Contains configuration for enabling/disabling MLE, certificate paths, private keys, and API-level MLE control mappings.
        /// </summary>
        IMerchantMLESettings MerchantMLESettings { get; }

        /// <summary>
        /// Gets the merchant network settings for HTTP communication configuration.
        /// Includes proxy settings, SSL/TLS configuration, and other network-related properties.
        /// </summary>
        IMerchantNetworkSettings MerchantNetworkSettings { get; }

        /// <summary>
        /// Gets the merchant legacy settings for backward compatibility with older SDK versions.
        /// Contains HTTP headers, API keys, authentication tokens, timeout, and other legacy configuration properties.
        /// </summary>
        IMerchantLegacySettings MerchantLegacySettings { get; }
    }
}
