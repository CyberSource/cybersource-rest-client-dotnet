# CyberSource.Api.TokenApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCardArtAsset**](TokenApi.md#getcardartasset) | **GET** /tms/v2/tokens/{instrumentIdentifierId}/{tokenProvider}/assets/{assetType} | Retrieve Card Art
[**PostTokenPaymentCredentials**](TokenApi.md#posttokenpaymentcredentials) | **POST** /tms/v2/tokens/{tokenId}/payment-credentials | Generate Payment Credentials for a TMS Token


<a name="getcardartasset"></a>
# **GetCardArtAsset**
> InlineResponse200 GetCardArtAsset (string instrumentIdentifierId, string tokenProvider, string assetType)

Retrieve Card Art

Retrieves Card Art for a specific Instrument Identifier. The Card Art is a visual representation of the cardholder's payment card. Card Art is only available if a Network Token is successfully provisioned. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetCardArtAssetExample
    {
        public void main()
        {
            var apiInstance = new TokenApi();
            var instrumentIdentifierId = instrumentIdentifierId_example;  // string | The Id of an Instrument Identifier.
            var tokenProvider = tokenProvider_example;  // string | The token provider.
            var assetType = assetType_example;  // string | The type of asset.

            try
            {
                // Retrieve Card Art
                InlineResponse200 result = apiInstance.GetCardArtAsset(instrumentIdentifierId, tokenProvider, assetType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenApi.GetCardArtAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentIdentifierId** | **string**| The Id of an Instrument Identifier. | 
 **tokenProvider** | **string**| The token provider. | 
 **assetType** | **string**| The type of asset. | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttokenpaymentcredentials"></a>
# **PostTokenPaymentCredentials**
> string PostTokenPaymentCredentials (string tokenId, PostPaymentCredentialsRequest postPaymentCredentialsRequest, string profileId = null)

Generate Payment Credentials for a TMS Token

|  |  |  |     | - -- | - -- | - -- |     |**Token**<br>A Token can represent your tokenized Customer, Payment Instrument, Instrument Identifier or Tokenized Card information.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Credentials**<br>Contains payment information such as the network token, generated cryptogram for Visa & MasterCard or dynamic CVV for Amex in a JSON Web Encryption (JWE) response.<br>Your system can use this API to retrieve the Payment Credentials for an existing Customer, Payment Instrument, Instrument Identifier or Tokenized Card.<br>Optionally, **authenticated identities** information from Passkey authentication can be provided to potentially achieve liability shift, which may result in the return of an e-commerce indicator of 5 if successful. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostTokenPaymentCredentialsExample
    {
        public void main()
        {
            var apiInstance = new TokenApi();
            var tokenId = tokenId_example;  // string | The Id of a token representing a Customer, Payment Instrument or Instrument Identifier.
            var postPaymentCredentialsRequest = new PostPaymentCredentialsRequest(); // PostPaymentCredentialsRequest | 
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Generate Payment Credentials for a TMS Token
                string result = apiInstance.PostTokenPaymentCredentials(tokenId, postPaymentCredentialsRequest, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenApi.PostTokenPaymentCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenId** | **string**| The Id of a token representing a Customer, Payment Instrument or Instrument Identifier. | 
 **postPaymentCredentialsRequest** | [**PostPaymentCredentialsRequest**](PostPaymentCredentialsRequest.md)|  | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/jose;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

