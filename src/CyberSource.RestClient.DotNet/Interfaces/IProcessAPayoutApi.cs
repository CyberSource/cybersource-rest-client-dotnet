using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProcessAPayoutApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Process a Payout
        /// </summary>
        /// <remarks>
        /// Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="octCreatePaymentRequest"></param>
        /// <returns>PtsV2PayoutsPost201Response</returns>
        PtsV2PayoutsPost201Response OctCreatePayment(PtsV2PayoutsPostResponse octCreatePaymentRequest);

        /// <summary>
        /// Process a Payout
        /// </summary>
        /// <remarks>
        /// Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="octCreatePaymentRequest"></param>
        /// <returns>ApiResponse of PtsV2PayoutsPost201Response</returns>
        ApiResponse<PtsV2PayoutsPost201Response> OctCreatePaymentWithHttpInfo(
            PtsV2PayoutsPostResponse octCreatePaymentRequest);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Process a Payout
        /// </summary>
        /// <remarks>
        /// Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="octCreatePaymentRequest"></param>
        /// <returns>Task of PtsV2PayoutsPost201Response</returns>
        System.Threading.Tasks.Task<PtsV2PayoutsPost201Response> OctCreatePaymentAsync(
            PtsV2PayoutsPostResponse octCreatePaymentRequest);

        /// <summary>
        /// Process a Payout
        /// </summary>
        /// <remarks>
        /// Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="octCreatePaymentRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PayoutsPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2PayoutsPost201Response>> OctCreatePaymentAsyncWithHttpInfo(
            PtsV2PayoutsPostResponse octCreatePaymentRequest);

        #endregion Asynchronous Operations
    }
}