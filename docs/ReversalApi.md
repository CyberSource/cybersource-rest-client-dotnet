# CyberSource.Api.ReversalApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthReversal**](ReversalApi.md#authreversal) | **POST** /pts/v2/payments/{id}/reversals | Process an Authorization Reversal


<a name="authreversal"></a>
# **AuthReversal**
> PtsV2PaymentsReversalsPost201Response AuthReversal (string id, AuthReversalRequest authReversalRequest)

Process an Authorization Reversal

Include the payment ID in the POST request to reverse the payment amount.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class AuthReversalExample
    {
        public void main()
        {
            var apiInstance = new ReversalApi();
            var id = id_example;  // string | The payment ID returned from a previous payment request.
            var authReversalRequest = new AuthReversalRequest(); // AuthReversalRequest | 

            try
            {
                // Process an Authorization Reversal
                PtsV2PaymentsReversalsPost201Response result = apiInstance.AuthReversal(id, authReversalRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReversalApi.AuthReversal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The payment ID returned from a previous payment request. | 
 **authReversalRequest** | [**AuthReversalRequest**](AuthReversalRequest.md)|  | 

### Return type

[**PtsV2PaymentsReversalsPost201Response**](PtsV2PaymentsReversalsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

