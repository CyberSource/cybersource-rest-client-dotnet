using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVoidApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Void a Capture
        /// </summary>
        /// <remarks>
        /// Include the capture ID in the POST request to cancel the capture.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidCaptureRequest"></param>
        /// <param name="id">The capture ID returned from a previous capture request.</param>
        /// <returns>PtsV2PaymentsVoidsPost201Response</returns>
        PtsV2PaymentsVoidsPost201Response VoidCapture(VoidCaptureRequest voidCaptureRequest, string id);

        /// <summary>
        /// Void a Capture
        /// </summary>
        /// <remarks>
        /// Include the capture ID in the POST request to cancel the capture.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidCaptureRequest"></param>
        /// <param name="id">The capture ID returned from a previous capture request.</param>
        /// <returns>ApiResponse of PtsV2PaymentsVoidsPost201Response</returns>
        ApiResponse<PtsV2PaymentsVoidsPost201Response> VoidCaptureWithHttpInfo(VoidCaptureRequest voidCaptureRequest,
            string id);

        /// <summary>
        /// Void a Credit
        /// </summary>
        /// <remarks>
        /// Include the credit ID in the POST request to cancel the credit.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidCreditRequest"></param>
        /// <param name="id">The credit ID returned from a previous credit request.</param>
        /// <returns>PtsV2PaymentsVoidsPost201Response</returns>
        PtsV2PaymentsVoidsPost201Response VoidCredit(VoidCreditRequest voidCreditRequest, string id);

        /// <summary>
        /// Void a Credit
        /// </summary>
        /// <remarks>
        /// Include the credit ID in the POST request to cancel the credit.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidCreditRequest"></param>
        /// <param name="id">The credit ID returned from a previous credit request.</param>
        /// <returns>ApiResponse of PtsV2PaymentsVoidsPost201Response</returns>
        ApiResponse<PtsV2PaymentsVoidsPost201Response> VoidCreditWithHttpInfo(VoidCreditRequest voidCreditRequest,
            string id);

        /// <summary>
        /// Void a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to cancel the payment.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidPaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <returns>PtsV2PaymentsVoidsPost201Response</returns>
        PtsV2PaymentsVoidsPost201Response VoidPayment(VoidPaymentRequest voidPaymentRequest, string id);

        /// <summary>
        /// Void a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to cancel the payment.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidPaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <returns>ApiResponse of PtsV2PaymentsVoidsPost201Response</returns>
        ApiResponse<PtsV2PaymentsVoidsPost201Response> VoidPaymentWithHttpInfo(VoidPaymentRequest voidPaymentRequest,
            string id);

        /// <summary>
        /// Void a Refund
        /// </summary>
        /// <remarks>
        /// Include the refund ID in the POST request to cancel the refund.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidRefundRequest"></param>
        /// <param name="id">The refund ID returned from a previous refund request.</param>
        /// <returns>PtsV2PaymentsVoidsPost201Response</returns>
        PtsV2PaymentsVoidsPost201Response VoidRefund(VoidRefundRequest voidRefundRequest, string id);

        /// <summary>
        /// Void a Refund
        /// </summary>
        /// <remarks>
        /// Include the refund ID in the POST request to cancel the refund.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidRefundRequest"></param>
        /// <param name="id">The refund ID returned from a previous refund request.</param>
        /// <returns>ApiResponse of PtsV2PaymentsVoidsPost201Response</returns>
        ApiResponse<PtsV2PaymentsVoidsPost201Response> VoidRefundWithHttpInfo(VoidRefundRequest voidRefundRequest,
            string id);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Void a Capture
        /// </summary>
        /// <remarks>
        /// Include the capture ID in the POST request to cancel the capture.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidCaptureRequest"></param>
        /// <param name="id">The capture ID returned from a previous capture request.</param>
        /// <returns>Task of PtsV2PaymentsVoidsPost201Response</returns>
        Task<PtsV2PaymentsVoidsPost201Response> VoidCaptureAsync(
            VoidCaptureRequest voidCaptureRequest, string id);

        /// <summary>
        /// Void a Capture
        /// </summary>
        /// <remarks>
        /// Include the capture ID in the POST request to cancel the capture.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidCaptureRequest"></param>
        /// <param name="id">The capture ID returned from a previous capture request.</param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsVoidsPost201Response)</returns>
        Task<ApiResponse<PtsV2PaymentsVoidsPost201Response>> VoidCaptureAsyncWithHttpInfo(
            VoidCaptureRequest voidCaptureRequest, string id);

        /// <summary>
        /// Void a Credit
        /// </summary>
        /// <remarks>
        /// Include the credit ID in the POST request to cancel the credit.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidCreditRequest"></param>
        /// <param name="id">The credit ID returned from a previous credit request.</param>
        /// <returns>Task of PtsV2PaymentsVoidsPost201Response</returns>
        Task<PtsV2PaymentsVoidsPost201Response> VoidCreditAsync(
            VoidCreditRequest voidCreditRequest, string id);

        /// <summary>
        /// Void a Credit
        /// </summary>
        /// <remarks>
        /// Include the credit ID in the POST request to cancel the credit.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidCreditRequest"></param>
        /// <param name="id">The credit ID returned from a previous credit request.</param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsVoidsPost201Response)</returns>
        Task<ApiResponse<PtsV2PaymentsVoidsPost201Response>> VoidCreditAsyncWithHttpInfo(
            VoidCreditRequest voidCreditRequest, string id);

        /// <summary>
        /// Void a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to cancel the payment.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidPaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <returns>Task of PtsV2PaymentsVoidsPost201Response</returns>
        Task<PtsV2PaymentsVoidsPost201Response> VoidPaymentAsync(
            VoidPaymentRequest voidPaymentRequest, string id);

        /// <summary>
        /// Void a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to cancel the payment.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidPaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsVoidsPost201Response)</returns>
        Task<ApiResponse<PtsV2PaymentsVoidsPost201Response>> VoidPaymentAsyncWithHttpInfo(
            VoidPaymentRequest voidPaymentRequest, string id);

        /// <summary>
        /// Void a Refund
        /// </summary>
        /// <remarks>
        /// Include the refund ID in the POST request to cancel the refund.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidRefundRequest"></param>
        /// <param name="id">The refund ID returned from a previous refund request.</param>
        /// <returns>Task of PtsV2PaymentsVoidsPost201Response</returns>
        Task<PtsV2PaymentsVoidsPost201Response> VoidRefundAsync(
            VoidRefundRequest voidRefundRequest, string id);

        /// <summary>
        /// Void a Refund
        /// </summary>
        /// <remarks>
        /// Include the refund ID in the POST request to cancel the refund.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voidRefundRequest"></param>
        /// <param name="id">The refund ID returned from a previous refund request.</param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsVoidsPost201Response)</returns>
        Task<ApiResponse<PtsV2PaymentsVoidsPost201Response>> VoidRefundAsyncWithHttpInfo(
            VoidRefundRequest voidRefundRequest, string id);

        #endregion Asynchronous Operations
    }
}