# CyberSource.Api.SymmetricKeyManagementApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateV2SharedSecretKeys**](SymmetricKeyManagementApi.md#createv2sharedsecretkeys) | **POST** /kms/v2/keys-sym | Create Shared-Secret Keys
[**DeleteBulkSymmetricKeys**](SymmetricKeyManagementApi.md#deletebulksymmetrickeys) | **POST** /kms/v2/keys-sym/deletes | Delete one or more Symmetric keys
[**GetKeyDetails**](SymmetricKeyManagementApi.md#getkeydetails) | **GET** /kms/v2/keys-sym/{keyId} | Retrieves shared secret key details


<a name="createv2sharedsecretkeys"></a>
# **CreateV2SharedSecretKeys**
> InlineResponse201 CreateV2SharedSecretKeys (CreateSharedSecretKeysRequest createSharedSecretKeysRequest)

Create Shared-Secret Keys

Create one or more Shared-Secret Keys 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateV2SharedSecretKeysExample
    {
        public void main()
        {
            var apiInstance = new SymmetricKeyManagementApi();
            var createSharedSecretKeysRequest = new CreateSharedSecretKeysRequest(); // CreateSharedSecretKeysRequest | 

            try
            {
                // Create Shared-Secret Keys
                InlineResponse201 result = apiInstance.CreateV2SharedSecretKeys(createSharedSecretKeysRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SymmetricKeyManagementApi.CreateV2SharedSecretKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createSharedSecretKeysRequest** | [**CreateSharedSecretKeysRequest**](CreateSharedSecretKeysRequest.md)|  | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebulksymmetrickeys"></a>
# **DeleteBulkSymmetricKeys**
> InlineResponse2001 DeleteBulkSymmetricKeys (DeleteBulkSymmetricKeysRequest deleteBulkSymmetricKeysRequest)

Delete one or more Symmetric keys

'Delete one or more Symmetric keys' 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteBulkSymmetricKeysExample
    {
        public void main()
        {
            var apiInstance = new SymmetricKeyManagementApi();
            var deleteBulkSymmetricKeysRequest = new DeleteBulkSymmetricKeysRequest(); // DeleteBulkSymmetricKeysRequest | 

            try
            {
                // Delete one or more Symmetric keys
                InlineResponse2001 result = apiInstance.DeleteBulkSymmetricKeys(deleteBulkSymmetricKeysRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SymmetricKeyManagementApi.DeleteBulkSymmetricKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deleteBulkSymmetricKeysRequest** | [**DeleteBulkSymmetricKeysRequest**](DeleteBulkSymmetricKeysRequest.md)|  | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkeydetails"></a>
# **GetKeyDetails**
> InlineResponse200 GetKeyDetails (string keyId)

Retrieves shared secret key details

Retrieves keys details by providing the key id.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetKeyDetailsExample
    {
        public void main()
        {
            var apiInstance = new SymmetricKeyManagementApi();
            var keyId = keyId_example;  // string | Key ID. 

            try
            {
                // Retrieves shared secret key details
                InlineResponse200 result = apiInstance.GetKeyDetails(keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SymmetricKeyManagementApi.GetKeyDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyId** | **string**| Key ID.  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

