# CyberSource.Api.PaymentInstrumentApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePaymentInstrument**](PaymentInstrumentApi.md#createpaymentinstrument) | **POST** /tms/v1/paymentinstruments | Create a Payment Instrument
[**DeletePaymentInstrument**](PaymentInstrumentApi.md#deletepaymentinstrument) | **DELETE** /tms/v1/paymentinstruments/{tokenId} | Delete a Payment Instrument
[**GetPaymentInstrument**](PaymentInstrumentApi.md#getpaymentinstrument) | **GET** /tms/v1/paymentinstruments/{tokenId} | Retrieve a Payment Instrument
[**UpdatePaymentInstrument**](PaymentInstrumentApi.md#updatepaymentinstrument) | **PATCH** /tms/v1/paymentinstruments/{tokenId} | Update a Payment Instrument


<a name="createpaymentinstrument"></a>
# **CreatePaymentInstrument**
> TmsV1PaymentinstrumentsPatch200Response CreatePaymentInstrument (string profileId, string vCMerchantId, string vCCorrelationId, CreatePaymentInstrumentRequest createPaymentInstrumentRequest, string clientApplication = null)

Create a Payment Instrument

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreatePaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentApi();
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var vCMerchantId = vCMerchantId_example;  // string | CyberSource merchant id.
            var vCCorrelationId = vCCorrelationId_example;  // string | The mandatory correlation id passed by upstream (calling) system.
            var createPaymentInstrumentRequest = new CreatePaymentInstrumentRequest(); // CreatePaymentInstrumentRequest | Specify the customer's payment details for card or bank account.
            var clientApplication = clientApplication_example;  // string | Client application name (optional) 

            try
            {
                // Create a Payment Instrument
                TmsV1PaymentinstrumentsPatch200Response result = apiInstance.CreatePaymentInstrument(profileId, vCMerchantId, vCCorrelationId, createPaymentInstrumentRequest, clientApplication);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentApi.CreatePaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | 
 **vCMerchantId** | **string**| CyberSource merchant id. | 
 **vCCorrelationId** | **string**| The mandatory correlation id passed by upstream (calling) system. | 
 **createPaymentInstrumentRequest** | [**CreatePaymentInstrumentRequest**](CreatePaymentInstrumentRequest.md)| Specify the customer&#39;s payment details for card or bank account. | 
 **clientApplication** | **string**| Client application name | [optional] 

### Return type

[**TmsV1PaymentinstrumentsPatch200Response**](TmsV1PaymentinstrumentsPatch200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepaymentinstrument"></a>
# **DeletePaymentInstrument**
> void DeletePaymentInstrument (string profileId, string vCMerchantId, string vCCorrelationId, string tokenId, string clientApplication = null)

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
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var vCMerchantId = vCMerchantId_example;  // string | CyberSource merchant id.
            var vCCorrelationId = vCCorrelationId_example;  // string | The mandatory correlation id passed by upstream (calling) system.
            var tokenId = tokenId_example;  // string | The TokenId of a Payment Instrument.
            var clientApplication = clientApplication_example;  // string | Client application name (optional) 

            try
            {
                // Delete a Payment Instrument
                apiInstance.DeletePaymentInstrument(profileId, vCMerchantId, vCCorrelationId, tokenId, clientApplication);
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
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | 
 **vCMerchantId** | **string**| CyberSource merchant id. | 
 **vCCorrelationId** | **string**| The mandatory correlation id passed by upstream (calling) system. | 
 **tokenId** | **string**| The TokenId of a Payment Instrument. | 
 **clientApplication** | **string**| Client application name | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentinstrument"></a>
# **GetPaymentInstrument**
> TmsV1PaymentinstrumentsPatch200Response GetPaymentInstrument (string profileId, string vCMerchantId, string vCCorrelationId, string tokenId, string clientApplication = null)

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
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var vCMerchantId = vCMerchantId_example;  // string | CyberSource merchant id.
            var vCCorrelationId = vCCorrelationId_example;  // string | The mandatory correlation id passed by upstream (calling) system.
            var tokenId = tokenId_example;  // string | The TokenId of a Payment Instrument.
            var clientApplication = clientApplication_example;  // string | Client application name (optional) 

            try
            {
                // Retrieve a Payment Instrument
                TmsV1PaymentinstrumentsPatch200Response result = apiInstance.GetPaymentInstrument(profileId, vCMerchantId, vCCorrelationId, tokenId, clientApplication);
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
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | 
 **vCMerchantId** | **string**| CyberSource merchant id. | 
 **vCCorrelationId** | **string**| The mandatory correlation id passed by upstream (calling) system. | 
 **tokenId** | **string**| The TokenId of a Payment Instrument. | 
 **clientApplication** | **string**| Client application name | [optional] 

### Return type

[**TmsV1PaymentinstrumentsPatch200Response**](TmsV1PaymentinstrumentsPatch200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepaymentinstrument"></a>
# **UpdatePaymentInstrument**
> TmsV1PaymentinstrumentsPatch200Response UpdatePaymentInstrument (string profileId, string vCMerchantId, string vCCorrelationId, string tokenId, UpdatePaymentInstrumentRequest updatePaymentInstrumentRequest, string clientApplication = null)

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
    public class UpdatePaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentApi();
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var vCMerchantId = vCMerchantId_example;  // string | CyberSource merchant id.
            var vCCorrelationId = vCCorrelationId_example;  // string | The mandatory correlation id passed by upstream (calling) system.
            var tokenId = tokenId_example;  // string | The TokenId of a Payment Instrument.
            var updatePaymentInstrumentRequest = new UpdatePaymentInstrumentRequest(); // UpdatePaymentInstrumentRequest | Specify the customer's payment details.
            var clientApplication = clientApplication_example;  // string | Client application name (optional) 

            try
            {
                // Update a Payment Instrument
                TmsV1PaymentinstrumentsPatch200Response result = apiInstance.UpdatePaymentInstrument(profileId, vCMerchantId, vCCorrelationId, tokenId, updatePaymentInstrumentRequest, clientApplication);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentApi.UpdatePaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | 
 **vCMerchantId** | **string**| CyberSource merchant id. | 
 **vCCorrelationId** | **string**| The mandatory correlation id passed by upstream (calling) system. | 
 **tokenId** | **string**| The TokenId of a Payment Instrument. | 
 **updatePaymentInstrumentRequest** | [**UpdatePaymentInstrumentRequest**](UpdatePaymentInstrumentRequest.md)| Specify the customer&#39;s payment details. | 
 **clientApplication** | **string**| Client application name | [optional] 

### Return type

[**TmsV1PaymentinstrumentsPatch200Response**](TmsV1PaymentinstrumentsPatch200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

