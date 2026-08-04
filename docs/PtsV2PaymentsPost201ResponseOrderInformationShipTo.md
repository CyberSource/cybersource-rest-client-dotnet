# CyberSource.Model.PtsV2PaymentsPost201ResponseOrderInformationShipTo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Firstname** | **string** | First name of the recipient.  | [optional] 
**Lastname** | **string** | Last name of the recipient.  | [optional] 
**Address1** | **string** | First line of the shipping address.  | [optional] 
**Address2** | **string** | Second line of the shipping address.  | [optional] 
**Locality** | **string** | City of the shipping address.  | [optional] 
**AdministrativeArea** | **string** | State or province of shipping address. This is a State, Province, and Territory Codes for the United States and Canada.  | [optional] 
**PostalCode** | **string** | Postal code of the shipping address. Consists of 5 to 9 digits.  | [optional] 
**Country** | **string** | Country of shipping address. This is a two-character ISO Standard Country Codes.  | [optional] 
**PhoneNumber** | **string** | Phone number of the recipient.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

