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

Create a new invoice.

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
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallinvoices"></a>
# **GetAllInvoices**
> InvoicingV2InvoicesAllGet200Response GetAllInvoices (int? offset, int? limit, string status = null)

Get a List of Invoices

Get a list of invoices.

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
            var status = status_example;  // string | The status of the invoice.  Possible values:   - DRAFT   - CREATED   - SENT   - PARTIAL   - PAID   - CANCELED  (optional) 

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
 **status** | **string**| The status of the invoice.  Possible values:   - DRAFT   - CREATED   - SENT   - PARTIAL   - PAID   - CANCELED  | [optional] 

### Return type

[**InvoicingV2InvoicesAllGet200Response**](InvoicingV2InvoicesAllGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoice"></a>
# **GetInvoice**
> InvoicingV2InvoicesGet200Response GetInvoice (string id)

Get Invoice Details

Get the details of a specific invoice.

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
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="performcancelaction"></a>
# **PerformCancelAction**
> InvoicingV2InvoicesPost201Response PerformCancelAction (string id)

Cancel an Invoice

Cancel an invoice.

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
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="performsendaction"></a>
# **PerformSendAction**
> InvoicingV2InvoicesPost201Response PerformSendAction (string id)

Send an Invoice

Send an invoice.

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
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvoice"></a>
# **UpdateInvoice**
> InvoicingV2InvoicesPost201Response UpdateInvoice (string id, UpdateInvoiceRequest updateInvoiceRequest)

Update an Invoice

Update an invoice.

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
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

