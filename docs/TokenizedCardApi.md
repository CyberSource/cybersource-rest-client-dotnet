# CyberSource.Api.TokenizedCardApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTokenizedCard**](TokenizedCardApi.md#deletetokenizedcard) | **DELETE** /tms/v2/tokenized-cards/{tokenizedCardId} | Delete a Tokenized Card
[**GetTokenizedCard**](TokenizedCardApi.md#gettokenizedcard) | **GET** /tms/v2/tokenized-cards/{tokenizedCardId} | Retrieve a Tokenized Card
[**PostIssuerLifeCycleSimulation**](TokenizedCardApi.md#postissuerlifecyclesimulation) | **POST** /tms/v2/tokenized-cards/{tokenizedCardId}/issuer-life-cycle-event-simulations | Simulate Issuer Life Cycle Management Events
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
> InlineResponse2001 GetTokenizedCard (string tokenizedCardId, string profileId = null)

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
                InlineResponse2001 result = apiInstance.GetTokenizedCard(tokenizedCardId, profileId);
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postissuerlifecyclesimulation"></a>
# **PostIssuerLifeCycleSimulation**
> void PostIssuerLifeCycleSimulation (string profileId, string tokenizedCardId, PostIssuerLifeCycleSimulationRequest postIssuerLifeCycleSimulationRequest)

Simulate Issuer Life Cycle Management Events

**Lifecycle Management Events**<br>Simulates an issuer life cycle manegement event for updates on the tokenized card. The events that can be simulated are: - Token status changes (e.g. active, suspended, deleted) - Updates to the underlying card, including card art changes, expiration date changes, and card number suffix. **Note:** This is only available in CAS environment. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostIssuerLifeCycleSimulationExample
    {
        public void main()
        {
            var apiInstance = new TokenizedCardApi();
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration.
            var tokenizedCardId = tokenizedCardId_example;  // string | The Id of a tokenized card.
            var postIssuerLifeCycleSimulationRequest = new PostIssuerLifeCycleSimulationRequest(); // PostIssuerLifeCycleSimulationRequest | 

            try
            {
                // Simulate Issuer Life Cycle Management Events
                apiInstance.PostIssuerLifeCycleSimulation(profileId, tokenizedCardId, postIssuerLifeCycleSimulationRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenizedCardApi.PostIssuerLifeCycleSimulation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | 
 **tokenizedCardId** | **string**| The Id of a tokenized card. | 
 **postIssuerLifeCycleSimulationRequest** | [**PostIssuerLifeCycleSimulationRequest**](PostIssuerLifeCycleSimulationRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttokenizedcard"></a>
# **PostTokenizedCard**
> InlineResponse2001 PostTokenizedCard (PostTokenizedCardRequest postTokenizedCardRequest, string profileId = null)

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
            var postTokenizedCardRequest = new PostTokenizedCardRequest(); // PostTokenizedCardRequest | 
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Create a Tokenized Card
                InlineResponse2001 result = apiInstance.PostTokenizedCard(postTokenizedCardRequest, profileId);
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
 **postTokenizedCardRequest** | [**PostTokenizedCardRequest**](PostTokenizedCardRequest.md)|  | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

