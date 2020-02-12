# CyberSource.Api.TokenizationApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Tokenize**](TokenizationApi.md#tokenize) | **POST** /flex/v1/tokens | Tokenize Card


<a name="tokenize"></a>
# **Tokenize**
> FlexV1TokensPost200Response Tokenize (TokenizeRequest tokenizeRequest)

Tokenize Card

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
            var apiInstance = new TokenizationApi();
            var tokenizeRequest = new TokenizeRequest(); // TokenizeRequest | 

            try
            {
                // Tokenize Card
                FlexV1TokensPost200Response result = apiInstance.Tokenize(tokenizeRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenizationApi.Tokenize: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenizeRequest** | [**TokenizeRequest**](TokenizeRequest.md)|  | 

### Return type

[**FlexV1TokensPost200Response**](FlexV1TokensPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

