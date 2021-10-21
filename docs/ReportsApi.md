# CyberSource.Api.ReportsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateReport**](ReportsApi.md#createreport) | **POST** /reporting/v3/reports | Create Adhoc Report
[**GetReportByReportId**](ReportsApi.md#getreportbyreportid) | **GET** /reporting/v3/reports/{reportId} | Get Report Based on Report Id
[**SearchReports**](ReportsApi.md#searchreports) | **GET** /reporting/v3/reports | Retrieve Available Reports


<a name="createreport"></a>
# **CreateReport**
> void CreateReport (CreateAdhocReportRequest createAdhocReportRequest, string organizationId = null)

Create Adhoc Report

Create a one-time report. You must specify the type of report in reportDefinitionName. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation) 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateReportExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var createAdhocReportRequest = new CreateAdhocReportRequest(); // CreateAdhocReportRequest | Report subscription request payload
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 

            try
            {
                // Create Adhoc Report
                apiInstance.CreateReport(createAdhocReportRequest, organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.CreateReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createAdhocReportRequest** | [**CreateAdhocReportRequest**](CreateAdhocReportRequest.md)| Report subscription request payload | 
 **organizationId** | **string**| Valid Organization Id | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportbyreportid"></a>
# **GetReportByReportId**
> ReportingV3ReportsIdGet200Response GetReportByReportId (string reportId, string organizationId = null)

Get Report Based on Report Id

Download a report using the reportId value. If you don’t already know this value, you can obtain it using the Retrieve available reports call. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetReportByReportIdExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var reportId = reportId_example;  // string | Valid Report Id
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 

            try
            {
                // Get Report Based on Report Id
                ReportingV3ReportsIdGet200Response result = apiInstance.GetReportByReportId(reportId, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportByReportId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportId** | **string**| Valid Report Id | 
 **organizationId** | **string**| Valid Organization Id | [optional] 

### Return type

[**ReportingV3ReportsIdGet200Response**](ReportingV3ReportsIdGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchreports"></a>
# **SearchReports**
> ReportingV3ReportsGet200Response SearchReports (DateTime? startTime, DateTime? endTime, string timeQueryType, string organizationId = null, string reportMimeType = null, string reportFrequency = null, string reportName = null, int? reportDefinitionId = null, string reportStatus = null)

Retrieve Available Reports

Retrieve a list of the available reports to which you are subscribed. This will also give you the reportId value, which you can also use to download a report. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class SearchReportsExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) 
            var timeQueryType = timeQueryType_example;  // string | Specify time you would like to search  Valid values: - reportTimeFrame - executedTime 
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 
            var reportMimeType = reportMimeType_example;  // string | Valid Report Format  Valid values: - application/xml - text/csv  (optional) 
            var reportFrequency = reportFrequency_example;  // string | Valid Report Frequency  Valid values: - DAILY - WEEKLY - MONTHLY - USER_DEFINED - ADHOC  (optional) 
            var reportName = reportName_example;  // string | Valid Report Name (optional) 
            var reportDefinitionId = 56;  // int? | Valid Report Definition Id (optional) 
            var reportStatus = reportStatus_example;  // string | Valid Report Status  Valid values: - COMPLETED - PENDING - QUEUED - RUNNING - ERROR - NO_DATA  (optional) 

            try
            {
                // Retrieve Available Reports
                ReportingV3ReportsGet200Response result = apiInstance.SearchReports(startTime, endTime, timeQueryType, organizationId, reportMimeType, reportFrequency, reportName, reportDefinitionId, reportStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.SearchReports: " + e.Message );
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
 **timeQueryType** | **string**| Specify time you would like to search  Valid values: - reportTimeFrame - executedTime  | 
 **organizationId** | **string**| Valid Organization Id | [optional] 
 **reportMimeType** | **string**| Valid Report Format  Valid values: - application/xml - text/csv  | [optional] 
 **reportFrequency** | **string**| Valid Report Frequency  Valid values: - DAILY - WEEKLY - MONTHLY - USER_DEFINED - ADHOC  | [optional] 
 **reportName** | **string**| Valid Report Name | [optional] 
 **reportDefinitionId** | **int?**| Valid Report Definition Id | [optional] 
 **reportStatus** | **string**| Valid Report Status  Valid values: - COMPLETED - PENDING - QUEUED - RUNNING - ERROR - NO_DATA  | [optional] 

### Return type

[**ReportingV3ReportsGet200Response**](ReportingV3ReportsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

