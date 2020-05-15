# CyberSource.Api.DownloadXSDApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetXSDV2**](DownloadXSDApi.md#getxsdv2) | **GET** /reporting/v3/xsds/{reportDefinitionNameVersion} | Download XSD for Report


<a name="getxsdv2"></a>
# **GetXSDV2**
> void GetXSDV2 (string reportDefinitionNameVersion)

Download XSD for Report

Used to download XSDs for reports on no-auth.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetXSDV2Example
    {
        public void main()
        {
            var apiInstance = new DownloadXSDApi();
            var reportDefinitionNameVersion = reportDefinitionNameVersion_example;  // string | Name and version of XSD file to download. Some XSDs only have one version. In that case version name is not needed. Some example values are DecisionManagerDetailReport, DecisionManagerTypes

            try
            {
                // Download XSD for Report
                apiInstance.GetXSDV2(reportDefinitionNameVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadXSDApi.GetXSDV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportDefinitionNameVersion** | **string**| Name and version of XSD file to download. Some XSDs only have one version. In that case version name is not needed. Some example values are DecisionManagerDetailReport, DecisionManagerTypes | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

