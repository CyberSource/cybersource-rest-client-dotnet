using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReversalApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Process an Authorization Reversal
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to reverse the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>PtsV2PaymentsReversalsPost201Response</returns>
        PtsV2PaymentsReversalsPost201Response AuthReversal(string id, AuthReversalRequest authReversalRequest);

        /// <summary>
        /// Process an Authorization Reversal
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to reverse the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>ApiResponse of PtsV2PaymentsReversalsPost201Response</returns>
        ApiResponse<PtsV2PaymentsReversalsPost201Response> AuthReversalWithHttpInfo(string id,
            AuthReversalRequest authReversalRequest);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Process an Authorization Reversal
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to reverse the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>Task of PtsV2PaymentsReversalsPost201Response</returns>
        Task<PtsV2PaymentsReversalsPost201Response> AuthReversalAsync(string id,
            AuthReversalRequest authReversalRequest);

        /// <summary>
        /// Process an Authorization Reversal
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to reverse the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsReversalsPost201Response)</returns>
        Task<ApiResponse<PtsV2PaymentsReversalsPost201Response>> AuthReversalAsyncWithHttpInfo(
            string id, AuthReversalRequest authReversalRequest);

        #endregion Asynchronous Operations
    }
}