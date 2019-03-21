using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionDetailsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Retrieve a Transaction
        /// </summary>
        /// <remarks>
        /// Include the Request ID in the GET request to retrieve the transaction details.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Request ID. </param>
        /// <returns>TssV2TransactionsGet200Response</returns>
        TssV2TransactionsGet200Response GetTransaction(string id);

        /// <summary>
        /// Retrieve a Transaction
        /// </summary>
        /// <remarks>
        /// Include the Request ID in the GET request to retrieve the transaction details.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Request ID. </param>
        /// <returns>ApiResponse of TssV2TransactionsGet200Response</returns>
        ApiResponse<TssV2TransactionsGet200Response> GetTransactionWithHttpInfo(string id);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Retrieve a Transaction
        /// </summary>
        /// <remarks>
        /// Include the Request ID in the GET request to retrieve the transaction details.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Request ID. </param>
        /// <returns>Task of TssV2TransactionsGet200Response</returns>
        Task<TssV2TransactionsGet200Response> GetTransactionAsync(string id);

        /// <summary>
        /// Retrieve a Transaction
        /// </summary>
        /// <remarks>
        /// Include the Request ID in the GET request to retrieve the transaction details.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Request ID. </param>
        /// <returns>Task of ApiResponse (TssV2TransactionsGet200Response)</returns>
        Task<ApiResponse<TssV2TransactionsGet200Response>>
            GetTransactionAsyncWithHttpInfo(string id);

        #endregion Asynchronous Operations
    }
}