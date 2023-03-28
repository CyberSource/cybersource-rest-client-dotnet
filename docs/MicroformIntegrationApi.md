# CyberSource.Api.MicroformIntegrationApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateCaptureContext**](MicroformIntegrationApi.md#generatecapturecontext) | **POST** /microform/v2/sessions | Generate Capture Context


<a name="generatecapturecontext"></a>
# **GenerateCaptureContext**
> string GenerateCaptureContext (GenerateCaptureContextRequest generateCaptureContextRequest)

Generate Capture Context

This API is used to generate the Capture Context data structure for the Microform Integration.  Microform is a browser-based acceptance solution that allows a seller to capture payment information is a secure manner from their website.  For more information about Flex Microform transactions, see the [Flex Developer Guides Page](https://developer.cybersource.com/api/developer-guides/dita-flex/SAFlexibleToken.html). For examples on how to integrate Flex Microform within your webpage please see our [GitHub Flex Samples](https://github.com/CyberSource?q=flex&type=&language=) This API is a server-to-server API to generate the capture context that can be used to initiate instance of microform on a acceptance page.  The capture context is a digitally signed JWT that provides authentication, one-time keys, and the target origin to the Microform Integration application. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GenerateCaptureContextExample
    {
        public void main()
        {
            var apiInstance = new MicroformIntegrationApi();
            var generateCaptureContextRequest = new GenerateCaptureContextRequest(); // GenerateCaptureContextRequest | 

            try
            {
                // Generate Capture Context
                string result = apiInstance.GenerateCaptureContext(generateCaptureContextRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MicroformIntegrationApi.GenerateCaptureContext: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateCaptureContextRequest** | [**GenerateCaptureContextRequest**](GenerateCaptureContextRequest.md)|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/jwt

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

