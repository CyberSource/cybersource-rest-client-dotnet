using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSource.Client
{
    /// <summary>
    /// Provides extension methods for configuring merchant authentication credentials on an IConfiguration instance.
    /// These methods allow fluent configuration of different authentication mechanisms including HTTP Signature, JWT, OAuth, and Mutual Auth.
    /// </summary>
    public static class ConfigurationAuthenticationExtensions
    {
        /// <summary>
        /// Adds HTTP Signature authentication credentials to the configuration.
        /// Creates merchant credential settings for HTTP Signature authentication and adds them to the mutable configuration.
        /// </summary>
        /// <param name="configuration">The configuration instance to add HTTP Signature credentials to. Must implement IMutableConfiguration.</param>
        /// <param name="configurationDictionary">A dictionary containing HTTP Signature authentication configuration values including merchant secret key and merchant key ID.</param>
        /// <returns>The same configuration instance for method chaining.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configuration or configurationDictionary is null.</exception>
        /// <exception cref="ArgumentException">Thrown when configuration does not implement IMutableConfiguration.</exception>
        public static IConfiguration AddHttpSignatureCredentials(this IConfiguration configuration, IReadOnlyDictionary<string, string> configurationDictionary)
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

            MerchantCredentialSettingsProcessor processor = new MerchantCredentialSettingsProcessor(
                    new MerchantCredentialSettingsFactory(),
                    new MerchantCredentialSettingsValidator());

            var newMerchantHttpCredentials = processor.CreateHttpSignatureSettings(configurationDictionary);

            mutable.AddMerchantCredentialSettings(newMerchantHttpCredentials);

            return configuration;
        }

        /// <summary>
        /// Adds JWT (JSON Web Token) authentication credentials to the configuration.
        /// Creates merchant credential settings for JWT authentication and adds them to the mutable configuration.
        /// </summary>
        /// <param name="configuration">The configuration instance to add JWT credentials to. Must implement IMutableConfiguration.</param>
        /// <param name="configurationDictionary">A dictionary containing JWT authentication configuration values including keys directory, key filename, key password, and key alias.</param>
        /// <returns>The same configuration instance for method chaining.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configuration or configurationDictionary is null.</exception>
        /// <exception cref="ArgumentException">Thrown when configuration does not implement IMutableConfiguration.</exception>
        public static IConfiguration AddJwtCredentials(this IConfiguration configuration, IReadOnlyDictionary<string, string> configurationDictionary)
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
                throw new ArgumentException("Configuration must be mutable to add JWT credentials.", nameof(configuration));
            }

            MerchantCredentialSettingsProcessor processor = new MerchantCredentialSettingsProcessor(
                    new MerchantCredentialSettingsFactory(),
                    new MerchantCredentialSettingsValidator());

            var newMerchantJwtCredentials = processor.CreateJwtSettings(configurationDictionary);

            mutable.AddMerchantCredentialSettings(newMerchantJwtCredentials);

            return configuration;
        }

        /// <summary>
        /// Adds OAuth authentication credentials to the configuration.
        /// Creates merchant credential settings for OAuth authentication and adds them to the mutable configuration.
        /// </summary>
        /// <param name="configuration">The configuration instance to add OAuth credentials to. Must implement IMutableConfiguration.</param>
        /// <param name="configurationDictionary">A dictionary containing OAuth authentication configuration values including access token and refresh token.</param>
        /// <returns>The same configuration instance for method chaining.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configuration or configurationDictionary is null.</exception>
        /// <exception cref="ArgumentException">Thrown when configuration does not implement IMutableConfiguration.</exception>
        public static IConfiguration AddOAuthCredentials(this IConfiguration configuration, IReadOnlyDictionary<string, string> configurationDictionary)
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
                throw new ArgumentException("Configuration must be mutable to add OAuth credentials.", nameof(configuration));
            }

            MerchantCredentialSettingsProcessor processor = new MerchantCredentialSettingsProcessor(
                    new MerchantCredentialSettingsFactory(),
                    new MerchantCredentialSettingsValidator());

            var newMerchantOAuthCredentials = processor.CreateOAuthSettings(configurationDictionary);

            mutable.AddMerchantCredentialSettings(newMerchantOAuthCredentials);

            return configuration;
        }

        /// <summary>
        /// Adds Mutual Auth authentication credentials to the configuration.
        /// Creates merchant credential settings for Mutual Auth authentication and adds them to the mutable configuration.
        /// </summary>
        /// <param name="configuration">The configuration instance to add Mutual Auth credentials to. Must implement IMutableConfiguration.</param>
        /// <param name="configurationDictionary">A dictionary containing Mutual Auth authentication configuration values including client ID and client secret.</param>
        /// <returns>The same configuration instance for method chaining.</returns>
        /// <exception cref="ArgumentNullException">Thrown when configuration or configurationDictionary is null.</exception>
        /// <exception cref="ArgumentException">Thrown when configuration does not implement IMutableConfiguration.</exception>
        public static IConfiguration AddMutualAuthCredentials(this IConfiguration configuration, IReadOnlyDictionary<string, string> configurationDictionary)
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
                throw new ArgumentException("Configuration must be mutable to add MutualAuth credentials.", nameof(configuration));
            }

            MerchantCredentialSettingsProcessor processor = new MerchantCredentialSettingsProcessor(
                    new MerchantCredentialSettingsFactory(),
                    new MerchantCredentialSettingsValidator());

            var newMerchantMutualAuthCredentials = processor.CreateMutualAuthSettings(configurationDictionary);

            mutable.AddMerchantCredentialSettings(newMerchantMutualAuthCredentials);

            return configuration;
        }
    }
}
