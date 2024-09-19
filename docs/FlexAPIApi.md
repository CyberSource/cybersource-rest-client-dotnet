# CyberSource.Api.FlexAPIApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateFlexAPICaptureContext**](FlexAPIApi.md#generateflexapicapturecontext) | **POST** /flex/v2/sessions | Establish a Payment Session with a Capture Context


<a name="generateflexapicapturecontext"></a>
# **GenerateFlexAPICaptureContext**
> string GenerateFlexAPICaptureContext (GenerateFlexAPICaptureContextRequest generateFlexAPICaptureContextRequest)

Establish a Payment Session with a Capture Context

To establish a payment session, include the API fields you plan to use in that session in the body of the request.  The system then returns a JSON Web Token (JWT) that includes the capture context.   To determine which fields to include in your capture context, identify the personal information that you wish to isolate from the payment session.  **Capture Context Fields**<br> When making a session request, any fields that you request to be added to the capture context are required by default.  However, you can choose to make a field optional by setting the required parameter to false. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GenerateFlexAPICaptureContextExample
    {
        public void main()
        {
            var apiInstance = new FlexAPIApi();
            var generateFlexAPICaptureContextRequest = new GenerateFlexAPICaptureContextRequest(); // GenerateFlexAPICaptureContextRequest | 

            try
            {
                // Establish a Payment Session with a Capture Context
                string result = apiInstance.GenerateFlexAPICaptureContext(generateFlexAPICaptureContextRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlexAPIApi.GenerateFlexAPICaptureContext: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateFlexAPICaptureContextRequest** | [**GenerateFlexAPICaptureContextRequest**](GenerateFlexAPICaptureContextRequest.md)|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/jwt

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

