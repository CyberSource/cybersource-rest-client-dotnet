using AuthenticationSdk.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSource.Client
{
    /// <summary>
    /// Defines the contract for a factory that creates merchant request settings instances.
    /// Responsible for instantiating IMerchantRequestSettings from request-related parameters.
    /// </summary>
    public interface IMerchantRequestSettingsFactory
    {
        /// <summary>
        /// Creates an instance of IMerchantRequestSettings from request parameters.
        /// </summary>
        /// <param name="requestMethod">The type of HTTP request method (e.g., POST, PUT, GET, PATCH, DELETE).</param>
        /// <param name="requestTarget">The target endpoint or URI path for the CyberSource API request.</param>
        /// <param name="requestJsonData">The JSON-formatted request payload data to be sent in the request body.</param>
        /// <returns>An IMerchantRequestSettings instance containing the specified request configuration.</returns>
        public IMerchantRequestSettings Create(string requestMethod, string requestTarget, string requestJsonData);
    }

    /// <summary>
    /// Factory implementation for creating merchant request settings instances.
    /// Constructs request configuration objects from request parameters.
    /// </summary>
    public class MerchantRequestSettingsFactory : IMerchantRequestSettingsFactory
    {
        /// <summary>
        /// Creates an instance of IMerchantRequestSettings from request parameters.
        /// Initializes a new MerchantRequestSettings instance with the specified request configuration.
        /// </summary>
        /// <param name="requestMethod">The type of HTTP request method (e.g., POST, PUT, GET, PATCH, DELETE).</param>
        /// <param name="requestTarget">The target endpoint or URI path for the CyberSource API request.</param>
        /// <param name="requestJsonData">The JSON-formatted request payload data to be sent in the request body.</param>
        /// <returns>An IMerchantRequestSettings instance containing the specified request configuration.</returns>
        public IMerchantRequestSettings Create(string requestMethod, string requestTarget, string requestJsonData)
        {
            return new MerchantRequestSettings(requestMethod, requestTarget, requestJsonData);
        }
    }
}
