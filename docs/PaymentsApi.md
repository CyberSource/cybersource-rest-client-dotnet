# CyberSource.Api.PaymentsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePayment**](PaymentsApi.md#createpayment) | **POST** /pts/v2/payments | Process a Payment
[**IncrementAuth**](PaymentsApi.md#incrementauth) | **PATCH** /pts/v2/payments/{id} | Increment an Authorization
[**RefreshPaymentStatus**](PaymentsApi.md#refreshpaymentstatus) | **POST** /pts/v2/refresh-payment-status/{id} | Check a Payment Status


<a name="createpayment"></a>
# **CreatePayment**
> PtsV2PaymentsPost201Response CreatePayment (CreatePaymentRequest createPaymentRequest)

Process a Payment

A payment authorizes the amount for the transaction. There are a number of supported payment features, such as E-commerce and Card Present - Credit Card/Debit Card, Echeck, e-Wallets, Level II/III Data, etc..  A payment response includes the status of the request. It also includes processor-specific information when the request is successful and errors if unsuccessful. See the [Payments Developer Guides Page](https://developer.cybersource.com/docs/cybs/en-us/payments/developer/ctv/rest/payments/payments-intro.html).  Authorization can be requested with Capture, Decision Manager, Payer Authentication(3ds), and Token Creation. 

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
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incrementauth"></a>
# **IncrementAuth**
> PtsV2IncrementalAuthorizationPatch201Response IncrementAuth (string id, IncrementAuthRequest incrementAuthRequest)

Increment an Authorization

Use this service to authorize additional charges in a lodging or autorental transaction. Include the ID returned from the original authorization in the PATCH request to add additional charges to that authorization. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class IncrementAuthExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var id = id_example;  // string | The ID returned from the original authorization request.
            var incrementAuthRequest = new IncrementAuthRequest(); // IncrementAuthRequest | 

            try
            {
                // Increment an Authorization
                PtsV2IncrementalAuthorizationPatch201Response result = apiInstance.IncrementAuth(id, incrementAuthRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.IncrementAuth: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID returned from the original authorization request. | 
 **incrementAuthRequest** | [**IncrementAuthRequest**](IncrementAuthRequest.md)|  | 

### Return type

[**PtsV2IncrementalAuthorizationPatch201Response**](PtsV2IncrementalAuthorizationPatch201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refreshpaymentstatus"></a>
# **RefreshPaymentStatus**
> PtsV2PaymentsPost201Response1 RefreshPaymentStatus (string id, RefreshPaymentStatusRequest refreshPaymentStatusRequest)

Check a Payment Status

Checks and updates the payment status 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class RefreshPaymentStatusExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var id = id_example;  // string | The payment id whose status needs to be checked and updated.
            var refreshPaymentStatusRequest = new RefreshPaymentStatusRequest(); // RefreshPaymentStatusRequest | 

            try
            {
                // Check a Payment Status
                PtsV2PaymentsPost201Response1 result = apiInstance.RefreshPaymentStatus(id, refreshPaymentStatusRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.RefreshPaymentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The payment id whose status needs to be checked and updated. | 
 **refreshPaymentStatusRequest** | [**RefreshPaymentStatusRequest**](RefreshPaymentStatusRequest.md)|  | 

### Return type

[**PtsV2PaymentsPost201Response1**](PtsV2PaymentsPost201Response1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

