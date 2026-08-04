# CyberSource.Api.MerchantCapabilitiesApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateMerchantKey**](MerchantCapabilitiesApi.md#activatemerchantkey) | **POST** /icc/v1/merchants/{merchantId}/keys/{keyId}/activate | Activate a merchant key
[**AddMerchantKey**](MerchantCapabilitiesApi.md#addmerchantkey) | **POST** /icc/v1/merchants/{merchantId}/keys | Add a key to a merchant
[**DeactivateMerchantKey**](MerchantCapabilitiesApi.md#deactivatemerchantkey) | **DELETE** /icc/v1/merchants/{merchantId}/keys/{keyId} | Deactivate a merchant key
[**GetAllProducts**](MerchantCapabilitiesApi.md#getallproducts) | **GET** /icc/v1/products | Get All Products
[**GetMerchant**](MerchantCapabilitiesApi.md#getmerchant) | **GET** /icc/v1/merchants/{merchantId} | Get a merchant
[**GetMerchantKey**](MerchantCapabilitiesApi.md#getmerchantkey) | **GET** /icc/v1/merchants/{merchantId}/keys/{keyId} | Get a key by merchant and key ID
[**GetProduct**](MerchantCapabilitiesApi.md#getproduct) | **GET** /icc/v1/products/{product_id} | Get Product by ID
[**IngestProductFeedJson**](MerchantCapabilitiesApi.md#ingestproductfeedjson) | **POST** /icc/v1/products/feed | Ingest Product Feed
[**ListMerchantKeys**](MerchantCapabilitiesApi.md#listmerchantkeys) | **GET** /icc/v1/merchants/{merchantId}/keys | List keys for a merchant
[**RegisterMerchant**](MerchantCapabilitiesApi.md#registermerchant) | **POST** /icc/v1/merchants | Register a merchant
[**UpdateMerchant**](MerchantCapabilitiesApi.md#updatemerchant) | **PUT** /icc/v1/merchants/{merchantId} | Update a merchant
[**UpdateMerchantKey**](MerchantCapabilitiesApi.md#updatemerchantkey) | **PUT** /icc/v1/merchants/{merchantId}/keys/{keyId} | Update a merchant key


<a name="activatemerchantkey"></a>
# **ActivateMerchantKey**
> ActivateMerchantKeyResponse200 ActivateMerchantKey (string merchantId, string keyId)

Activate a merchant key

Activate a deactivated key. Raises 403 if merchant is deactivated, 404 if merchant or key not found, 409 if key is already active.

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
            var apiInstance = new MerchantCapabilitiesApi();
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
                Debug.Print("Exception when calling MerchantCapabilitiesApi.ActivateMerchantKey: " + e.Message );
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

Add a new encryption key for a merchant. Raises 401 if not authenticated, 403 if caller does not own the merchant, 404 if merchant not found.

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
            var apiInstance = new MerchantCapabilitiesApi();
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
                Debug.Print("Exception when calling MerchantCapabilitiesApi.AddMerchantKey: " + e.Message );
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

<a name="deactivatemerchantkey"></a>
# **DeactivateMerchantKey**
> DeactivateMerchantKeyResponse200 DeactivateMerchantKey (string merchantId, string keyId)

Deactivate a merchant key

Deactivate a key (soft delete). Raises 401 if not authenticated, 403 if caller does not own the merchant, 404 if key not found.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeactivateMerchantKeyExample
    {
        public void main()
        {
            var apiInstance = new MerchantCapabilitiesApi();
            var merchantId = merchantId_example;  // string | Unique merchant identifier (UUID)
            var keyId = keyId_example;  // string | Unique key identifier (UUID)

            try
            {
                // Deactivate a merchant key
                DeactivateMerchantKeyResponse200 result = apiInstance.DeactivateMerchantKey(merchantId, keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantCapabilitiesApi.DeactivateMerchantKey: " + e.Message );
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

[**DeactivateMerchantKeyResponse200**](DeactivateMerchantKeyResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallproducts"></a>
# **GetAllProducts**
> InlineResponse20020 GetAllProducts (Object getAllProductsRequest, int? page = null, int? size = null)

Get All Products

Returns the full product catalog stored in ACG.  **Note:** This endpoint is intended for catalog verification and merchant tooling. It is not a real-time product discovery API for end buyers. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetAllProductsExample
    {
        public void main()
        {
            var apiInstance = new MerchantCapabilitiesApi();
            var getAllProductsRequest = ;  // Object | Empty request body.
            var page = 56;  // int? | Page number to retrieve (0-based). Defaults to 0. (optional)  (default to 0)
            var size = 56;  // int? | Number of products per page. Defaults to 300. Server enforces a maximum of 1000; values above 1000 are capped.  (optional)  (default to 300)

            try
            {
                // Get All Products
                InlineResponse20020 result = apiInstance.GetAllProducts(getAllProductsRequest, page, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantCapabilitiesApi.GetAllProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getAllProductsRequest** | **Object**| Empty request body. | 
 **page** | **int?**| Page number to retrieve (0-based). Defaults to 0. | [optional] [default to 0]
 **size** | **int?**| Number of products per page. Defaults to 300. Server enforces a maximum of 1000; values above 1000 are capped.  | [optional] [default to 300]

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

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

Get merchant by ID with all associated keys. Raises 404 if merchant not found.

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
            var apiInstance = new MerchantCapabilitiesApi();
            var merchantId = merchantId_example;  // string | Unique merchant identifier (UUID)

            try
            {
                // Get a merchant
                MerchantRegistrationResponse201 result = apiInstance.GetMerchant(merchantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantCapabilitiesApi.GetMerchant: " + e.Message );
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

Get a specific key by merchant ID and key ID. Raises 401 if not authenticated, 404 if key not found.

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
            var apiInstance = new MerchantCapabilitiesApi();
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
                Debug.Print("Exception when calling MerchantCapabilitiesApi.GetMerchantKey: " + e.Message );
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

<a name="getproduct"></a>
# **GetProduct**
> InlineResponse20021 GetProduct (string productId, Object getProductRequest)

Get Product by ID

Retrieves a single product from the ACG catalog by its unique product identifier (SKU).  Use this to verify that a product was ingested correctly, inspect its current field values, or check its syndication-eligibility flags (`is_eligible_search`, `is_eligible_checkout`). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetProductExample
    {
        public void main()
        {
            var apiInstance = new MerchantCapabilitiesApi();
            var productId = productId_example;  // string | The unique product identifier (SKU) assigned by the merchant and provided during feed ingestion. Example: `SKU-1001`. 
            var getProductRequest = ;  // Object | Empty request body.

            try
            {
                // Get Product by ID
                InlineResponse20021 result = apiInstance.GetProduct(productId, getProductRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantCapabilitiesApi.GetProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**| The unique product identifier (SKU) assigned by the merchant and provided during feed ingestion. Example: &#x60;SKU-1001&#x60;.  | 
 **getProductRequest** | **Object**| Empty request body. | 

### Return type

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ingestproductfeedjson"></a>
# **IngestProductFeedJson**
> InlineResponse20019 IngestProductFeedJson (ProductFeedRequest productFeedRequest)

Ingest Product Feed

Uploads a merchant product catalog to ACG and triggers asynchronous syndication to all configured protocol backends (e.g. Google Merchant Center).  **Processing pipeline:** 1. Each product is validated against UCP/ACP schema requirements (required fields, format rules) 2. Valid products are saved to the ACG catalog 3. An async syndication job is triggered to push the catalog to configured backends 4. A `feed_id` is returned — use this with the Syndication Status endpoint to monitor progress  **Supported content types:** `application/json` (this endpoint). CSV and JSONL uploads are also supported via file upload endpoints.  **Partial success:** If some products fail validation, the response status is `PARTIAL_SUCCESS` and the `errors` array lists the per-product validation failures. Successfully validated products are still ingested and syndicated. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class IngestProductFeedJsonExample
    {
        public void main()
        {
            var apiInstance = new MerchantCapabilitiesApi();
            var productFeedRequest = new ProductFeedRequest(); // ProductFeedRequest | Product feed payload. The `products` array is required and must contain at least one product. See `ProductInput` for the full list of required fields. 

            try
            {
                // Ingest Product Feed
                InlineResponse20019 result = apiInstance.IngestProductFeedJson(productFeedRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantCapabilitiesApi.IngestProductFeedJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productFeedRequest** | [**ProductFeedRequest**](ProductFeedRequest.md)| Product feed payload. The &#x60;products&#x60; array is required and must contain at least one product. See &#x60;ProductInput&#x60; for the full list of required fields.  | 

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

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

List all keys for a specific merchant with optional filtering by status. Raises 404 if merchant not found.

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
            var apiInstance = new MerchantCapabilitiesApi();
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
                Debug.Print("Exception when calling MerchantCapabilitiesApi.ListMerchantKeys: " + e.Message );
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

Onboard a new merchant into the VMRS. The merchant declares how they want payment data delivered: cryptogram type (TAVV or DAVV), transaction indicator (TAP, ACG, or Both), whether credentials should be encrypted, and their public encryption key if encryption is enabled. Raises 409 if merchantUrl or vmid already exists.

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
            var apiInstance = new MerchantCapabilitiesApi();
            var merchantRequest = new MerchantRequest(); // MerchantRequest | Merchant registration request

            try
            {
                // Register a merchant
                MerchantRegistrationResponse201 result = apiInstance.RegisterMerchant(merchantRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantCapabilitiesApi.RegisterMerchant: " + e.Message );
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

Update merchant configuration. Updatable fields: merchantName, merchantUrl, cryptogramType, acceptanceRelationships, protocolInteractions, webIntegrations, apiIntegrations. Partial updates are supported — only provided fields are changed. The vmid, indicator, and paymentPayloadType fields are not updatable here; use the enable/disable-payment-encryption endpoints for encryption changes. Raises 404 if merchant not found, 403 if merchant is deactivated, 409 if new merchantUrl already exists.

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
            var apiInstance = new MerchantCapabilitiesApi();
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
                Debug.Print("Exception when calling MerchantCapabilitiesApi.UpdateMerchant: " + e.Message );
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

Update key information. Updatable fields are keyName, encryptionKey, algorithm, encryptionType, and expirationDate. Raises 401 if not authenticated, 403 if caller does not own the merchant or if merchant/key is deactivated, 404 if merchant or key not found, 409 if new keyName already exists.

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
            var apiInstance = new MerchantCapabilitiesApi();
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
                Debug.Print("Exception when calling MerchantCapabilitiesApi.UpdateMerchantKey: " + e.Message );
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

