# CyberSource.Api.InvoiceSettingsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInvoiceSettings**](InvoiceSettingsApi.md#getinvoicesettings) | **GET** /invoicing/v2/invoiceSettings | Get Invoice Settings
[**UpdateInvoiceSettings**](InvoiceSettingsApi.md#updateinvoicesettings) | **PUT** /invoicing/v2/invoiceSettings | Update Invoice Settings


<a name="getinvoicesettings"></a>
# **GetInvoiceSettings**
> InvoicingV2InvoiceSettingsGet200Response GetInvoiceSettings ()

Get Invoice Settings

Allows you to retrieve the invoice settings for the payment page.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetInvoiceSettingsExample
    {
        public void main()
        {
            var apiInstance = new InvoiceSettingsApi();

            try
            {
                // Get Invoice Settings
                InvoicingV2InvoiceSettingsGet200Response result = apiInstance.GetInvoiceSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceSettingsApi.GetInvoiceSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InvoicingV2InvoiceSettingsGet200Response**](InvoicingV2InvoiceSettingsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvoicesettings"></a>
# **UpdateInvoiceSettings**
> InvoicingV2InvoiceSettingsGet200Response UpdateInvoiceSettings (InvoiceSettingsRequest invoiceSettingsRequest)

Update Invoice Settings

Allows you to customize the payment page, the checkout experience, email communication and payer authentication. You can customize the invoice to match your brand with your business name, logo and brand colors, and a VAT Tax number. You can choose to capture the payers shipping details, phone number and email during the checkout process. You can add a custom message to all invoice emails and enable or disable payer authentication for invoice payments.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateInvoiceSettingsExample
    {
        public void main()
        {
            var apiInstance = new InvoiceSettingsApi();
            var invoiceSettingsRequest = new InvoiceSettingsRequest(); // InvoiceSettingsRequest | 

            try
            {
                // Update Invoice Settings
                InvoicingV2InvoiceSettingsGet200Response result = apiInstance.UpdateInvoiceSettings(invoiceSettingsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceSettingsApi.UpdateInvoiceSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceSettingsRequest** | [**InvoiceSettingsRequest**](InvoiceSettingsRequest.md)|  | 

### Return type

[**InvoicingV2InvoiceSettingsGet200Response**](InvoicingV2InvoiceSettingsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

