using AuthenticationSdk.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSource.Client
{
    /// <summary>
    /// Defines methods for mutating an IConfiguration instance by adding merchant authentication and encryption settings.
    /// This internal interface extends IConfiguration and provides write access to configuration settings.
    /// </summary>
    internal interface IMutableConfiguration : IConfiguration
    {
        /// <summary>
        /// Adds merchant credential settings to the configuration.
        /// </summary>
        /// <param name="merchantCredentialSettings">The merchant credential settings to add, containing authentication details such as API keys, tokens, or certificates.</param>
        void AddMerchantCredentialSettings(IMerchantCredentialSettings merchantCredentialSettings);

        /// <summary>
        /// Adds Message Level Encryption (MLE) settings to the configuration.
        /// </summary>
        /// <param name="merchantMLESettings">The merchant MLE settings to add, containing encryption configuration for request and response MLE.</param>
        void AddMLESettings(IMerchantMLESettings merchantMLESettings);
    }
}
