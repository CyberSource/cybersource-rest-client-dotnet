# CyberSource.Api.KeymanagementApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchKeys**](KeymanagementApi.md#searchkeys) | **GET** /kms/v2/keys | Search Keys


<a name="searchkeys"></a>
# **SearchKeys**
> InlineResponse2001 SearchKeys (int? offset = null, int? limit = null, string sort = null, List<string> organizationIds = null, List<string> keyIds = null, List<string> keyTypes = null, DateTime? expirationStartDate = null, DateTime? expirationEndDate = null)

Search Keys

Search one or more Keys

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class SearchKeysExample
    {
        public void main()
        {
            var apiInstance = new KeymanagementApi();
            var offset = 56;  // int? | This allows you to specify the page offset from the resulting list resultset you want the records to be returned (optional) 
            var limit = 56;  // int? | This allows you to specify the total number of records to be returned off the resulting list resultset (optional) 
            var sort = sort_example;  // string | This allows you to specify a comma separated list of fields in the order which the resulting list resultset must be sorted. (optional) 
            var organizationIds = new List<string>(); // List<string> | List of Orgaization Ids to search. The maximum size of the organization Ids list is 1. The maximum length of Organization Id is 30. (optional) 
            var keyIds = new List<string>(); // List<string> | List of Key Ids to search. The maximum size of the Key Ids list is 1 (optional) 
            var keyTypes = new List<string>(); // List<string> | Key Type, Possible values -  certificate, password, pgp and scmp_api. When Key Type is provided atleast one more filter needs to be provided (optional) 
            var expirationStartDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Expiry Filter Start Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional) 
            var expirationEndDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Expiry Filter End Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional) 

            try
            {
                // Search Keys
                InlineResponse2001 result = apiInstance.SearchKeys(offset, limit, sort, organizationIds, keyIds, keyTypes, expirationStartDate, expirationEndDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeymanagementApi.SearchKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| This allows you to specify the page offset from the resulting list resultset you want the records to be returned | [optional] 
 **limit** | **int?**| This allows you to specify the total number of records to be returned off the resulting list resultset | [optional] 
 **sort** | **string**| This allows you to specify a comma separated list of fields in the order which the resulting list resultset must be sorted. | [optional] 
 **organizationIds** | [**List&lt;string&gt;**](string.md)| List of Orgaization Ids to search. The maximum size of the organization Ids list is 1. The maximum length of Organization Id is 30. | [optional] 
 **keyIds** | [**List&lt;string&gt;**](string.md)| List of Key Ids to search. The maximum size of the Key Ids list is 1 | [optional] 
 **keyTypes** | [**List&lt;string&gt;**](string.md)| Key Type, Possible values -  certificate, password, pgp and scmp_api. When Key Type is provided atleast one more filter needs to be provided | [optional] 
 **expirationStartDate** | **DateTime?**| Expiry Filter Start Date. When Expiration Date filter is provided, atleast one more filter needs to be provided | [optional] 
 **expirationEndDate** | **DateTime?**| Expiry Filter End Date. When Expiration Date filter is provided, atleast one more filter needs to be provided | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

