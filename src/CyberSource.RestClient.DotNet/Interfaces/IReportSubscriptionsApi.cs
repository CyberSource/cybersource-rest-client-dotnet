using System;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportSubscriptionsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Create Report Subscription for a report name by organization
        /// </summary>
        /// <remarks>
        /// Create a report subscription for your organization. The report name must be unique. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Report subscription request payload</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns></returns>
        void CreateSubscription(RequestBody1 requestBody, string organizationId = null);

        /// <summary>
        /// Create Report Subscription for a report name by organization
        /// </summary>
        /// <remarks>
        /// Create a report subscription for your organization. The report name must be unique. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Report subscription request payload</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateSubscriptionWithHttpInfo(RequestBody1 requestBody, string organizationId = null);

        /// <summary>
        /// Delete subscription of a report name by organization
        /// </summary>
        /// <remarks>
        /// Delete a report subscription for your organization. You must know the unique name of the report you want to delete. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportName">Name of the Report to Delete</param>
        /// <returns></returns>
        void DeleteSubscription(string reportName);

        /// <summary>
        /// Delete subscription of a report name by organization
        /// </summary>
        /// <remarks>
        /// Delete a report subscription for your organization. You must know the unique name of the report you want to delete. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportName">Name of the Report to Delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteSubscriptionWithHttpInfo(string reportName);

        /// <summary>
        /// Get all subscriptions
        /// </summary>
        /// <remarks>
        /// View a summary of all report subscriptions. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ReportingV3ReportSubscriptionsGet200Response</returns>
        ReportingV3ReportSubscriptionsGet200Response GetAllSubscriptions();

        /// <summary>
        /// Get all subscriptions
        /// </summary>
        /// <remarks>
        /// View a summary of all report subscriptions. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ReportingV3ReportSubscriptionsGet200Response</returns>
        ApiResponse<ReportingV3ReportSubscriptionsGet200Response> GetAllSubscriptionsWithHttpInfo();

        /// <summary>
        /// Get subscription for report name
        /// </summary>
        /// <remarks>
        /// View the details of a report subscription, such as the report format or report frequency, using the report’s unique name. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportName">Name of the Report to Retrieve</param>
        /// <returns>ReportingV3ReportSubscriptionsGet200ResponseSubscriptions</returns>
        ReportingV3ReportSubscriptionsGet200ResponseSubscriptions GetSubscription(string reportName);

        /// <summary>
        /// Get subscription for report name
        /// </summary>
        /// <remarks>
        /// View the details of a report subscription, such as the report format or report frequency, using the report’s unique name. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportName">Name of the Report to Retrieve</param>
        /// <returns>ApiResponse of ReportingV3ReportSubscriptionsGet200ResponseSubscriptions</returns>
        ApiResponse<ReportingV3ReportSubscriptionsGet200ResponseSubscriptions> GetSubscriptionWithHttpInfo(
            string reportName);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Create Report Subscription for a report name by organization
        /// </summary>
        /// <remarks>
        /// Create a report subscription for your organization. The report name must be unique. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Report subscription request payload</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateSubscriptionAsync(RequestBody1 requestBody, string organizationId = null);

        /// <summary>
        /// Create Report Subscription for a report name by organization
        /// </summary>
        /// <remarks>
        /// Create a report subscription for your organization. The report name must be unique. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Report subscription request payload</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateSubscriptionAsyncWithHttpInfo(RequestBody1 requestBody,
            string organizationId = null);

        /// <summary>
        /// Delete subscription of a report name by organization
        /// </summary>
        /// <remarks>
        /// Delete a report subscription for your organization. You must know the unique name of the report you want to delete. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportName">Name of the Report to Delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteSubscriptionAsync(string reportName);

        /// <summary>
        /// Delete subscription of a report name by organization
        /// </summary>
        /// <remarks>
        /// Delete a report subscription for your organization. You must know the unique name of the report you want to delete. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportName">Name of the Report to Delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSubscriptionAsyncWithHttpInfo(string reportName);

        /// <summary>
        /// Get all subscriptions
        /// </summary>
        /// <remarks>
        /// View a summary of all report subscriptions. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ReportingV3ReportSubscriptionsGet200Response</returns>
        System.Threading.Tasks.Task<ReportingV3ReportSubscriptionsGet200Response> GetAllSubscriptionsAsync();

        /// <summary>
        /// Get all subscriptions
        /// </summary>
        /// <remarks>
        /// View a summary of all report subscriptions. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ReportingV3ReportSubscriptionsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportingV3ReportSubscriptionsGet200Response>>
            GetAllSubscriptionsAsyncWithHttpInfo();

        /// <summary>
        /// Get subscription for report name
        /// </summary>
        /// <remarks>
        /// View the details of a report subscription, such as the report format or report frequency, using the report’s unique name. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportName">Name of the Report to Retrieve</param>
        /// <returns>Task of ReportingV3ReportSubscriptionsGet200ResponseSubscriptions</returns>
        System.Threading.Tasks.Task<ReportingV3ReportSubscriptionsGet200ResponseSubscriptions> GetSubscriptionAsync(
            string reportName);

        /// <summary>
        /// Get subscription for report name
        /// </summary>
        /// <remarks>
        /// View the details of a report subscription, such as the report format or report frequency, using the report’s unique name. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportName">Name of the Report to Retrieve</param>
        /// <returns>Task of ApiResponse (ReportingV3ReportSubscriptionsGet200ResponseSubscriptions)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportingV3ReportSubscriptionsGet200ResponseSubscriptions>>
            GetSubscriptionAsyncWithHttpInfo(string reportName);

        #endregion Asynchronous Operations
    }
}