# CyberSource.Model.CancelCheckoutResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The checkout session identifier. | 
**Status** | **string** | Will always be &#x60;canceled&#x60; on a successful response.  Possible values: - canceled | 
**Currency** | **string** | ISO 4217 lowercase currency code. | 
**Buyer** | [**AcpCheckoutSessionResponseBuyer**](AcpCheckoutSessionResponseBuyer.md) |  | [optional] 
**LineItems** | [**List&lt;CheckoutSessionResponseLineItems&gt;**](CheckoutSessionResponseLineItems.md) | Line items with merchant-confirmed pricing. | 
**FulfillmentAddress** | [**CheckoutSessionResponseFulfillmentAddress**](CheckoutSessionResponseFulfillmentAddress.md) |  | [optional] 
**FulfillmentOptions** | [**List&lt;CheckoutSessionResponseFulfillmentOptions&gt;**](CheckoutSessionResponseFulfillmentOptions.md) | Available fulfillment methods with pricing. | 
**FulfillmentOptionId** | **string** | ID of the currently selected fulfillment option. | [optional] 
**Totals** | [**List&lt;CheckoutSessionResponseTotals&gt;**](CheckoutSessionResponseTotals.md) | Order cost breakdown as typed total lines. All amounts in minor units (cents). | 
**Messages** | [**List&lt;CheckoutSessionResponseMessages&gt;**](CheckoutSessionResponseMessages.md) | Informational or error messages from the merchant backend. | 
**Links** | [**List&lt;CheckoutSessionResponseLinks&gt;**](CheckoutSessionResponseLinks.md) | Related resource links from the merchant (e.g. terms of use, privacy policy). | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

