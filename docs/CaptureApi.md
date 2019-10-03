# CyberSource.Api.CaptureApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CapturePayment**](CaptureApi.md#capturepayment) | **POST** /pts/v2/payments/{id}/captures | Capture a Payment


<a name="capturepayment"></a>
# **CapturePayment**
> PtsV2PaymentsCapturesPost201Response CapturePayment (CapturePaymentRequest capturePaymentRequest, string id)

Capture a Payment

Include the payment ID in the POST request to capture the payment amount.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CapturePaymentExample
    {
        public void main()
        {
            var apiInstance = new CaptureApi();
            var capturePaymentRequest = new CapturePaymentRequest(); // CapturePaymentRequest | 
            var id = id_example;  // string | The payment ID returned from a previous payment request. This ID links the capture to the payment. 

            try
            {
                // Capture a Payment
                PtsV2PaymentsCapturesPost201Response result = apiInstance.CapturePayment(capturePaymentRequest, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaptureApi.CapturePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **capturePaymentRequest** | [**CapturePaymentRequest**](CapturePaymentRequest.md)|  | 
 **id** | **string**| The payment ID returned from a previous payment request. This ID links the capture to the payment.  | 

### Return type

[**PtsV2PaymentsCapturesPost201Response**](PtsV2PaymentsCapturesPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

