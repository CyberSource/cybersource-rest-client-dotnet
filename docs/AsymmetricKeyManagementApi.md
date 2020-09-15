# CyberSource.Api.AsymmetricKeyManagementApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateP12Keys**](AsymmetricKeyManagementApi.md#createp12keys) | **POST** /kms/v2/keys-asym | Create one or more PKCS#12 keys
[**DeleteBulkP12Keys**](AsymmetricKeyManagementApi.md#deletebulkp12keys) | **POST** /kms/v2/keys-asym/deletes | Delete one or more PKCS#12 keys
[**GetP12KeyDetails**](AsymmetricKeyManagementApi.md#getp12keydetails) | **GET** /kms/v2/keys-asym/{keyId} | Retrieves PKCS#12 key details


<a name="createp12keys"></a>
# **CreateP12Keys**
> KmsV2KeysAsymPost201Response CreateP12Keys (CreateP12KeysRequest createP12KeysRequest)

Create one or more PKCS#12 keys

'Create one or more PKCS#12 keys' 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateP12KeysExample
    {
        public void main()
        {
            var apiInstance = new AsymmetricKeyManagementApi();
            var createP12KeysRequest = new CreateP12KeysRequest(); // CreateP12KeysRequest | 

            try
            {
                // Create one or more PKCS#12 keys
                KmsV2KeysAsymPost201Response result = apiInstance.CreateP12Keys(createP12KeysRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsymmetricKeyManagementApi.CreateP12Keys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createP12KeysRequest** | [**CreateP12KeysRequest**](CreateP12KeysRequest.md)|  | 

### Return type

[**KmsV2KeysAsymPost201Response**](KmsV2KeysAsymPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebulkp12keys"></a>
# **DeleteBulkP12Keys**
> KmsV2KeysAsymDeletesPost200Response DeleteBulkP12Keys (DeleteBulkP12KeysRequest deleteBulkP12KeysRequest)

Delete one or more PKCS#12 keys

'Delete one or more PKCS#12 keys' 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteBulkP12KeysExample
    {
        public void main()
        {
            var apiInstance = new AsymmetricKeyManagementApi();
            var deleteBulkP12KeysRequest = new DeleteBulkP12KeysRequest(); // DeleteBulkP12KeysRequest | 

            try
            {
                // Delete one or more PKCS#12 keys
                KmsV2KeysAsymDeletesPost200Response result = apiInstance.DeleteBulkP12Keys(deleteBulkP12KeysRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsymmetricKeyManagementApi.DeleteBulkP12Keys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deleteBulkP12KeysRequest** | [**DeleteBulkP12KeysRequest**](DeleteBulkP12KeysRequest.md)|  | 

### Return type

[**KmsV2KeysAsymDeletesPost200Response**](KmsV2KeysAsymDeletesPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getp12keydetails"></a>
# **GetP12KeyDetails**
> KmsV2KeysAsymGet200Response GetP12KeyDetails (string keyId)

Retrieves PKCS#12 key details

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
    public class GetP12KeyDetailsExample
    {
        public void main()
        {
            var apiInstance = new AsymmetricKeyManagementApi();
            var keyId = keyId_example;  // string | Key ID. 

            try
            {
                // Retrieves PKCS#12 key details
                KmsV2KeysAsymGet200Response result = apiInstance.GetP12KeyDetails(keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsymmetricKeyManagementApi.GetP12KeyDetails: " + e.Message );
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

[**KmsV2KeysAsymGet200Response**](KmsV2KeysAsymGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

