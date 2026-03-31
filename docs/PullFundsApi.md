# CyberSource.Api.PullFundsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePullFundsRefund**](PullFundsApi.md#createpullfundsrefund) | **POST** /pts/v1/pull-funds-transfer/{id}/refund | Process a Pull Funds Refund
[**CreatePullFundsReversal**](PullFundsApi.md#createpullfundsreversal) | **POST** /pts/v1/pull-funds-transfer/{id}/reversal | Process a Pull Funds Reversal
[**CreatePullFundsTransfer**](PullFundsApi.md#createpullfundstransfer) | **POST** /pts/v1/pull-funds-transfer | Process a Pull Funds Transfer


<a name="createpullfundsrefund"></a>
# **CreatePullFundsRefund**
> PullFundsRefund201Response CreatePullFundsRefund (PullFundsRefundRequest pullFundsRefundRequest, string id, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId)

Process a Pull Funds Refund

Refund an Account Funding Transaction (AFT). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreatePullFundsRefundExample
    {
        public void main()
        {
            var apiInstance = new PullFundsApi();
            var pullFundsRefundRequest = new PullFundsRefundRequest(); // PullFundsRefundRequest | 
            var id = id_example;  // string | The transaction id of a previous Account Funding Transaction. 
            var contentType = contentType_example;  // string | 
            var xRequestid = xRequestid_example;  // string | 
            var vCMerchantId = vCMerchantId_example;  // string | 
            var vCPermissions = vCPermissions_example;  // string | 
            var vCCorrelationId = vCCorrelationId_example;  // string | 
            var vCOrganizationId = vCOrganizationId_example;  // string | 

            try
            {
                // Process a Pull Funds Refund
                PullFundsRefund201Response result = apiInstance.CreatePullFundsRefund(pullFundsRefundRequest, id, contentType, xRequestid, vCMerchantId, vCPermissions, vCCorrelationId, vCOrganizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullFundsApi.CreatePullFundsRefund: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pullFundsRefundRequest** | [**PullFundsRefundRequest**](PullFundsRefundRequest.md)|  | 
 **id** | **string**| The transaction id of a previous Account Funding Transaction.  | 
 **contentType** | **string**|  | 
 **xRequestid** | **string**|  | 
 **vCMerchantId** | **string**|  | 
 **vCPermissions** | **string**|  | 
 **vCCorrelationId** | **string**|  | 
 **vCOrganizationId** | **string**|  | 

### Return type

[**PullFundsRefund201Response**](PullFundsRefund201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpullfundsreversal"></a>
# **CreatePullFundsReversal**
> PullFundsReversal201Response CreatePullFundsReversal (PullFundsReversalRequest pullFundsReversalRequest, string id, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId)

Process a Pull Funds Reversal

Reverse an Account Funding Transaction (AFT). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreatePullFundsReversalExample
    {
        public void main()
        {
            var apiInstance = new PullFundsApi();
            var pullFundsReversalRequest = new PullFundsReversalRequest(); // PullFundsReversalRequest | 
            var id = id_example;  // string | The transaction id of a previous Account Funding Transaction. 
            var contentType = contentType_example;  // string | 
            var xRequestid = xRequestid_example;  // string | 
            var vCMerchantId = vCMerchantId_example;  // string | 
            var vCPermissions = vCPermissions_example;  // string | 
            var vCCorrelationId = vCCorrelationId_example;  // string | 
            var vCOrganizationId = vCOrganizationId_example;  // string | 

            try
            {
                // Process a Pull Funds Reversal
                PullFundsReversal201Response result = apiInstance.CreatePullFundsReversal(pullFundsReversalRequest, id, contentType, xRequestid, vCMerchantId, vCPermissions, vCCorrelationId, vCOrganizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullFundsApi.CreatePullFundsReversal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pullFundsReversalRequest** | [**PullFundsReversalRequest**](PullFundsReversalRequest.md)|  | 
 **id** | **string**| The transaction id of a previous Account Funding Transaction.  | 
 **contentType** | **string**|  | 
 **xRequestid** | **string**|  | 
 **vCMerchantId** | **string**|  | 
 **vCPermissions** | **string**|  | 
 **vCCorrelationId** | **string**|  | 
 **vCOrganizationId** | **string**|  | 

### Return type

[**PullFundsReversal201Response**](PullFundsReversal201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpullfundstransfer"></a>
# **CreatePullFundsTransfer**
> PullFunds201Response CreatePullFundsTransfer (PullFundsRequest pullFundsRequest, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId)

Process a Pull Funds Transfer

Receive funds using an Account Funding Transaction (AFT). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreatePullFundsTransferExample
    {
        public void main()
        {
            var apiInstance = new PullFundsApi();
            var pullFundsRequest = new PullFundsRequest(); // PullFundsRequest | 
            var contentType = contentType_example;  // string | 
            var xRequestid = xRequestid_example;  // string | 
            var vCMerchantId = vCMerchantId_example;  // string | 
            var vCPermissions = vCPermissions_example;  // string | 
            var vCCorrelationId = vCCorrelationId_example;  // string | 
            var vCOrganizationId = vCOrganizationId_example;  // string | 

            try
            {
                // Process a Pull Funds Transfer
                PullFunds201Response result = apiInstance.CreatePullFundsTransfer(pullFundsRequest, contentType, xRequestid, vCMerchantId, vCPermissions, vCCorrelationId, vCOrganizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullFundsApi.CreatePullFundsTransfer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pullFundsRequest** | [**PullFundsRequest**](PullFundsRequest.md)|  | 
 **contentType** | **string**|  | 
 **xRequestid** | **string**|  | 
 **vCMerchantId** | **string**|  | 
 **vCPermissions** | **string**|  | 
 **vCCorrelationId** | **string**|  | 
 **vCOrganizationId** | **string**|  | 

### Return type

[**PullFunds201Response**](PullFunds201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

