# CyberSource.Api.NotificationOfChangesApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNotificationOfChangeReport**](NotificationOfChangesApi.md#getnotificationofchangereport) | **GET** /reporting/v3/notification-of-changes | Get Notification of Changes


<a name="getnotificationofchangereport"></a>
# **GetNotificationOfChangeReport**
> ReportingV3NotificationofChangesGet200Response GetNotificationOfChangeReport (DateTime? startTime, DateTime? endTime)

Get Notification of Changes

Download the Notification of Change report. This report shows eCheck-related fields updated as a result of a response to an eCheck settlement transaction. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetNotificationOfChangeReportExample
    {
        public void main()
        {
            var apiInstance = new NotificationOfChangesApi();
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) 

            try
            {
                // Get Notification of Changes
                ReportingV3NotificationofChangesGet200Response result = apiInstance.GetNotificationOfChangeReport(startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationOfChangesApi.GetNotificationOfChangeReport: " + e.Message );
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

### Return type

[**ReportingV3NotificationofChangesGet200Response**](ReportingV3NotificationofChangesGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json, text/csv, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

