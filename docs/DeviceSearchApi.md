# CyberSource.Api.DeviceSearchApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostSearchQuery**](DeviceSearchApi.md#postsearchquery) | **POST** /dms/v2/devices/search | Retrieve List of Devices for a given search query V2
[**PostSearchQueryV3**](DeviceSearchApi.md#postsearchqueryv3) | **POST** /dms/v3/devices/search | Retrieve List of Devices for a given search query


<a name="postsearchquery"></a>
# **PostSearchQuery**
> InlineResponse2009 PostSearchQuery (PostDeviceSearchRequest postDeviceSearchRequest)

Retrieve List of Devices for a given search query V2

Retrieves list of terminals in paginated format.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostSearchQueryExample
    {
        public void main()
        {
            var apiInstance = new DeviceSearchApi();
            var postDeviceSearchRequest = new PostDeviceSearchRequest(); // PostDeviceSearchRequest | 

            try
            {
                // Retrieve List of Devices for a given search query V2
                InlineResponse2009 result = apiInstance.PostSearchQuery(postDeviceSearchRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceSearchApi.PostSearchQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postDeviceSearchRequest** | [**PostDeviceSearchRequest**](PostDeviceSearchRequest.md)|  | 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsearchqueryv3"></a>
# **PostSearchQueryV3**
> InlineResponse20011 PostSearchQueryV3 (PostDeviceSearchRequestV3 postDeviceSearchRequestV3)

Retrieve List of Devices for a given search query

Search for devices matching a given search query.  The search query supports serialNumber, readerId, terminalId, status, statusChangeReason or organizationId  Matching results are paginated. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostSearchQueryV3Example
    {
        public void main()
        {
            var apiInstance = new DeviceSearchApi();
            var postDeviceSearchRequestV3 = new PostDeviceSearchRequestV3(); // PostDeviceSearchRequestV3 | 

            try
            {
                // Retrieve List of Devices for a given search query
                InlineResponse20011 result = apiInstance.PostSearchQueryV3(postDeviceSearchRequestV3);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceSearchApi.PostSearchQueryV3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postDeviceSearchRequestV3** | [**PostDeviceSearchRequestV3**](PostDeviceSearchRequestV3.md)|  | 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

