# CyberSource.Model.InlineResponse20112LineItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ACG-assigned line item identifier. | [optional] 
**Item** | [**InlineResponse20112Item**](InlineResponse20112Item.md) |  | [optional] 
**BaseAmount** | **int?** | Unit price × quantity before discounts, in minor units. | [optional] 
**Discount** | **int?** | Discount amount for this line item, in minor units. | [optional] 
**Subtotal** | **int?** | base_amount minus discount, in minor units. | [optional] 
**Tax** | **int?** | Tax on this line item, in minor units. | [optional] 
**Total** | **int?** | subtotal plus tax, in minor units. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

