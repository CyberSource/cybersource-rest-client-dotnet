# CyberSource.Api.ReversalApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthReversal**](ReversalApi.md#authreversal) | **POST** /pts/v2/payments/{id}/reversals | Process an Authorization Reversal
[**MitReversal**](ReversalApi.md#mitreversal) | **POST** /pts/v2/reversals/ | Merchant Initiated Reversal


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
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mitreversal"></a>
# **MitReversal**
> PtsV2PaymentsReversalsPost201Response MitReversal (MitReversalRequest mitReversalRequest)

Merchant Initiated Reversal

This is to reverse a previous payment that merchant does not receive a reply.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class MitReversalExample
    {
        public void main()
        {
            var apiInstance = new ReversalApi();
            var mitReversalRequest = new MitReversalRequest(); // MitReversalRequest | 

            try
            {
                // Merchant Initiated Reversal
                PtsV2PaymentsReversalsPost201Response result = apiInstance.MitReversal(mitReversalRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReversalApi.MitReversal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mitReversalRequest** | [**MitReversalRequest**](MitReversalRequest.md)|  | 

### Return type

[**PtsV2PaymentsReversalsPost201Response**](PtsV2PaymentsReversalsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

