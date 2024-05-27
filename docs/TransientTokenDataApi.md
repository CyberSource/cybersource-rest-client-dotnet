# CyberSource.Api.TransientTokenDataApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPaymentCredentialsForTransientToken**](TransientTokenDataApi.md#getpaymentcredentialsfortransienttoken) | **GET** /flex/v2/payment-credentials/{paymentCredentialsReference} | Get Payment Credentials
[**GetTransactionForTransientToken**](TransientTokenDataApi.md#gettransactionfortransienttoken) | **GET** /up/v1/payment-details/{transientToken} | Get Transient Token Data


<a name="getpaymentcredentialsfortransienttoken"></a>
# **GetPaymentCredentialsForTransientToken**
> string GetPaymentCredentialsForTransientToken (string paymentCredentialsReference)

Get Payment Credentials

Retrieve the Payment data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will return PCI payment data captured by the Unified Checkout platform.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetPaymentCredentialsForTransientTokenExample
    {
        public void main()
        {
            var apiInstance = new TransientTokenDataApi();
            var paymentCredentialsReference = paymentCredentialsReference_example;  // string | The paymentCredentialsReference field contained within the Transient token returned from a successful Unified Checkout transaction 

            try
            {
                // Get Payment Credentials
                string result = apiInstance.GetPaymentCredentialsForTransientToken(paymentCredentialsReference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransientTokenDataApi.GetPaymentCredentialsForTransientToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentCredentialsReference** | **string**| The paymentCredentialsReference field contained within the Transient token returned from a successful Unified Checkout transaction  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionfortransienttoken"></a>
# **GetTransactionForTransientToken**
> void GetTransactionForTransientToken (string transientToken)

Get Transient Token Data

Retrieve the data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will not return PCI payment data (PAN). Include the Request ID in the GET request to retrieve the transaction details.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetTransactionForTransientTokenExample
    {
        public void main()
        {
            var apiInstance = new TransientTokenDataApi();
            var transientToken = transientToken_example;  // string | Transient Token returned by the Unified Checkout application. 

            try
            {
                // Get Transient Token Data
                apiInstance.GetTransactionForTransientToken(transientToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransientTokenDataApi.GetTransactionForTransientToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transientToken** | **string**| Transient Token returned by the Unified Checkout application.  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

