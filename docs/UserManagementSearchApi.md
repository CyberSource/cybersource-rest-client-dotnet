# CyberSource.Api.UserManagementSearchApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchUsers**](UserManagementSearchApi.md#searchusers) | **POST** /ums/v1/users/search | Search User Information


<a name="searchusers"></a>
# **SearchUsers**
> UmsV1UsersGet200Response SearchUsers (SearchRequest searchRequest)

Search User Information

This endpoint is to get all the user information depending on the filter criteria passed in request body.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class SearchUsersExample
    {
        public void main()
        {
            var apiInstance = new UserManagementSearchApi();
            var searchRequest = new SearchRequest(); // SearchRequest | 

            try
            {
                // Search User Information
                UmsV1UsersGet200Response result = apiInstance.SearchUsers(searchRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserManagementSearchApi.SearchUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchRequest** | [**SearchRequest**](SearchRequest.md)|  | 

### Return type

[**UmsV1UsersGet200Response**](UmsV1UsersGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

