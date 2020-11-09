# CyberSource.Api.PaymentInstrumentApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePaymentInstrument**](PaymentInstrumentApi.md#deletepaymentinstrument) | **DELETE** /tms/v1/paymentinstruments/{paymentInstrumentTokenId} | Delete a Payment Instrument
[**GetPaymentInstrument**](PaymentInstrumentApi.md#getpaymentinstrument) | **GET** /tms/v1/paymentinstruments/{paymentInstrumentTokenId} | Retrieve a Payment Instrument
[**PatchPaymentInstrument**](PaymentInstrumentApi.md#patchpaymentinstrument) | **PATCH** /tms/v1/paymentinstruments/{paymentInstrumentTokenId} | Update a Payment Instrument
[**PostPaymentInstrument**](PaymentInstrumentApi.md#postpaymentinstrument) | **POST** /tms/v1/paymentinstruments | Create a Payment Instrument


<a name="deletepaymentinstrument"></a>
# **DeletePaymentInstrument**
> void DeletePaymentInstrument (string paymentInstrumentTokenId, string profileId = null)

Delete a Payment Instrument

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeletePaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentApi();
            var paymentInstrumentTokenId = paymentInstrumentTokenId_example;  // string | The TokenId of a payment instrument.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Delete a Payment Instrument
                apiInstance.DeletePaymentInstrument(paymentInstrumentTokenId, profileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentApi.DeletePaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="getpaymentinstrument"></a>
# **GetPaymentInstrument**
> Tmsv2customersEmbeddedDefaultPaymentInstrument GetPaymentInstrument (string paymentInstrumentTokenId, string profileId = null)

Retrieve a Payment Instrument

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentApi();
            var paymentInstrumentTokenId = paymentInstrumentTokenId_example;  // string | The TokenId of a payment instrument.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Retrieve a Payment Instrument
                Tmsv2customersEmbeddedDefaultPaymentInstrument result = apiInstance.GetPaymentInstrument(paymentInstrumentTokenId, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentApi.GetPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="patchpaymentinstrument"></a>
# **PatchPaymentInstrument**
> Tmsv2customersEmbeddedDefaultPaymentInstrument PatchPaymentInstrument (string paymentInstrumentTokenId, PatchPaymentInstrumentRequest patchPaymentInstrumentRequest, string profileId = null, string ifMatch = null)

Update a Payment Instrument

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PatchPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentApi();
            var paymentInstrumentTokenId = paymentInstrumentTokenId_example;  // string | The TokenId of a payment instrument.
            var patchPaymentInstrumentRequest = new PatchPaymentInstrumentRequest(); // PatchPaymentInstrumentRequest | 
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 
            var ifMatch = ifMatch_example;  // string | Contains an ETag value from a GET request to make the request conditional. (optional) 

            try
            {
                // Update a Payment Instrument
                Tmsv2customersEmbeddedDefaultPaymentInstrument result = apiInstance.PatchPaymentInstrument(paymentInstrumentTokenId, patchPaymentInstrumentRequest, profileId, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentApi.PatchPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentInstrumentTokenId** | **string**| The TokenId of a payment instrument. | 
 **patchPaymentInstrumentRequest** | [**PatchPaymentInstrumentRequest**](PatchPaymentInstrumentRequest.md)|  | 
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

<a name="postpaymentinstrument"></a>
# **PostPaymentInstrument**
> Tmsv2customersEmbeddedDefaultPaymentInstrument PostPaymentInstrument (PostPaymentInstrumentRequest postPaymentInstrumentRequest, string profileId = null)

Create a Payment Instrument

Include an existing TMS Instrument Identifier id in the request body. * An Instrument Identifier token can be created by calling: **POST *_/tms/v1/instrumentidentifiers*** 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentApi();
            var postPaymentInstrumentRequest = new PostPaymentInstrumentRequest(); // PostPaymentInstrumentRequest | 
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Create a Payment Instrument
                Tmsv2customersEmbeddedDefaultPaymentInstrument result = apiInstance.PostPaymentInstrument(postPaymentInstrumentRequest, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentApi.PostPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postPaymentInstrumentRequest** | [**PostPaymentInstrumentRequest**](PostPaymentInstrumentRequest.md)|  | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**Tmsv2customersEmbeddedDefaultPaymentInstrument**](Tmsv2customersEmbeddedDefaultPaymentInstrument.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

