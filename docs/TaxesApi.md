# CyberSource.Api.TaxesApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CalculateTax**](TaxesApi.md#calculatetax) | **POST** /vas/v2/tax | Calculate Taxes
[**VoidTax**](TaxesApi.md#voidtax) | **PATCH** /vas/v2/tax/{id} | Void Taxes


<a name="calculatetax"></a>
# **CalculateTax**
> VasV2PaymentsPost201Response CalculateTax (TaxRequest taxRequest)

Calculate Taxes

The tax calculation service provides real-time sales tax and VAT calculations for orders placed with your business worldwide.  It enhances your ability to conduct business globally and enables you to avoid the risk and complexity of managing online tax calculation.  The service supports product-based tax rules and exemptions for goods and services.  The tax rates are updated twice a month and calculations include sub-level detail (rates per taxing jurisdiction, names and types of jurisdictions). Implementation guidance, list of supported countries, and information on tax reporting are in the [Tax User Guide](https://developer.cybersource.com/docs/cybs/en-us/tax-calculation/developer/all/rest/tax-calculation/tax-overview.html). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CalculateTaxExample
    {
        public void main()
        {
            var apiInstance = new TaxesApi();
            var taxRequest = new TaxRequest(); // TaxRequest | 

            try
            {
                // Calculate Taxes
                VasV2PaymentsPost201Response result = apiInstance.CalculateTax(taxRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.CalculateTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taxRequest** | [**TaxRequest**](TaxRequest.md)|  | 

### Return type

[**VasV2PaymentsPost201Response**](VasV2PaymentsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voidtax"></a>
# **VoidTax**
> VasV2TaxVoid200Response VoidTax (VoidTaxRequest voidTaxRequest, string id)

Void Taxes

Pass the Tax Request ID in the PATCH request to void the committed tax calculation.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class VoidTaxExample
    {
        public void main()
        {
            var apiInstance = new TaxesApi();
            var voidTaxRequest = new VoidTaxRequest(); // VoidTaxRequest | 
            var id = id_example;  // string | The tax ID returned from a previous request.

            try
            {
                // Void Taxes
                VasV2TaxVoid200Response result = apiInstance.VoidTax(voidTaxRequest, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.VoidTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voidTaxRequest** | [**VoidTaxRequest**](VoidTaxRequest.md)|  | 
 **id** | **string**| The tax ID returned from a previous request. | 

### Return type

[**VasV2TaxVoid200Response**](VasV2TaxVoid200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

