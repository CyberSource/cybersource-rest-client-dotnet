# CyberSource.Model.UcpCreateCheckoutSessionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LineItems** | [**List&lt;Iccv1checkoutsessionsLineItems&gt;**](Iccv1checkoutsessionsLineItems.md) | The products the buyer wants to purchase. At least one line item is required. | 
**Buyer** | [**UcpCreateCheckoutSessionBuyer**](UcpCreateCheckoutSessionBuyer.md) |  | [optional] 
**Currency** | **string** | Optional. ISO 4217 currency code for the session (e.g. &#x60;USD&#x60;, &#x60;EUR&#x60;). | [optional] 
**Payment** | [**Iccv1checkoutsessionsPayment**](Iccv1checkoutsessionsPayment.md) |  | [optional] 
**Fulfillment** | [**Iccv1checkoutsessionsFulfillment**](Iccv1checkoutsessionsFulfillment.md) |  | [optional] 
**Discounts** | [**Iccv1checkoutsessionsDiscounts**](Iccv1checkoutsessionsDiscounts.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

