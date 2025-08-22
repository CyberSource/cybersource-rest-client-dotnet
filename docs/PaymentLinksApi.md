# CyberSource.Api.PaymentLinksApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePaymentLink**](PaymentLinksApi.md#createpaymentlink) | **POST** /ipl/v2/payment-links | Create a Payment Link
[**GetAllPaymentLinks**](PaymentLinksApi.md#getallpaymentlinks) | **GET** /ipl/v2/payment-links | Get a List of Payment Links
[**GetPaymentLink**](PaymentLinksApi.md#getpaymentlink) | **GET** /ipl/v2/payment-links/{id} | Get Payment Link Details
[**UpdatePaymentLink**](PaymentLinksApi.md#updatepaymentlink) | **PATCH** /ipl/v2/payment-links/{id} | Update a Payment Link


<a name="createpaymentlink"></a>
# **CreatePaymentLink**
> PblPaymentLinksPost201Response CreatePaymentLink (CreatePaymentLinkRequest createPaymentLinkRequest)

Create a Payment Link

Pay by Link is an easy and fast way to securely sell products or receive donations online. This solution is ideal for distributing the same payment link to multiple customers.   Links for making purchases are referred to as fixed-price links, and links for making donations are referred to as customer-set price links. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreatePaymentLinkExample
    {
        public void main()
        {
            var apiInstance = new PaymentLinksApi();
            var createPaymentLinkRequest = new CreatePaymentLinkRequest(); // CreatePaymentLinkRequest | 

            try
            {
                // Create a Payment Link
                PblPaymentLinksPost201Response result = apiInstance.CreatePaymentLink(createPaymentLinkRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.CreatePaymentLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createPaymentLinkRequest** | [**CreatePaymentLinkRequest**](CreatePaymentLinkRequest.md)|  | 

### Return type

[**PblPaymentLinksPost201Response**](PblPaymentLinksPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallpaymentlinks"></a>
# **GetAllPaymentLinks**
> PblPaymentLinksAllGet200Response GetAllPaymentLinks (int? offset, int? limit, string status = null)

Get a List of Payment Links

Provides a (filtered) list of payment links that have been created in your account. You can filter the list based on the following status types:  - ACTIVE  - INACTIVE 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetAllPaymentLinksExample
    {
        public void main()
        {
            var apiInstance = new PaymentLinksApi();
            var offset = 56;  // int? | Page offset number.
            var limit = 56;  // int? | Maximum number of items you would like returned.   Maximum limit: 1000 
            var status = status_example;  // string | The status of the purchase or donation link.  Possible values:   - ACTIVE   - INACTIVE  (optional) 

            try
            {
                // Get a List of Payment Links
                PblPaymentLinksAllGet200Response result = apiInstance.GetAllPaymentLinks(offset, limit, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.GetAllPaymentLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| Page offset number. | 
 **limit** | **int?**| Maximum number of items you would like returned.   Maximum limit: 1000  | 
 **status** | **string**| The status of the purchase or donation link.  Possible values:   - ACTIVE   - INACTIVE  | [optional] 

### Return type

[**PblPaymentLinksAllGet200Response**](PblPaymentLinksAllGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentlink"></a>
# **GetPaymentLink**
> PblPaymentLinksGet200Response GetPaymentLink (string id)

Get Payment Link Details

You can retrieve details of a specific payment link. For each payment transaction you can use the Transaction Details API to get more details on the payment transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetPaymentLinkExample
    {
        public void main()
        {
            var apiInstance = new PaymentLinksApi();
            var id = id_example;  // string | The purchase number.

            try
            {
                // Get Payment Link Details
                PblPaymentLinksGet200Response result = apiInstance.GetPaymentLink(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.GetPaymentLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The purchase number. | 

### Return type

[**PblPaymentLinksGet200Response**](PblPaymentLinksGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepaymentlink"></a>
# **UpdatePaymentLink**
> PblPaymentLinksPost201Response UpdatePaymentLink (string id, UpdatePaymentLinkRequest updatePaymentLinkRequest)

Update a Payment Link

You can update all information except the payment link number for a payment link. Changes made to amount/price will apply to new payments made using the payment link. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdatePaymentLinkExample
    {
        public void main()
        {
            var apiInstance = new PaymentLinksApi();
            var id = id_example;  // string | The purchase number.
            var updatePaymentLinkRequest = new UpdatePaymentLinkRequest(); // UpdatePaymentLinkRequest | Updating the purchase or donation link does not resend the link automatically. You must resend the purchase or donation link separately.

            try
            {
                // Update a Payment Link
                PblPaymentLinksPost201Response result = apiInstance.UpdatePaymentLink(id, updatePaymentLinkRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.UpdatePaymentLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The purchase number. | 
 **updatePaymentLinkRequest** | [**UpdatePaymentLinkRequest**](UpdatePaymentLinkRequest.md)| Updating the purchase or donation link does not resend the link automatically. You must resend the purchase or donation link separately. | 

### Return type

[**PblPaymentLinksPost201Response**](PblPaymentLinksPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

