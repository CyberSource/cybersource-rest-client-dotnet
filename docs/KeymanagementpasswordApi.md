# CyberSource.Api.KeyManagementPasswordApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UpdatePassword**](KeyManagementPasswordApi.md#updatepassword) | **PATCH** /kms/v2/keys-password/{keyId} | Activate or De-activate Password


<a name="updatepassword"></a>
# **UpdatePassword**
> Object UpdatePassword (string keyId, UpdatePasswordKeysRequest updatePasswordKeysRequest)

Activate or De-activate Password

Activate or De-activate key of type password 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdatePasswordExample
    {
        public void main()
        {
            var apiInstance = new KeyManagementPasswordApi();
            var keyId = keyId_example;  // string | Key ID. 
            var updatePasswordKeysRequest = new UpdatePasswordKeysRequest(); // UpdatePasswordKeysRequest | 

            try
            {
                // Activate or De-activate Password
                Object result = apiInstance.UpdatePassword(keyId, updatePasswordKeysRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeyManagementPasswordApi.UpdatePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyId** | **string**| Key ID.  | 
 **updatePasswordKeysRequest** | [**UpdatePasswordKeysRequest**](UpdatePasswordKeysRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

