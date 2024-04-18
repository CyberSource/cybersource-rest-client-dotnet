# CyberSource.Api.KeyManagementPgpApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UpdatePGP**](KeyManagementPgpApi.md#updatepgp) | **PATCH** /kms/v2/keys-pgp/{keyId} | Activate or De-activate PGP Key


<a name="updatepgp"></a>
# **UpdatePGP**
> Object UpdatePGP (string keyId, UpdatePGPKeysRequest updatePGPKeysRequest)

Activate or De-activate PGP Key

Activate or De-activate PGP Key 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdatePGPExample
    {
        public void main()
        {
            var apiInstance = new KeyManagementPgpApi();
            var keyId = keyId_example;  // string | Key ID. 
            var updatePGPKeysRequest = new UpdatePGPKeysRequest(); // UpdatePGPKeysRequest | 

            try
            {
                // Activate or De-activate PGP Key
                Object result = apiInstance.UpdatePGP(keyId, updatePGPKeysRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeyManagementPgpApi.UpdatePGP: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyId** | **string**| Key ID.  | 
 **updatePGPKeysRequest** | [**UpdatePGPKeysRequest**](UpdatePGPKeysRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

