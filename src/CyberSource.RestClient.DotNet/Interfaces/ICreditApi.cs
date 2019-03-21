using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICreditApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Process a Credit
        /// </summary>
        /// <remarks>
        /// POST to the credit resource to credit funds to a specified credit card.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCreditRequest"></param>
        /// <returns>PtsV2CreditsPost201Response</returns>
        PtsV2CreditsPost201Response CreateCredit(CreateCreditRequest createCreditRequest);

        /// <summary>
        /// Process a Credit
        /// </summary>
        /// <remarks>
        /// POST to the credit resource to credit funds to a specified credit card.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCreditRequest"></param>
        /// <returns>ApiResponse of PtsV2CreditsPost201Response</returns>
        ApiResponse<PtsV2CreditsPost201Response> CreateCreditWithHttpInfo(CreateCreditRequest createCreditRequest);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Process a Credit
        /// </summary>
        /// <remarks>
        /// POST to the credit resource to credit funds to a specified credit card.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCreditRequest"></param>
        /// <returns>Task of PtsV2CreditsPost201Response</returns>
        Task<PtsV2CreditsPost201Response> CreateCreditAsync(
            CreateCreditRequest createCreditRequest);

        /// <summary>
        /// Process a Credit
        /// </summary>
        /// <remarks>
        /// POST to the credit resource to credit funds to a specified credit card.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createCreditRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2CreditsPost201Response)</returns>
        Task<ApiResponse<PtsV2CreditsPost201Response>> CreateCreditAsyncWithHttpInfo(
            CreateCreditRequest createCreditRequest);

        #endregion Asynchronous Operations
    }
}