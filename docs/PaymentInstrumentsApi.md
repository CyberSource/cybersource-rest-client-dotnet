# CyberSource.Api.PaymentInstrumentsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGet**](PaymentInstrumentsApi.md#tmsv1instrumentidentifierstokenidpaymentinstrumentsget) | **GET** /tms/v1/instrumentidentifiers/{tokenId}/paymentinstruments | Retrieve all Payment Instruments associated with an Instrument Identifier
[**TmsV1PaymentinstrumentsPost**](PaymentInstrumentsApi.md#tmsv1paymentinstrumentspost) | **POST** /tms/v1/paymentinstruments | Create a Payment Instrument
[**TmsV1PaymentinstrumentsTokenIdDelete**](PaymentInstrumentsApi.md#tmsv1paymentinstrumentstokeniddelete) | **DELETE** /tms/v1/paymentinstruments/{tokenId} | Delete a Payment Instrument
[**TmsV1PaymentinstrumentsTokenIdGet**](PaymentInstrumentsApi.md#tmsv1paymentinstrumentstokenidget) | **GET** /tms/v1/paymentinstruments/{tokenId} | Retrieve a Payment Instrument
[**TmsV1PaymentinstrumentsTokenIdPatch**](PaymentInstrumentsApi.md#tmsv1paymentinstrumentstokenidpatch) | **PATCH** /tms/v1/paymentinstruments/{tokenId} | Update a Payment Instrument


<a name="tmsv1instrumentidentifierstokenidpaymentinstrumentsget"></a>
# **TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGet**
> TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGet (string profileId, string tokenId, string offset = null, string limit = null)

Retrieve all Payment Instruments associated with an Instrument Identifier

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGetExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentsApi();
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var tokenId = tokenId_example;  // string | The TokenId of an Instrument Identifier.
            var offset = offset_example;  // string | Starting Payment Instrument record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional) 
            var limit = limit_example;  // string | The maximum number of Payment Instruments that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional)  (default to 20)

            try
            {
                // Retrieve all Payment Instruments associated with an Instrument Identifier
                TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response result = apiInstance.TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGet(profileId, tokenId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentsApi.TmsV1InstrumentidentifiersTokenIdPaymentinstrumentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | 
 **tokenId** | **string**| The TokenId of an Instrument Identifier. | 
 **offset** | **string**| Starting Payment Instrument record in zero-based dataset that should be returned as the first object in the array. Default is 0. | [optional] 
 **limit** | **string**| The maximum number of Payment Instruments that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. | [optional] [default to 20]

### Return type

[**TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response**](TmsV1InstrumentidentifiersPaymentinstrumentsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tmsv1paymentinstrumentspost"></a>
# **TmsV1PaymentinstrumentsPost**
> TmsV1PaymentinstrumentsPost201Response TmsV1PaymentinstrumentsPost (string profileId, Body2 body)

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
    public class TmsV1PaymentinstrumentsPostExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentsApi();
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var body = new Body2(); // Body2 | Please specify the customers payment details for card or bank account.

            try
            {
                // Create a Payment Instrument
                TmsV1PaymentinstrumentsPost201Response result = apiInstance.TmsV1PaymentinstrumentsPost(profileId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentsApi.TmsV1PaymentinstrumentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | 
 **body** | [**Body2**](Body2.md)| Please specify the customers payment details for card or bank account. | 

### Return type

[**TmsV1PaymentinstrumentsPost201Response**](TmsV1PaymentinstrumentsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tmsv1paymentinstrumentstokeniddelete"></a>
# **TmsV1PaymentinstrumentsTokenIdDelete**
> void TmsV1PaymentinstrumentsTokenIdDelete (string profileId, string tokenId)

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
    public class TmsV1PaymentinstrumentsTokenIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentsApi();
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var tokenId = tokenId_example;  // string | The TokenId of a Payment Instrument.

            try
            {
                // Delete a Payment Instrument
                apiInstance.TmsV1PaymentinstrumentsTokenIdDelete(profileId, tokenId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentsApi.TmsV1PaymentinstrumentsTokenIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | 
 **tokenId** | **string**| The TokenId of a Payment Instrument. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tmsv1paymentinstrumentstokenidget"></a>
# **TmsV1PaymentinstrumentsTokenIdGet**
> TmsV1PaymentinstrumentsPost201Response TmsV1PaymentinstrumentsTokenIdGet (string profileId, string tokenId)

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
    public class TmsV1PaymentinstrumentsTokenIdGetExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentsApi();
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var tokenId = tokenId_example;  // string | The TokenId of a Payment Instrument.

            try
            {
                // Retrieve a Payment Instrument
                TmsV1PaymentinstrumentsPost201Response result = apiInstance.TmsV1PaymentinstrumentsTokenIdGet(profileId, tokenId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentsApi.TmsV1PaymentinstrumentsTokenIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | 
 **tokenId** | **string**| The TokenId of a Payment Instrument. | 

### Return type

[**TmsV1PaymentinstrumentsPost201Response**](TmsV1PaymentinstrumentsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tmsv1paymentinstrumentstokenidpatch"></a>
# **TmsV1PaymentinstrumentsTokenIdPatch**
> TmsV1PaymentinstrumentsPost201Response TmsV1PaymentinstrumentsTokenIdPatch (string profileId, string tokenId, Body3 body)

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
    public class TmsV1PaymentinstrumentsTokenIdPatchExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentsApi();
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var tokenId = tokenId_example;  // string | The TokenId of a Payment Instrument.
            var body = new Body3(); // Body3 | Please specify the customers payment details.

            try
            {
                // Update a Payment Instrument
                TmsV1PaymentinstrumentsPost201Response result = apiInstance.TmsV1PaymentinstrumentsTokenIdPatch(profileId, tokenId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentsApi.TmsV1PaymentinstrumentsTokenIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | 
 **tokenId** | **string**| The TokenId of a Payment Instrument. | 
 **body** | [**Body3**](Body3.md)| Please specify the customers payment details. | 

### Return type

[**TmsV1PaymentinstrumentsPost201Response**](TmsV1PaymentinstrumentsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

