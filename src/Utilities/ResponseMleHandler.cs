using AuthenticationSdk.core;
using AuthenticationSdk.util;
using System;
using System.Net.Http;
using System.Text;
using CyberSource.Client;
using Microsoft.Extensions.Logging;

namespace CyberSource.Utilities
{
    public static class ResponseMleHandler
    {
        /// <summary>
        /// Decrypts MLE encrypted response if applicable. The content string is mutated in place
        /// via <paramref name="content"/>, and, when provided, <paramref name="response"/> is
        /// updated to carry the decrypted body so downstream consumers reading
        /// <see cref="HttpResponseMessage.Content"/> observe the decrypted payload.
        /// </summary>
        /// <param name="response">The HTTP response</param>
        /// <param name="content">The string that will contain the decrypted response message</param>
        /// <param name="merchantConfig">Merchant configuration for decryption</param>
        /// <param name="loggerFactory">Optional logger factory for logging.</param>
        public static void DecryptMleResponseIfNeeded(HttpResponseMessage response, ref string content, MerchantConfig merchantConfig, ILoggerFactory loggerFactory = null)
        {
            if (MLEUtility.CheckIsMleEncryptedResponse(content))
            {
                int statusCode = response != null ? (int)response.StatusCode : 0;
                if (merchantConfig == null)
                {
                    throw new ApiException(statusCode, "merchantConfig cannot be null when decrypting MLE encrypted response.");
                }

                try
                {
                    content = MLEUtility.DecryptMleResponsePayload(merchantConfig, content, loggerFactory);
                    ReplaceContent(response, content);
                }
                catch (Exception e)
                {
                    throw new ApiException(statusCode, e.Message);
                }
            }
        }

        #region NEW METHODS
        /// <summary>
        /// Decrypts MLE encrypted response if applicable using merchant credential / MLE settings.
        /// </summary>
        /// <param name="response">The HTTP response</param>
        /// <param name="content">The string that will contain the decrypted response message</param>
        /// <param name="merchantCredentialSettings">Object of IMerchantCredentialSettings containing merchant credentials</param>
        /// <param name="merchantMLESettings">Object of IMerchantMLESettings containing merchant MLE credentials</param>
        /// <param name="loggerFactory">Optional logger factory for logging.</param>
        public static void DecryptMleResponseIfNeeded(HttpResponseMessage response, ref string content, IMerchantCredentialSettings merchantCredentialSettings, IMerchantMLESettings merchantMLESettings, ILoggerFactory loggerFactory = null)
        {
            if (MLEUtility.CheckIsMleEncryptedResponse(content))
            {
                int statusCode = response != null ? (int)response.StatusCode : 0;
                if (merchantMLESettings == null)
                {
                    throw new ApiException(statusCode, "Merchant MLE Settings cannot be null when decrypting MLE encrypted response.");
                }

                try
                {
                    content = MLEUtility.DecryptMleResponsePayload(merchantCredentialSettings, merchantMLESettings, content, loggerFactory);
                    ReplaceContent(response, content);
                }
                catch (Exception e)
                {
                    throw new ApiException(statusCode, e.Message);
                }
            }
        }

        private static void ReplaceContent(HttpResponseMessage response, string content)
        {
            if (response == null) { return; }
            // Preserve the original media type when possible so downstream consumers that inspect
            // Content.Headers.ContentType keep observing the same value they would have before MLE
            // decryption ran.
            var originalMediaType = response.Content?.Headers?.ContentType?.MediaType ?? "application/json";
            response.Content?.Dispose();
            response.Content = new StringContent(content ?? string.Empty, Encoding.UTF8, originalMediaType);
        }
        #endregion
    }
}
