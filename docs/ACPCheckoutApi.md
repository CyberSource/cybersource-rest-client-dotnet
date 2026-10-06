# CyberSource.Api.ACPCheckoutApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelCheckout**](ACPCheckoutApi.md#cancelcheckout) | **POST** /icc/v1/checkout_sessions/{session_id}/cancel | Cancel Checkout ACP
[**CompleteCheckout**](ACPCheckoutApi.md#completecheckout) | **POST** /icc/v1/checkout_sessions/{session_id}/complete | Complete Checkout ACP
[**CreateCheckoutSession**](ACPCheckoutApi.md#createcheckoutsession) | **POST** /icc/v1/checkout_sessions | Create Checkout Session ACP
[**GetCheckoutSession**](ACPCheckoutApi.md#getcheckoutsession) | **GET** /icc/v1/checkout_sessions/{session_id} | Get Checkout Session ACP
[**UpdateCheckoutSession**](ACPCheckoutApi.md#updatecheckoutsession) | **POST** /icc/v1/checkout_sessions/{session_id} | Update Checkout Session ACP


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
            var apiInstance = new ACPCheckoutApi();
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
                Debug.Print("Exception when calling ACPCheckoutApi.CancelCheckout: " + e.Message );
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
            var apiInstance = new ACPCheckoutApi();
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
                Debug.Print("Exception when calling ACPCheckoutApi.CompleteCheckout: " + e.Message );
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
            var apiInstance = new ACPCheckoutApi();
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
                Debug.Print("Exception when calling ACPCheckoutApi.CreateCheckoutSession: " + e.Message );
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
            var apiInstance = new ACPCheckoutApi();
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
                Debug.Print("Exception when calling ACPCheckoutApi.GetCheckoutSession: " + e.Message );
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
            var apiInstance = new ACPCheckoutApi();
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
                Debug.Print("Exception when calling ACPCheckoutApi.UpdateCheckoutSession: " + e.Message );
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

