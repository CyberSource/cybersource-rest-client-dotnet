# CyberSource.Api.PurchaseAndRefundDetailsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPurchaseAndRefundDetails**](PurchaseAndRefundDetailsApi.md#getpurchaseandrefunddetails) | **GET** /reporting/v3/purchase-refund-details | Get Purchase and Refund Details


<a name="getpurchaseandrefunddetails"></a>
# **GetPurchaseAndRefundDetails**
> ReportingV3PurchaseRefundDetailsGet200Response GetPurchaseAndRefundDetails (DateTime? startTime, DateTime? endTime, string organizationId = null, string paymentSubtype = null, string viewBy = null, string groupName = null, int? offset = null, int? limit = null)

Get Purchase and Refund Details

Download the Purchase and Refund Details report. This report report includes all purchases and refund transactions, as well as all activities related to transactions resulting in an adjustment to the net proceeds. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetPurchaseAndRefundDetailsExample
    {
        public void main()
        {
            var apiInstance = new PurchaseAndRefundDetailsApi();
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) 
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 
            var paymentSubtype = paymentSubtype_example;  // string | Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional)  (default to ALL)
            var viewBy = viewBy_example;  // string | View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional)  (default to requestDate)
            var groupName = groupName_example;  // string | Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional) 
            var offset = 56;  // int? | Offset of the Purchase and Refund Results. (optional) 
            var limit = 56;  // int? | Results count per page. Range(1-2000) (optional)  (default to 2000)

            try
            {
                // Get Purchase and Refund Details
                ReportingV3PurchaseRefundDetailsGet200Response result = apiInstance.GetPurchaseAndRefundDetails(startTime, endTime, organizationId, paymentSubtype, viewBy, groupName, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseAndRefundDetailsApi.GetPurchaseAndRefundDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTime** | **DateTime?**| Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z)  | 
 **endTime** | **DateTime?**| Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z)  | 
 **organizationId** | **string**| Valid Organization Id | [optional] 
 **paymentSubtype** | **string**| Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  | [optional] [default to ALL]
 **viewBy** | **string**| View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  | [optional] [default to requestDate]
 **groupName** | **string**| Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds | [optional] 
 **offset** | **int?**| Offset of the Purchase and Refund Results. | [optional] 
 **limit** | **int?**| Results count per page. Range(1-2000) | [optional] [default to 2000]

### Return type

[**ReportingV3PurchaseRefundDetailsGet200Response**](ReportingV3PurchaseRefundDetailsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json, application/xml, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

