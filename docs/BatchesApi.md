# CyberSource.Api.BatchesApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBatchReport**](BatchesApi.md#getbatchreport) | **GET** /accountupdater/v1/batches/{batchId}/report | Retrieve a Batch Report
[**GetBatchStatus**](BatchesApi.md#getbatchstatus) | **GET** /accountupdater/v1/batches/{batchId}/status | Retrieve a Batch Status
[**GetBatchesList**](BatchesApi.md#getbatcheslist) | **GET** /accountupdater/v1/batches | List Batches
[**PostBatch**](BatchesApi.md#postbatch) | **POST** /accountupdater/v1/batches | Create a Batch


<a name="getbatchreport"></a>
# **GetBatchReport**
> InlineResponse20014 GetBatchReport (string batchId)

Retrieve a Batch Report

**Get Batch Report**<br>This resource accepts a batch id and returns: - The batch status. - The total number of accepted, rejected, updated records. - The total number of card association responses. - The billable quantities of:   - New Account Numbers (NAN)   - New Expiry Dates (NED)   - Account Closures (ACL)   - Contact Card Holders (CCH) - Source record information including token ids, masked card number, expiration dates & card type. - Response record information including response code, reason, token ids, masked card number, expiration dates & card type. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetBatchReportExample
    {
        public void main()
        {
            var apiInstance = new BatchesApi();
            var batchId = batchId_example;  // string | Unique identification number assigned to the submitted request.

            try
            {
                // Retrieve a Batch Report
                InlineResponse20014 result = apiInstance.GetBatchReport(batchId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.GetBatchReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchId** | **string**| Unique identification number assigned to the submitted request. | 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbatchstatus"></a>
# **GetBatchStatus**
> InlineResponse20013 GetBatchStatus (string batchId)

Retrieve a Batch Status

**Get Batch Status**<br>This resource accepts a batch id and returns: - The batch status. - The total number of accepted, rejected, updated records. - The total number of card association responses. - The billable quantities of:   - New Account Numbers (NAN)   - New Expiry Dates (NED)   - Account Closures (ACL)   - Contact Card Holders (CCH) 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetBatchStatusExample
    {
        public void main()
        {
            var apiInstance = new BatchesApi();
            var batchId = batchId_example;  // string | Unique identification number assigned to the submitted request.

            try
            {
                // Retrieve a Batch Status
                InlineResponse20013 result = apiInstance.GetBatchStatus(batchId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.GetBatchStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchId** | **string**| Unique identification number assigned to the submitted request. | 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbatcheslist"></a>
# **GetBatchesList**
> InlineResponse20012 GetBatchesList (long? offset = null, long? limit = null, string fromDate = null, string toDate = null)

List Batches

**List Batches**<br>This resource accepts a optional date range, record offset and limit, returning a paginated response of batches containing: - The batch id. - The batch status. - The batch created / modified dates. - The total number of accepted, rejected, updated records. - The total number of card association responses. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetBatchesListExample
    {
        public void main()
        {
            var apiInstance = new BatchesApi();
            var offset = 789;  // long? | Starting record in zero-based dataset that should be returned as the first object in the array. (optional)  (default to 0)
            var limit = 789;  // long? | The maximum number that can be returned in the array starting from the offset record in zero-based dataset. (optional)  (default to 20)
            var fromDate = fromDate_example;  // string | ISO-8601 format: yyyyMMddTHHmmssZ (optional) 
            var toDate = toDate_example;  // string | ISO-8601 format: yyyyMMddTHHmmssZ (optional) 

            try
            {
                // List Batches
                InlineResponse20012 result = apiInstance.GetBatchesList(offset, limit, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.GetBatchesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **long?**| Starting record in zero-based dataset that should be returned as the first object in the array. | [optional] [default to 0]
 **limit** | **long?**| The maximum number that can be returned in the array starting from the offset record in zero-based dataset. | [optional] [default to 20]
 **fromDate** | **string**| ISO-8601 format: yyyyMMddTHHmmssZ | [optional] 
 **toDate** | **string**| ISO-8601 format: yyyyMMddTHHmmssZ | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postbatch"></a>
# **PostBatch**
> InlineResponse202 PostBatch (Body body)

Create a Batch

**Create a Batch**<br>This resource accepts TMS tokens ids of a Customer, Payment Instrument or Instrument Identifier. <br> The card numbers for the supplied tokens ids are then sent to the relevant card associations to check for updates.<br>The following type of batches can be submitted: -  **oneOff** batch containing tokens id for Visa or MasterCard card numbers. - **amexRegistration** batch containing tokens id for Amex card numbers.  A batch id will be returned on a successful response which can be used to get the batch status and the batch report. The availability of API features for a merchant may depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostBatchExample
    {
        public void main()
        {
            var apiInstance = new BatchesApi();
            var body = new Body(); // Body | 

            try
            {
                // Create a Batch
                InlineResponse202 result = apiInstance.PostBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.PostBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)|  | 

### Return type

[**InlineResponse202**](InlineResponse202.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

