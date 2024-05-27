# CyberSource.Api.InvoicesApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInvoice**](InvoicesApi.md#createinvoice) | **POST** /invoicing/v2/invoices | Create a New Invoice
[**GetAllInvoices**](InvoicesApi.md#getallinvoices) | **GET** /invoicing/v2/invoices | Get a List of Invoices
[**GetInvoice**](InvoicesApi.md#getinvoice) | **GET** /invoicing/v2/invoices/{id} | Get Invoice Details
[**PerformCancelAction**](InvoicesApi.md#performcancelaction) | **POST** /invoicing/v2/invoices/{id}/cancelation | Cancel an Invoice
[**PerformSendAction**](InvoicesApi.md#performsendaction) | **POST** /invoicing/v2/invoices/{id}/delivery | Send an Invoice
[**UpdateInvoice**](InvoicesApi.md#updateinvoice) | **PUT** /invoicing/v2/invoices/{id} | Update an Invoice


<a name="createinvoice"></a>
# **CreateInvoice**
> InvoicingV2InvoicesPost201Response CreateInvoice (CreateInvoiceRequest createInvoiceRequest)

Create a New Invoice

The invoicing product enables you to bill any customer with an email address and accept digital payments securely from any connected device. You can either use the system generated email or use the invoice payment link in your own communication. You can add discounts and taxes for the entire invoice or for each line item. To customize the invoice to match your brand see [Invoice Settings](https://developer.cybersource.com/api-reference-assets/index.html#invoicing_invoice-settings_update-invoice-settings). The invoice payment page uses Unified Checkout to process the payments.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateInvoiceExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var createInvoiceRequest = new CreateInvoiceRequest(); // CreateInvoiceRequest | 

            try
            {
                // Create a New Invoice
                InvoicingV2InvoicesPost201Response result = apiInstance.CreateInvoice(createInvoiceRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.CreateInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createInvoiceRequest** | [**CreateInvoiceRequest**](CreateInvoiceRequest.md)|  | 

### Return type

[**InvoicingV2InvoicesPost201Response**](InvoicingV2InvoicesPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallinvoices"></a>
# **GetAllInvoices**
> InvoicingV2InvoicesAllGet200Response GetAllInvoices (int? offset, int? limit, string status = null)

Get a List of Invoices

Provides a (filtered) list of invoices that have been created in your account. You can filter the list based on Invoice Status by setting the status query parameter to one of DRAFT, CREATED, SENT, PARTIAL, PAID or CANCELED.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetAllInvoicesExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var offset = 56;  // int? | Page offset number.
            var limit = 56;  // int? | Maximum number of items you would like returned.
            var status = status_example;  // string | The status of the invoice.  Possible values:   - DRAFT   - CREATED   - SENT   - PARTIAL   - PAID   - CANCELED   - PENDING  (optional) 

            try
            {
                // Get a List of Invoices
                InvoicingV2InvoicesAllGet200Response result = apiInstance.GetAllInvoices(offset, limit, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetAllInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| Page offset number. | 
 **limit** | **int?**| Maximum number of items you would like returned. | 
 **status** | **string**| The status of the invoice.  Possible values:   - DRAFT   - CREATED   - SENT   - PARTIAL   - PAID   - CANCELED   - PENDING  | [optional] 

### Return type

[**InvoicingV2InvoicesAllGet200Response**](InvoicingV2InvoicesAllGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoice"></a>
# **GetInvoice**
> InvoicingV2InvoicesGet200Response GetInvoice (string id)

Get Invoice Details

You can retrieve details of a specific invoice. This can be used to check the Invoice status and get a list of invoice payments in the invoice history section of the response. For each payment transaction you can use the Transaction Details API to get more details on the payment transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetInvoiceExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var id = id_example;  // string | The invoice number.

            try
            {
                // Get Invoice Details
                InvoicingV2InvoicesGet200Response result = apiInstance.GetInvoice(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The invoice number. | 

### Return type

[**InvoicingV2InvoicesGet200Response**](InvoicingV2InvoicesGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="performcancelaction"></a>
# **PerformCancelAction**
> InvoicingV2InvoicesPost201Response PerformCancelAction (string id)

Cancel an Invoice

You can cancel an invoice if no payment is made to it. You cannot cancel partially or fully paid invoices.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PerformCancelActionExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var id = id_example;  // string | The invoice number.

            try
            {
                // Cancel an Invoice
                InvoicingV2InvoicesPost201Response result = apiInstance.PerformCancelAction(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.PerformCancelAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The invoice number. | 

### Return type

[**InvoicingV2InvoicesPost201Response**](InvoicingV2InvoicesPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="performsendaction"></a>
# **PerformSendAction**
> InvoicingV2InvoicesPost201Response PerformSendAction (string id)

Send an Invoice

You can send an invoice in draft or created state or resend a sent or partially paid invoice. Fully paid or canceled invoices cannot be resent.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PerformSendActionExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var id = id_example;  // string | The invoice number.

            try
            {
                // Send an Invoice
                InvoicingV2InvoicesPost201Response result = apiInstance.PerformSendAction(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.PerformSendAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The invoice number. | 

### Return type

[**InvoicingV2InvoicesPost201Response**](InvoicingV2InvoicesPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvoice"></a>
# **UpdateInvoice**
> InvoicingV2InvoicesPost201Response UpdateInvoice (string id, UpdateInvoiceRequest updateInvoiceRequest)

Update an Invoice

You can update all information except the invoice number till any payment is received for an invoice. Invoices that are partially or fully paid or cancelled cannot be updated.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateInvoiceExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var id = id_example;  // string | The invoice number.
            var updateInvoiceRequest = new UpdateInvoiceRequest(); // UpdateInvoiceRequest | Updating the invoice does not resend the invoice automatically. You must resend the invoice separately.

            try
            {
                // Update an Invoice
                InvoicingV2InvoicesPost201Response result = apiInstance.UpdateInvoice(id, updateInvoiceRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.UpdateInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The invoice number. | 
 **updateInvoiceRequest** | [**UpdateInvoiceRequest**](UpdateInvoiceRequest.md)| Updating the invoice does not resend the invoice automatically. You must resend the invoice separately. | 

### Return type

[**InvoicingV2InvoicesPost201Response**](InvoicingV2InvoicesPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

