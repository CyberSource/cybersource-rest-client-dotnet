# CyberSource.Api.TransientTokenDataApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTransactionForTransientToken**](TransientTokenDataApi.md#gettransactionfortransienttoken) | **GET** /up/v1/payment-details/{transientToken} | Get Transient Token Data


<a name="gettransactionfortransienttoken"></a>
# **GetTransactionForTransientToken**
> void GetTransactionForTransientToken (string transientToken)

Get Transient Token Data

Retrieve the data captured by Unfied Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will not return PCI payment data (PAN). Include the Request ID in the GET request to retrieve the transaction details.

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

