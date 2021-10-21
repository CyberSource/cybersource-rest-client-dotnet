# CyberSource.Api.ReportDownloadsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadReport**](ReportDownloadsApi.md#downloadreport) | **GET** /reporting/v3/report-downloads | Download a Report


<a name="downloadreport"></a>
# **DownloadReport**
> void DownloadReport (DateTime? reportDate, string reportName, string organizationId = null)

Download a Report

Download a report using the unique report name and date. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DownloadReportExample
    {
        public void main()
        {
            var apiInstance = new ReportDownloadsApi();
            var reportDate = 2013-10-20;  // DateTime? | Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**  yyyy-mm-dd For reports that span multiple days, this value would be the end date of the report in the time zone of the report subscription. Example 1: If your report start date is 2020-03-06 and the end date is 2020-03-09, the reportDate passed in the query is 2020-03-09. Example 2: If your report runs from midnight to midnight on 2020-03-09, the reportDate passed in the query is 2020-03-10 
            var reportName = reportName_example;  // string | Name of the report to download
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 

            try
            {
                // Download a Report
                apiInstance.DownloadReport(reportDate, reportName, organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportDownloadsApi.DownloadReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportDate** | **DateTime?**| Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**  yyyy-mm-dd For reports that span multiple days, this value would be the end date of the report in the time zone of the report subscription. Example 1: If your report start date is 2020-03-06 and the end date is 2020-03-09, the reportDate passed in the query is 2020-03-09. Example 2: If your report runs from midnight to midnight on 2020-03-09, the reportDate passed in the query is 2020-03-10  | 
 **reportName** | **string**| Name of the report to download | 
 **organizationId** | **string**| Valid Organization Id | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/xml, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

