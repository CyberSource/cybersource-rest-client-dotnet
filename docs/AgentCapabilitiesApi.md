# CyberSource.Api.AgentCapabilitiesApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateAgentKey**](AgentCapabilitiesApi.md#activateagentkey) | **POST** /icc/v1/agents/{agentId}/keys/{keyId}/activate | Activate a key
[**AddAgentKey**](AgentCapabilitiesApi.md#addagentkey) | **POST** /icc/v1/agents/{agentId}/keys | Add a key to an agent
[**CancelCheckout**](AgentCapabilitiesApi.md#cancelcheckout) | **POST** /icc/v1/checkout_sessions/{session_id}/cancel | Cancel Checkout ACP
[**CancelPurchaseIntent**](AgentCapabilitiesApi.md#cancelpurchaseintent) | **PUT** /icc/v1/instructions/{instructionId}/cancel | Cancel a purchase intent
[**CompleteCheckout**](AgentCapabilitiesApi.md#completecheckout) | **POST** /icc/v1/checkout_sessions/{session_id}/complete | Complete Checkout ACP
[**ConfirmTransactionEvents**](AgentCapabilitiesApi.md#confirmtransactionevents) | **POST** /icc/v1/instructions/{instructionId}/confirmations | Confirm transaction events
[**CreateCheckoutSession**](AgentCapabilitiesApi.md#createcheckoutsession) | **POST** /icc/v1/checkout_sessions | Create Checkout Session ACP
[**DeactivateAgentKey**](AgentCapabilitiesApi.md#deactivateagentkey) | **DELETE** /icc/v1/agents/{agentId}/keys/{keyId} | Deactivate a key
[**EnrollCard**](AgentCapabilitiesApi.md#enrollcard) | **POST** /icc/v1/tokens | Enroll a card
[**GetAgent**](AgentCapabilitiesApi.md#getagent) | **GET** /icc/v1/agents/{agentId} | Get an agent
[**GetAgentKey**](AgentCapabilitiesApi.md#getagentkey) | **GET** /icc/v1/agents/{agentId}/keys/{keyId} | Get a key by agent and key ID
[**GetCheckoutSession**](AgentCapabilitiesApi.md#getcheckoutsession) | **GET** /icc/v1/checkout_sessions/{session_id} | Get Checkout Session ACP
[**InitiatePurchaseIntent**](AgentCapabilitiesApi.md#initiatepurchaseintent) | **POST** /icc/v1/instructions | Initiate a purchase intent
[**ListAgentKeys**](AgentCapabilitiesApi.md#listagentkeys) | **GET** /icc/v1/agents/{agentId}/keys | List keys for an agent
[**RegisterAgent**](AgentCapabilitiesApi.md#registeragent) | **POST** /icc/v1/agents | Register an agent
[**RetrievePaymentCredentials**](AgentCapabilitiesApi.md#retrievepaymentcredentials) | **POST** /icc/v1/instructions/{instructionId}/credentials | Retrieve payment credentials
[**UcpCancelCheckout**](AgentCapabilitiesApi.md#ucpcancelcheckout) | **POST** /icc/v1/checkout-sessions/{session_id}/cancel | Cancel Checkout UCP
[**UcpCompleteCheckout**](AgentCapabilitiesApi.md#ucpcompletecheckout) | **POST** /icc/v1/checkout-sessions/{session_id}/complete | Complete Checkout UCP
[**UcpCreateCheckoutSession**](AgentCapabilitiesApi.md#ucpcreatecheckoutsession) | **POST** /icc/v1/checkout-sessions | Create Checkout Session UCP
[**UcpGetCheckoutSession**](AgentCapabilitiesApi.md#ucpgetcheckoutsession) | **GET** /icc/v1/checkout-sessions/{session_id} | Get Checkout Session UCP
[**UcpUpdateCheckoutSession**](AgentCapabilitiesApi.md#ucpupdatecheckoutsession) | **PUT** /icc/v1/checkout-sessions/{session_id} | Update Checkout Session UCP
[**UpdateAgent**](AgentCapabilitiesApi.md#updateagent) | **PUT** /icc/v1/agents/{agentId} | Update an agent
[**UpdateAgentKey**](AgentCapabilitiesApi.md#updateagentkey) | **PUT** /icc/v1/agents/{agentId}/keys/{keyId} | Update a key
[**UpdateCheckoutSession**](AgentCapabilitiesApi.md#updatecheckoutsession) | **POST** /icc/v1/checkout_sessions/{session_id} | Update Checkout Session ACP
[**UpdatePurchaseIntent**](AgentCapabilitiesApi.md#updatepurchaseintent) | **PUT** /icc/v1/instructions/{instructionId} | Update a purchase intent


<a name="activateagentkey"></a>
# **ActivateAgentKey**
> AddAgentKeyResponse201 ActivateAgentKey (string agentId, string keyId)

Activate a key

Activate a deactivated key. Raises 404 if agent or key not found, 403 if agent is deactivated.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ActivateAgentKeyExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var keyId = keyId_example;  // string | Unique key identifier

            try
            {
                // Activate a key
                AddAgentKeyResponse201 result = apiInstance.ActivateAgentKey(agentId, keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.ActivateAgentKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **keyId** | **string**| Unique key identifier | 

### Return type

[**AddAgentKeyResponse201**](AddAgentKeyResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addagentkey"></a>
# **AddAgentKey**
> AddAgentKeyResponse201 AddAgentKey (string agentId, KeyRequest keyRequest)

Add a key to an agent

[category 1 — Agent_Capabilities] Upload a Base64-encoded public key for an agent.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class AddAgentKeyExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var keyRequest = new KeyRequest(); // KeyRequest | Key creation request

            try
            {
                // Add a key to an agent
                AddAgentKeyResponse201 result = apiInstance.AddAgentKey(agentId, keyRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.AddAgentKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **keyRequest** | [**KeyRequest**](KeyRequest.md)| Key creation request | 

### Return type

[**AddAgentKeyResponse201**](AddAgentKeyResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelcheckout"></a>
# **CancelCheckout**
> InlineResponse20018 CancelCheckout (string sessionId, string idempotencyKey = null, string acceptLanguage = null, string userAgent = null, string requestId = null, string signature = null, string timestamp = null, string aPIVersion = null)

Cancel Checkout ACP

Cancels an active ACP checkout session. No charge is made to the buyer.  This call is safe to make multiple times — cancelling an already-cancelled session returns a successful response without error.  Sessions also expire automatically after 30 minutes of inactivity, so explicit cancellation is optional but recommended to release any reserved inventory immediately. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CancelCheckoutExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var sessionId = sessionId_example;  // string | The unique identifier of the ACP checkout session to cancel. Obtained from the `id` field in the Create Session response. 
            var idempotencyKey = idempotencyKey_example;  // string | Client-generated unique key to ensure this request is processed exactly once. If a request with the same key was already processed, the original response is returned.  (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language for the response (e.g. `en-US`, `fr-FR`). Passed to the merchant backend for localized content.  (optional) 
            var userAgent = userAgent_example;  // string | Client user agent string identifying the AI agent platform and version.  (optional) 
            var requestId = requestId_example;  // string | Unique request identifier for distributed tracing and debugging. Echoed back in the response headers.  (optional) 
            var signature = signature_example;  // string | Request signature for payload integrity verification.  (optional) 
            var timestamp = timestamp_example;  // string | ISO 8601 timestamp of when the request was generated. Used in conjunction with Signature for replay protection.  (optional) 
            var aPIVersion = aPIVersion_example;  // string | ACP specification version the client is targeting (e.g. `2024-01-01`). When omitted, the latest supported version is assumed.  (optional) 

            try
            {
                // Cancel Checkout ACP
                InlineResponse20018 result = apiInstance.CancelCheckout(sessionId, idempotencyKey, acceptLanguage, userAgent, requestId, signature, timestamp, aPIVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.CancelCheckout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **string**| The unique identifier of the ACP checkout session to cancel. Obtained from the &#x60;id&#x60; field in the Create Session response.  | 
 **idempotencyKey** | **string**| Client-generated unique key to ensure this request is processed exactly once. If a request with the same key was already processed, the original response is returned.  | [optional] 
 **acceptLanguage** | **string**| Preferred language for the response (e.g. &#x60;en-US&#x60;, &#x60;fr-FR&#x60;). Passed to the merchant backend for localized content.  | [optional] 
 **userAgent** | **string**| Client user agent string identifying the AI agent platform and version.  | [optional] 
 **requestId** | **string**| Unique request identifier for distributed tracing and debugging. Echoed back in the response headers.  | [optional] 
 **signature** | **string**| Request signature for payload integrity verification.  | [optional] 
 **timestamp** | **string**| ISO 8601 timestamp of when the request was generated. Used in conjunction with Signature for replay protection.  | [optional] 
 **aPIVersion** | **string**| ACP specification version the client is targeting (e.g. &#x60;2024-01-01&#x60;). When omitted, the latest supported version is assumed.  | [optional] 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            var apiInstance = new AgentCapabilitiesApi();
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
                Debug.Print("Exception when calling AgentCapabilitiesApi.CancelPurchaseIntent: " + e.Message );
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

<a name="completecheckout"></a>
# **CompleteCheckout**
> InlineResponse20017 CompleteCheckout (string sessionId, AcpCompleteCheckoutRequest acpCompleteCheckoutRequest, string idempotencyKey = null, string acceptLanguage = null, string userAgent = null, string requestId = null, string signature = null, string timestamp = null, string aPIVersion = null)

Complete Checkout ACP

**Final step of the ACP checkout flow.**  Submits payment and buyer information to place the order with the merchant. On success, the session transitions to `completed` and an `order_id` is returned confirming the merchant accepted the order.  Once completed, the session is immutable — it cannot be updated or cancelled.  **Payment token:** The `payment.token` must be a valid token from the payment provider configured for the merchant (e.g. a tokenized card from Stripe or Braintree). ACG forwards the token to the merchant's payment processor — it is never stored. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CompleteCheckoutExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var sessionId = sessionId_example;  // string | The unique identifier of the ACP checkout session to complete.
            var acpCompleteCheckoutRequest = new AcpCompleteCheckoutRequest(); // AcpCompleteCheckoutRequest | Final buyer and payment details needed to place the order. Both `buyer` and `payment` may have been provided in earlier Create/Update calls; if so, they can be omitted here. At least a valid payment token is required to process the transaction. 
            var idempotencyKey = idempotencyKey_example;  // string | Client-generated unique key to ensure this request is processed exactly once. If a request with the same key was already processed, the original response is returned.  (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language for the response (e.g. `en-US`, `fr-FR`). Passed to the merchant backend for localized content.  (optional) 
            var userAgent = userAgent_example;  // string | Client user agent string identifying the AI agent platform and version.  (optional) 
            var requestId = requestId_example;  // string | Unique request identifier for distributed tracing and debugging. Echoed back in the response headers.  (optional) 
            var signature = signature_example;  // string | Request signature for payload integrity verification.  (optional) 
            var timestamp = timestamp_example;  // string | ISO 8601 timestamp of when the request was generated. Used in conjunction with Signature for replay protection.  (optional) 
            var aPIVersion = aPIVersion_example;  // string | ACP specification version the client is targeting (e.g. `2024-01-01`). When omitted, the latest supported version is assumed.  (optional) 

            try
            {
                // Complete Checkout ACP
                InlineResponse20017 result = apiInstance.CompleteCheckout(sessionId, acpCompleteCheckoutRequest, idempotencyKey, acceptLanguage, userAgent, requestId, signature, timestamp, aPIVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.CompleteCheckout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **string**| The unique identifier of the ACP checkout session to complete. | 
 **acpCompleteCheckoutRequest** | [**AcpCompleteCheckoutRequest**](AcpCompleteCheckoutRequest.md)| Final buyer and payment details needed to place the order. Both &#x60;buyer&#x60; and &#x60;payment&#x60; may have been provided in earlier Create/Update calls; if so, they can be omitted here. At least a valid payment token is required to process the transaction.  | 
 **idempotencyKey** | **string**| Client-generated unique key to ensure this request is processed exactly once. If a request with the same key was already processed, the original response is returned.  | [optional] 
 **acceptLanguage** | **string**| Preferred language for the response (e.g. &#x60;en-US&#x60;, &#x60;fr-FR&#x60;). Passed to the merchant backend for localized content.  | [optional] 
 **userAgent** | **string**| Client user agent string identifying the AI agent platform and version.  | [optional] 
 **requestId** | **string**| Unique request identifier for distributed tracing and debugging. Echoed back in the response headers.  | [optional] 
 **signature** | **string**| Request signature for payload integrity verification.  | [optional] 
 **timestamp** | **string**| ISO 8601 timestamp of when the request was generated. Used in conjunction with Signature for replay protection.  | [optional] 
 **aPIVersion** | **string**| ACP specification version the client is targeting (e.g. &#x60;2024-01-01&#x60;). When omitted, the latest supported version is assumed.  | [optional] 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

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
            var apiInstance = new AgentCapabilitiesApi();
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
                Debug.Print("Exception when calling AgentCapabilitiesApi.ConfirmTransactionEvents: " + e.Message );
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

<a name="createcheckoutsession"></a>
# **CreateCheckoutSession**
> InlineResponse20112 CreateCheckoutSession (AcpCreateCheckoutSessionRequest acpCreateCheckoutSessionRequest, string idempotencyKey = null, string acceptLanguage = null, string userAgent = null, string requestId = null, string signature = null, string timestamp = null, string aPIVersion = null)

Create Checkout Session ACP

**Step 1 of the ACP checkout flow.**  Initiates a new ACP checkout session with the buyer's cart. ACG validates item availability against the merchant's catalog, calculates initial pricing and tax, and returns a session object with a unique `id`.  **Store the `id`** — every subsequent call in this checkout flow (update, complete, cancel) requires it.  The session remains active for 30 minutes. A new session must be created after expiry.  **Idempotency:** Supply an `Idempotency-Key` header to safely retry this call without creating duplicate sessions. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateCheckoutSessionExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var acpCreateCheckoutSessionRequest = new AcpCreateCheckoutSessionRequest(); // AcpCreateCheckoutSessionRequest | The cart contents and buyer context for this checkout session. `items` is required. `buyer` and `fulfillment_address` are optional on creation and can be provided via Update Session before completing checkout. 
            var idempotencyKey = idempotencyKey_example;  // string | Client-generated unique key to ensure this request is processed exactly once. If a request with the same key was already processed, the original response is returned.  (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language for the response (e.g. `en-US`, `fr-FR`). Passed to the merchant backend for localized content.  (optional) 
            var userAgent = userAgent_example;  // string | Client user agent string identifying the AI agent platform and version.  (optional) 
            var requestId = requestId_example;  // string | Unique request identifier for distributed tracing and debugging. Echoed back in the response headers.  (optional) 
            var signature = signature_example;  // string | Request signature for payload integrity verification.  (optional) 
            var timestamp = timestamp_example;  // string | ISO 8601 timestamp of when the request was generated. Used in conjunction with Signature for replay protection.  (optional) 
            var aPIVersion = aPIVersion_example;  // string | ACP specification version the client is targeting (e.g. `2024-01-01`). When omitted, the latest supported version is assumed.  (optional) 

            try
            {
                // Create Checkout Session ACP
                InlineResponse20112 result = apiInstance.CreateCheckoutSession(acpCreateCheckoutSessionRequest, idempotencyKey, acceptLanguage, userAgent, requestId, signature, timestamp, aPIVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.CreateCheckoutSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acpCreateCheckoutSessionRequest** | [**AcpCreateCheckoutSessionRequest**](AcpCreateCheckoutSessionRequest.md)| The cart contents and buyer context for this checkout session. &#x60;items&#x60; is required. &#x60;buyer&#x60; and &#x60;fulfillment_address&#x60; are optional on creation and can be provided via Update Session before completing checkout.  | 
 **idempotencyKey** | **string**| Client-generated unique key to ensure this request is processed exactly once. If a request with the same key was already processed, the original response is returned.  | [optional] 
 **acceptLanguage** | **string**| Preferred language for the response (e.g. &#x60;en-US&#x60;, &#x60;fr-FR&#x60;). Passed to the merchant backend for localized content.  | [optional] 
 **userAgent** | **string**| Client user agent string identifying the AI agent platform and version.  | [optional] 
 **requestId** | **string**| Unique request identifier for distributed tracing and debugging. Echoed back in the response headers.  | [optional] 
 **signature** | **string**| Request signature for payload integrity verification.  | [optional] 
 **timestamp** | **string**| ISO 8601 timestamp of when the request was generated. Used in conjunction with Signature for replay protection.  | [optional] 
 **aPIVersion** | **string**| ACP specification version the client is targeting (e.g. &#x60;2024-01-01&#x60;). When omitted, the latest supported version is assumed.  | [optional] 

### Return type

[**InlineResponse20112**](InlineResponse20112.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deactivateagentkey"></a>
# **DeactivateAgentKey**
> void DeactivateAgentKey (string agentId, string keyId)

Deactivate a key

Deactivate a key (soft delete). Raises 404 if key not found.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeactivateAgentKeyExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var keyId = keyId_example;  // string | Unique key identifier

            try
            {
                // Deactivate a key
                apiInstance.DeactivateAgentKey(agentId, keyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.DeactivateAgentKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **keyId** | **string**| Unique key identifier | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enrollcard"></a>
# **EnrollCard**
> AgenticCardEnrollmentResponse200 EnrollCard (AgenticCardEnrollmentRequest agenticCardEnrollmentRequest)

Enroll a card

Enroll a payment card for agentic or e-commerce transactions. This is typically the first step in the Intelligent Commerce payment lifecycle — the agent calls this endpoint to register a consumer's card, creating a tokenized reference that can be used in subsequent purchase instructions and payment credential retrieval. Requires device information, consumer identity, billing details, and payment instrument references. Returns a status of ACTIVE (HTTP 200) if enrollment completes immediately, or PENDING (HTTP 202) with pendingEvents if cardholder authentication is required. Call this endpoint when a consumer wants to add a new payment card or when setting up a card for agentic payment flows.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class EnrollCardExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var agenticCardEnrollmentRequest = new AgenticCardEnrollmentRequest(); // AgenticCardEnrollmentRequest | 

            try
            {
                // Enroll a card
                AgenticCardEnrollmentResponse200 result = apiInstance.EnrollCard(agenticCardEnrollmentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.EnrollCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agenticCardEnrollmentRequest** | [**AgenticCardEnrollmentRequest**](AgenticCardEnrollmentRequest.md)|  | 

### Return type

[**AgenticCardEnrollmentResponse200**](AgenticCardEnrollmentResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagent"></a>
# **GetAgent**
> AgentRegistrationResponse201 GetAgent (string agentId)

Get an agent

[category 1 — Agent_Capabilities] Get agent by ID with all keys. Raises 404 if agent not found.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetAgentExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var agentId = agentId_example;  // string | Unique agent identifier

            try
            {
                // Get an agent
                AgentRegistrationResponse201 result = apiInstance.GetAgent(agentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.GetAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 

### Return type

[**AgentRegistrationResponse201**](AgentRegistrationResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagentkey"></a>
# **GetAgentKey**
> AddAgentKeyResponse201 GetAgentKey (string agentId, string keyId)

Get a key by agent and key ID

Get a specific key by agent ID and key ID. Raises 404 if key not found.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetAgentKeyExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var keyId = keyId_example;  // string | Unique key identifier

            try
            {
                // Get a key by agent and key ID
                AddAgentKeyResponse201 result = apiInstance.GetAgentKey(agentId, keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.GetAgentKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **keyId** | **string**| Unique key identifier | 

### Return type

[**AddAgentKeyResponse201**](AddAgentKeyResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcheckoutsession"></a>
# **GetCheckoutSession**
> InlineResponse20112 GetCheckoutSession (string sessionId, Object acpGetCheckoutSessionRequest, string idempotencyKey = null, string acceptLanguage = null, string userAgent = null, string requestId = null, string signature = null, string timestamp = null, string aPIVersion = null)

Get Checkout Session ACP

Retrieves the current state of an ACP checkout session, including line items, buyer information,  and current totals.  Use this to: - Verify session status before presenting a checkout summary to the buyer - Resume an interrupted checkout flow - Poll for status after an async operation - Confirm a session has not expired before submitting payment 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetCheckoutSessionExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var sessionId = sessionId_example;  // string | The unique identifier of the ACP checkout session to retrieve. Obtained from the `id` field in the Create Session response. 
            var acpGetCheckoutSessionRequest = ;  // Object | Empty request body.
            var idempotencyKey = idempotencyKey_example;  // string | Client-generated unique key to ensure this request is processed exactly once. If a request with the same key was already processed, the original response is returned.  (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language for the response (e.g. `en-US`, `fr-FR`). Passed to the merchant backend for localized content.  (optional) 
            var userAgent = userAgent_example;  // string | Client user agent string identifying the AI agent platform and version.  (optional) 
            var requestId = requestId_example;  // string | Unique request identifier for distributed tracing and debugging. Echoed back in the response headers.  (optional) 
            var signature = signature_example;  // string | Request signature for payload integrity verification.  (optional) 
            var timestamp = timestamp_example;  // string | ISO 8601 timestamp of when the request was generated. Used in conjunction with Signature for replay protection.  (optional) 
            var aPIVersion = aPIVersion_example;  // string | ACP specification version the client is targeting (e.g. `2024-01-01`). When omitted, the latest supported version is assumed.  (optional) 

            try
            {
                // Get Checkout Session ACP
                InlineResponse20112 result = apiInstance.GetCheckoutSession(sessionId, acpGetCheckoutSessionRequest, idempotencyKey, acceptLanguage, userAgent, requestId, signature, timestamp, aPIVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.GetCheckoutSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **string**| The unique identifier of the ACP checkout session to retrieve. Obtained from the &#x60;id&#x60; field in the Create Session response.  | 
 **acpGetCheckoutSessionRequest** | **Object**| Empty request body. | 
 **idempotencyKey** | **string**| Client-generated unique key to ensure this request is processed exactly once. If a request with the same key was already processed, the original response is returned.  | [optional] 
 **acceptLanguage** | **string**| Preferred language for the response (e.g. &#x60;en-US&#x60;, &#x60;fr-FR&#x60;). Passed to the merchant backend for localized content.  | [optional] 
 **userAgent** | **string**| Client user agent string identifying the AI agent platform and version.  | [optional] 
 **requestId** | **string**| Unique request identifier for distributed tracing and debugging. Echoed back in the response headers.  | [optional] 
 **signature** | **string**| Request signature for payload integrity verification.  | [optional] 
 **timestamp** | **string**| ISO 8601 timestamp of when the request was generated. Used in conjunction with Signature for replay protection.  | [optional] 
 **aPIVersion** | **string**| ACP specification version the client is targeting (e.g. &#x60;2024-01-01&#x60;). When omitted, the latest supported version is assumed.  | [optional] 

### Return type

[**InlineResponse20112**](InlineResponse20112.md)

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
            var apiInstance = new AgentCapabilitiesApi();
            var agenticCreatePurchaseIntentRequest = new AgenticCreatePurchaseIntentRequest(); // AgenticCreatePurchaseIntentRequest | 

            try
            {
                // Initiate a purchase intent
                AgenticCreatePurchaseIntentResponse200 result = apiInstance.InitiatePurchaseIntent(agenticCreatePurchaseIntentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.InitiatePurchaseIntent: " + e.Message );
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

<a name="listagentkeys"></a>
# **ListAgentKeys**
> ListAgentKeysResponse200 ListAgentKeys (string agentId, int? page = null, int? pageSize = null)

List keys for an agent

[category 1 — Agent_Capabilities] List all keys for a specific agent with pagination.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ListAgentKeysExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var page = 56;  // int? | Page number (1-indexed) (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page (max 100) (optional)  (default to 30)

            try
            {
                // List keys for an agent
                ListAgentKeysResponse200 result = apiInstance.ListAgentKeys(agentId, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.ListAgentKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **page** | **int?**| Page number (1-indexed) | [optional] [default to 1]
 **pageSize** | **int?**| Items per page (max 100) | [optional] [default to 30]

### Return type

[**ListAgentKeysResponse200**](ListAgentKeysResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registeragent"></a>
# **RegisterAgent**
> AgentRegistrationResponse201 RegisterAgent (AgentRequest agentRequest)

Register an agent

Register a new AI agent in the VARS. Once registered, the agent can upload public keys that merchants and Visa services use to verify request signatures. Raises 409 if domain, contactEmail, or tokenRequestorId already exists.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class RegisterAgentExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var agentRequest = new AgentRequest(); // AgentRequest | Agent registration request

            try
            {
                // Register an agent
                AgentRegistrationResponse201 result = apiInstance.RegisterAgent(agentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.RegisterAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentRequest** | [**AgentRequest**](AgentRequest.md)| Agent registration request | 

### Return type

[**AgentRegistrationResponse201**](AgentRegistrationResponse201.md)

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
            var apiInstance = new AgentCapabilitiesApi();
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
                Debug.Print("Exception when calling AgentCapabilitiesApi.RetrievePaymentCredentials: " + e.Message );
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

<a name="ucpcancelcheckout"></a>
# **UcpCancelCheckout**
> InlineResponse20113 UcpCancelCheckout (string sessionId)

Cancel Checkout UCP

Cancels an active UCP checkout session. No charge is made.  This operation is idempotent — cancelling an already-cancelled session returns a successful response. Sessions also expire automatically after 30 minutes of inactivity. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UcpCancelCheckoutExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var sessionId = sess_abc123;  // string | The unique identifier of the UCP checkout session to cancel.

            try
            {
                // Cancel Checkout UCP
                InlineResponse20113 result = apiInstance.UcpCancelCheckout(sessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.UcpCancelCheckout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **string**| The unique identifier of the UCP checkout session to cancel. | 

### Return type

[**InlineResponse20113**](InlineResponse20113.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ucpcompletecheckout"></a>
# **UcpCompleteCheckout**
> InlineResponse20113 UcpCompleteCheckout (string sessionId, string idempotencyKey = null, UcpCompleteCheckoutRequest ucpCompleteCheckoutRequest = null)

Complete Checkout UCP

**Final step of the UCP checkout flow.**  Finalizes the session and places the order with the merchant. ACG translates the UCP completion request to the merchant's checkout API.  On success, the session transitions to `completed`. An `order_id` is not returned in the UCP response — use the ACP Complete endpoint if you need order confirmation details.  **Always use an `idempotency-key`** to prevent duplicate orders on network retries. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UcpCompleteCheckoutExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var sessionId = sess_abc123;  // string | The unique identifier of the UCP checkout session to complete.
            var idempotencyKey = a1b2c3d4-e5f6-7890-abcd-ef1234567890;  // string | **Strongly recommended.** A unique key that ensures this order is placed exactly once on retries. Lowercase per UCP spec.  (optional) 
            var ucpCompleteCheckoutRequest = new UcpCompleteCheckoutRequest(); // UcpCompleteCheckoutRequest | UCP completion payload containing payment instrument and optional risk signals. If payment context was already provided in the Create or Update call, the body can be omitted. Risk signals are logged for fraud analysis and are not forwarded to the merchant.  (optional) 

            try
            {
                // Complete Checkout UCP
                InlineResponse20113 result = apiInstance.UcpCompleteCheckout(sessionId, idempotencyKey, ucpCompleteCheckoutRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.UcpCompleteCheckout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **string**| The unique identifier of the UCP checkout session to complete. | 
 **idempotencyKey** | **string**| **Strongly recommended.** A unique key that ensures this order is placed exactly once on retries. Lowercase per UCP spec.  | [optional] 
 **ucpCompleteCheckoutRequest** | [**UcpCompleteCheckoutRequest**](UcpCompleteCheckoutRequest.md)| UCP completion payload containing payment instrument and optional risk signals. If payment context was already provided in the Create or Update call, the body can be omitted. Risk signals are logged for fraud analysis and are not forwarded to the merchant.  | [optional] 

### Return type

[**InlineResponse20113**](InlineResponse20113.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ucpcreatecheckoutsession"></a>
# **UcpCreateCheckoutSession**
> InlineResponse20113 UcpCreateCheckoutSession (UcpCreateCheckoutSessionRequest ucpCreateCheckoutSessionRequest, string idempotencyKey = null)

Create Checkout Session UCP

**Step 1 of the UCP checkout flow.**  Creates a new UCP checkout session using Google's Universal Commerce Protocol format. ACG translates the UCP request into the internal ACP format, applies merchant pricing, and returns a UCP-format session response with a session `id`.  UCP uses `line_items` (instead of `items`) and lowercase header names (`idempotency-key`) per the UCP specification.  **Store the `id`** from the response — it is required for all subsequent UCP calls. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UcpCreateCheckoutSessionExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var ucpCreateCheckoutSessionRequest = new UcpCreateCheckoutSessionRequest(); // UcpCreateCheckoutSessionRequest | UCP checkout session creation payload containing line items, buyer details, currency, and optional payment, fulfillment, and discount information. 
            var idempotencyKey = fc23729f-dc9b-4619-8742-2cf9d7bfdf1b;  // string | Client-generated unique key (UUID recommended) to ensure this request is processed exactly once. Lowercase per UCP specification.  (optional) 

            try
            {
                // Create Checkout Session UCP
                InlineResponse20113 result = apiInstance.UcpCreateCheckoutSession(ucpCreateCheckoutSessionRequest, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.UcpCreateCheckoutSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ucpCreateCheckoutSessionRequest** | [**UcpCreateCheckoutSessionRequest**](UcpCreateCheckoutSessionRequest.md)| UCP checkout session creation payload containing line items, buyer details, currency, and optional payment, fulfillment, and discount information.  | 
 **idempotencyKey** | **string**| Client-generated unique key (UUID recommended) to ensure this request is processed exactly once. Lowercase per UCP specification.  | [optional] 

### Return type

[**InlineResponse20113**](InlineResponse20113.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ucpgetcheckoutsession"></a>
# **UcpGetCheckoutSession**
> InlineResponse20113 UcpGetCheckoutSession (string sessionId, Object ucpGetCheckoutSessionRequest)

Get Checkout Session UCP

Retrieves the current state of a UCP checkout session.  Use this to verify session status, retrieve updated totals after a fulfillment change, or resume a session after an interruption. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UcpGetCheckoutSessionExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var sessionId = sess_abc123;  // string | The unique identifier of the UCP checkout session to retrieve. Obtained from the `id` field in the Create Session response. 
            var ucpGetCheckoutSessionRequest = ;  // Object | Empty request body.

            try
            {
                // Get Checkout Session UCP
                InlineResponse20113 result = apiInstance.UcpGetCheckoutSession(sessionId, ucpGetCheckoutSessionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.UcpGetCheckoutSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **string**| The unique identifier of the UCP checkout session to retrieve. Obtained from the &#x60;id&#x60; field in the Create Session response.  | 
 **ucpGetCheckoutSessionRequest** | **Object**| Empty request body. | 

### Return type

[**InlineResponse20113**](InlineResponse20113.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ucpupdatecheckoutsession"></a>
# **UcpUpdateCheckoutSession**
> InlineResponse20113 UcpUpdateCheckoutSession (string sessionId, UcpUpdateCheckoutSessionRequest ucpUpdateCheckoutSessionRequest, string idempotencyKey = null)

Update Checkout Session UCP

Modifies an active UCP checkout session and returns the updated session state.  Use this to change line item quantities, update fulfillment address or method, or apply discount codes. Totals are recalculated and returned in the response.  Only the fields you include in the request body are updated. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UcpUpdateCheckoutSessionExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var sessionId = sess_abc123;  // string | The unique identifier of the UCP checkout session to update.
            var ucpUpdateCheckoutSessionRequest = new UcpUpdateCheckoutSessionRequest(); // UcpUpdateCheckoutSessionRequest | UCP session update payload. All fields are optional — only fields you include will be applied. 
            var idempotencyKey = a1b2c3d4-e5f6-7890-abcd-ef1234567890;  // string | Client-generated unique key for idempotency. Lowercase per UCP spec. (optional) 

            try
            {
                // Update Checkout Session UCP
                InlineResponse20113 result = apiInstance.UcpUpdateCheckoutSession(sessionId, ucpUpdateCheckoutSessionRequest, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.UcpUpdateCheckoutSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **string**| The unique identifier of the UCP checkout session to update. | 
 **ucpUpdateCheckoutSessionRequest** | [**UcpUpdateCheckoutSessionRequest**](UcpUpdateCheckoutSessionRequest.md)| UCP session update payload. All fields are optional — only fields you include will be applied.  | 
 **idempotencyKey** | **string**| Client-generated unique key for idempotency. Lowercase per UCP spec. | [optional] 

### Return type

[**InlineResponse20113**](InlineResponse20113.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateagent"></a>
# **UpdateAgent**
> AgentRegistrationResponse201 UpdateAgent (string agentId, AgentUpdate agentUpdate)

Update an agent

[category 1 — Agent_Capabilities] Update agent information. Updatable fields are name, domain, description, contactEmail, and agentMetadata. Extra fields (e.g. tokenRequestorId, keys) will return 422 Validation Error. Raises 404 if agent not found, 403 if agent is deactivated, 409 if new domain or contactEmail already exists.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateAgentExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var agentUpdate = new AgentUpdate(); // AgentUpdate | Agent update request

            try
            {
                // Update an agent
                AgentRegistrationResponse201 result = apiInstance.UpdateAgent(agentId, agentUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.UpdateAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **agentUpdate** | [**AgentUpdate**](AgentUpdate.md)| Agent update request | 

### Return type

[**AgentRegistrationResponse201**](AgentRegistrationResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateagentkey"></a>
# **UpdateAgentKey**
> AddAgentKeyResponse201 UpdateAgentKey (string agentId, string keyId, KeyUpdate keyUpdate)

Update a key

Update key information. Updatable fields are keyName, publicKey, algorithm, and expirationDate. Raises 404 if agent or key not found, 403 if agent or key is deactivated, 409 if new keyName already exists.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateAgentKeyExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var keyId = keyId_example;  // string | Unique key identifier
            var keyUpdate = new KeyUpdate(); // KeyUpdate | Key update request

            try
            {
                // Update a key
                AddAgentKeyResponse201 result = apiInstance.UpdateAgentKey(agentId, keyId, keyUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.UpdateAgentKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **keyId** | **string**| Unique key identifier | 
 **keyUpdate** | [**KeyUpdate**](KeyUpdate.md)| Key update request | 

### Return type

[**AddAgentKeyResponse201**](AddAgentKeyResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecheckoutsession"></a>
# **UpdateCheckoutSession**
> InlineResponse20112 UpdateCheckoutSession (string sessionId, AcpUpdateCheckoutSessionRequest acpUpdateCheckoutSessionRequest, string idempotencyKey = null, string acceptLanguage = null, string userAgent = null, string requestId = null, string signature = null, string timestamp = null, string aPIVersion = null)

Update Checkout Session ACP

Modifies an active ACP checkout session and returns the updated session state with recalculated totals.  Use this to: - Add, remove, or change quantities of cart items - Apply or remove discount codes - Update the buyer's shipping address or contact details - Trigger re-calculation of shipping costs and tax  Only fields included in the request body are updated — omitted fields retain their current values.  **Idempotency:** Supply an `Idempotency-Key` to safely retry updates without applying them twice. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateCheckoutSessionExample
    {
        public void main()
        {
            var apiInstance = new AgentCapabilitiesApi();
            var sessionId = sessionId_example;  // string | The unique identifier of the ACP checkout session to update. Obtained from the `id` field in the Create Session response. 
            var acpUpdateCheckoutSessionRequest = new AcpUpdateCheckoutSessionRequest(); // AcpUpdateCheckoutSessionRequest | Fields to update. All fields are optional — only included fields are changed. To replace the cart entirely, provide the full `items` array. 
            var idempotencyKey = idempotencyKey_example;  // string | Client-generated unique key to ensure this request is processed exactly once. If a request with the same key was already processed, the original response is returned.  (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language for the response (e.g. `en-US`, `fr-FR`). Passed to the merchant backend for localized content.  (optional) 
            var userAgent = userAgent_example;  // string | Client user agent string identifying the AI agent platform and version.  (optional) 
            var requestId = requestId_example;  // string | Unique request identifier for distributed tracing and debugging. Echoed back in the response headers.  (optional) 
            var signature = signature_example;  // string | Request signature for payload integrity verification.  (optional) 
            var timestamp = timestamp_example;  // string | ISO 8601 timestamp of when the request was generated. Used in conjunction with Signature for replay protection.  (optional) 
            var aPIVersion = aPIVersion_example;  // string | ACP specification version the client is targeting (e.g. `2024-01-01`). When omitted, the latest supported version is assumed.  (optional) 

            try
            {
                // Update Checkout Session ACP
                InlineResponse20112 result = apiInstance.UpdateCheckoutSession(sessionId, acpUpdateCheckoutSessionRequest, idempotencyKey, acceptLanguage, userAgent, requestId, signature, timestamp, aPIVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentCapabilitiesApi.UpdateCheckoutSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **string**| The unique identifier of the ACP checkout session to update. Obtained from the &#x60;id&#x60; field in the Create Session response.  | 
 **acpUpdateCheckoutSessionRequest** | [**AcpUpdateCheckoutSessionRequest**](AcpUpdateCheckoutSessionRequest.md)| Fields to update. All fields are optional — only included fields are changed. To replace the cart entirely, provide the full &#x60;items&#x60; array.  | 
 **idempotencyKey** | **string**| Client-generated unique key to ensure this request is processed exactly once. If a request with the same key was already processed, the original response is returned.  | [optional] 
 **acceptLanguage** | **string**| Preferred language for the response (e.g. &#x60;en-US&#x60;, &#x60;fr-FR&#x60;). Passed to the merchant backend for localized content.  | [optional] 
 **userAgent** | **string**| Client user agent string identifying the AI agent platform and version.  | [optional] 
 **requestId** | **string**| Unique request identifier for distributed tracing and debugging. Echoed back in the response headers.  | [optional] 
 **signature** | **string**| Request signature for payload integrity verification.  | [optional] 
 **timestamp** | **string**| ISO 8601 timestamp of when the request was generated. Used in conjunction with Signature for replay protection.  | [optional] 
 **aPIVersion** | **string**| ACP specification version the client is targeting (e.g. &#x60;2024-01-01&#x60;). When omitted, the latest supported version is assumed.  | [optional] 

### Return type

[**InlineResponse20112**](InlineResponse20112.md)

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
            var apiInstance = new AgentCapabilitiesApi();
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
                Debug.Print("Exception when calling AgentCapabilitiesApi.UpdatePurchaseIntent: " + e.Message );
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

