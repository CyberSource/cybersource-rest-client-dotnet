# CyberSource.Api.InterchangeClearingLevelDetailsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInterchangeClearingLevelDetails**](InterchangeClearingLevelDetailsApi.md#getinterchangeclearingleveldetails) | **GET** /reporting/v3/interchange-clearing-level-details | Interchange Clearing Level data for an account or a merchant


<a name="getinterchangeclearingleveldetails"></a>
# **GetInterchangeClearingLevelDetails**
> ReportingV3InterchangeClearingLevelDetailsGet200Response GetInterchangeClearingLevelDetails (DateTime? startTime, DateTime? endTime, string organizationId = null)

Interchange Clearing Level data for an account or a merchant

Interchange Clearing Level data for an account or a merchant

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetInterchangeClearingLevelDetailsExample
    {
        public void main()
        {
            var apiInstance = new InterchangeClearingLevelDetailsApi();
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) 
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 

            try
            {
                // Interchange Clearing Level data for an account or a merchant
                ReportingV3InterchangeClearingLevelDetailsGet200Response result = apiInstance.GetInterchangeClearingLevelDetails(startTime, endTime, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterchangeClearingLevelDetailsApi.GetInterchangeClearingLevelDetails: " + e.Message );
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

### Return type

[**ReportingV3InterchangeClearingLevelDetailsGet200Response**](ReportingV3InterchangeClearingLevelDetailsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

