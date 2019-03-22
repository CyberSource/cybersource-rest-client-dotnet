using System;
using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInstrumentIdentifierApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Delete an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns></returns>
        void TmsV1InstrumentidentifiersTokenIdDelete(string profileId, string tokenId);

        /// <summary>
        /// Delete an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TmsV1InstrumentidentifiersTokenIdDeleteWithHttpInfo(string profileId, string tokenId);

        /// <summary>
        /// Retrieve an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>TmsV1InstrumentidentifiersPost200Response</returns>
        TmsV1InstrumentidentifiersPost200Response
            TmsV1InstrumentidentifiersTokenIdGet(string profileId, string tokenId);

        /// <summary>
        /// Retrieve an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>ApiResponse of TmsV1InstrumentidentifiersPost200Response</returns>
        ApiResponse<TmsV1InstrumentidentifiersPost200Response> TmsV1InstrumentidentifiersTokenIdGetWithHttpInfo(
            string profileId, string tokenId);

        /// <summary>
        /// Update a Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="body">Please specify the previous transaction Id to update.</param>
        /// <returns>TmsV1InstrumentidentifiersPost200Response</returns>
        TmsV1InstrumentidentifiersPost200Response TmsV1InstrumentidentifiersTokenIdPatch(string profileId,
            string tokenId, Body1 body);

        /// <summary>
        /// Update a Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="body">Please specify the previous transaction Id to update.</param>
        /// <returns>ApiResponse of TmsV1InstrumentidentifiersPost200Response</returns>
        ApiResponse<TmsV1InstrumentidentifiersPost200Response> TmsV1InstrumentidentifiersTokenIdPatchWithHttpInfo(
            string profileId, string tokenId, Body1 body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Delete an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>Task of void</returns>
        Task TmsV1InstrumentidentifiersTokenIdDeleteAsync(string profileId, string tokenId);

        /// <summary>
        /// Delete an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> TmsV1InstrumentidentifiersTokenIdDeleteAsyncWithHttpInfo(
            string profileId, string tokenId);

        /// <summary>
        /// Retrieve an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>Task of TmsV1InstrumentidentifiersPost200Response</returns>
        Task<TmsV1InstrumentidentifiersPost200Response>
            TmsV1InstrumentidentifiersTokenIdGetAsync(string profileId, string tokenId);

        /// <summary>
        /// Retrieve an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>Task of ApiResponse (TmsV1InstrumentidentifiersPost200Response)</returns>
        Task<ApiResponse<TmsV1InstrumentidentifiersPost200Response>>
            TmsV1InstrumentidentifiersTokenIdGetAsyncWithHttpInfo(string profileId, string tokenId);

        /// <summary>
        /// Update a Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="body">Please specify the previous transaction Id to update.</param>
        /// <returns>Task of TmsV1InstrumentidentifiersPost200Response</returns>
        Task<TmsV1InstrumentidentifiersPost200Response>
            TmsV1InstrumentidentifiersTokenIdPatchAsync(string profileId, string tokenId, Body1 body);

        /// <summary>
        /// Update a Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="body">Please specify the previous transaction Id to update.</param>
        /// <returns>Task of ApiResponse (TmsV1InstrumentidentifiersPost200Response)</returns>
        Task<ApiResponse<TmsV1InstrumentidentifiersPost200Response>>
            TmsV1InstrumentidentifiersTokenIdPatchAsyncWithHttpInfo(string profileId, string tokenId, Body1 body);

        #endregion Asynchronous Operations
    }
}