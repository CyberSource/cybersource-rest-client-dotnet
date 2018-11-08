# CyberSource.Api.InstrumentIdentifierApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TmsV1InstrumentidentifiersTokenIdDelete**](InstrumentIdentifierApi.md#tmsv1instrumentidentifierstokeniddelete) | **DELETE** /tms/v1/instrumentidentifiers/{tokenId} | Delete an Instrument Identifier
[**TmsV1InstrumentidentifiersTokenIdGet**](InstrumentIdentifierApi.md#tmsv1instrumentidentifierstokenidget) | **GET** /tms/v1/instrumentidentifiers/{tokenId} | Retrieve an Instrument Identifier
[**TmsV1InstrumentidentifiersTokenIdPatch**](InstrumentIdentifierApi.md#tmsv1instrumentidentifierstokenidpatch) | **PATCH** /tms/v1/instrumentidentifiers/{tokenId} | Update a Instrument Identifier


<a name="tmsv1instrumentidentifierstokeniddelete"></a>
# **TmsV1InstrumentidentifiersTokenIdDelete**
> void TmsV1InstrumentidentifiersTokenIdDelete (string profileId, string tokenId)

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
    public class TmsV1InstrumentidentifiersTokenIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var tokenId = tokenId_example;  // string | The TokenId of an Instrument Identifier.

            try
            {
                // Delete an Instrument Identifier
                apiInstance.TmsV1InstrumentidentifiersTokenIdDelete(profileId, tokenId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.TmsV1InstrumentidentifiersTokenIdDelete: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tmsv1instrumentidentifierstokenidget"></a>
# **TmsV1InstrumentidentifiersTokenIdGet**
> TmsV1InstrumentidentifiersPost200Response TmsV1InstrumentidentifiersTokenIdGet (string profileId, string tokenId)

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
    public class TmsV1InstrumentidentifiersTokenIdGetExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var tokenId = tokenId_example;  // string | The TokenId of an Instrument Identifier.

            try
            {
                // Retrieve an Instrument Identifier
                TmsV1InstrumentidentifiersPost200Response result = apiInstance.TmsV1InstrumentidentifiersTokenIdGet(profileId, tokenId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.TmsV1InstrumentidentifiersTokenIdGet: " + e.Message );
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

### Return type

[**TmsV1InstrumentidentifiersPost200Response**](TmsV1InstrumentidentifiersPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tmsv1instrumentidentifierstokenidpatch"></a>
# **TmsV1InstrumentidentifiersTokenIdPatch**
> TmsV1InstrumentidentifiersPost200Response TmsV1InstrumentidentifiersTokenIdPatch (string profileId, string tokenId, Body1 body)

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
    public class TmsV1InstrumentidentifiersTokenIdPatchExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var tokenId = tokenId_example;  // string | The TokenId of an Instrument Identifier.
            var body = new Body1(); // Body1 | Please specify the previous transaction Id to update.

            try
            {
                // Update a Instrument Identifier
                TmsV1InstrumentidentifiersPost200Response result = apiInstance.TmsV1InstrumentidentifiersTokenIdPatch(profileId, tokenId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.TmsV1InstrumentidentifiersTokenIdPatch: " + e.Message );
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
 **body** | [**Body1**](Body1.md)| Please specify the previous transaction Id to update. | 

### Return type

[**TmsV1InstrumentidentifiersPost200Response**](TmsV1InstrumentidentifiersPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

