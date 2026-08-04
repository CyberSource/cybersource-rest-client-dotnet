# CyberSource.Model.UnderwritingConfigurationOrganizationInformationBusinessInformationAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Country** | **string** | Country where the business is located. Two character country code, ISO 3166-1 alpha-2. | 
**Address1** | **string** | Business street address | 
**Address2** | **string** | Business street address continued | [optional] 
**BuildingName** | **string** | Building Name | [optional] 
**Locality** | **string** | City of the billing address | 
**AdministrativeArea** | **string** | Business state (US) or province (Canada, others). Required for US and Canada. | 
**PostalCode** | **string** | Business zip code (US) or postal code (Canada). The postal code must consist of 5 to 9 digits. Required for United States and Canada. | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

