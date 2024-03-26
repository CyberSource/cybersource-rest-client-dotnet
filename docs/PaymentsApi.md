# CyberSource.Api.PaymentsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrderRequest**](PaymentsApi.md#createorderrequest) | **POST** /pts/v2/payment-references/{id}/intents | Create a Payment Order Request
[**CreatePayment**](PaymentsApi.md#createpayment) | **POST** /pts/v2/payments | Process a Payment
[**CreateSessionRequest**](PaymentsApi.md#createsessionrequest) | **POST** /pts/v2/payment-references | Create Alternative Payments Sessions Request
[**IncrementAuth**](PaymentsApi.md#incrementauth) | **PATCH** /pts/v2/payments/{id} | Increment an Authorization
[**RefreshPaymentStatus**](PaymentsApi.md#refreshpaymentstatus) | **POST** /pts/v2/refresh-payment-status/{id} | Check a Payment Status
[**UpdateSessionReq**](PaymentsApi.md#updatesessionreq) | **PATCH** /pts/v2/payment-references/{id} | Update Alternative Payments Sessions Request


<a name="createorderrequest"></a>
# **CreateOrderRequest**
> PtsV2PaymentsOrderPost201Response CreateOrderRequest (OrderPaymentRequest orderPaymentRequest, string id)

Create a Payment Order Request

Create a Payment Order Request

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateOrderRequestExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var orderPaymentRequest = new OrderPaymentRequest(); // OrderPaymentRequest | 
            var id = id_example;  // string | Request identifier number for the order request. 

            try
            {
                // Create a Payment Order Request
                PtsV2PaymentsOrderPost201Response result = apiInstance.CreateOrderRequest(orderPaymentRequest, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateOrderRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderPaymentRequest** | [**OrderPaymentRequest**](OrderPaymentRequest.md)|  | 
 **id** | **string**| Request identifier number for the order request.  | 

### Return type

[**PtsV2PaymentsOrderPost201Response**](PtsV2PaymentsOrderPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

<a name="createsessionrequest"></a>
# **CreateSessionRequest**
> PtsV2PaymentsPost201Response2 CreateSessionRequest (CreateSessionReq createSessionReq)

Create Alternative Payments Sessions Request

Create Alternative Payments Sessions Request

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateSessionRequestExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var createSessionReq = new CreateSessionReq(); // CreateSessionReq | 

            try
            {
                // Create Alternative Payments Sessions Request
                PtsV2PaymentsPost201Response2 result = apiInstance.CreateSessionRequest(createSessionReq);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateSessionRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createSessionReq** | [**CreateSessionReq**](CreateSessionReq.md)|  | 

### Return type

[**PtsV2PaymentsPost201Response2**](PtsV2PaymentsPost201Response2.md)

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

<a name="updatesessionreq"></a>
# **UpdateSessionReq**
> PtsV2PaymentsPost201Response2 UpdateSessionReq (CreateSessionRequest createSessionRequest, string id)

Update Alternative Payments Sessions Request

Update Alternative Payments Sessions Request

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateSessionReqExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var createSessionRequest = new CreateSessionRequest(); // CreateSessionRequest | 
            var id = id_example;  // string | The payment ID. This ID is returned from a previous payment request.

            try
            {
                // Update Alternative Payments Sessions Request
                PtsV2PaymentsPost201Response2 result = apiInstance.UpdateSessionReq(createSessionRequest, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.UpdateSessionReq: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createSessionRequest** | [**CreateSessionRequest**](CreateSessionRequest.md)|  | 
 **id** | **string**| The payment ID. This ID is returned from a previous payment request. | 

### Return type

[**PtsV2PaymentsPost201Response2**](PtsV2PaymentsPost201Response2.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

