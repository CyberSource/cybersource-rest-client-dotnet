# CyberSource.Api.PaymentsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePayment**](PaymentsApi.md#createpayment) | **POST** /pts/v2/payments/ | Process a Payment


<a name="createpayment"></a>
# **CreatePayment**
> PtsV2PaymentsPost201Response CreatePayment (CreatePaymentRequest createPaymentRequest)

Process a Payment

Authorize the payment for the transaction. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreatePaymentExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var createPaymentRequest = new CreatePaymentRequest(); // CreatePaymentRequest | 

            try
            {
                // Process a Payment
                PtsV2PaymentsPost201Response result = apiInstance.CreatePayment(createPaymentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreatePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createPaymentRequest** | [**CreatePaymentRequest**](CreatePaymentRequest.md)|  | 

### Return type

[**PtsV2PaymentsPost201Response**](PtsV2PaymentsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

