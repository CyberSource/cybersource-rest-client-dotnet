# CyberSource.Api.FlexTokenApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Tokenize**](FlexTokenApi.md#tokenize) | **POST** /flex/v1/tokens/ | Flex Tokenize card


<a name="tokenize"></a>
# **Tokenize**
> FlexV1TokensPost200Response Tokenize (TokenizeRequest tokenizeRequest = null)

Flex Tokenize card

Returns a token representing the supplied card details. The token replaces card data and can be used as the Subscription ID in the CyberSource Simple Order API or SCMP API. This is an unauthenticated call that you should initiate from your customer’s device or browser.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class TokenizeExample
    {
        public void main()
        {
            var apiInstance = new FlexTokenApi();
            var tokenizeRequest = new TokenizeRequest(); // TokenizeRequest |  (optional) 

            try
            {
                // Flex Tokenize card
                FlexV1TokensPost200Response result = apiInstance.Tokenize(tokenizeRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlexTokenApi.Tokenize: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenizeRequest** | [**TokenizeRequest**](TokenizeRequest.md)|  | [optional] 

### Return type

[**FlexV1TokensPost200Response**](FlexV1TokensPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

