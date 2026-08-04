# CyberSource.Model.UnderwritingConfigurationOrganizationInformationBusinessInformationAddress1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Country** | **string** | Country where the owner resides. Two character country code. | 
**Address1** | **string** | Owner&#39;s street address. | 
**Address2** | **string** | Owner&#39;s street address Continued | [optional] 
**BuildingName** | **string** | Building Name | [optional] 
**Locality** | **string** | Owner&#39;s city | 
**AdministrativeArea** | **string** | Owner&#39;s state (US) or province (Canada, others) | 
**PostalCode** | **string** | Owner&#39;s zip code (US) or postal code (Canada) | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

