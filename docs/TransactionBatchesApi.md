# CyberSource.Api.TransactionBatchesApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PtsV1TransactionBatchesGet**](TransactionBatchesApi.md#ptsv1transactionbatchesget) | **GET** /pts/v1/transaction-batches | Get a list of batch files processed through the Offline Transaction Submission Services


<a name="ptsv1transactionbatchesget"></a>
# **PtsV1TransactionBatchesGet**
> PtsV1TransactionBatchesGet200Response PtsV1TransactionBatchesGet (DateTime? startTime, DateTime? endTime)

Get a list of batch files processed through the Offline Transaction Submission Services

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
    public class PtsV1TransactionBatchesGetExample
    {
        public void main()
        {
            var apiInstance = new TransactionBatchesApi();
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZZ 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZZ 

            try
            {
                // Get a list of batch files processed through the Offline Transaction Submission Services
                PtsV1TransactionBatchesGet200Response result = apiInstance.PtsV1TransactionBatchesGet(startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionBatchesApi.PtsV1TransactionBatchesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTime** | **DateTime?**| Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ  | 
 **endTime** | **DateTime?**| Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ  | 

### Return type

[**PtsV1TransactionBatchesGet200Response**](PtsV1TransactionBatchesGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

