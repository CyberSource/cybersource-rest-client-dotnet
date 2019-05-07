# CyberSource.Api.TransactionBatchesApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTransactionBatchDetails**](TransactionBatchesApi.md#gettransactionbatchdetails) | **GET** /pts/v1/transaction-batch-details | Filters batch response. 
[**GetTransactionBatchId**](TransactionBatchesApi.md#gettransactionbatchid) | **GET** /pts/v1/transaction-batches/{id} | Get individual batch file
[**GetTransactionBatches**](TransactionBatchesApi.md#gettransactionbatches) | **GET** /pts/v1/transaction-batches | Get a list of batch files


<a name="gettransactionbatchdetails"></a>
# **GetTransactionBatchDetails**
> void GetTransactionBatchDetails (string transactionBatchId, DateTime? uploadDate = null, string status = null)

Filters batch response. 

Filters batch response. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetTransactionBatchDetailsExample
    {
        public void main()
        {
            var apiInstance = new TransactionBatchesApi();
            var transactionBatchId = transactionBatchId_example;  // string | Transaction Batch Id, this is unique.
            var uploadDate = 2013-10-20;  // DateTime? | Date in which the original batch file was uploaded. Date must be in ISO-8601 format. (optional) 
            var status = status_example;  // string | Allows you to filter by rejected response.  (optional) 

            try
            {
                // Filters batch response. 
                apiInstance.GetTransactionBatchDetails(transactionBatchId, uploadDate, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionBatchesApi.GetTransactionBatchDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionBatchId** | **string**| Transaction Batch Id, this is unique. | 
 **uploadDate** | **DateTime?**| Date in which the original batch file was uploaded. Date must be in ISO-8601 format. | [optional] 
 **status** | **string**| Allows you to filter by rejected response.  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: text/vnd.cybersource.map-csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionbatchid"></a>
# **GetTransactionBatchId**
> void GetTransactionBatchId (string id)

Get individual batch file

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
    public class GetTransactionBatchIdExample
    {
        public void main()
        {
            var apiInstance = new TransactionBatchesApi();
            var id = id_example;  // string | The batch id assigned for the template.

            try
            {
                // Get individual batch file
                apiInstance.GetTransactionBatchId(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionBatchesApi.GetTransactionBatchId: " + e.Message );
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

<a name="gettransactionbatches"></a>
# **GetTransactionBatches**
> PtsV1TransactionBatchesGet200Response GetTransactionBatches (DateTime? startTime, DateTime? endTime)

Get a list of batch files

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
    public class GetTransactionBatchesExample
    {
        public void main()
        {
            var apiInstance = new TransactionBatchesApi();
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZZ 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZZ 

            try
            {
                // Get a list of batch files
                PtsV1TransactionBatchesGet200Response result = apiInstance.GetTransactionBatches(startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionBatchesApi.GetTransactionBatches: " + e.Message );
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

