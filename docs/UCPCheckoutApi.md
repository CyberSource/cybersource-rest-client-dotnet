# CyberSource.Api.UCPCheckoutApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UcpCancelCheckout**](UCPCheckoutApi.md#ucpcancelcheckout) | **POST** /icc/v1/checkout-sessions/{session_id}/cancel | Cancel Checkout UCP
[**UcpCompleteCheckout**](UCPCheckoutApi.md#ucpcompletecheckout) | **POST** /icc/v1/checkout-sessions/{session_id}/complete | Complete Checkout UCP
[**UcpCreateCheckoutSession**](UCPCheckoutApi.md#ucpcreatecheckoutsession) | **POST** /icc/v1/checkout-sessions | Create Checkout Session UCP
[**UcpGetCheckoutSession**](UCPCheckoutApi.md#ucpgetcheckoutsession) | **GET** /icc/v1/checkout-sessions/{session_id} | Get Checkout Session UCP
[**UcpUpdateCheckoutSession**](UCPCheckoutApi.md#ucpupdatecheckoutsession) | **PUT** /icc/v1/checkout-sessions/{session_id} | Update Checkout Session UCP


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
            var apiInstance = new UCPCheckoutApi();
            var sessionId = sess_abc123;  // string | The unique identifier of the UCP checkout session to cancel.

            try
            {
                // Cancel Checkout UCP
                InlineResponse20113 result = apiInstance.UcpCancelCheckout(sessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UCPCheckoutApi.UcpCancelCheckout: " + e.Message );
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
            var apiInstance = new UCPCheckoutApi();
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
                Debug.Print("Exception when calling UCPCheckoutApi.UcpCompleteCheckout: " + e.Message );
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
            var apiInstance = new UCPCheckoutApi();
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
                Debug.Print("Exception when calling UCPCheckoutApi.UcpCreateCheckoutSession: " + e.Message );
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
            var apiInstance = new UCPCheckoutApi();
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
                Debug.Print("Exception when calling UCPCheckoutApi.UcpGetCheckoutSession: " + e.Message );
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
            var apiInstance = new UCPCheckoutApi();
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
                Debug.Print("Exception when calling UCPCheckoutApi.UcpUpdateCheckoutSession: " + e.Message );
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

