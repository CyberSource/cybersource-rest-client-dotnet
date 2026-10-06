# CyberSource.Api.MerchantRegistrationApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateMerchantKey**](MerchantRegistrationApi.md#activatemerchantkey) | **POST** /icc/v1/merchants/{merchantId}/keys/{keyId}/activate | Activate a merchant key
[**AddMerchantKey**](MerchantRegistrationApi.md#addmerchantkey) | **POST** /icc/v1/merchants/{merchantId}/keys | Add a key to a merchant
[**GetMerchant**](MerchantRegistrationApi.md#getmerchant) | **GET** /icc/v1/merchants/{merchantId} | Get a merchant
[**GetMerchantKey**](MerchantRegistrationApi.md#getmerchantkey) | **GET** /icc/v1/merchants/{merchantId}/keys/{keyId} | Get a key by merchant and key ID
[**ListMerchantKeys**](MerchantRegistrationApi.md#listmerchantkeys) | **GET** /icc/v1/merchants/{merchantId}/keys | List keys for a merchant
[**RegisterMerchant**](MerchantRegistrationApi.md#registermerchant) | **POST** /icc/v1/merchants | Register a merchant
[**UpdateMerchant**](MerchantRegistrationApi.md#updatemerchant) | **PUT** /icc/v1/merchants/{merchantId} | Update a merchant
[**UpdateMerchantKey**](MerchantRegistrationApi.md#updatemerchantkey) | **PUT** /icc/v1/merchants/{merchantId}/keys/{keyId} | Update a merchant key


<a name="activatemerchantkey"></a>
# **ActivateMerchantKey**
> ActivateMerchantKeyResponse200 ActivateMerchantKey (string merchantId, string keyId)

Activate a merchant key

**Activate a Merchant Key**<br>Activates a deactivated encryption key for the specified merchant.<br><br> **Note:** Expired keys must be renewed via `PUT /merchants/{merchantId}/keys/{keyId}` before they can be activated.<br> Returns **403** if the merchant is deactivated or the key is expired, **404** if the merchant or key is not found, **409** if the key is already active. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ActivateMerchantKeyExample
    {
        public void main()
        {
            var apiInstance = new MerchantRegistrationApi();
            var merchantId = merchantId_example;  // string | Unique merchant identifier (UUID)
            var keyId = keyId_example;  // string | Unique key identifier (UUID)

            try
            {
                // Activate a merchant key
                ActivateMerchantKeyResponse200 result = apiInstance.ActivateMerchantKey(merchantId, keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantRegistrationApi.ActivateMerchantKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantId** | **string**| Unique merchant identifier (UUID) | 
 **keyId** | **string**| Unique key identifier (UUID) | 

### Return type

[**ActivateMerchantKeyResponse200**](ActivateMerchantKeyResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addmerchantkey"></a>
# **AddMerchantKey**
> ActivateMerchantKeyResponse200 AddMerchantKey (string merchantId, KeyRequest1 keyRequest)

Add a key to a merchant

**Add a Key to a Merchant**<br>Adds a new encryption key for the specified merchant. The new key is created as ***active*** immediately.<br><br> **Note:** Adding a new key automatically deactivates all previously active keys for this merchant (single-active key invariant).<br> Returns **403** if the merchant is deactivated, **404** if the merchant is not found. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class AddMerchantKeyExample
    {
        public void main()
        {
            var apiInstance = new MerchantRegistrationApi();
            var merchantId = merchantId_example;  // string | Unique merchant identifier (UUID)
            var keyRequest = new KeyRequest1(); // KeyRequest1 | Key creation request

            try
            {
                // Add a key to a merchant
                ActivateMerchantKeyResponse200 result = apiInstance.AddMerchantKey(merchantId, keyRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantRegistrationApi.AddMerchantKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantId** | **string**| Unique merchant identifier (UUID) | 
 **keyRequest** | [**KeyRequest1**](KeyRequest1.md)| Key creation request | 

### Return type

[**ActivateMerchantKeyResponse200**](ActivateMerchantKeyResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmerchant"></a>
# **GetMerchant**
> MerchantRegistrationResponse201 GetMerchant (string merchantId)

Get a merchant

**Get a Merchant**<br>Retrieves a single merchant by its unique identifier, including all associated encryption keys.<br><br> Returns **404** if the merchant is not found. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetMerchantExample
    {
        public void main()
        {
            var apiInstance = new MerchantRegistrationApi();
            var merchantId = merchantId_example;  // string | Unique merchant identifier (UUID)

            try
            {
                // Get a merchant
                MerchantRegistrationResponse201 result = apiInstance.GetMerchant(merchantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantRegistrationApi.GetMerchant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantId** | **string**| Unique merchant identifier (UUID) | 

### Return type

[**MerchantRegistrationResponse201**](MerchantRegistrationResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmerchantkey"></a>
# **GetMerchantKey**
> ActivateMerchantKeyResponse200 GetMerchantKey (string merchantId, string keyId)

Get a key by merchant and key ID

**Get a Merchant Key**<br>Retrieves a specific encryption key by merchant ID and key ID.<br><br> Returns **404** if the merchant or key is not found. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetMerchantKeyExample
    {
        public void main()
        {
            var apiInstance = new MerchantRegistrationApi();
            var merchantId = merchantId_example;  // string | Unique merchant identifier (UUID)
            var keyId = keyId_example;  // string | Unique key identifier (UUID)

            try
            {
                // Get a key by merchant and key ID
                ActivateMerchantKeyResponse200 result = apiInstance.GetMerchantKey(merchantId, keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantRegistrationApi.GetMerchantKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantId** | **string**| Unique merchant identifier (UUID) | 
 **keyId** | **string**| Unique key identifier (UUID) | 

### Return type

[**ActivateMerchantKeyResponse200**](ActivateMerchantKeyResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmerchantkeys"></a>
# **ListMerchantKeys**
> ListMerchantKeysResponse200 ListMerchantKeys (string merchantId, string status = null)

List keys for a merchant

**List Keys for a Merchant**<br>Returns all encryption keys associated with the specified merchant, with optional filtering by key status.<br><br> Returns **404** if the merchant is not found. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ListMerchantKeysExample
    {
        public void main()
        {
            var apiInstance = new MerchantRegistrationApi();
            var merchantId = merchantId_example;  // string | Unique merchant identifier (UUID)
            var status = status_example;  // string | Filter by key status: 'active', 'deactivated', or 'expired'. Omit to return all keys. (optional) 

            try
            {
                // List keys for a merchant
                ListMerchantKeysResponse200 result = apiInstance.ListMerchantKeys(merchantId, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantRegistrationApi.ListMerchantKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantId** | **string**| Unique merchant identifier (UUID) | 
 **status** | **string**| Filter by key status: &#39;active&#39;, &#39;deactivated&#39;, or &#39;expired&#39;. Omit to return all keys. | [optional] 

### Return type

[**ListMerchantKeysResponse200**](ListMerchantKeysResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registermerchant"></a>
# **RegisterMerchant**
> MerchantRegistrationResponse201 RegisterMerchant (MerchantRequest merchantRequest)

Register a merchant

**Register a Merchant**<br>Onboards a new merchant into the Visa Merchant Registry Service (VMRS). The merchant declares how payment credentials should be delivered: cryptogram type (TAVV or DAVV), transaction indicator (TAP — Trusted Agent Protocol, ACG — Agentic Checkout Gateway, or BOTH), and whether credentials should be encrypted.<br><br> If `paymentPayloadType` is set to ***ENCRYPTED***, an `encryptionKey` must be provided.<br> Returns **409** if a merchant with the same `merchantUrl` or `vmid` already exists. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class RegisterMerchantExample
    {
        public void main()
        {
            var apiInstance = new MerchantRegistrationApi();
            var merchantRequest = new MerchantRequest(); // MerchantRequest | Merchant registration request

            try
            {
                // Register a merchant
                MerchantRegistrationResponse201 result = apiInstance.RegisterMerchant(merchantRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantRegistrationApi.RegisterMerchant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantRequest** | [**MerchantRequest**](MerchantRequest.md)| Merchant registration request | 

### Return type

[**MerchantRegistrationResponse201**](MerchantRegistrationResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemerchant"></a>
# **UpdateMerchant**
> MerchantRegistrationResponse201 UpdateMerchant (string merchantId, MerchantUpdate merchantUpdate)

Update a merchant

**Update a Merchant**<br>Updates merchant configuration. The following fields can be modified: `merchantName`, `merchantUrl`, `cryptogramType`, `paymentPayloadType`, `acceptanceRelationships`, `protocolInteractions`, `webIntegrations`, and `apiIntegrations`.<br><br> Partial updates are supported — only provided fields are changed. The `vmid` and `indicator` fields cannot be updated via this endpoint.<br> Returns **400** if switching to ***ENCRYPTED*** without an active encryption key, **403** if the merchant is deactivated, **404** if not found, **409** if the new `merchantUrl` already exists. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateMerchantExample
    {
        public void main()
        {
            var apiInstance = new MerchantRegistrationApi();
            var merchantId = merchantId_example;  // string | Unique merchant identifier (UUID)
            var merchantUpdate = new MerchantUpdate(); // MerchantUpdate | Merchant update request

            try
            {
                // Update a merchant
                MerchantRegistrationResponse201 result = apiInstance.UpdateMerchant(merchantId, merchantUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantRegistrationApi.UpdateMerchant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantId** | **string**| Unique merchant identifier (UUID) | 
 **merchantUpdate** | [**MerchantUpdate**](MerchantUpdate.md)| Merchant update request | 

### Return type

[**MerchantRegistrationResponse201**](MerchantRegistrationResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemerchantkey"></a>
# **UpdateMerchantKey**
> ActivateMerchantKeyResponse200 UpdateMerchantKey (string merchantId, string keyId, KeyUpdate1 keyUpdate)

Update a merchant key

**Update a Merchant Key**<br>Updates encryption key information. The following fields can be modified: `keyName`, `encryptionKey`, `algorithm`, `encryptionType`, and `expirationDate`.<br><br> Returns **403** if the merchant is deactivated, key is deactivated, or key is expired, **404** if the merchant or key is not found, **409** if the new `keyName` already exists. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateMerchantKeyExample
    {
        public void main()
        {
            var apiInstance = new MerchantRegistrationApi();
            var merchantId = merchantId_example;  // string | Unique merchant identifier (UUID)
            var keyId = keyId_example;  // string | Unique key identifier (UUID)
            var keyUpdate = new KeyUpdate1(); // KeyUpdate1 | Key update request

            try
            {
                // Update a merchant key
                ActivateMerchantKeyResponse200 result = apiInstance.UpdateMerchantKey(merchantId, keyId, keyUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantRegistrationApi.UpdateMerchantKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantId** | **string**| Unique merchant identifier (UUID) | 
 **keyId** | **string**| Unique key identifier (UUID) | 
 **keyUpdate** | [**KeyUpdate1**](KeyUpdate1.md)| Key update request | 

### Return type

[**ActivateMerchantKeyResponse200**](ActivateMerchantKeyResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

