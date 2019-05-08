# CyberSource.Api.InstrumentIdentifierApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInstrumentIdentifier**](InstrumentIdentifierApi.md#createinstrumentidentifier) | **POST** /tms/v1/instrumentidentifiers | Create an Instrument Identifier
[**DeleteInstrumentIdentifier**](InstrumentIdentifierApi.md#deleteinstrumentidentifier) | **DELETE** /tms/v1/instrumentidentifiers/{tokenId} | Delete an Instrument Identifier
[**GetAllPaymentInstruments**](InstrumentIdentifierApi.md#getallpaymentinstruments) | **GET** /tms/v1/instrumentidentifiers/{tokenId}/paymentinstruments | Retrieve all Payment Instruments associated with an Instrument Identifier
[**GetInstrumentIdentifier**](InstrumentIdentifierApi.md#getinstrumentidentifier) | **GET** /tms/v1/instrumentidentifiers/{tokenId} | Retrieve an Instrument Identifier
[**UpdateInstrumentIdentifier**](InstrumentIdentifierApi.md#updateinstrumentidentifier) | **PATCH** /tms/v1/instrumentidentifiers/{tokenId} | Update a Instrument Identifier


<a name="createinstrumentidentifier"></a>
# **CreateInstrumentIdentifier**
> TmsV1InstrumentIdentifiersPost200Response CreateInstrumentIdentifier (CreateInstrumentIdentifierRequest createInstrumentIdentifierRequest)

Create an Instrument Identifier

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateInstrumentIdentifierExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var createInstrumentIdentifierRequest = new CreateInstrumentIdentifierRequest(); // CreateInstrumentIdentifierRequest | Please specify either a Card, Bank Account or Enrollable Card

            try
            {
                // Create an Instrument Identifier
                TmsV1InstrumentIdentifiersPost200Response result = apiInstance.CreateInstrumentIdentifier(createInstrumentIdentifierRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.CreateInstrumentIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createInstrumentIdentifierRequest** | [**CreateInstrumentIdentifierRequest**](CreateInstrumentIdentifierRequest.md)| Please specify either a Card, Bank Account or Enrollable Card | 

### Return type

[**TmsV1InstrumentIdentifiersPost200Response**](TmsV1InstrumentIdentifiersPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/hal+json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinstrumentidentifier"></a>
# **DeleteInstrumentIdentifier**
> void DeleteInstrumentIdentifier (string tokenId)

Delete an Instrument Identifier

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteInstrumentIdentifierExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var tokenId = tokenId_example;  // string | The TokenId of an Instrument Identifier.

            try
            {
                // Delete an Instrument Identifier
                apiInstance.DeleteInstrumentIdentifier(tokenId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.DeleteInstrumentIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenId** | **string**| The TokenId of an Instrument Identifier. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallpaymentinstruments"></a>
# **GetAllPaymentInstruments**
> TmsV1InstrumentIdentifiersPaymentInstrumentsGet200Response GetAllPaymentInstruments (string tokenId, long? offset = null, long? limit = null)

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
    public class GetAllPaymentInstrumentsExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var tokenId = tokenId_example;  // string | The TokenId of an Instrument Identifier.
            var offset = 789;  // long? | Starting Payment Instrument record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional)  (default to 0)
            var limit = 789;  // long? | The maximum number of Payment Instruments that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional)  (default to 20)

            try
            {
                // Retrieve all Payment Instruments associated with an Instrument Identifier
                TmsV1InstrumentIdentifiersPaymentInstrumentsGet200Response result = apiInstance.GetAllPaymentInstruments(tokenId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.GetAllPaymentInstruments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenId** | **string**| The TokenId of an Instrument Identifier. | 
 **offset** | **long?**| Starting Payment Instrument record in zero-based dataset that should be returned as the first object in the array. Default is 0. | [optional] [default to 0]
 **limit** | **long?**| The maximum number of Payment Instruments that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. | [optional] [default to 20]

### Return type

[**TmsV1InstrumentIdentifiersPaymentInstrumentsGet200Response**](TmsV1InstrumentIdentifiersPaymentInstrumentsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentidentifier"></a>
# **GetInstrumentIdentifier**
> TmsV1InstrumentIdentifiersPost200Response GetInstrumentIdentifier (string tokenId)

Retrieve an Instrument Identifier

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetInstrumentIdentifierExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var tokenId = tokenId_example;  // string | The TokenId of an Instrument Identifier.

            try
            {
                // Retrieve an Instrument Identifier
                TmsV1InstrumentIdentifiersPost200Response result = apiInstance.GetInstrumentIdentifier(tokenId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.GetInstrumentIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenId** | **string**| The TokenId of an Instrument Identifier. | 

### Return type

[**TmsV1InstrumentIdentifiersPost200Response**](TmsV1InstrumentIdentifiersPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinstrumentidentifier"></a>
# **UpdateInstrumentIdentifier**
> TmsV1InstrumentIdentifiersPost200Response UpdateInstrumentIdentifier (string tokenId, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest)

Update a Instrument Identifier

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateInstrumentIdentifierExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var tokenId = tokenId_example;  // string | The TokenId of an Instrument Identifier.
            var updateInstrumentIdentifierRequest = new UpdateInstrumentIdentifierRequest(); // UpdateInstrumentIdentifierRequest | Specify the previous transaction ID to update.

            try
            {
                // Update a Instrument Identifier
                TmsV1InstrumentIdentifiersPost200Response result = apiInstance.UpdateInstrumentIdentifier(tokenId, updateInstrumentIdentifierRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.UpdateInstrumentIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenId** | **string**| The TokenId of an Instrument Identifier. | 
 **updateInstrumentIdentifierRequest** | [**UpdateInstrumentIdentifierRequest**](UpdateInstrumentIdentifierRequest.md)| Specify the previous transaction ID to update. | 

### Return type

[**TmsV1InstrumentIdentifiersPost200Response**](TmsV1InstrumentIdentifiersPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

