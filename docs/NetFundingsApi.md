# CyberSource.Api.NetFundingsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNetFundingInfo**](NetFundingsApi.md#getnetfundinginfo) | **GET** /reporting/v3/net-fundings | Get Netfunding information for an account or a merchant


<a name="getnetfundinginfo"></a>
# **GetNetFundingInfo**
> ReportingV3NetFundingsGet200Response GetNetFundingInfo (DateTime? startTime, DateTime? endTime, string organizationId = null, string groupName = null)

Get Netfunding information for an account or a merchant

Get Netfunding information for an account or a merchant.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetNetFundingInfoExample
    {
        public void main()
        {
            var apiInstance = new NetFundingsApi();
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd'T'HH:mm:ssXXX 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd'T'HH:mm:ssXXX 
            var organizationId = organizationId_example;  // string | Valid Cybersource Organization Id (optional) 
            var groupName = groupName_example;  // string | Valid CyberSource Group Name. (optional) 

            try
            {
                // Get Netfunding information for an account or a merchant
                ReportingV3NetFundingsGet200Response result = apiInstance.GetNetFundingInfo(startTime, endTime, organizationId, groupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetFundingsApi.GetNetFundingInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTime** | **DateTime?**| Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX  | 
 **endTime** | **DateTime?**| Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX  | 
 **organizationId** | **string**| Valid Cybersource Organization Id | [optional] 
 **groupName** | **string**| Valid CyberSource Group Name. | [optional] 

### Return type

[**ReportingV3NetFundingsGet200Response**](ReportingV3NetFundingsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

