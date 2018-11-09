# CyberSource.Api.ReportDefinitionsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetResourceInfoByReportDefinition**](ReportDefinitionsApi.md#getresourceinfobyreportdefinition) | **GET** /reporting/v3/report-definitions/{reportDefinitionName} | Get a single report definition information
[**GetResourceV2Info**](ReportDefinitionsApi.md#getresourcev2info) | **GET** /reporting/v3/report-definitions | Get reporting resource information


<a name="getresourceinfobyreportdefinition"></a>
# **GetResourceInfoByReportDefinition**
> ReportingV3ReportDefinitionsNameGet200Response GetResourceInfoByReportDefinition (string reportDefinitionName, string organizationId = null)

Get a single report definition information

The report definition name must be used as path parameter exclusive of each other

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
            var organizationId = organizationId_example;  // string | Valid Cybersource Organization Id (optional) 

            try
            {
                // Get a single report definition information
                ReportingV3ReportDefinitionsNameGet200Response result = apiInstance.GetResourceInfoByReportDefinition(reportDefinitionName, organizationId);
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
 **organizationId** | **string**| Valid Cybersource Organization Id | [optional] 

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
> ReportingV3ReportDefinitionsGet200Response GetResourceV2Info (string organizationId = null)

Get reporting resource information



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
            var organizationId = organizationId_example;  // string | Valid Cybersource Organization Id (optional) 

            try
            {
                // Get reporting resource information
                ReportingV3ReportDefinitionsGet200Response result = apiInstance.GetResourceV2Info(organizationId);
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
 **organizationId** | **string**| Valid Cybersource Organization Id | [optional] 

### Return type

[**ReportingV3ReportDefinitionsGet200Response**](ReportingV3ReportDefinitionsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

