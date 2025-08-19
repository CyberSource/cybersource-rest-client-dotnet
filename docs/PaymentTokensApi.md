# CyberSource.Api.PaymentTokensApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RetrieveOrDeletePaymentToken**](PaymentTokensApi.md#retrieveordeletepaymenttoken) | **POST** /pts/v2/payment-tokens | Retrieve or Delete Payment Token


<a name="retrieveordeletepaymenttoken"></a>
# **RetrieveOrDeletePaymentToken**
> InlineResponse201 RetrieveOrDeletePaymentToken (Request request)

Retrieve or Delete Payment Token

This API can be used in two flavours - for retrieval or deletion of vault id. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class RetrieveOrDeletePaymentTokenExample
    {
        public void main()
        {
            var apiInstance = new PaymentTokensApi();
            var request = new Request(); // Request | 

            try
            {
                // Retrieve or Delete Payment Token
                InlineResponse201 result = apiInstance.RetrieveOrDeletePaymentToken(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentTokensApi.RetrieveOrDeletePaymentToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**Request**](Request.md)|  | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

