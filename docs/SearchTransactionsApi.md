# CyberSource.Api.SearchTransactionsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSearch**](SearchTransactionsApi.md#createsearch) | **POST** /tss/v2/searches | Create a search request
[**GetSearch**](SearchTransactionsApi.md#getsearch) | **GET** /tss/v2/searches/{id} | Get Search results


<a name="createsearch"></a>
# **CreateSearch**
> TssV2TransactionsPost201Response CreateSearch (TssV2TransactionsPostResponse createSearchRequest)

Create a search request

Create a search request. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateSearchExample
    {
        public void main()
        {
            var apiInstance = new SearchTransactionsApi();
            var createSearchRequest = new TssV2TransactionsPostResponse(); // TssV2TransactionsPostResponse | 

            try
            {
                // Create a search request
                TssV2TransactionsPost201Response result = apiInstance.CreateSearch(createSearchRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchTransactionsApi.CreateSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createSearchRequest** | [**TssV2TransactionsPostResponse**](TssV2TransactionsPostResponse.md)|  | 

### Return type

[**TssV2TransactionsPost201Response**](TssV2TransactionsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsearch"></a>
# **GetSearch**
> TssV2TransactionsPost201Response GetSearch (string id)

Get Search results

Include the Search ID in the GET request to retrieve the search results.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetSearchExample
    {
        public void main()
        {
            var apiInstance = new SearchTransactionsApi();
            var id = id_example;  // string | Search ID.

            try
            {
                // Get Search results
                TssV2TransactionsPost201Response result = apiInstance.GetSearch(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchTransactionsApi.GetSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Search ID. | 

### Return type

[**TssV2TransactionsPost201Response**](TssV2TransactionsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

