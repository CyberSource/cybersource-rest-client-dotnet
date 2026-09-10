# CyberSource.Api.TransactionQueryApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateQueryApi**](TransactionQueryApi.md#createqueryapi) | **POST** /pts/v2/payouts/transaction-query/{id} | Query Transaction Details


<a name="createqueryapi"></a>
# **CreateQueryApi**
> InlineResponse2014 CreateQueryApi (string id, Body1 body, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId, int? limit = null, int? offset = null)

Query Transaction Details

Query the status and details of payouts transactions including Pull Funds, Push Funds, and Pull Funds Reversals 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateQueryApiExample
    {
        public void main()
        {
            var apiInstance = new TransactionQueryApi();
            var id = id_example;  // string | This is the CyberSource Request ID generated for successfully processed AFT/OCT that needs to be queried. 
            var body = new Body1(); // Body1 | 
            var contentType = contentType_example;  // string | 
            var xRequestid = xRequestid_example;  // string | 
            var vCMerchantId = vCMerchantId_example;  // string | 
            var vCPermissions = vCPermissions_example;  // string | 
            var vCCorrelationId = vCCorrelationId_example;  // string | 
            var vCOrganizationId = vCOrganizationId_example;  // string | 
            var limit = 56;  // int? | The maximum number of options to be retrieved from the processor and displayed to the consumer.  (optional) 
            var offset = 56;  // int? | Offset from the first item in the list of options received from the processor. If you want to display the options in multiple lists, this number represents the first option displayed in each list.  (optional) 

            try
            {
                // Query Transaction Details
                InlineResponse2014 result = apiInstance.CreateQueryApi(id, body, contentType, xRequestid, vCMerchantId, vCPermissions, vCCorrelationId, vCOrganizationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionQueryApi.CreateQueryApi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| This is the CyberSource Request ID generated for successfully processed AFT/OCT that needs to be queried.  | 
 **body** | [**Body1**](Body1.md)|  | 
 **contentType** | **string**|  | 
 **xRequestid** | **string**|  | 
 **vCMerchantId** | **string**|  | 
 **vCPermissions** | **string**|  | 
 **vCCorrelationId** | **string**|  | 
 **vCOrganizationId** | **string**|  | 
 **limit** | **int?**| The maximum number of options to be retrieved from the processor and displayed to the consumer.  | [optional] 
 **offset** | **int?**| Offset from the first item in the list of options received from the processor. If you want to display the options in multiple lists, this number represents the first option displayed in each list.  | [optional] 

### Return type

[**InlineResponse2014**](InlineResponse2014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

