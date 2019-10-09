# CyberSource.Api.TransactionDetailsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTransaction**](TransactionDetailsApi.md#gettransaction) | **GET** /tss/v2/transactions/{id} | Retrieve a Transaction


<a name="gettransaction"></a>
# **GetTransaction**
> TssV2TransactionsGet200Response GetTransaction (string id)

Retrieve a Transaction

Include the Request ID in the GET request to retrieve the transaction details.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetTransactionExample
    {
        public void main()
        {
            var apiInstance = new TransactionDetailsApi();
            var id = id_example;  // string | Request ID. 

            try
            {
                // Retrieve a Transaction
                TssV2TransactionsGet200Response result = apiInstance.GetTransaction(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionDetailsApi.GetTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Request ID.  | 

### Return type

[**TssV2TransactionsGet200Response**](TssV2TransactionsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

