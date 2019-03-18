using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFlexTokenApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Flex Tokenize card
        /// </summary>
        /// <remarks>
        /// Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenizeRequest"> (optional)</param>
        /// <returns>FlexV1TokensPost200Response</returns>
        FlexV1TokensPost200Response Tokenize(TokenizeRequest tokenizeRequest = null);

        /// <summary>
        /// Flex Tokenize card
        /// </summary>
        /// <remarks>
        /// Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenizeRequest"> (optional)</param>
        /// <returns>ApiResponse of FlexV1TokensPost200Response</returns>
        ApiResponse<FlexV1TokensPost200Response> TokenizeWithHttpInfo(TokenizeRequest tokenizeRequest = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Flex Tokenize card
        /// </summary>
        /// <remarks>
        /// Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenizeRequest"> (optional)</param>
        /// <returns>Task of FlexV1TokensPost200Response</returns>
        System.Threading.Tasks.Task<FlexV1TokensPost200Response> TokenizeAsync(TokenizeRequest tokenizeRequest = null);

        /// <summary>
        /// Flex Tokenize card
        /// </summary>
        /// <remarks>
        /// Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenizeRequest"> (optional)</param>
        /// <returns>Task of ApiResponse (FlexV1TokensPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlexV1TokensPost200Response>> TokenizeAsyncWithHttpInfo(
            TokenizeRequest tokenizeRequest = null);

        #endregion Asynchronous Operations
    }
}