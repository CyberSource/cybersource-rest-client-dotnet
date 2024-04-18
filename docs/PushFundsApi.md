# CyberSource.Api.PushFundsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePushFundsTransfer**](PushFundsApi.md#createpushfundstransfer) | **POST** /pts/v1/push-funds-transfer | Process a Push Funds Transfer


<a name="createpushfundstransfer"></a>
# **CreatePushFundsTransfer**
> PushFunds201Response CreatePushFundsTransfer (PushFundsRequest pushFundsRequest, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId)

Process a Push Funds Transfer

Receive funds using an Original Credit Transaction (OCT). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreatePushFundsTransferExample
    {
        public void main()
        {
            var apiInstance = new PushFundsApi();
            var pushFundsRequest = new PushFundsRequest(); // PushFundsRequest | 
            var contentType = contentType_example;  // string | 
            var xRequestid = xRequestid_example;  // string | 
            var vCMerchantId = vCMerchantId_example;  // string | 
            var vCPermissions = vCPermissions_example;  // string | 
            var vCCorrelationId = vCCorrelationId_example;  // string | 
            var vCOrganizationId = vCOrganizationId_example;  // string | 

            try
            {
                // Process a Push Funds Transfer
                PushFunds201Response result = apiInstance.CreatePushFundsTransfer(pushFundsRequest, contentType, xRequestid, vCMerchantId, vCPermissions, vCCorrelationId, vCOrganizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushFundsApi.CreatePushFundsTransfer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pushFundsRequest** | [**PushFundsRequest**](PushFundsRequest.md)|  | 
 **contentType** | **string**|  | 
 **xRequestid** | **string**|  | 
 **vCMerchantId** | **string**|  | 
 **vCPermissions** | **string**|  | 
 **vCCorrelationId** | **string**|  | 
 **vCOrganizationId** | **string**|  | 

### Return type

[**PushFunds201Response**](PushFunds201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

