# CyberSource.Model.UnifiedriskOrderLineItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemId** | **string** | Unique identifier for the item. | [optional] 
**Name** | **string** | Name of the product. | [optional] 
**Quantity** | **int?** | Quantity of the product ordered. | [optional] 
**Price** | **decimal?** | Price of the product. | [optional] 
**Type** | **decimal?** | Type of commodity. | [optional] 
**Sku** | **string** | SKU for the product. | [optional] 
**CurrencyCode** | **string** | ISO 4217 3-letter currency code for the line item price (e.g., USD, EUR, GBP). Required when line item prices are expressed in a currency that differs from the order-level transaction currency. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

