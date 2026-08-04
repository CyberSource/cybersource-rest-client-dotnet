# CyberSource.Model.UcpUpdateCheckoutSessionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The session ID being updated. | [optional] 
**LineItems** | [**List&lt;Iccv1checkoutsessionsLineItems&gt;**](Iccv1checkoutsessionsLineItems.md) | Replacement line item list. When provided, replaces the entire cart. | [optional] 
**Buyer** | [**UcpUpdateCheckoutSessionBuyer**](UcpUpdateCheckoutSessionBuyer.md) |  | [optional] 
**Currency** | **string** | ISO 4217 currency code for the session (e.g. &#x60;USD&#x60;, &#x60;EUR&#x60;). | [optional] 
**Payment** | [**Iccv1checkoutsessionssessionIdPayment**](Iccv1checkoutsessionssessionIdPayment.md) |  | [optional] 
**Fulfillment** | [**Iccv1checkoutsessionssessionIdFulfillment**](Iccv1checkoutsessionssessionIdFulfillment.md) |  | [optional] 
**Discounts** | [**Iccv1checkoutsessionssessionIdDiscounts**](Iccv1checkoutsessionssessionIdDiscounts.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

