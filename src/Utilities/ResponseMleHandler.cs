using AuthenticationSdk.core;
using AuthenticationSdk.util;
using System;
using CyberSource.Client;
using RestSharp;
using Microsoft.Extensions.Logging;

namespace CyberSource.Utilities
{
    public static class ResponseMleHandler
    {
        /// <summary>
        /// Decrypts MLE encrypted response if applicable
        /// </summary>
        /// <param name="localVarResponse">The HTTP response</param>
        /// <param name="merchantConfig">Merchant configuration for decryption</param>
        /// <param name="loggerFactory">Optional logger factory for logging.</param>
        public static void DecryptMleResponseIfNeeded(RestResponse localVarResponse, MerchantConfig merchantConfig, ILoggerFactory loggerFactory = null)
        {
            if (MLEUtility.CheckIsMleEncryptedResponse(localVarResponse.Content))
            {
                if (merchantConfig == null)
                {
                    throw new ApiException((int)localVarResponse.StatusCode, "merchantConfig cannot be null when decrypting MLE encrypted response.");
                }
            
                try
                {
                    var decryptedContent = MLEUtility.DecryptMleResponsePayload(merchantConfig, localVarResponse.Content, loggerFactory);
                    localVarResponse.Content = decryptedContent;
                }
                catch (Exception e)
                {
                    throw new ApiException((int)localVarResponse.StatusCode, e.Message);
                }
            }
        }

        #region NEW METHODS
        /// <summary>
        /// Decrypts MLE encrypted response if applicable
        /// </summary>
        /// <param name="localVarResponse">The HTTP response</param>
        /// <param name="merchantCredentialSettings">Object of IMerchantCredentialSettings containing merchant credentials</param>
        /// <param name="merchantMLESettings">Object of IMerchantMLESettings containing merchant MLE credentials</param>
        /// <param name="loggerFactory">Optional logger factory for logging.</param>
        public static void DecryptMleResponseIfNeeded(RestResponse localVarResponse, IMerchantCredentialSettings merchantCredentialSettings, IMerchantMLESettings merchantMLESettings, ILoggerFactory loggerFactory = null)
        {
            if (MLEUtility.CheckIsMleEncryptedResponse(localVarResponse.Content))
            {
                if (merchantMLESettings == null)
                {
                    throw new ApiException((int)localVarResponse.StatusCode, "Merchant MLE Settings cannot be null when decrypting MLE encrypted response.");
                }

                try
                {
                    var decryptedContent = MLEUtility.DecryptMleResponsePayload(merchantCredentialSettings, merchantMLESettings, localVarResponse.Content, loggerFactory);
                    localVarResponse.Content = decryptedContent;
                }
                catch (Exception e)
                {
                    throw new ApiException((int)localVarResponse.StatusCode, e.Message);
                }
            }
        }
        #endregion
    }
}
