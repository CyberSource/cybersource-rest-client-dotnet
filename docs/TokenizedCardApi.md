# CyberSource.Api.TokenizedCardApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTokenizedCard**](TokenizedCardApi.md#deletetokenizedcard) | **DELETE** /tms/v2/tokenized-cards/{tokenizedCardId} | Delete a Tokenized Card
[**GetTokenizedCard**](TokenizedCardApi.md#gettokenizedcard) | **GET** /tms/v2/tokenized-cards/{tokenizedCardId} | Retrieve a Tokenized Card
[**PostTokenizedCard**](TokenizedCardApi.md#posttokenizedcard) | **POST** /tms/v2/tokenized-cards | Create a Tokenized Card


<a name="deletetokenizedcard"></a>
# **DeleteTokenizedCard**
> void DeleteTokenizedCard (string tokenizedCardId, string profileId = null)

Delete a Tokenized Card

|  |  |  | | - -- | - -- | - -- | | The Network Token will attempt to be deleted from the card association and if successful the corresponding TMS Network Token will be deleted. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteTokenizedCardExample
    {
        public void main()
        {
            var apiInstance = new TokenizedCardApi();
            var tokenizedCardId = tokenizedCardId_example;  // string | The Id of a tokenized card.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Delete a Tokenized Card
                apiInstance.DeleteTokenizedCard(tokenizedCardId, profileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenizedCardApi.DeleteTokenizedCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenizedCardId** | **string**| The Id of a tokenized card. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettokenizedcard"></a>
# **GetTokenizedCard**
> TokenizedcardRequest GetTokenizedCard (string tokenizedCardId, string profileId = null)

Retrieve a Tokenized Card

|  |  |  | | - -- | - -- | - -- | |**Tokenized Cards**<br>A Tokenized Card represents a network token. Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.  

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetTokenizedCardExample
    {
        public void main()
        {
            var apiInstance = new TokenizedCardApi();
            var tokenizedCardId = tokenizedCardId_example;  // string | The Id of a tokenized card.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Retrieve a Tokenized Card
                TokenizedcardRequest result = apiInstance.GetTokenizedCard(tokenizedCardId, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenizedCardApi.GetTokenizedCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenizedCardId** | **string**| The Id of a tokenized card. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**TokenizedcardRequest**](TokenizedcardRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttokenizedcard"></a>
# **PostTokenizedCard**
> TokenizedcardRequest PostTokenizedCard (TokenizedcardRequest tokenizedcardRequest, string profileId = null)

Create a Tokenized Card

|  |  |  | | - -- | - -- | - -- | |**Tokenized cards**<br>A Tokenized card represents a network token. Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostTokenizedCardExample
    {
        public void main()
        {
            var apiInstance = new TokenizedCardApi();
            var tokenizedcardRequest = new TokenizedcardRequest(); // TokenizedcardRequest | 
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Create a Tokenized Card
                TokenizedcardRequest result = apiInstance.PostTokenizedCard(tokenizedcardRequest, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenizedCardApi.PostTokenizedCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenizedcardRequest** | [**TokenizedcardRequest**](TokenizedcardRequest.md)|  | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**TokenizedcardRequest**](TokenizedcardRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

