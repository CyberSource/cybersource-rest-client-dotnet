using System;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPurchaseAndRefundDetailsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get Purchase and Refund details
        /// </summary>
        /// <remarks>
        /// Download the Purchase and Refund Details report. This report report includes all purchases and refund transactions, as well as all activities related to transactions resulting in an adjustment to the net proceeds. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="paymentSubtype">Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional, default to ALL)</param>
        /// <param name="viewBy">View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional, default to requestDate)</param>
        /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional)</param>
        /// <param name="offset">Offset of the Purchase and Refund Results. (optional)</param>
        /// <param name="limit">Results count per page. Range(1-2000) (optional, default to 2000)</param>
        /// <returns>ReportingV3PurchaseRefundDetailsGet200Response</returns>
        ReportingV3PurchaseRefundDetailsGet200Response GetPurchaseAndRefundDetails(DateTime? startTime,
            DateTime? endTime, string organizationId = null, string paymentSubtype = null, string viewBy = null,
            string groupName = null, int? offset = null, int? limit = null);

        /// <summary>
        /// Get Purchase and Refund details
        /// </summary>
        /// <remarks>
        /// Download the Purchase and Refund Details report. This report report includes all purchases and refund transactions, as well as all activities related to transactions resulting in an adjustment to the net proceeds. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="paymentSubtype">Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional, default to ALL)</param>
        /// <param name="viewBy">View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional, default to requestDate)</param>
        /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional)</param>
        /// <param name="offset">Offset of the Purchase and Refund Results. (optional)</param>
        /// <param name="limit">Results count per page. Range(1-2000) (optional, default to 2000)</param>
        /// <returns>ApiResponse of ReportingV3PurchaseRefundDetailsGet200Response</returns>
        ApiResponse<ReportingV3PurchaseRefundDetailsGet200Response> GetPurchaseAndRefundDetailsWithHttpInfo(
            DateTime? startTime, DateTime? endTime, string organizationId = null, string paymentSubtype = null,
            string viewBy = null, string groupName = null, int? offset = null, int? limit = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get Purchase and Refund details
        /// </summary>
        /// <remarks>
        /// Download the Purchase and Refund Details report. This report report includes all purchases and refund transactions, as well as all activities related to transactions resulting in an adjustment to the net proceeds. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="paymentSubtype">Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional, default to ALL)</param>
        /// <param name="viewBy">View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional, default to requestDate)</param>
        /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional)</param>
        /// <param name="offset">Offset of the Purchase and Refund Results. (optional)</param>
        /// <param name="limit">Results count per page. Range(1-2000) (optional, default to 2000)</param>
        /// <returns>Task of ReportingV3PurchaseRefundDetailsGet200Response</returns>
        System.Threading.Tasks.Task<ReportingV3PurchaseRefundDetailsGet200Response> GetPurchaseAndRefundDetailsAsync(
            DateTime? startTime, DateTime? endTime, string organizationId = null, string paymentSubtype = null,
            string viewBy = null, string groupName = null, int? offset = null, int? limit = null);

        /// <summary>
        /// Get Purchase and Refund details
        /// </summary>
        /// <remarks>
        /// Download the Purchase and Refund Details report. This report report includes all purchases and refund transactions, as well as all activities related to transactions resulting in an adjustment to the net proceeds. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="paymentSubtype">Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional, default to ALL)</param>
        /// <param name="viewBy">View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional, default to requestDate)</param>
        /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional)</param>
        /// <param name="offset">Offset of the Purchase and Refund Results. (optional)</param>
        /// <param name="limit">Results count per page. Range(1-2000) (optional, default to 2000)</param>
        /// <returns>Task of ApiResponse (ReportingV3PurchaseRefundDetailsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportingV3PurchaseRefundDetailsGet200Response>>
            GetPurchaseAndRefundDetailsAsyncWithHttpInfo(DateTime? startTime, DateTime? endTime,
                string organizationId = null, string paymentSubtype = null, string viewBy = null,
                string groupName = null, int? offset = null, int? limit = null);

        #endregion Asynchronous Operations
    }
}