# CyberSource.Api.InstrumentIdentifierApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteInstrumentIdentifier**](InstrumentIdentifierApi.md#deleteinstrumentidentifier) | **DELETE** /tms/v1/instrumentidentifiers/{instrumentIdentifierTokenId} | Delete an Instrument Identifier
[**GetInstrumentIdentifier**](InstrumentIdentifierApi.md#getinstrumentidentifier) | **GET** /tms/v1/instrumentidentifiers/{instrumentIdentifierTokenId} | Retrieve an Instrument Identifier
[**GetInstrumentIdentifierPaymentInstrumentsList**](InstrumentIdentifierApi.md#getinstrumentidentifierpaymentinstrumentslist) | **GET** /tms/v1/instrumentidentifiers/{instrumentIdentifierTokenId}/paymentinstruments | List Payment Instruments for an Instrument Identifier
[**PatchInstrumentIdentifier**](InstrumentIdentifierApi.md#patchinstrumentidentifier) | **PATCH** /tms/v1/instrumentidentifiers/{instrumentIdentifierTokenId} | Update an Instrument Identifier
[**PostInstrumentIdentifier**](InstrumentIdentifierApi.md#postinstrumentidentifier) | **POST** /tms/v1/instrumentidentifiers | Create an Instrument Identifier
[**PostInstrumentIdentifierEnrollment**](InstrumentIdentifierApi.md#postinstrumentidentifierenrollment) | **POST** /tms/v1/instrumentidentifiers/{instrumentIdentifierTokenId}/enrollment | Enroll an Instrument Identifier for Network Tokenization


<a name="deleteinstrumentidentifier"></a>
# **DeleteInstrumentIdentifier**
> void DeleteInstrumentIdentifier (string instrumentIdentifierTokenId, string profileId = null)

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
            var instrumentIdentifierTokenId = instrumentIdentifierTokenId_example;  // string | The TokenId of a Instrument Identifier.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Delete an Instrument Identifier
                apiInstance.DeleteInstrumentIdentifier(instrumentIdentifierTokenId, profileId);
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
 **instrumentIdentifierTokenId** | **string**| The TokenId of a Instrument Identifier. | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentidentifier"></a>
# **GetInstrumentIdentifier**
> Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifier GetInstrumentIdentifier (string instrumentIdentifierTokenId, string profileId = null)

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
            var instrumentIdentifierTokenId = instrumentIdentifierTokenId_example;  // string | The TokenId of a Instrument Identifier.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Retrieve an Instrument Identifier
                Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifier result = apiInstance.GetInstrumentIdentifier(instrumentIdentifierTokenId, profileId);
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
 **instrumentIdentifierTokenId** | **string**| The TokenId of a Instrument Identifier. | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifier**](Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentidentifierpaymentinstrumentslist"></a>
# **GetInstrumentIdentifierPaymentInstrumentsList**
> PaymentInstrumentList GetInstrumentIdentifierPaymentInstrumentsList (string instrumentIdentifierTokenId, string profileId = null, long? offset = null, long? limit = null)

List Payment Instruments for an Instrument Identifier

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetInstrumentIdentifierPaymentInstrumentsListExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var instrumentIdentifierTokenId = instrumentIdentifierTokenId_example;  // string | The TokenId of a Instrument Identifier.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 
            var offset = 789;  // long? | Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional)  (default to 0)
            var limit = 789;  // long? | The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional)  (default to 20)

            try
            {
                // List Payment Instruments for an Instrument Identifier
                PaymentInstrumentList result = apiInstance.GetInstrumentIdentifierPaymentInstrumentsList(instrumentIdentifierTokenId, profileId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.GetInstrumentIdentifierPaymentInstrumentsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentIdentifierTokenId** | **string**| The TokenId of a Instrument Identifier. | 
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

<a name="patchinstrumentidentifier"></a>
# **PatchInstrumentIdentifier**
> Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifier PatchInstrumentIdentifier (string instrumentIdentifierTokenId, PatchInstrumentIdentifierRequest patchInstrumentIdentifierRequest, string profileId = null, string ifMatch = null)

Update an Instrument Identifier

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PatchInstrumentIdentifierExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var instrumentIdentifierTokenId = instrumentIdentifierTokenId_example;  // string | The TokenId of a Instrument Identifier.
            var patchInstrumentIdentifierRequest = new PatchInstrumentIdentifierRequest(); // PatchInstrumentIdentifierRequest | Specify the previous transaction ID to update.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 
            var ifMatch = ifMatch_example;  // string | Contains an ETag value from a GET request to make the request conditional. (optional) 

            try
            {
                // Update an Instrument Identifier
                Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifier result = apiInstance.PatchInstrumentIdentifier(instrumentIdentifierTokenId, patchInstrumentIdentifierRequest, profileId, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.PatchInstrumentIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentIdentifierTokenId** | **string**| The TokenId of a Instrument Identifier. | 
 **patchInstrumentIdentifierRequest** | [**PatchInstrumentIdentifierRequest**](PatchInstrumentIdentifierRequest.md)| Specify the previous transaction ID to update. | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 
 **ifMatch** | **string**| Contains an ETag value from a GET request to make the request conditional. | [optional] 

### Return type

[**Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifier**](Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinstrumentidentifier"></a>
# **PostInstrumentIdentifier**
> Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifier PostInstrumentIdentifier (PostInstrumentIdentifierRequest postInstrumentIdentifierRequest, string profileId = null)

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
    public class PostInstrumentIdentifierExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var postInstrumentIdentifierRequest = new PostInstrumentIdentifierRequest(); // PostInstrumentIdentifierRequest | Specify either a Card, Bank Account or Enrollable Card
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Create an Instrument Identifier
                Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifier result = apiInstance.PostInstrumentIdentifier(postInstrumentIdentifierRequest, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.PostInstrumentIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postInstrumentIdentifierRequest** | [**PostInstrumentIdentifierRequest**](PostInstrumentIdentifierRequest.md)| Specify either a Card, Bank Account or Enrollable Card | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifier**](Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinstrumentidentifierenrollment"></a>
# **PostInstrumentIdentifierEnrollment**
> void PostInstrumentIdentifierEnrollment (string instrumentIdentifierTokenId, PostInstrumentIdentifierEnrollmentRequest postInstrumentIdentifierEnrollmentRequest, string profileId = null)

Enroll an Instrument Identifier for Network Tokenization

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostInstrumentIdentifierEnrollmentExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var instrumentIdentifierTokenId = instrumentIdentifierTokenId_example;  // string | The TokenId of a Instrument Identifier.
            var postInstrumentIdentifierEnrollmentRequest = new PostInstrumentIdentifierEnrollmentRequest(); // PostInstrumentIdentifierEnrollmentRequest | Specify Enrollable Card details
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Enroll an Instrument Identifier for Network Tokenization
                apiInstance.PostInstrumentIdentifierEnrollment(instrumentIdentifierTokenId, postInstrumentIdentifierEnrollmentRequest, profileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.PostInstrumentIdentifierEnrollment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentIdentifierTokenId** | **string**| The TokenId of a Instrument Identifier. | 
 **postInstrumentIdentifierEnrollmentRequest** | [**PostInstrumentIdentifierEnrollmentRequest**](PostInstrumentIdentifierEnrollmentRequest.md)| Specify Enrollable Card details | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

