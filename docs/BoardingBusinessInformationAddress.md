# CyberSource.Model.BoardingBusinessInformationAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Country** | **string** |  | 
**Address1** | **string** |  | 
**Address2** | **string** |  | [optional] 
**Locality** | **string** | City of the billing address. | 
**AdministrativeArea** | **string** | State or province of the billing address. Required for United States and Canada. | [optional] 
**PostalCode** | **string** | Postal code for the billing address. The postal code must consist of 5 to 9 digits. Required for United States and Canada. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

