# CyberSource.Api.ProductFeedApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllProducts**](ProductFeedApi.md#getallproducts) | **GET** /icc/v1/products | Get All Products
[**GetFeedJobStatus**](ProductFeedApi.md#getfeedjobstatus) | **GET** /icc/v1/products/feed/bulk/{jobId} | Get Feed Job Status
[**GetProduct**](ProductFeedApi.md#getproduct) | **GET** /icc/v1/products/{product_id} | Get Product by ID
[**SubmitProductFeedJson**](ProductFeedApi.md#submitproductfeedjson) | **POST** /icc/v1/products/feed | Ingest Product Feed


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
            var apiInstance = new ProductFeedApi();
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
                Debug.Print("Exception when calling ProductFeedApi.GetAllProducts: " + e.Message );
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

<a name="getfeedjobstatus"></a>
# **GetFeedJobStatus**
> InlineResponse20019 GetFeedJobStatus (Guid? jobId, Object getFeedJobStatusRequest)

Get Feed Job Status

Returns the processing and syndication status of a previously submitted product feed job.  Use this to poll the `jobId` returned by the Ingest Product Feed endpoint until processing and syndication complete. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetFeedJobStatusExample
    {
        public void main()
        {
            var apiInstance = new ProductFeedApi();
            var jobId = new Guid?(); // Guid? | Unique identifier of the feed submission job, returned by the Ingest Product Feed endpoint. 
            var getFeedJobStatusRequest = ;  // Object | Empty request body.

            try
            {
                // Get Feed Job Status
                InlineResponse20019 result = apiInstance.GetFeedJobStatus(jobId, getFeedJobStatusRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductFeedApi.GetFeedJobStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | [**Guid?**](Guid?.md)| Unique identifier of the feed submission job, returned by the Ingest Product Feed endpoint.  | 
 **getFeedJobStatusRequest** | **Object**| Empty request body. | 

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

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
            var apiInstance = new ProductFeedApi();
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
                Debug.Print("Exception when calling ProductFeedApi.GetProduct: " + e.Message );
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

<a name="submitproductfeedjson"></a>
# **SubmitProductFeedJson**
> InlineResponse2021 SubmitProductFeedJson (ProductFeedRequest productFeedRequest)

Ingest Product Feed

Submits a merchant product catalog to ACG for asynchronous processing and syndication to all configured protocol backends (e.g. Google Merchant Center).  **Processing pipeline:** 1. The request is accepted immediately and a `jobId` is returned — validation, ingestion,    and syndication all happen asynchronously in the background. 2. Each product is validated against UCP/ACP schema requirements (required fields, format rules) 3. Valid products are saved to the ACG catalog 4. An async syndication job is triggered to push the catalog to configured backends  **Supported content types:** `application/json` (this endpoint). CSV and JSONL uploads are also supported via file upload endpoints.  **Note:** This endpoint no longer returns per-product validation results or syndication outcomes synchronously — only the `jobId` acknowledgement shown below. Use that `jobId` to track processing and syndication status. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class SubmitProductFeedJsonExample
    {
        public void main()
        {
            var apiInstance = new ProductFeedApi();
            var productFeedRequest = new ProductFeedRequest(); // ProductFeedRequest | Product feed payload. The `products` array is required and must contain at least one product. See `ProductInput` for the full list of required fields. 

            try
            {
                // Ingest Product Feed
                InlineResponse2021 result = apiInstance.SubmitProductFeedJson(productFeedRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductFeedApi.SubmitProductFeedJson: " + e.Message );
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

[**InlineResponse2021**](InlineResponse2021.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

