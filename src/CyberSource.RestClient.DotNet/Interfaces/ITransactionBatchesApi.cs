using System;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionBatchesApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get individual batch file
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The batch id assigned for the template.</param>
        /// <returns>PtsV1TransactionBatchesIdGet200Response</returns>
        PtsV1TransactionBatchesIdGet200Response GetTransactionBatchId(string id);

        /// <summary>
        /// Get individual batch file
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The batch id assigned for the template.</param>
        /// <returns>ApiResponse of PtsV1TransactionBatchesIdGet200Response</returns>
        ApiResponse<PtsV1TransactionBatchesIdGet200Response> GetTransactionBatchIdWithHttpInfo(string id);

        /// <summary>
        /// Get a list of batch files
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <returns>PtsV1TransactionBatchesGet200Response</returns>
        PtsV1TransactionBatchesGet200Response GetTransactionBatches(DateTime? startTime, DateTime? endTime);

        /// <summary>
        /// Get a list of batch files
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <returns>ApiResponse of PtsV1TransactionBatchesGet200Response</returns>
        ApiResponse<PtsV1TransactionBatchesGet200Response> GetTransactionBatchesWithHttpInfo(DateTime? startTime,
            DateTime? endTime);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get individual batch file
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The batch id assigned for the template.</param>
        /// <returns>Task of PtsV1TransactionBatchesIdGet200Response</returns>
        System.Threading.Tasks.Task<PtsV1TransactionBatchesIdGet200Response> GetTransactionBatchIdAsync(string id);

        /// <summary>
        /// Get individual batch file
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The batch id assigned for the template.</param>
        /// <returns>Task of ApiResponse (PtsV1TransactionBatchesIdGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV1TransactionBatchesIdGet200Response>>
            GetTransactionBatchIdAsyncWithHttpInfo(string id);

        /// <summary>
        /// Get a list of batch files
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <returns>Task of PtsV1TransactionBatchesGet200Response</returns>
        System.Threading.Tasks.Task<PtsV1TransactionBatchesGet200Response> GetTransactionBatchesAsync(
            DateTime? startTime, DateTime? endTime);

        /// <summary>
        /// Get a list of batch files
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <returns>Task of ApiResponse (PtsV1TransactionBatchesGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV1TransactionBatchesGet200Response>>
            GetTransactionBatchesAsyncWithHttpInfo(DateTime? startTime, DateTime? endTime);

        #endregion Asynchronous Operations
    }
}