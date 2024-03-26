# CyberSource.Api.UnifiedCheckoutCaptureContextApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateUnifiedCheckoutCaptureContext**](UnifiedCheckoutCaptureContextApi.md#generateunifiedcheckoutcapturecontext) | **POST** /up/v1/capture-contexts | Generate Unified Checkout Capture Context


<a name="generateunifiedcheckoutcapturecontext"></a>
# **GenerateUnifiedCheckoutCaptureContext**
> string GenerateUnifiedCheckoutCaptureContext (GenerateUnifiedCheckoutCaptureContextRequest generateUnifiedCheckoutCaptureContextRequest)

Generate Unified Checkout Capture Context

Unified Checkout is a powerful product within the Digital Acceptance Suite. Unified Checkout is designed to assist merchants with the adoption and inclusion of digital payments within their payment acceptance page. With Unified Checkout Integration you can add digital payment methods to create familiar, convenient and seamless payment experiences that are designed to reduce checkout friction and increase conversions. Click to Pay Drop-in UI is built on the Unified Checkout platform. For more information about Unified Checkout, see the [Unified Checkout Developer Guides Page](https://developer.cybersource.com/docs/cybs/en-us/unified-checkout/developer/all/rest/unified-checkout/uc-intro.html). For examples on how to integrate Unified Checkout within your webpage please see our [GitHub Unified Checkout Samples](https://github.com/CyberSource/cybersource-unified-checkout-sample-java). For more information about Click to Pay drop in UI, see the [Click to Pay Drop-in UI Developer Guides Page](https://developer.cybersource.com/docs/cybs/en-us/click-to-pay/developer/all/rest/click-to-pay/ctp-intro.html). Generate Unified Checkout Capture Context Generate a one-time use capture context used for the invocation of Unified Checkout. The Request wil contain all of the parameters for how Unified Checkout will operate within a client webpage. The resulting payload will be a JWT signed object that can be used to initiate Unified Checkout or Click to Pay Drop-in UI within a web page

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
                string result = apiInstance.GenerateUnifiedCheckoutCaptureContext(generateUnifiedCheckoutCaptureContextRequest);
                Debug.WriteLine(result);
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

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/jwt

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

