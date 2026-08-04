# CyberSource.Model.Kmsegressv2keysasymKeyInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | Provider name  | [optional] 
**Tenant** | **string** | Tenant name  | [optional] 
**KeyType** | **string** | Type of the key  | [optional] 
**OrganizationId** | **string** | Organization Id  | [optional] 
**Pub** | **string** | Public certificate with only base64 encoded payload and not the header (BEGIN CERTIFICATE) and footer (END CERTIFICATE)  | [optional] 
**KeyId** | **string** | Key Serial Number  | [optional] 
**Pvt** | **string** | Private certificate with only base64 encoded payload and not header (BEGIN CERTIFICATE) and footer (END CERTIFICATE)  | [optional] 
**Status** | **string** | The status of the key  | [optional] 
**ExpiryDuration** | **string** | Key expiry duration in days  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

