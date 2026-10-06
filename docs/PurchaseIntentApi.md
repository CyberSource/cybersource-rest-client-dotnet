# CyberSource.Api.PurchaseIntentApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelPurchaseIntent**](PurchaseIntentApi.md#cancelpurchaseintent) | **PUT** /icc/v1/instructions/{instructionId}/cancel | Cancel a purchase intent
[**InitiatePurchaseIntent**](PurchaseIntentApi.md#initiatepurchaseintent) | **POST** /icc/v1/instructions | Initiate a purchase intent
[**UpdatePurchaseIntent**](PurchaseIntentApi.md#updatepurchaseintent) | **PUT** /icc/v1/instructions/{instructionId} | Update a purchase intent


<a name="cancelpurchaseintent"></a>
# **CancelPurchaseIntent**
> AgenticCreatePurchaseIntentResponse200 CancelPurchaseIntent (string instructionId, AgenticCancelPurchaseIntentRequest agenticCancelPurchaseIntentRequest)

Cancel a purchase intent

Cancel an existing purchase intent (instruction) identified by its instructionId. The agent calls this endpoint when the consumer decides to abandon the purchase before payment credentials have been used. Requires device information and assurance data for identity verification. Returns status CANCELLED (HTTP 200) on success, or PENDING (HTTP 202) with pendingEvents if cardholder authentication is required before cancellation can proceed.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CancelPurchaseIntentExample
    {
        public void main()
        {
            var apiInstance = new PurchaseIntentApi();
            var instructionId = instructionId_example;  // string | 
            var agenticCancelPurchaseIntentRequest = new AgenticCancelPurchaseIntentRequest(); // AgenticCancelPurchaseIntentRequest | Unique identifier for the purchase intent instruction.

            try
            {
                // Cancel a purchase intent
                AgenticCreatePurchaseIntentResponse200 result = apiInstance.CancelPurchaseIntent(instructionId, agenticCancelPurchaseIntentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseIntentApi.CancelPurchaseIntent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instructionId** | **string**|  | 
 **agenticCancelPurchaseIntentRequest** | [**AgenticCancelPurchaseIntentRequest**](AgenticCancelPurchaseIntentRequest.md)| Unique identifier for the purchase intent instruction. | 

### Return type

[**AgenticCreatePurchaseIntentResponse200**](AgenticCreatePurchaseIntentResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initiatepurchaseintent"></a>
# **InitiatePurchaseIntent**
> AgenticCreatePurchaseIntentResponse200 InitiatePurchaseIntent (AgenticCreatePurchaseIntentRequest agenticCreatePurchaseIntentRequest)

Initiate a purchase intent

Create a new purchase intent (instruction) for an agentic transaction. The agent calls this endpoint after a card has been enrolled to define what the consumer wants to buy. The request includes payment instrument references, device and assurance data, mandates (spending limits, merchant preferences, and product descriptions), and optional buyer information. Return an instructionId (HTTP 200) if the intent is created immediately, or PENDING (HTTP 202) with pendingEvents if cardholder authentication is required. The instructionId returned is used in all subsequent operations - update, cancel, retrieve credentials, and confirm transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class InitiatePurchaseIntentExample
    {
        public void main()
        {
            var apiInstance = new PurchaseIntentApi();
            var agenticCreatePurchaseIntentRequest = new AgenticCreatePurchaseIntentRequest(); // AgenticCreatePurchaseIntentRequest | 

            try
            {
                // Initiate a purchase intent
                AgenticCreatePurchaseIntentResponse200 result = apiInstance.InitiatePurchaseIntent(agenticCreatePurchaseIntentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseIntentApi.InitiatePurchaseIntent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agenticCreatePurchaseIntentRequest** | [**AgenticCreatePurchaseIntentRequest**](AgenticCreatePurchaseIntentRequest.md)|  | 

### Return type

[**AgenticCreatePurchaseIntentResponse200**](AgenticCreatePurchaseIntentResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepurchaseintent"></a>
# **UpdatePurchaseIntent**
> AgenticCreatePurchaseIntentResponse200 UpdatePurchaseIntent (string instructionId, AgenticUpdatePurchaseIntentRequest agenticUpdatePurchaseIntentRequest)

Update a purchase intent

Update an existing purchase intent (instruction) identified by its instructionId. The agent calls this endpoint when the consumer modifies their order — for example, changing the quantity, updating mandates, switching payment instruments, or changing shipping details. The request body has the same structure as the initiate request. Returns the same instructionId (HTTP 200) on success, or PENDING (HTTP 202) with pendingEvents if additional cardholder authentication is required for the updated intent.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdatePurchaseIntentExample
    {
        public void main()
        {
            var apiInstance = new PurchaseIntentApi();
            var instructionId = instructionId_example;  // string | Unique identifier for the purchase intent instruction.
            var agenticUpdatePurchaseIntentRequest = new AgenticUpdatePurchaseIntentRequest(); // AgenticUpdatePurchaseIntentRequest | 

            try
            {
                // Update a purchase intent
                AgenticCreatePurchaseIntentResponse200 result = apiInstance.UpdatePurchaseIntent(instructionId, agenticUpdatePurchaseIntentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseIntentApi.UpdatePurchaseIntent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instructionId** | **string**| Unique identifier for the purchase intent instruction. | 
 **agenticUpdatePurchaseIntentRequest** | [**AgenticUpdatePurchaseIntentRequest**](AgenticUpdatePurchaseIntentRequest.md)|  | 

### Return type

[**AgenticCreatePurchaseIntentResponse200**](AgenticCreatePurchaseIntentResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

