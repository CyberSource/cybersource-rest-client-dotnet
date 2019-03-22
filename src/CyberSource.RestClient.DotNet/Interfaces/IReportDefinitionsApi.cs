using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportDefinitionsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get report definition
        /// </summary>
        /// <remarks>
        /// View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ReportingV3ReportDefinitionsNameGet200Response</returns>
        ReportingV3ReportDefinitionsNameGet200Response GetResourceInfoByReportDefinition(string reportDefinitionName, string organizationId = null);

        /// <summary>
        /// Get report definition
        /// </summary>
        /// <remarks>
        /// View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of ReportingV3ReportDefinitionsNameGet200Response</returns>
        ApiResponse<ReportingV3ReportDefinitionsNameGet200Response> GetResourceInfoByReportDefinitionWithHttpInfo(string reportDefinitionName, string organizationId = null);

        /// <summary>
        /// Get reporting resource information
        /// </summary>
        /// <remarks>
        /// View a list of supported reports and their attributes before subscribing to them. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ReportingV3ReportDefinitionsGet200Response</returns>
        ReportingV3ReportDefinitionsGet200Response GetResourceV2Info(string organizationId = null);

        /// <summary>
        /// Get reporting resource information
        /// </summary>
        /// <remarks>
        /// View a list of supported reports and their attributes before subscribing to them. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of ReportingV3ReportDefinitionsGet200Response</returns>
        ApiResponse<ReportingV3ReportDefinitionsGet200Response> GetResourceV2InfoWithHttpInfo(string organizationId = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get report definition
        /// </summary>
        /// <remarks>
        /// View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ReportingV3ReportDefinitionsNameGet200Response</returns>
        Task<ReportingV3ReportDefinitionsNameGet200Response> GetResourceInfoByReportDefinitionAsync(string reportDefinitionName, string organizationId = null);

        /// <summary>
        /// Get report definition
        /// </summary>
        /// <remarks>
        /// View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3ReportDefinitionsNameGet200Response)</returns>
        Task<ApiResponse<ReportingV3ReportDefinitionsNameGet200Response>> GetResourceInfoByReportDefinitionAsyncWithHttpInfo(string reportDefinitionName, string organizationId = null);

        /// <summary>
        /// Get reporting resource information
        /// </summary>
        /// <remarks>
        /// View a list of supported reports and their attributes before subscribing to them. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ReportingV3ReportDefinitionsGet200Response</returns>
        Task<ReportingV3ReportDefinitionsGet200Response> GetResourceV2InfoAsync(string organizationId = null);

        /// <summary>
        /// Get reporting resource information
        /// </summary>
        /// <remarks>
        /// View a list of supported reports and their attributes before subscribing to them. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3ReportDefinitionsGet200Response)</returns>
        Task<ApiResponse<ReportingV3ReportDefinitionsGet200Response>> GetResourceV2InfoAsyncWithHttpInfo(string organizationId = null);

        #endregion Asynchronous Operations
    }
}