# CyberSource.Api.SecureFileShareApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFile**](SecureFileShareApi.md#getfile) | **GET** /sfs/v1/files/{fileId} | Download a file with file identifier
[**GetFileDetail**](SecureFileShareApi.md#getfiledetail) | **GET** /sfs/v1/file-details | Get list of files


<a name="getfile"></a>
# **GetFile**
> void GetFile (string fileId, string organizationId = null)

Download a file with file identifier

Download a file for the given file identifier

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetFileExample
    {
        public void main()
        {
            var apiInstance = new SecureFileShareApi();
            var fileId = fileId_example;  // string | Unique identifier for each file
            var organizationId = organizationId_example;  // string | Valid Cybersource Organization Id (optional) 

            try
            {
                // Download a file with file identifier
                apiInstance.GetFile(fileId, organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecureFileShareApi.GetFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**| Unique identifier for each file | 
 **organizationId** | **string**| Valid Cybersource Organization Id | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/xml, text/csv, application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfiledetail"></a>
# **GetFileDetail**
> V1FileDetailsGet200Response GetFileDetail (DateTime? startDate, DateTime? endDate, string organizationId = null)

Get list of files

Get list of files and it's information of them available inside the report directory

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetFileDetailExample
    {
        public void main()
        {
            var apiInstance = new SecureFileShareApi();
            var startDate = 2013-10-20;  // DateTime? | Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd 
            var endDate = 2013-10-20;  // DateTime? | Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd 
            var organizationId = organizationId_example;  // string | Valid Cybersource Organization Id (optional) 

            try
            {
                // Get list of files
                V1FileDetailsGet200Response result = apiInstance.GetFileDetail(startDate, endDate, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecureFileShareApi.GetFileDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd  | 
 **endDate** | **DateTime?**| Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd  | 
 **organizationId** | **string**| Valid Cybersource Organization Id | [optional] 

### Return type

[**V1FileDetailsGet200Response**](V1FileDetailsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

