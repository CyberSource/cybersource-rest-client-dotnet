using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IKeyGenerationApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Generate Key
        /// </summary>
        /// <remarks>
        /// Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generatePublicKeyRequest"> (optional)</param>
        /// <returns>FlexV1KeysPost200Response</returns>
        FlexV1KeysPost200Response GeneratePublicKey(GeneratePublicKeyRequest generatePublicKeyRequest = null);

        /// <summary>
        /// Generate Key
        /// </summary>
        /// <remarks>
        /// Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generatePublicKeyRequest"> (optional)</param>
        /// <returns>ApiResponse of FlexV1KeysPost200Response</returns>
        ApiResponse<FlexV1KeysPost200Response> GeneratePublicKeyWithHttpInfo(
            GeneratePublicKeyRequest generatePublicKeyRequest = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Generate Key
        /// </summary>
        /// <remarks>
        /// Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generatePublicKeyRequest"> (optional)</param>
        /// <returns>Task of FlexV1KeysPost200Response</returns>
        System.Threading.Tasks.Task<FlexV1KeysPost200Response> GeneratePublicKeyAsync(
            GeneratePublicKeyRequest generatePublicKeyRequest = null);

        /// <summary>
        /// Generate Key
        /// </summary>
        /// <remarks>
        /// Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generatePublicKeyRequest"> (optional)</param>
        /// <returns>Task of ApiResponse (FlexV1KeysPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlexV1KeysPost200Response>> GeneratePublicKeyAsyncWithHttpInfo(
            GeneratePublicKeyRequest generatePublicKeyRequest = null);

        #endregion Asynchronous Operations
    }
}