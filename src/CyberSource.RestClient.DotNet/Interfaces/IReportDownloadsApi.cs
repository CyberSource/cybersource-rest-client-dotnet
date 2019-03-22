using System;
using System.Threading.Tasks;
using CyberSource.Client;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportDownloadsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Download a report
        /// </summary>
        /// <remarks>
        /// Download a report using the unique report name and date. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns></returns>
        object DownloadReport(DateTime? reportDate, string reportName, string organizationId = null);

        /// <summary>
        /// Download a report
        /// </summary>
        /// <remarks>
        /// Download a report using the unique report name and date. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DownloadReportWithHttpInfo(DateTime? reportDate, string reportName, string organizationId = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Download a report
        /// </summary>
        /// <remarks>
        /// Download a report using the unique report name and date. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of void</returns>
        Task<object> DownloadReportAsync(DateTime? reportDate, string reportName, string organizationId = null);

        /// <summary>
        /// Download a report
        /// </summary>
        /// <remarks>
        /// Download a report using the unique report name and date. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> DownloadReportAsyncWithHttpInfo(DateTime? reportDate, string reportName, string organizationId = null);

        #endregion Asynchronous Operations
    }
}