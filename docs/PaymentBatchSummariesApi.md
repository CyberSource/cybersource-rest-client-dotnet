# CyberSource.Api.PaymentBatchSummariesApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPaymentBatchSummary**](PaymentBatchSummariesApi.md#getpaymentbatchsummary) | **GET** /reporting/v3/payment-batch-summaries | Get Payment Batch Summary Data


<a name="getpaymentbatchsummary"></a>
# **GetPaymentBatchSummary**
> ReportingV3PaymentBatchSummariesGet200Response GetPaymentBatchSummary (DateTime? startTime, DateTime? endTime, string organizationId = null, string rollUp = null, string breakdown = null, int? startDayOfWeek = null)

Get Payment Batch Summary Data

Scope can be either account/merchant or reseller.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetPaymentBatchSummaryExample
    {
        public void main()
        {
            var apiInstance = new PaymentBatchSummariesApi();
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) 
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 
            var rollUp = rollUp_example;  // string | Conditional - RollUp for data for day/week/month. Required while getting breakdown data for a Merchant (optional) 
            var breakdown = breakdown_example;  // string | Conditional - Breakdown on account_rollup/all_merchant/selected_merchant. Required while getting breakdown data for a Merchant. (optional) 
            var startDayOfWeek = 56;  // int? | Optional - Start day of week to breakdown data for weeks in a month (optional) 

            try
            {
                // Get Payment Batch Summary Data
                ReportingV3PaymentBatchSummariesGet200Response result = apiInstance.GetPaymentBatchSummary(startTime, endTime, organizationId, rollUp, breakdown, startDayOfWeek);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentBatchSummariesApi.GetPaymentBatchSummary: " + e.Message );
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
 **rollUp** | **string**| Conditional - RollUp for data for day/week/month. Required while getting breakdown data for a Merchant | [optional] 
 **breakdown** | **string**| Conditional - Breakdown on account_rollup/all_merchant/selected_merchant. Required while getting breakdown data for a Merchant. | [optional] 
 **startDayOfWeek** | **int?**| Optional - Start day of week to breakdown data for weeks in a month | [optional] 

### Return type

[**ReportingV3PaymentBatchSummariesGet200Response**](ReportingV3PaymentBatchSummariesGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json, text/csv, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

