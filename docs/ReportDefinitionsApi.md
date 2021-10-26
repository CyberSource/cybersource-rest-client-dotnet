# CyberSource.Api.ReportDefinitionsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetResourceInfoByReportDefinition**](ReportDefinitionsApi.md#getresourceinfobyreportdefinition) | **GET** /reporting/v3/report-definitions/{reportDefinitionName} | Get Report Definition
[**GetResourceV2Info**](ReportDefinitionsApi.md#getresourcev2info) | **GET** /reporting/v3/report-definitions | Get Reporting Resource Information


<a name="getresourceinfobyreportdefinition"></a>
# **GetResourceInfoByReportDefinition**
> ReportingV3ReportDefinitionsNameGet200Response GetResourceInfoByReportDefinition (string reportDefinitionName, string subscriptionType = null, string reportMimeType = null, string organizationId = null)

Get Report Definition

View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetResourceInfoByReportDefinitionExample
    {
        public void main()
        {
            var apiInstance = new ReportDefinitionsApi();
            var reportDefinitionName = reportDefinitionName_example;  // string | Name of the Report definition to retrieve
            var subscriptionType = subscriptionType_example;  // string | The subscription type for which report definition is required. By default the type will be CUSTOM. Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional) 
            var reportMimeType = reportMimeType_example;  // string | The format for which the report definition is required. By default the value will be CSV. Valid Values: - application/xml - text/csv  (optional) 
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 

            try
            {
                // Get Report Definition
                ReportingV3ReportDefinitionsNameGet200Response result = apiInstance.GetResourceInfoByReportDefinition(reportDefinitionName, subscriptionType, reportMimeType, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportDefinitionsApi.GetResourceInfoByReportDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportDefinitionName** | **string**| Name of the Report definition to retrieve | 
 **subscriptionType** | **string**| The subscription type for which report definition is required. By default the type will be CUSTOM. Valid Values: - CLASSIC - CUSTOM - STANDARD  | [optional] 
 **reportMimeType** | **string**| The format for which the report definition is required. By default the value will be CSV. Valid Values: - application/xml - text/csv  | [optional] 
 **organizationId** | **string**| Valid Organization Id | [optional] 

### Return type

[**ReportingV3ReportDefinitionsNameGet200Response**](ReportingV3ReportDefinitionsNameGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresourcev2info"></a>
# **GetResourceV2Info**
> ReportingV3ReportDefinitionsGet200Response GetResourceV2Info (string subscriptionType = null, string organizationId = null)

Get Reporting Resource Information

View a list of supported reports and their attributes before subscribing to them. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetResourceV2InfoExample
    {
        public void main()
        {
            var apiInstance = new ReportDefinitionsApi();
            var subscriptionType = subscriptionType_example;  // string | Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional) 
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 

            try
            {
                // Get Reporting Resource Information
                ReportingV3ReportDefinitionsGet200Response result = apiInstance.GetResourceV2Info(subscriptionType, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportDefinitionsApi.GetResourceV2Info: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionType** | **string**| Valid Values: - CLASSIC - CUSTOM - STANDARD  | [optional] 
 **organizationId** | **string**| Valid Organization Id | [optional] 

### Return type

[**ReportingV3ReportDefinitionsGet200Response**](ReportingV3ReportDefinitionsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

