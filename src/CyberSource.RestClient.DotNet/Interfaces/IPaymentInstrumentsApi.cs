using System;
using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentInstrumentsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Retrieve all Payment Instruments associated with an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="offset">Starting Payment Instrument record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional)</param>
        /// <param name="limit">The maximum number of Payment Instruments that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional, default to 20)</param>
        /// <returns>TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response</returns>
        TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response
            TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGet(string profileId, string tokenId,
                string offset = null, string limit = null);

        /// <summary>
        /// Retrieve all Payment Instruments associated with an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="offset">Starting Payment Instrument record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional)</param>
        /// <param name="limit">The maximum number of Payment Instruments that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional, default to 20)</param>
        /// <returns>ApiResponse of TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response</returns>
        ApiResponse<TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response>
            TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGetWithHttpInfo(string profileId, string tokenId,
                string offset = null, string limit = null);

        /// <summary>
        /// Create a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="body">Please specify the customers payment details for card or bank account.</param>
        /// <returns>TmsV1PaymentinstrumentsPost201Response</returns>
        TmsV1PaymentinstrumentsPost201Response TmsV1PaymentinstrumentsPost(string profileId, Body2 body);

        /// <summary>
        /// Create a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="body">Please specify the customers payment details for card or bank account.</param>
        /// <returns>ApiResponse of TmsV1PaymentinstrumentsPost201Response</returns>
        ApiResponse<TmsV1PaymentinstrumentsPost201Response> TmsV1PaymentinstrumentsPostWithHttpInfo(string profileId,
            Body2 body);

        /// <summary>
        /// Delete a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns></returns>
        void TmsV1PaymentinstrumentsTokenIdDelete(string profileId, string tokenId);

        /// <summary>
        /// Delete a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TmsV1PaymentinstrumentsTokenIdDeleteWithHttpInfo(string profileId, string tokenId);

        /// <summary>
        /// Retrieve a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>TmsV1PaymentinstrumentsGet200Response</returns>
        TmsV1PaymentinstrumentsGet200Response TmsV1PaymentinstrumentsTokenIdGet(string profileId, string tokenId);

        /// <summary>
        /// Retrieve a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>ApiResponse of TmsV1PaymentinstrumentsGet200Response</returns>
        ApiResponse<TmsV1PaymentinstrumentsGet200Response> TmsV1PaymentinstrumentsTokenIdGetWithHttpInfo(
            string profileId, string tokenId);

        /// <summary>
        /// Update a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <param name="body">Please specify the customers payment details.</param>
        /// <returns>TmsV1PaymentinstrumentsGet200Response</returns>
        TmsV1PaymentinstrumentsGet200Response TmsV1PaymentinstrumentsTokenIdPatch(string profileId, string tokenId,
            Body3 body);

        /// <summary>
        /// Update a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <param name="body">Please specify the customers payment details.</param>
        /// <returns>ApiResponse of TmsV1PaymentinstrumentsGet200Response</returns>
        ApiResponse<TmsV1PaymentinstrumentsGet200Response> TmsV1PaymentinstrumentsTokenIdPatchWithHttpInfo(
            string profileId, string tokenId, Body3 body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Retrieve all Payment Instruments associated with an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="offset">Starting Payment Instrument record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional)</param>
        /// <param name="limit">The maximum number of Payment Instruments that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional, default to 20)</param>
        /// <returns>Task of TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response</returns>
        Task<TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response>
            TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGetAsync(string profileId, string tokenId,
                string offset = null, string limit = null);

        /// <summary>
        /// Retrieve all Payment Instruments associated with an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="offset">Starting Payment Instrument record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional)</param>
        /// <param name="limit">The maximum number of Payment Instruments that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response)</returns>
        Task<ApiResponse<TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response>>
            TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGetAsyncWithHttpInfo(string profileId, string tokenId,
                string offset = null, string limit = null);

        /// <summary>
        /// Create a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="body">Please specify the customers payment details for card or bank account.</param>
        /// <returns>Task of TmsV1PaymentinstrumentsPost201Response</returns>
        Task<TmsV1PaymentinstrumentsPost201Response> TmsV1PaymentinstrumentsPostAsync(
            string profileId, Body2 body);

        /// <summary>
        /// Create a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="body">Please specify the customers payment details for card or bank account.</param>
        /// <returns>Task of ApiResponse (TmsV1PaymentinstrumentsPost201Response)</returns>
        Task<ApiResponse<TmsV1PaymentinstrumentsPost201Response>>
            TmsV1PaymentinstrumentsPostAsyncWithHttpInfo(string profileId, Body2 body);

        /// <summary>
        /// Delete a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>Task of void</returns>
        Task TmsV1PaymentinstrumentsTokenIdDeleteAsync(string profileId, string tokenId);

        /// <summary>
        /// Delete a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> TmsV1PaymentinstrumentsTokenIdDeleteAsyncWithHttpInfo(
            string profileId, string tokenId);

        /// <summary>
        /// Retrieve a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>Task of TmsV1PaymentinstrumentsGet200Response</returns>
        Task<TmsV1PaymentinstrumentsGet200Response> TmsV1PaymentinstrumentsTokenIdGetAsync(
            string profileId, string tokenId);

        /// <summary>
        /// Retrieve a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>Task of ApiResponse (TmsV1PaymentinstrumentsGet200Response)</returns>
        Task<ApiResponse<TmsV1PaymentinstrumentsGet200Response>>
            TmsV1PaymentinstrumentsTokenIdGetAsyncWithHttpInfo(string profileId, string tokenId);

        /// <summary>
        /// Update a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <param name="body">Please specify the customers payment details.</param>
        /// <returns>Task of TmsV1PaymentinstrumentsGet200Response</returns>
        Task<TmsV1PaymentinstrumentsGet200Response> TmsV1PaymentinstrumentsTokenIdPatchAsync(
            string profileId, string tokenId, Body3 body);

        /// <summary>
        /// Update a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <param name="body">Please specify the customers payment details.</param>
        /// <returns>Task of ApiResponse (TmsV1PaymentinstrumentsGet200Response)</returns>
        Task<ApiResponse<TmsV1PaymentinstrumentsGet200Response>>
            TmsV1PaymentinstrumentsTokenIdPatchAsyncWithHttpInfo(string profileId, string tokenId, Body3 body);

        #endregion Asynchronous Operations
    }
}