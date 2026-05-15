# CyberSource.Api.InstructionsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelPurchaseIntent**](InstructionsApi.md#cancelpurchaseintent) | **PUT** /acp/v1/instructions/{instructionId}/cancel | Cancel a purchase intent
[**ConfirmTransactionEvents**](InstructionsApi.md#confirmtransactionevents) | **POST** /acp/v1/instructions/{instructionId}/confirmations | Confirm transaction events
[**InitiatePurchaseIntent**](InstructionsApi.md#initiatepurchaseintent) | **POST** /acp/v1/instructions | Initiate a purchase intent
[**RetrievePaymentCredentials**](InstructionsApi.md#retrievepaymentcredentials) | **POST** /acp/v1/instructions/{instructionId}/credentials | Retrieve payment credentials
[**UpdatePurchaseIntent**](InstructionsApi.md#updatepurchaseintent) | **PUT** /acp/v1/instructions/{instructionId} | Update a purchase intent


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
            var apiInstance = new InstructionsApi();
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
                Debug.Print("Exception when calling InstructionsApi.CancelPurchaseIntent: " + e.Message );
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

<a name="confirmtransactionevents"></a>
# **ConfirmTransactionEvents**
> AgenticConfirmTransactionEventsResponse202 ConfirmTransactionEvents (string instructionId, AgenticConfirmTransactionEventsRequest agenticConfirmTransactionEventsRequest)

Confirm transaction events

Confirm transaction events for a completed purchase. The agent calls this endpoint after the payment has been submitted to notify the Intelligent Commerce Connect of the transaction outcome. The request includes processor information (transaction type, status, approval codes), order details (shipping, tracking, product information), and merchant information. Returns HTTP 202 acknowledging receipt of the confirmation.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ConfirmTransactionEventsExample
    {
        public void main()
        {
            var apiInstance = new InstructionsApi();
            var instructionId = instructionId_example;  // string | Unique identifier for the purchase intent instruction.
            var agenticConfirmTransactionEventsRequest = new AgenticConfirmTransactionEventsRequest(); // AgenticConfirmTransactionEventsRequest | 

            try
            {
                // Confirm transaction events
                AgenticConfirmTransactionEventsResponse202 result = apiInstance.ConfirmTransactionEvents(instructionId, agenticConfirmTransactionEventsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstructionsApi.ConfirmTransactionEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instructionId** | **string**| Unique identifier for the purchase intent instruction. | 
 **agenticConfirmTransactionEventsRequest** | [**AgenticConfirmTransactionEventsRequest**](AgenticConfirmTransactionEventsRequest.md)|  | 

### Return type

[**AgenticConfirmTransactionEventsResponse202**](AgenticConfirmTransactionEventsResponse202.md)

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
            var apiInstance = new InstructionsApi();
            var agenticCreatePurchaseIntentRequest = new AgenticCreatePurchaseIntentRequest(); // AgenticCreatePurchaseIntentRequest | 

            try
            {
                // Initiate a purchase intent
                AgenticCreatePurchaseIntentResponse200 result = apiInstance.InitiatePurchaseIntent(agenticCreatePurchaseIntentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstructionsApi.InitiatePurchaseIntent: " + e.Message );
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

<a name="retrievepaymentcredentials"></a>
# **RetrievePaymentCredentials**
> AgenticRetrievePaymentCredentialsResponse200 RetrievePaymentCredentials (string instructionId, AgenticRetrievePaymentCredentialsRequest agenticRetrievePaymentCredentialsRequest)

Retrieve payment credentials

Retrieve tokenized payment credentials for a purchase intent to complete the transaction at a merchant. The agent calls this endpoint after a purchase intent has been created and approved, providing transaction-level details including order information, merchant details, payment options, and production information. Returns COMPLETED (HTTP 200) with a signed payload containing encrypted payment credentials (authorization token and JWS-signed payload), or PENDING (HTTP 202) with pendingEvents if additional cardholder authentication is required. The signed payload is used by the merchant's payment processor to complete the transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class RetrievePaymentCredentialsExample
    {
        public void main()
        {
            var apiInstance = new InstructionsApi();
            var instructionId = instructionId_example;  // string | Unique identifier for the purchase intent instruction.
            var agenticRetrievePaymentCredentialsRequest = new AgenticRetrievePaymentCredentialsRequest(); // AgenticRetrievePaymentCredentialsRequest | 

            try
            {
                // Retrieve payment credentials
                AgenticRetrievePaymentCredentialsResponse200 result = apiInstance.RetrievePaymentCredentials(instructionId, agenticRetrievePaymentCredentialsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstructionsApi.RetrievePaymentCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instructionId** | **string**| Unique identifier for the purchase intent instruction. | 
 **agenticRetrievePaymentCredentialsRequest** | [**AgenticRetrievePaymentCredentialsRequest**](AgenticRetrievePaymentCredentialsRequest.md)|  | 

### Return type

[**AgenticRetrievePaymentCredentialsResponse200**](AgenticRetrievePaymentCredentialsResponse200.md)

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
            var apiInstance = new InstructionsApi();
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
                Debug.Print("Exception when calling InstructionsApi.UpdatePurchaseIntent: " + e.Message );
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

