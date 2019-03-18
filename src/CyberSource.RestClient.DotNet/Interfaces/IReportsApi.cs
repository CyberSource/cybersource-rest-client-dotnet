using System;
using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Create Adhoc Report
        /// </summary>
        /// <remarks>
        /// Create a one-time report. You must specify the type of report in reportDefinitionName. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation) 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Report subscription request payload</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns></returns>
        void CreateReport(RequestBody requestBody, string organizationId = null);

        /// <summary>
        /// Create Adhoc Report
        /// </summary>
        /// <remarks>
        /// Create a one-time report. You must specify the type of report in reportDefinitionName. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation) 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Report subscription request payload</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateReportWithHttpInfo(RequestBody requestBody, string organizationId = null);

        /// <summary>
        /// Get Report based on reportId
        /// </summary>
        /// <remarks>
        /// Download a report using the reportId value. If you don’t already know this value, you can obtain it using the Retrieve available reports call. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Valid Report Id</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ReportingV3ReportsIdGet200Response</returns>
        ReportingV3ReportsIdGet200Response GetReportByReportId(string reportId, string organizationId = null);

        /// <summary>
        /// Get Report based on reportId
        /// </summary>
        /// <remarks>
        /// Download a report using the reportId value. If you don’t already know this value, you can obtain it using the Retrieve available reports call. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Valid Report Id</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of ReportingV3ReportsIdGet200Response</returns>
        ApiResponse<ReportingV3ReportsIdGet200Response> GetReportByReportIdWithHttpInfo(string reportId,
            string organizationId = null);

        /// <summary>
        /// Retrieve available reports
        /// </summary>
        /// <remarks>
        /// Retrieve a list of the available reports to which you are subscribed. This will also give you the reportId value, which you can also use to download a report. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="timeQueryType">Specify time you would like to search</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="reportMimeType">Valid Report Format (optional)</param>
        /// <param name="reportFrequency">Valid Report Frequency (optional)</param>
        /// <param name="reportName">Valid Report Name (optional)</param>
        /// <param name="reportDefinitionId">Valid Report Definition Id (optional)</param>
        /// <param name="reportStatus">Valid Report Status (optional)</param>
        /// <returns>ReportingV3ReportsGet200Response</returns>
        ReportingV3ReportsGet200Response SearchReports(DateTime? startTime, DateTime? endTime, string timeQueryType,
            string organizationId = null, string reportMimeType = null, string reportFrequency = null,
            string reportName = null, int? reportDefinitionId = null, string reportStatus = null);

        /// <summary>
        /// Retrieve available reports
        /// </summary>
        /// <remarks>
        /// Retrieve a list of the available reports to which you are subscribed. This will also give you the reportId value, which you can also use to download a report. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="timeQueryType">Specify time you would like to search</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="reportMimeType">Valid Report Format (optional)</param>
        /// <param name="reportFrequency">Valid Report Frequency (optional)</param>
        /// <param name="reportName">Valid Report Name (optional)</param>
        /// <param name="reportDefinitionId">Valid Report Definition Id (optional)</param>
        /// <param name="reportStatus">Valid Report Status (optional)</param>
        /// <returns>ApiResponse of ReportingV3ReportsGet200Response</returns>
        ApiResponse<ReportingV3ReportsGet200Response> SearchReportsWithHttpInfo(DateTime? startTime, DateTime? endTime,
            string timeQueryType, string organizationId = null, string reportMimeType = null,
            string reportFrequency = null, string reportName = null, int? reportDefinitionId = null,
            string reportStatus = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Create Adhoc Report
        /// </summary>
        /// <remarks>
        /// Create a one-time report. You must specify the type of report in reportDefinitionName. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation) 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Report subscription request payload</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of void</returns>
        Task CreateReportAsync(RequestBody requestBody, string organizationId = null);

        /// <summary>
        /// Create Adhoc Report
        /// </summary>
        /// <remarks>
        /// Create a one-time report. You must specify the type of report in reportDefinitionName. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation) 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Report subscription request payload</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> CreateReportAsyncWithHttpInfo(RequestBody requestBody,
            string organizationId = null);

        /// <summary>
        /// Get Report based on reportId
        /// </summary>
        /// <remarks>
        /// Download a report using the reportId value. If you don’t already know this value, you can obtain it using the Retrieve available reports call. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Valid Report Id</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ReportingV3ReportsIdGet200Response</returns>
        Task<ReportingV3ReportsIdGet200Response> GetReportByReportIdAsync(string reportId,
            string organizationId = null);

        /// <summary>
        /// Get Report based on reportId
        /// </summary>
        /// <remarks>
        /// Download a report using the reportId value. If you don’t already know this value, you can obtain it using the Retrieve available reports call. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Valid Report Id</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3ReportsIdGet200Response)</returns>
        Task<ApiResponse<ReportingV3ReportsIdGet200Response>>
            GetReportByReportIdAsyncWithHttpInfo(string reportId, string organizationId = null);

        /// <summary>
        /// Retrieve available reports
        /// </summary>
        /// <remarks>
        /// Retrieve a list of the available reports to which you are subscribed. This will also give you the reportId value, which you can also use to download a report. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="timeQueryType">Specify time you would like to search</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="reportMimeType">Valid Report Format (optional)</param>
        /// <param name="reportFrequency">Valid Report Frequency (optional)</param>
        /// <param name="reportName">Valid Report Name (optional)</param>
        /// <param name="reportDefinitionId">Valid Report Definition Id (optional)</param>
        /// <param name="reportStatus">Valid Report Status (optional)</param>
        /// <returns>Task of ReportingV3ReportsGet200Response</returns>
        Task<ReportingV3ReportsGet200Response> SearchReportsAsync(DateTime? startTime,
            DateTime? endTime, string timeQueryType, string organizationId = null, string reportMimeType = null,
            string reportFrequency = null, string reportName = null, int? reportDefinitionId = null,
            string reportStatus = null);

        /// <summary>
        /// Retrieve available reports
        /// </summary>
        /// <remarks>
        /// Retrieve a list of the available reports to which you are subscribed. This will also give you the reportId value, which you can also use to download a report. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="timeQueryType">Specify time you would like to search</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="reportMimeType">Valid Report Format (optional)</param>
        /// <param name="reportFrequency">Valid Report Frequency (optional)</param>
        /// <param name="reportName">Valid Report Name (optional)</param>
        /// <param name="reportDefinitionId">Valid Report Definition Id (optional)</param>
        /// <param name="reportStatus">Valid Report Status (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3ReportsGet200Response)</returns>
        Task<ApiResponse<ReportingV3ReportsGet200Response>> SearchReportsAsyncWithHttpInfo(
            DateTime? startTime, DateTime? endTime, string timeQueryType, string organizationId = null,
            string reportMimeType = null, string reportFrequency = null, string reportName = null,
            int? reportDefinitionId = null, string reportStatus = null);

        #endregion Asynchronous Operations
    }
}