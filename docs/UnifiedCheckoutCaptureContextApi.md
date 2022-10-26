# CyberSource.Api.UnifiedCheckoutCaptureContextApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateUnifiedCheckoutCaptureContext**](UnifiedCheckoutCaptureContextApi.md#generateunifiedcheckoutcapturecontext) | **POST** /up/v1/capture-contexts | Generate Unified Checkout Capture Context


<a name="generateunifiedcheckoutcapturecontext"></a>
# **GenerateUnifiedCheckoutCaptureContext**
> void GenerateUnifiedCheckoutCaptureContext (GenerateUnifiedCheckoutCaptureContextRequest generateUnifiedCheckoutCaptureContextRequest)

Generate Unified Checkout Capture Context

Generate a one-time use capture context used for the invocation of Unified Checkout. The Request wil contain all of the paramiters for how Unified Chkcout will operate within a client webpage. The resulting payload will be a JWT signed object that can be used to initate Unified Checkout within a merchnat web page

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GenerateUnifiedCheckoutCaptureContextExample
    {
        public void main()
        {
            var apiInstance = new UnifiedCheckoutCaptureContextApi();
            var generateUnifiedCheckoutCaptureContextRequest = new GenerateUnifiedCheckoutCaptureContextRequest(); // GenerateUnifiedCheckoutCaptureContextRequest | 

            try
            {
                // Generate Unified Checkout Capture Context
                apiInstance.GenerateUnifiedCheckoutCaptureContext(generateUnifiedCheckoutCaptureContextRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UnifiedCheckoutCaptureContextApi.GenerateUnifiedCheckoutCaptureContext: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateUnifiedCheckoutCaptureContextRequest** | [**GenerateUnifiedCheckoutCaptureContextRequest**](GenerateUnifiedCheckoutCaptureContextRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/jwt

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

