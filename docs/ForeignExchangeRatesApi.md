# CyberSource.Api.ForeignExchangeRatesApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFxRates**](ForeignExchangeRatesApi.md#createfxrates) | **POST** /pts/v2/payouts/fx-rates | Retrieve Foreign Exchange Rates


<a name="createfxrates"></a>
# **CreateFxRates**
> InlineResponse2013 CreateFxRates (Body body, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId)

Retrieve Foreign Exchange Rates

Retrieve current foreign exchange rates for cross-border payouts. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateFxRatesExample
    {
        public void main()
        {
            var apiInstance = new ForeignExchangeRatesApi();
            var body = new Body(); // Body | 
            var contentType = contentType_example;  // string | 
            var xRequestid = xRequestid_example;  // string | 
            var vCMerchantId = vCMerchantId_example;  // string | 
            var vCPermissions = vCPermissions_example;  // string | 
            var vCCorrelationId = vCCorrelationId_example;  // string | 
            var vCOrganizationId = vCOrganizationId_example;  // string | 

            try
            {
                // Retrieve Foreign Exchange Rates
                InlineResponse2013 result = apiInstance.CreateFxRates(body, contentType, xRequestid, vCMerchantId, vCPermissions, vCCorrelationId, vCOrganizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForeignExchangeRatesApi.CreateFxRates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)|  | 
 **contentType** | **string**|  | 
 **xRequestid** | **string**|  | 
 **vCMerchantId** | **string**|  | 
 **vCPermissions** | **string**|  | 
 **vCCorrelationId** | **string**|  | 
 **vCOrganizationId** | **string**|  | 

### Return type

[**InlineResponse2013**](InlineResponse2013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

