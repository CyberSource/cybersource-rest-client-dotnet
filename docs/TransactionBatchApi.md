# CyberSource.Api.TransactionBatchApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PtsV1TransactionBatchesIdGet**](TransactionBatchApi.md#ptsv1transactionbatchesidget) | **GET** /pts/v1/transaction-batches/{id} | Get an individual batch file Details processed through the Offline Transaction Submission Services


<a name="ptsv1transactionbatchesidget"></a>
# **PtsV1TransactionBatchesIdGet**
> void PtsV1TransactionBatchesIdGet (string id)

Get an individual batch file Details processed through the Offline Transaction Submission Services

Provide the search range

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PtsV1TransactionBatchesIdGetExample
    {
        public void main()
        {
            var apiInstance = new TransactionBatchApi();
            var id = id_example;  // string | The batch id assigned for the template.

            try
            {
                // Get an individual batch file Details processed through the Offline Transaction Submission Services
                apiInstance.PtsV1TransactionBatchesIdGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionBatchApi.PtsV1TransactionBatchesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The batch id assigned for the template. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

