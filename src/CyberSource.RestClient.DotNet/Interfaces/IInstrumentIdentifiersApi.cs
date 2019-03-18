using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInstrumentIdentifiersApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Create an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="body">Please specify either a Card or Bank Account.</param>
        /// <returns>TmsV1InstrumentidentifiersPost200Response</returns>
        TmsV1InstrumentidentifiersPost200Response TmsV1InstrumentidentifiersPost(string profileId, Body body);

        /// <summary>
        /// Create an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="body">Please specify either a Card or Bank Account.</param>
        /// <returns>ApiResponse of TmsV1InstrumentidentifiersPost200Response</returns>
        ApiResponse<TmsV1InstrumentidentifiersPost200Response> TmsV1InstrumentidentifiersPostWithHttpInfo(
            string profileId, Body body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Create an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="body">Please specify either a Card or Bank Account.</param>
        /// <returns>Task of TmsV1InstrumentidentifiersPost200Response</returns>
        System.Threading.Tasks.Task<TmsV1InstrumentidentifiersPost200Response> TmsV1InstrumentidentifiersPostAsync(
            string profileId, Body body);

        /// <summary>
        /// Create an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="body">Please specify either a Card or Bank Account.</param>
        /// <returns>Task of ApiResponse (TmsV1InstrumentidentifiersPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TmsV1InstrumentidentifiersPost200Response>>
            TmsV1InstrumentidentifiersPostAsyncWithHttpInfo(string profileId, Body body);

        #endregion Asynchronous Operations
    }
}