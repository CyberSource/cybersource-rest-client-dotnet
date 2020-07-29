# CyberSource.Api.KeyGenerationApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GeneratePublicKey**](KeyGenerationApi.md#generatepublickey) | **POST** /flex/v1/keys | Generate Key


<a name="generatepublickey"></a>
# **GeneratePublicKey**
> FlexV1KeysPost200Response GeneratePublicKey (string format, GeneratePublicKeyRequest generatePublicKeyRequest)

Generate Key

Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GeneratePublicKeyExample
    {
        public void main()
        {
            var apiInstance = new KeyGenerationApi();
            var format = format_example;  // string | Indicator to enable the receipt of the Keys response in Flex 11+ format (JWT) or legacy (parameter not required) (default to JWT)
            var generatePublicKeyRequest = new GeneratePublicKeyRequest(); // GeneratePublicKeyRequest | 

            try
            {
                // Generate Key
                FlexV1KeysPost200Response result = apiInstance.GeneratePublicKey(format, generatePublicKeyRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeyGenerationApi.GeneratePublicKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Indicator to enable the receipt of the Keys response in Flex 11+ format (JWT) or legacy (parameter not required) | [default to JWT]
 **generatePublicKeyRequest** | [**GeneratePublicKeyRequest**](GeneratePublicKeyRequest.md)|  | 

### Return type

[**FlexV1KeysPost200Response**](FlexV1KeysPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

