# CyberSource.Model.UnifiedriskOrderShippingStore
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StoreId** | **string** | Unique store identifier     | [optional] 
**StoreName** | **string** | Store name     | [optional] 
**StorePhone** | **string** | Store phone number     | [optional] 
**StoreAddress** | [**UnifiedriskOrderShippingStoreStoreAddress**](UnifiedriskOrderShippingStoreStoreAddress.md) |  | [optional] 
**AdministrativeArea** | **string** | State or province of the physical store, required for US and Canadian stores. Use ISO 3166-2 subdivision code | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

