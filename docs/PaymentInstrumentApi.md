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
> TmsV1PaymentinstrumentsPatch200Response CreatePaymentInstrument (CreatePaymentInstrumentRequest createPaymentInstrumentRequest)

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
            var createPaymentInstrumentRequest = new CreatePaymentInstrumentRequest(); // CreatePaymentInstrumentRequest | Specify the customer's payment details for card or bank account.

            try
            {
                // Create a Payment Instrument
                TmsV1PaymentinstrumentsPatch200Response result = apiInstance.CreatePaymentInstrument(createPaymentInstrumentRequest);
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
 **createPaymentInstrumentRequest** | [**CreatePaymentInstrumentRequest**](CreatePaymentInstrumentRequest.md)| Specify the customer&#39;s payment details for card or bank account. | 

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
> void DeletePaymentInstrument (string tokenId)

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
            var tokenId = tokenId_example;  // string | The TokenId of a Payment Instrument.

            try
            {
                // Delete a Payment Instrument
                apiInstance.DeletePaymentInstrument(tokenId);
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
 **tokenId** | **string**| The TokenId of a Payment Instrument. | 

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
> TmsV1PaymentinstrumentsPatch200Response GetPaymentInstrument (string tokenId)

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
            var tokenId = tokenId_example;  // string | The TokenId of a Payment Instrument.

            try
            {
                // Retrieve a Payment Instrument
                TmsV1PaymentinstrumentsPatch200Response result = apiInstance.GetPaymentInstrument(tokenId);
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
 **tokenId** | **string**| The TokenId of a Payment Instrument. | 

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
> TmsV1PaymentinstrumentsPatch200Response UpdatePaymentInstrument (string tokenId, UpdatePaymentInstrumentRequest updatePaymentInstrumentRequest)

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
            var tokenId = tokenId_example;  // string | The TokenId of a Payment Instrument.
            var updatePaymentInstrumentRequest = new UpdatePaymentInstrumentRequest(); // UpdatePaymentInstrumentRequest | Specify the customer's payment details.

            try
            {
                // Update a Payment Instrument
                TmsV1PaymentinstrumentsPatch200Response result = apiInstance.UpdatePaymentInstrument(tokenId, updatePaymentInstrumentRequest);
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
 **tokenId** | **string**| The TokenId of a Payment Instrument. | 
 **updatePaymentInstrumentRequest** | [**UpdatePaymentInstrumentRequest**](UpdatePaymentInstrumentRequest.md)| Specify the customer&#39;s payment details. | 

### Return type

[**TmsV1PaymentinstrumentsPatch200Response**](TmsV1PaymentinstrumentsPatch200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

