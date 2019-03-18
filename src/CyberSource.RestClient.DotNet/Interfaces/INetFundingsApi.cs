using System;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INetFundingsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get Netfunding information for an account or a merchant
        /// </summary>
        /// <remarks>
        /// Get Netfunding information for an account or a merchant.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="groupName">Valid CyberSource Group Name. (optional)</param>
        /// <returns>ReportingV3NetFundingsGet200Response</returns>
        ReportingV3NetFundingsGet200Response GetNetFundingInfo(DateTime? startTime, DateTime? endTime,
            string organizationId = null, string groupName = null);

        /// <summary>
        /// Get Netfunding information for an account or a merchant
        /// </summary>
        /// <remarks>
        /// Get Netfunding information for an account or a merchant.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="groupName">Valid CyberSource Group Name. (optional)</param>
        /// <returns>ApiResponse of ReportingV3NetFundingsGet200Response</returns>
        ApiResponse<ReportingV3NetFundingsGet200Response> GetNetFundingInfoWithHttpInfo(DateTime? startTime,
            DateTime? endTime, string organizationId = null, string groupName = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get Netfunding information for an account or a merchant
        /// </summary>
        /// <remarks>
        /// Get Netfunding information for an account or a merchant.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="groupName">Valid CyberSource Group Name. (optional)</param>
        /// <returns>Task of ReportingV3NetFundingsGet200Response</returns>
        System.Threading.Tasks.Task<ReportingV3NetFundingsGet200Response> GetNetFundingInfoAsync(DateTime? startTime,
            DateTime? endTime, string organizationId = null, string groupName = null);

        /// <summary>
        /// Get Netfunding information for an account or a merchant
        /// </summary>
        /// <remarks>
        /// Get Netfunding information for an account or a merchant.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="groupName">Valid CyberSource Group Name. (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3NetFundingsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportingV3NetFundingsGet200Response>>
            GetNetFundingInfoAsyncWithHttpInfo(DateTime? startTime, DateTime? endTime, string organizationId = null,
                string groupName = null);

        #endregion Asynchronous Operations
    }
}