using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICaptureApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Capture a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to capture the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>PtsV2PaymentsCapturesPost201Response</returns>
        PtsV2PaymentsCapturesPost201Response CapturePayment(CapturePaymentRequest capturePaymentRequest, string id);

        /// <summary>
        /// Capture a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to capture the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>ApiResponse of PtsV2PaymentsCapturesPost201Response</returns>
        ApiResponse<PtsV2PaymentsCapturesPost201Response> CapturePaymentWithHttpInfo(
            CapturePaymentRequest capturePaymentRequest, string id);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Capture a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to capture the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>Task of PtsV2PaymentsCapturesPost201Response</returns>
        System.Threading.Tasks.Task<PtsV2PaymentsCapturesPost201Response> CapturePaymentAsync(
            CapturePaymentRequest capturePaymentRequest, string id);

        /// <summary>
        /// Capture a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to capture the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsCapturesPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsCapturesPost201Response>> CapturePaymentAsyncWithHttpInfo(
            CapturePaymentRequest capturePaymentRequest, string id);

        #endregion Asynchronous Operations
    }
}