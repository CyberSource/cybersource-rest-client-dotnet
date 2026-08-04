# CyberSource.Model.Riskv1liststypeentriesOrderInformationAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address1** | **string** | First line of the street address | [optional] 
**Address2** | **string** | Second line of the street address | [optional] 
**Locality** | **string** | City of the street address. Required when adding the address to a list.  | [optional] 
**Country** | **string** | Country of the street address. Use the two-character codes located in the Support Center. Required if address1 is present.  | [optional] 
**AdministrativeArea** | **string** | State, province, or territory of the street address. Use the two-character codes located in the Support Center. | [optional] 
**PostalCode** | **string** | Postal code of the street address. Required when adding the address to a list. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

