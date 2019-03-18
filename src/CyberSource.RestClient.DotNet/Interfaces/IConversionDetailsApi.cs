using System;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConversionDetailsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get conversion detail transactions
        /// </summary>
        /// <remarks>
        /// Get conversion detail of transactions for a merchant.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ReportingV3ConversionDetailsGet200Response</returns>
        ReportingV3ConversionDetailsGet200Response GetConversionDetail(DateTime? startTime, DateTime? endTime,
            string organizationId = null);

        /// <summary>
        /// Get conversion detail transactions
        /// </summary>
        /// <remarks>
        /// Get conversion detail of transactions for a merchant.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of ReportingV3ConversionDetailsGet200Response</returns>
        ApiResponse<ReportingV3ConversionDetailsGet200Response> GetConversionDetailWithHttpInfo(DateTime? startTime,
            DateTime? endTime, string organizationId = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get conversion detail transactions
        /// </summary>
        /// <remarks>
        /// Get conversion detail of transactions for a merchant.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ReportingV3ConversionDetailsGet200Response</returns>
        System.Threading.Tasks.Task<ReportingV3ConversionDetailsGet200Response> GetConversionDetailAsync(
            DateTime? startTime, DateTime? endTime, string organizationId = null);

        /// <summary>
        /// Get conversion detail transactions
        /// </summary>
        /// <remarks>
        /// Get conversion detail of transactions for a merchant.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3ConversionDetailsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportingV3ConversionDetailsGet200Response>>
            GetConversionDetailAsyncWithHttpInfo(DateTime? startTime, DateTime? endTime, string organizationId = null);

        #endregion Asynchronous Operations
    }
}