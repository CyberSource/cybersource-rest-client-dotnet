# CyberSource.Model.AcpUpdateCheckoutSessionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;Iccv1checkoutSessionsItems&gt;**](Iccv1checkoutSessionsItems.md) | Replacement cart item list. When provided, the entire cart is replaced with this array. To add a single item, include all existing items plus the new one.  | [optional] 
**Buyer** | [**AcpUpdateCheckoutSessionBuyer**](AcpUpdateCheckoutSessionBuyer.md) |  | [optional] 
**FulfillmentAddress** | [**Iccv1checkoutSessionssessionIdFulfillmentAddress**](Iccv1checkoutSessionssessionIdFulfillmentAddress.md) |  | [optional] 
**FulfillmentOptionId** | **string** | Optional. ID of the selected fulfillment option from &#x60;fulfillment_options&#x60; in the session response. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

