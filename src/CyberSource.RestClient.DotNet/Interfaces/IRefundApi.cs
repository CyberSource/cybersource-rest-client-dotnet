using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRefundApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Refund a Capture
        /// </summary>
        /// <remarks>
        /// Include the capture ID in the POST request to refund the captured amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>PtsV2PaymentsRefundPost201Response</returns>
        PtsV2PaymentsRefundPost201Response RefundCapture(RefundCaptureRequest refundCaptureRequest, string id);

        /// <summary>
        /// Refund a Capture
        /// </summary>
        /// <remarks>
        /// Include the capture ID in the POST request to refund the captured amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>ApiResponse of PtsV2PaymentsRefundPost201Response</returns>
        ApiResponse<PtsV2PaymentsRefundPost201Response> RefundCaptureWithHttpInfo(
            RefundCaptureRequest refundCaptureRequest, string id);

        /// <summary>
        /// Refund a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to refund the payment amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>PtsV2PaymentsRefundPost201Response</returns>
        PtsV2PaymentsRefundPost201Response RefundPayment(RefundPaymentRequest refundPaymentRequest, string id);

        /// <summary>
        /// Refund a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to refund the payment amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>ApiResponse of PtsV2PaymentsRefundPost201Response</returns>
        ApiResponse<PtsV2PaymentsRefundPost201Response> RefundPaymentWithHttpInfo(
            RefundPaymentRequest refundPaymentRequest, string id);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Refund a Capture
        /// </summary>
        /// <remarks>
        /// Include the capture ID in the POST request to refund the captured amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>Task of PtsV2PaymentsRefundPost201Response</returns>
        Task<PtsV2PaymentsRefundPost201Response> RefundCaptureAsync(
            RefundCaptureRequest refundCaptureRequest, string id);

        /// <summary>
        /// Refund a Capture
        /// </summary>
        /// <remarks>
        /// Include the capture ID in the POST request to refund the captured amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsRefundPost201Response)</returns>
        Task<ApiResponse<PtsV2PaymentsRefundPost201Response>> RefundCaptureAsyncWithHttpInfo(
            RefundCaptureRequest refundCaptureRequest, string id);

        /// <summary>
        /// Refund a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to refund the payment amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>Task of PtsV2PaymentsRefundPost201Response</returns>
        Task<PtsV2PaymentsRefundPost201Response> RefundPaymentAsync(
            RefundPaymentRequest refundPaymentRequest, string id);

        /// <summary>
        /// Refund a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to refund the payment amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsRefundPost201Response)</returns>
        Task<ApiResponse<PtsV2PaymentsRefundPost201Response>> RefundPaymentAsyncWithHttpInfo(
            RefundPaymentRequest refundPaymentRequest, string id);

        #endregion Asynchronous Operations
    }
}