using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchTransactionsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Create a search request
        /// </summary>
        /// <remarks>
        /// Create a search request. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>TssV2TransactionsPost201Response</returns>
        TssV2TransactionsPost201Response CreateSearch(TssV2TransactionsPostResponse createSearchRequest);

        /// <summary>
        /// Create a search request
        /// </summary>
        /// <remarks>
        /// Create a search request. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>ApiResponse of TssV2TransactionsPost201Response</returns>
        ApiResponse<TssV2TransactionsPost201Response> CreateSearchWithHttpInfo(
            TssV2TransactionsPostResponse createSearchRequest);

        /// <summary>
        /// Get Search results
        /// </summary>
        /// <remarks>
        /// Include the Search ID in the GET request to retrieve the search results.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Search ID.</param>
        /// <returns>TssV2TransactionsPost201Response</returns>
        TssV2TransactionsPost201Response GetSearch(string id);

        /// <summary>
        /// Get Search results
        /// </summary>
        /// <remarks>
        /// Include the Search ID in the GET request to retrieve the search results.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Search ID.</param>
        /// <returns>ApiResponse of TssV2TransactionsPost201Response</returns>
        ApiResponse<TssV2TransactionsPost201Response> GetSearchWithHttpInfo(string id);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Create a search request
        /// </summary>
        /// <remarks>
        /// Create a search request. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>Task of TssV2TransactionsPost201Response</returns>
        Task<TssV2TransactionsPost201Response> CreateSearchAsync(
            TssV2TransactionsPostResponse createSearchRequest);

        /// <summary>
        /// Create a search request
        /// </summary>
        /// <remarks>
        /// Create a search request. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>Task of ApiResponse (TssV2TransactionsPost201Response)</returns>
        Task<ApiResponse<TssV2TransactionsPost201Response>> CreateSearchAsyncWithHttpInfo(
            TssV2TransactionsPostResponse createSearchRequest);

        /// <summary>
        /// Get Search results
        /// </summary>
        /// <remarks>
        /// Include the Search ID in the GET request to retrieve the search results.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Search ID.</param>
        /// <returns>Task of TssV2TransactionsPost201Response</returns>
        Task<TssV2TransactionsPost201Response> GetSearchAsync(string id);

        /// <summary>
        /// Get Search results
        /// </summary>
        /// <remarks>
        /// Include the Search ID in the GET request to retrieve the search results.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Search ID.</param>
        /// <returns>Task of ApiResponse (TssV2TransactionsPost201Response)</returns>
        Task<ApiResponse<TssV2TransactionsPost201Response>>
            GetSearchAsyncWithHttpInfo(string id);

        #endregion Asynchronous Operations
    }
}