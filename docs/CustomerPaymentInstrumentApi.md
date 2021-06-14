# CyberSource.Api.CustomerPaymentInstrumentApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCustomerPaymentInstrument**](CustomerPaymentInstrumentApi.md#deletecustomerpaymentinstrument) | **DELETE** /tms/v2/customers/{customerTokenId}/payment-instruments/{paymentInstrumentTokenId} | Delete a Customer Payment Instrument
[**GetCustomerPaymentInstrument**](CustomerPaymentInstrumentApi.md#getcustomerpaymentinstrument) | **GET** /tms/v2/customers/{customerTokenId}/payment-instruments/{paymentInstrumentTokenId} | Retrieve a Customer Payment Instrument
[**GetCustomerPaymentInstrumentsList**](CustomerPaymentInstrumentApi.md#getcustomerpaymentinstrumentslist) | **GET** /tms/v2/customers/{customerTokenId}/payment-instruments | List Payment Instruments for a Customer
[**PatchCustomersPaymentInstrument**](CustomerPaymentInstrumentApi.md#patchcustomerspaymentinstrument) | **PATCH** /tms/v2/customers/{customerTokenId}/payment-instruments/{paymentInstrumentTokenId} | Update a Customer Payment Instrument
[**PostCustomerPaymentInstrument**](CustomerPaymentInstrumentApi.md#postcustomerpaymentinstrument) | **POST** /tms/v2/customers/{customerTokenId}/payment-instruments | Create a Customer Payment Instrument


<a name="deletecustomerpaymentinstrument"></a>
# **DeleteCustomerPaymentInstrument**
> void DeleteCustomerPaymentInstrument (string customerTokenId, string paymentInstrumentTokenId, string profileId = null)

Delete a Customer Payment Instrument

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteCustomerPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new CustomerPaymentInstrumentApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var paymentInstrumentTokenId = paymentInstrumentTokenId_example;  // string | The TokenId of a payment instrument.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Delete a Customer Payment Instrument
                apiInstance.DeleteCustomerPaymentInstrument(customerTokenId, paymentInstrumentTokenId, profileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerPaymentInstrumentApi.DeleteCustomerPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerTokenId** | **string**| The TokenId of a customer. | 
 **paymentInstrumentTokenId** | **string**| The TokenId of a payment instrument. | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerpaymentinstrument"></a>
# **GetCustomerPaymentInstrument**
> Tmsv2customersEmbeddedDefaultPaymentInstrument GetCustomerPaymentInstrument (string customerTokenId, string paymentInstrumentTokenId, string profileId = null)

Retrieve a Customer Payment Instrument

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetCustomerPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new CustomerPaymentInstrumentApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var paymentInstrumentTokenId = paymentInstrumentTokenId_example;  // string | The TokenId of a payment instrument.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Retrieve a Customer Payment Instrument
                Tmsv2customersEmbeddedDefaultPaymentInstrument result = apiInstance.GetCustomerPaymentInstrument(customerTokenId, paymentInstrumentTokenId, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerPaymentInstrumentApi.GetCustomerPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerTokenId** | **string**| The TokenId of a customer. | 
 **paymentInstrumentTokenId** | **string**| The TokenId of a payment instrument. | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**Tmsv2customersEmbeddedDefaultPaymentInstrument**](Tmsv2customersEmbeddedDefaultPaymentInstrument.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerpaymentinstrumentslist"></a>
# **GetCustomerPaymentInstrumentsList**
> PaymentInstrumentList GetCustomerPaymentInstrumentsList (string customerTokenId, string profileId = null, long? offset = null, long? limit = null)

List Payment Instruments for a Customer

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetCustomerPaymentInstrumentsListExample
    {
        public void main()
        {
            var apiInstance = new CustomerPaymentInstrumentApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 
            var offset = 789;  // long? | Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional)  (default to 0)
            var limit = 789;  // long? | The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional)  (default to 20)

            try
            {
                // List Payment Instruments for a Customer
                PaymentInstrumentList result = apiInstance.GetCustomerPaymentInstrumentsList(customerTokenId, profileId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerPaymentInstrumentApi.GetCustomerPaymentInstrumentsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerTokenId** | **string**| The TokenId of a customer. | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 
 **offset** | **long?**| Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0. | [optional] [default to 0]
 **limit** | **long?**| The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. | [optional] [default to 20]

### Return type

[**PaymentInstrumentList**](PaymentInstrumentList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchcustomerspaymentinstrument"></a>
# **PatchCustomersPaymentInstrument**
> Tmsv2customersEmbeddedDefaultPaymentInstrument PatchCustomersPaymentInstrument (string customerTokenId, string paymentInstrumentTokenId, PatchCustomerPaymentInstrumentRequest patchCustomerPaymentInstrumentRequest, string profileId = null, string ifMatch = null)

Update a Customer Payment Instrument

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PatchCustomersPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new CustomerPaymentInstrumentApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var paymentInstrumentTokenId = paymentInstrumentTokenId_example;  // string | The TokenId of a payment instrument.
            var patchCustomerPaymentInstrumentRequest = new PatchCustomerPaymentInstrumentRequest(); // PatchCustomerPaymentInstrumentRequest | 
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 
            var ifMatch = ifMatch_example;  // string | Contains an ETag value from a GET request to make the request conditional. (optional) 

            try
            {
                // Update a Customer Payment Instrument
                Tmsv2customersEmbeddedDefaultPaymentInstrument result = apiInstance.PatchCustomersPaymentInstrument(customerTokenId, paymentInstrumentTokenId, patchCustomerPaymentInstrumentRequest, profileId, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerPaymentInstrumentApi.PatchCustomersPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerTokenId** | **string**| The TokenId of a customer. | 
 **paymentInstrumentTokenId** | **string**| The TokenId of a payment instrument. | 
 **patchCustomerPaymentInstrumentRequest** | [**PatchCustomerPaymentInstrumentRequest**](PatchCustomerPaymentInstrumentRequest.md)|  | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 
 **ifMatch** | **string**| Contains an ETag value from a GET request to make the request conditional. | [optional] 

### Return type

[**Tmsv2customersEmbeddedDefaultPaymentInstrument**](Tmsv2customersEmbeddedDefaultPaymentInstrument.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcustomerpaymentinstrument"></a>
# **PostCustomerPaymentInstrument**
> Tmsv2customersEmbeddedDefaultPaymentInstrument PostCustomerPaymentInstrument (string customerTokenId, PostCustomerPaymentInstrumentRequest postCustomerPaymentInstrumentRequest, string profileId = null)

Create a Customer Payment Instrument

Include an existing TMS Customer & Instrument Identifier token id in the request. * A Customer token can be created by calling: **POST *_/tms/v2/customers*** * An Instrument Identifier token can be created by calling: **POST *_/tms/v1/instrumentidentifiers*** 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostCustomerPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new CustomerPaymentInstrumentApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var postCustomerPaymentInstrumentRequest = new PostCustomerPaymentInstrumentRequest(); // PostCustomerPaymentInstrumentRequest | 
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Create a Customer Payment Instrument
                Tmsv2customersEmbeddedDefaultPaymentInstrument result = apiInstance.PostCustomerPaymentInstrument(customerTokenId, postCustomerPaymentInstrumentRequest, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerPaymentInstrumentApi.PostCustomerPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerTokenId** | **string**| The TokenId of a customer. | 
 **postCustomerPaymentInstrumentRequest** | [**PostCustomerPaymentInstrumentRequest**](PostCustomerPaymentInstrumentRequest.md)|  | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**Tmsv2customersEmbeddedDefaultPaymentInstrument**](Tmsv2customersEmbeddedDefaultPaymentInstrument.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

