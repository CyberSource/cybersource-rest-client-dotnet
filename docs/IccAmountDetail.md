# CyberSource.Model.IccAmountDetail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalAmount** | **string** | The final amount that the customer needs to pay or paid. | 
**Currency** | **string** | (Conditional) ISO 4217 currency code. Currency in which the transactionAmount, subTotal, tax, Shipping&amp; handling or discount amount is expressed. Conditionality - Required when either transactionAmount, subTotal, tax, Shipping&amp; handling or discount amount is present.  | 
**SubTotalAmount** | **string** | The total transaction amount before any taxes or discounts are applied. | [optional] 
**DiscountAmount** | **string** | The total discount amount applied to the transaction. | [optional] 
**ShippingAmount** | **string** | The total shipping and handling cost(amount) applied to the transaction. | [optional] 
**HandlingAmount** | **string** | The total shipping and handling cost(amount) applied to the transaction. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

