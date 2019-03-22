using System;
using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecureFileShareApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Download a file with file identifier
        /// </summary>
        /// <remarks>
        /// Download a file for the given file identifier
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">Unique identifier for each file</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns></returns>
        object GetFile(string fileId, string organizationId = null);

        /// <summary>
        /// Download a file with file identifier
        /// </summary>
        /// <remarks>
        /// Download a file for the given file identifier
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">Unique identifier for each file</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetFileWithHttpInfo(string fileId, string organizationId = null);

        /// <summary>
        /// Get list of files
        /// </summary>
        /// <remarks>
        /// Get list of files and it&#39;s information of them available inside the report directory
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="endDate">Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>V1FileDetailsGet200Response</returns>
        V1FileDetailsGet200Response GetFileDetails(DateTime? startDate, DateTime? endDate, string organizationId = null);

        /// <summary>
        /// Get list of files
        /// </summary>
        /// <remarks>
        /// Get list of files and it&#39;s information of them available inside the report directory
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="endDate">Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of V1FileDetailsGet200Response</returns>
        ApiResponse<V1FileDetailsGet200Response> GetFileDetailsWithHttpInfo(DateTime? startDate, DateTime? endDate, string organizationId = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Download a file with file identifier
        /// </summary>
        /// <remarks>
        /// Download a file for the given file identifier
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">Unique identifier for each file</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of void</returns>
        Task<object> GetFileAsync(string fileId, string organizationId = null);

        /// <summary>
        /// Download a file with file identifier
        /// </summary>
        /// <remarks>
        /// Download a file for the given file identifier
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">Unique identifier for each file</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> GetFileAsyncWithHttpInfo(string fileId, string organizationId = null);

        /// <summary>
        /// Get list of files
        /// </summary>
        /// <remarks>
        /// Get list of files and it&#39;s information of them available inside the report directory
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="endDate">Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of V1FileDetailsGet200Response</returns>
        Task<V1FileDetailsGet200Response> GetFileDetailsAsync(DateTime? startDate, DateTime? endDate, string organizationId = null);

        /// <summary>
        /// Get list of files
        /// </summary>
        /// <remarks>
        /// Get list of files and it&#39;s information of them available inside the report directory
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="endDate">Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (V1FileDetailsGet200Response)</returns>
        Task<ApiResponse<V1FileDetailsGet200Response>> GetFileDetailsAsyncWithHttpInfo(DateTime? startDate, DateTime? endDate, string organizationId = null);

        #endregion Asynchronous Operations
    }
}