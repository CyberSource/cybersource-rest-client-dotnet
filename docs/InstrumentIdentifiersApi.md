# CyberSource.Api.InstrumentIdentifiersApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TmsV1InstrumentidentifiersPost**](InstrumentIdentifiersApi.md#tmsv1instrumentidentifierspost) | **POST** /tms/v1/instrumentidentifiers | Create an Instrument Identifier


<a name="tmsv1instrumentidentifierspost"></a>
# **TmsV1InstrumentidentifiersPost**
> TmsV1InstrumentidentifiersPost200Response TmsV1InstrumentidentifiersPost (string profileId, Body body)

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
    public class TmsV1InstrumentidentifiersPostExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifiersApi();
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration.
            var body = new Body(); // Body | Please specify either a Card or Bank Account.

            try
            {
                // Create an Instrument Identifier
                TmsV1InstrumentidentifiersPost200Response result = apiInstance.TmsV1InstrumentidentifiersPost(profileId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifiersApi.TmsV1InstrumentidentifiersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | 
 **body** | [**Body**](Body.md)| Please specify either a Card or Bank Account. | 

### Return type

[**TmsV1InstrumentidentifiersPost200Response**](TmsV1InstrumentidentifiersPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

