using AuthenticationSdk.core;
using AuthenticationSdk.util;
using System;
using CyberSource.Client;
using RestSharp;

namespace CyberSource.Utilities
{
    public static class ResponseMleHandler
    {
    /// <summary>
    /// Decrypts MLE encrypted response if applicable
    /// </summary>
    /// <param name="localVarResponse">The HTTP response</param>
    /// <param name="merchantConfig">Merchant configuration for decryption</param>
    public static void DecryptMleResponseIfNeeded(RestResponse localVarResponse, MerchantConfig merchantConfig)
    {
        if (MLEUtility.CheckIsMleEncryptedResponse(localVarResponse.Content))
        {
            if (merchantConfig == null)
            {
                throw new ApiException((int)localVarResponse.StatusCode, "merchantConfig cannot be null when decrypting MLE encrypted response.");
            }

            try
            {
                var decryptedContent = MLEUtility.DecryptMleResponsePayload(merchantConfig, localVarResponse.Content);
                localVarResponse.Content = decryptedContent;
            }
            catch (Exception e)
            {
                throw new ApiException((int)localVarResponse.StatusCode, e.Message);
            }
        }
    }
    }
}