# CyberSource.Api.SymmetricKeyManagementApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateV2SharedSecretKeys**](SymmetricKeyManagementApi.md#createv2sharedsecretkeys) | **POST** /kms/v2/keys-sym | Create Shared-Secret Keys
[**CreateV2SharedSecretKeysVerifi**](SymmetricKeyManagementApi.md#createv2sharedsecretkeysverifi) | **POST** /kms/v2/keys-sym/verifi | Create Shared-Secret Keys as per verifi spec
[**DeleteBulkSymmetricKeys**](SymmetricKeyManagementApi.md#deletebulksymmetrickeys) | **POST** /kms/v2/keys-sym/deletes | Delete one or more Symmetric keys
[**GetKeyDetails**](SymmetricKeyManagementApi.md#getkeydetails) | **GET** /kms/v2/keys-sym/{keyId} | Retrieves shared secret key details


<a name="createv2sharedsecretkeys"></a>
# **CreateV2SharedSecretKeys**
> KmsV2KeysSymPost201Response CreateV2SharedSecretKeys (CreateSharedSecretKeysRequest createSharedSecretKeysRequest)

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
                KmsV2KeysSymPost201Response result = apiInstance.CreateV2SharedSecretKeys(createSharedSecretKeysRequest);
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

[**KmsV2KeysSymPost201Response**](KmsV2KeysSymPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createv2sharedsecretkeysverifi"></a>
# **CreateV2SharedSecretKeysVerifi**
> KmsV2KeysSymPost201Response CreateV2SharedSecretKeysVerifi (string vIcDomain, CreateSharedSecretKeysVerifiRequest createSharedSecretKeysVerifiRequest)

Create Shared-Secret Keys as per verifi spec

Create one or more Shared-Secret Keys as per Verifi spec with 32 chars, store digest algo during key generation. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateV2SharedSecretKeysVerifiExample
    {
        public void main()
        {
            var apiInstance = new SymmetricKeyManagementApi();
            var vIcDomain = vIcDomain_example;  // string | domain
            var createSharedSecretKeysVerifiRequest = new CreateSharedSecretKeysVerifiRequest(); // CreateSharedSecretKeysVerifiRequest | 

            try
            {
                // Create Shared-Secret Keys as per verifi spec
                KmsV2KeysSymPost201Response result = apiInstance.CreateV2SharedSecretKeysVerifi(vIcDomain, createSharedSecretKeysVerifiRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SymmetricKeyManagementApi.CreateV2SharedSecretKeysVerifi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vIcDomain** | **string**| domain | 
 **createSharedSecretKeysVerifiRequest** | [**CreateSharedSecretKeysVerifiRequest**](CreateSharedSecretKeysVerifiRequest.md)|  | 

### Return type

[**KmsV2KeysSymPost201Response**](KmsV2KeysSymPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebulksymmetrickeys"></a>
# **DeleteBulkSymmetricKeys**
> KmsV2KeysSymDeletesPost200Response DeleteBulkSymmetricKeys (DeleteBulkSymmetricKeysRequest deleteBulkSymmetricKeysRequest)

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
                KmsV2KeysSymDeletesPost200Response result = apiInstance.DeleteBulkSymmetricKeys(deleteBulkSymmetricKeysRequest);
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

[**KmsV2KeysSymDeletesPost200Response**](KmsV2KeysSymDeletesPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkeydetails"></a>
# **GetKeyDetails**
> KmsV2KeysSymGet200Response GetKeyDetails (string keyId)

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
                KmsV2KeysSymGet200Response result = apiInstance.GetKeyDetails(keyId);
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

[**KmsV2KeysSymGet200Response**](KmsV2KeysSymGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

