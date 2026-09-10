# CyberSource.Model.UnifiedriskOrderShippingStoreStoreAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | First line of the physical store address for click-and-collect or in-store pickup (street number and name) | [optional] 
**AddressLine2** | **string** | Second line of the physical store address (unit, suite, or floor) | [optional] 
**AddressLine3** | **string** | Third line of the physical store address for additional location details | [optional] 
**Country** | **string** | ISO 3166-1 alpha-2 or alpha-3 country code for the physical store location | [optional] 
**Locality** | **string** | City or town of the physical store location used for geolocation of the pickup point | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

