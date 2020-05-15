# CyberSource.Api.DownloadDTDApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDTDV2**](DownloadDTDApi.md#getdtdv2) | **GET** /reporting/v3/dtds/{reportDefinitionNameVersion} | Download DTD for Report


<a name="getdtdv2"></a>
# **GetDTDV2**
> void GetDTDV2 (string reportDefinitionNameVersion)

Download DTD for Report

Used to download DTDs for reports on no-auth.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetDTDV2Example
    {
        public void main()
        {
            var apiInstance = new DownloadDTDApi();
            var reportDefinitionNameVersion = reportDefinitionNameVersion_example;  // string | Name and version of DTD file to download. Some DTDs only have one version. In that case version name is not needed. Some example values are ctdr-1.0, tdr, pbdr-1.1

            try
            {
                // Download DTD for Report
                apiInstance.GetDTDV2(reportDefinitionNameVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadDTDApi.GetDTDV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportDefinitionNameVersion** | **string**| Name and version of DTD file to download. Some DTDs only have one version. In that case version name is not needed. Some example values are ctdr-1.0, tdr, pbdr-1.1 | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/xml-dtd

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

