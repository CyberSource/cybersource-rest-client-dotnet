# CyberSource.Api.RefundApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RefundCapture**](RefundApi.md#refundcapture) | **POST** /pts/v2/captures/{id}/refunds | Refund a Capture
[**RefundPayment**](RefundApi.md#refundpayment) | **POST** /pts/v2/payments/{id}/refunds | Refund a Payment


<a name="refundcapture"></a>
# **RefundCapture**
> PtsV2PaymentsRefundPost201Response RefundCapture (RefundCaptureRequest refundCaptureRequest, string id)

Refund a Capture

Refund a capture API is only used, if you have requested Capture independenlty using [/pts/v2/payments/{id}/captures](https://developer.cybersource.com/api-reference-assets/index.html#payments_capture) API call. Include the capture ID in the POST request to refund the captured amount. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class RefundCaptureExample
    {
        public void main()
        {
            var apiInstance = new RefundApi();
            var refundCaptureRequest = new RefundCaptureRequest(); // RefundCaptureRequest | 
            var id = id_example;  // string | The capture ID. This ID is returned from a previous capture request.

            try
            {
                // Refund a Capture
                PtsV2PaymentsRefundPost201Response result = apiInstance.RefundCapture(refundCaptureRequest, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundApi.RefundCapture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **refundCaptureRequest** | [**RefundCaptureRequest**](RefundCaptureRequest.md)|  | 
 **id** | **string**| The capture ID. This ID is returned from a previous capture request. | 

### Return type

[**PtsV2PaymentsRefundPost201Response**](PtsV2PaymentsRefundPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refundpayment"></a>
# **RefundPayment**
> PtsV2PaymentsRefundPost201Response RefundPayment (RefundPaymentRequest refundPaymentRequest, string id)

Refund a Payment

Refund a Payment API is only used, if you have requested Authorization and Capture together in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call. Include the payment ID in the POST request to refund the payment amount. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class RefundPaymentExample
    {
        public void main()
        {
            var apiInstance = new RefundApi();
            var refundPaymentRequest = new RefundPaymentRequest(); // RefundPaymentRequest | 
            var id = id_example;  // string | The payment ID. This ID is returned from a previous payment request.

            try
            {
                // Refund a Payment
                PtsV2PaymentsRefundPost201Response result = apiInstance.RefundPayment(refundPaymentRequest, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundApi.RefundPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **refundPaymentRequest** | [**RefundPaymentRequest**](RefundPaymentRequest.md)|  | 
 **id** | **string**| The payment ID. This ID is returned from a previous payment request. | 

### Return type

[**PtsV2PaymentsRefundPost201Response**](PtsV2PaymentsRefundPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

