# CyberSource.Api.KeyManagementScmpApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UpdateSCMP**](KeyManagementScmpApi.md#updatescmp) | **PATCH** /kms/v2/keys-scmp/{keyId} | Update or Deactivate


<a name="updatescmp"></a>
# **UpdateSCMP**
> Object UpdateSCMP (string keyId, UpdatePGPKeysRequest1 updatePGPKeysRequest)

Update or Deactivate

Update or Deactivate scmp api Key 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateSCMPExample
    {
        public void main()
        {
            var apiInstance = new KeyManagementScmpApi();
            var keyId = keyId_example;  // string | Key ID. 
            var updatePGPKeysRequest = new UpdatePGPKeysRequest1(); // UpdatePGPKeysRequest1 | 

            try
            {
                // Update or Deactivate
                Object result = apiInstance.UpdateSCMP(keyId, updatePGPKeysRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeyManagementScmpApi.UpdateSCMP: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyId** | **string**| Key ID.  | 
 **updatePGPKeysRequest** | [**UpdatePGPKeysRequest1**](UpdatePGPKeysRequest1.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

