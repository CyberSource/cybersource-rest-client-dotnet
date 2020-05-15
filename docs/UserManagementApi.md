# CyberSource.Api.UserManagementApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUsers**](UserManagementApi.md#getusers) | **GET** /ums/v1/users | Get User Information - Deprecated


<a name="getusers"></a>
# **GetUsers**
> UmsV1UsersGet200Response GetUsers (string organizationId = null, string userName = null, string permissionId = null, string roleId = null)

Get User Information - Deprecated

This endpoint is deprecated. Please use the search end point.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            var apiInstance = new UserManagementApi();
            var organizationId = organizationId_example;  // string | This is the orgId of the organization which the user belongs to. (optional) 
            var userName = userName_example;  // string | User ID of the user you want to get details on. (optional) 
            var permissionId = permissionId_example;  // string | permission that you are trying to search user on. (optional) 
            var roleId = roleId_example;  // string | role of the user you are trying to search on. (optional) 

            try
            {
                // Get User Information - Deprecated
                UmsV1UsersGet200Response result = apiInstance.GetUsers(organizationId, userName, permissionId, roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserManagementApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| This is the orgId of the organization which the user belongs to. | [optional] 
 **userName** | **string**| User ID of the user you want to get details on. | [optional] 
 **permissionId** | **string**| permission that you are trying to search user on. | [optional] 
 **roleId** | **string**| role of the user you are trying to search on. | [optional] 

### Return type

[**UmsV1UsersGet200Response**](UmsV1UsersGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

