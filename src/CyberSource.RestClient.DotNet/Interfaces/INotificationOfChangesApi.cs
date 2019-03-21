using System;
using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INotificationOfChangesApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get Notification Of Changes
        /// </summary>
        /// <remarks>
        /// Download the Notification of Change report. This report shows eCheck-related fields updated as a result of a response to an eCheck settlement transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <returns>ReportingV3NotificationofChangesGet200Response</returns>
        ReportingV3NotificationofChangesGet200Response GetNotificationOfChangeReport(DateTime? startTime,
            DateTime? endTime);

        /// <summary>
        /// Get Notification Of Changes
        /// </summary>
        /// <remarks>
        /// Download the Notification of Change report. This report shows eCheck-related fields updated as a result of a response to an eCheck settlement transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <returns>ApiResponse of ReportingV3NotificationofChangesGet200Response</returns>
        ApiResponse<ReportingV3NotificationofChangesGet200Response> GetNotificationOfChangeReportWithHttpInfo(
            DateTime? startTime, DateTime? endTime);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get Notification Of Changes
        /// </summary>
        /// <remarks>
        /// Download the Notification of Change report. This report shows eCheck-related fields updated as a result of a response to an eCheck settlement transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <returns>Task of ReportingV3NotificationofChangesGet200Response</returns>
        Task<ReportingV3NotificationofChangesGet200Response> GetNotificationOfChangeReportAsync(
            DateTime? startTime, DateTime? endTime);

        /// <summary>
        /// Get Notification Of Changes
        /// </summary>
        /// <remarks>
        /// Download the Notification of Change report. This report shows eCheck-related fields updated as a result of a response to an eCheck settlement transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <returns>Task of ApiResponse (ReportingV3NotificationofChangesGet200Response)</returns>
        Task<ApiResponse<ReportingV3NotificationofChangesGet200Response>>
            GetNotificationOfChangeReportAsyncWithHttpInfo(DateTime? startTime, DateTime? endTime);

        #endregion Asynchronous Operations
    }
}