# CyberSource.Model.AcpCreateCheckoutSessionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;Iccv1checkoutSessionsItems&gt;**](Iccv1checkoutSessionsItems.md) | The items the buyer wants to purchase. At least one item is required. Each &#x60;id&#x60; must match a product already present in the merchant&#39;s ACG catalog.  | 
**Buyer** | [**AcpCreateCheckoutSessionBuyer**](AcpCreateCheckoutSessionBuyer.md) |  | [optional] 
**FulfillmentAddress** | [**Iccv1checkoutSessionsFulfillmentAddress**](Iccv1checkoutSessionsFulfillmentAddress.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

