# CyberSource.Api.VoidApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MitVoid**](VoidApi.md#mitvoid) | **POST** /pts/v2/voids/ | Timeout Void
[**VoidCapture**](VoidApi.md#voidcapture) | **POST** /pts/v2/captures/{id}/voids | Void a Capture
[**VoidCredit**](VoidApi.md#voidcredit) | **POST** /pts/v2/credits/{id}/voids | Void a Credit
[**VoidPayment**](VoidApi.md#voidpayment) | **POST** /pts/v2/payments/{id}/voids | Void a Payment
[**VoidRefund**](VoidApi.md#voidrefund) | **POST** /pts/v2/refunds/{id}/voids | Void a Refund


<a name="mitvoid"></a>
# **MitVoid**
> PtsV2PaymentsVoidsPost201Response MitVoid (MitVoidRequest mitVoidRequest)

Timeout Void

This is to void a previous payment, capture, refund, or credit that merchant does not receive a reply(Mostly due to timeout). This is to void a previous payment, capture, refund, or credit that merchant does not receive a reply(Mostly due to Timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -> transactionId in your payment, capture, refund, or credit API call and use same transactionId in this API request payload to reverse the payment.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class MitVoidExample
    {
        public void main()
        {
            var apiInstance = new VoidApi();
            var mitVoidRequest = new MitVoidRequest(); // MitVoidRequest | 

            try
            {
                // Timeout Void
                PtsV2PaymentsVoidsPost201Response result = apiInstance.MitVoid(mitVoidRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoidApi.MitVoid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mitVoidRequest** | [**MitVoidRequest**](MitVoidRequest.md)|  | 

### Return type

[**PtsV2PaymentsVoidsPost201Response**](PtsV2PaymentsVoidsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voidcapture"></a>
# **VoidCapture**
> PtsV2PaymentsVoidsPost201Response VoidCapture (VoidCaptureRequest voidCaptureRequest, string id)

Void a Capture

Refund a capture API is only used, if you have requested Capture independenlty using [/pts/v2/payments/{id}/captures](https://developer.cybersource.com/api-reference-assets/index.html#payments_capture) API call. Include the capture ID in the POST request to cancel the capture. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class VoidCaptureExample
    {
        public void main()
        {
            var apiInstance = new VoidApi();
            var voidCaptureRequest = new VoidCaptureRequest(); // VoidCaptureRequest | 
            var id = id_example;  // string | The capture ID returned from a previous capture request.

            try
            {
                // Void a Capture
                PtsV2PaymentsVoidsPost201Response result = apiInstance.VoidCapture(voidCaptureRequest, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoidApi.VoidCapture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voidCaptureRequest** | [**VoidCaptureRequest**](VoidCaptureRequest.md)|  | 
 **id** | **string**| The capture ID returned from a previous capture request. | 

### Return type

[**PtsV2PaymentsVoidsPost201Response**](PtsV2PaymentsVoidsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voidcredit"></a>
# **VoidCredit**
> PtsV2PaymentsVoidsPost201Response VoidCredit (VoidCreditRequest voidCreditRequest, string id)

Void a Credit

Include the credit ID in the POST request to cancel the credit.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class VoidCreditExample
    {
        public void main()
        {
            var apiInstance = new VoidApi();
            var voidCreditRequest = new VoidCreditRequest(); // VoidCreditRequest | 
            var id = id_example;  // string | The credit ID returned from a previous credit request.

            try
            {
                // Void a Credit
                PtsV2PaymentsVoidsPost201Response result = apiInstance.VoidCredit(voidCreditRequest, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoidApi.VoidCredit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voidCreditRequest** | [**VoidCreditRequest**](VoidCreditRequest.md)|  | 
 **id** | **string**| The credit ID returned from a previous credit request. | 

### Return type

[**PtsV2PaymentsVoidsPost201Response**](PtsV2PaymentsVoidsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voidpayment"></a>
# **VoidPayment**
> PtsV2PaymentsVoidsPost201Response VoidPayment (VoidPaymentRequest voidPaymentRequest, string id)

Void a Payment

Void a Payment API is only used, if you have requested Authorization and Capture together in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call. Include the payment ID in the POST request to cancel the payment. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class VoidPaymentExample
    {
        public void main()
        {
            var apiInstance = new VoidApi();
            var voidPaymentRequest = new VoidPaymentRequest(); // VoidPaymentRequest | 
            var id = id_example;  // string | The payment ID returned from a previous payment request.

            try
            {
                // Void a Payment
                PtsV2PaymentsVoidsPost201Response result = apiInstance.VoidPayment(voidPaymentRequest, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoidApi.VoidPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voidPaymentRequest** | [**VoidPaymentRequest**](VoidPaymentRequest.md)|  | 
 **id** | **string**| The payment ID returned from a previous payment request. | 

### Return type

[**PtsV2PaymentsVoidsPost201Response**](PtsV2PaymentsVoidsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voidrefund"></a>
# **VoidRefund**
> PtsV2PaymentsVoidsPost201Response VoidRefund (VoidRefundRequest voidRefundRequest, string id)

Void a Refund

Include the refund ID in the POST request to cancel the refund.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class VoidRefundExample
    {
        public void main()
        {
            var apiInstance = new VoidApi();
            var voidRefundRequest = new VoidRefundRequest(); // VoidRefundRequest | 
            var id = id_example;  // string | The refund ID returned from a previous refund request.

            try
            {
                // Void a Refund
                PtsV2PaymentsVoidsPost201Response result = apiInstance.VoidRefund(voidRefundRequest, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoidApi.VoidRefund: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voidRefundRequest** | [**VoidRefundRequest**](VoidRefundRequest.md)|  | 
 **id** | **string**| The refund ID returned from a previous refund request. | 

### Return type

[**PtsV2PaymentsVoidsPost201Response**](PtsV2PaymentsVoidsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

