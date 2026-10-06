# CyberSource.Model.InlineResponse20112
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this checkout session. Required for all subsequent calls (update, complete, cancel).  | 
**Status** | **string** | Current lifecycle state of the session per ACP spec: - &#x60;not_ready_for_payment&#x60; — session is open but not yet ready - &#x60;ready_for_payment&#x60; — session is ready to be completed - &#x60;completed&#x60; — order has been placed; session is immutable - &#x60;canceled&#x60; — session was abandoned; no charge was made   Possible values: - not_ready_for_payment - ready_for_payment - completed - canceled | 
**Currency** | **string** | ISO 4217 lowercase currency code for this session. | 
**LineItems** | [**List&lt;InlineResponse20112LineItems&gt;**](InlineResponse20112LineItems.md) | Line items with merchant-confirmed pricing. | 
**FulfillmentAddress** | [**InlineResponse20112FulfillmentAddress**](InlineResponse20112FulfillmentAddress.md) |  | [optional] 
**FulfillmentOptions** | [**List&lt;InlineResponse20112FulfillmentOptions&gt;**](InlineResponse20112FulfillmentOptions.md) | Available fulfillment methods with pricing. | 
**FulfillmentOptionId** | **string** | ID of the currently selected fulfillment option. | [optional] 
**Totals** | [**List&lt;InlineResponse20112Totals&gt;**](InlineResponse20112Totals.md) | Order cost breakdown as an array of typed total lines. All amounts in minor units (cents). | 
**Buyer** | [**AcpCheckoutSessionResponseBuyer**](AcpCheckoutSessionResponseBuyer.md) |  | [optional] 
**PaymentProvider** | [**InlineResponse20112PaymentProvider**](InlineResponse20112PaymentProvider.md) |  | [optional] 
**Messages** | [**List&lt;InlineResponse20112Messages&gt;**](InlineResponse20112Messages.md) | Informational or error messages from the merchant backend. | 
**Links** | [**List&lt;InlineResponse20112Links&gt;**](InlineResponse20112Links.md) | Related resource links from the merchant (e.g. terms of use, privacy policy, seller shop policies).  | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

