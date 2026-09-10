# CyberSource.Model.UnifiedriskAuthorization
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Indicator** | **bool?** | Indicates whether the transaction has passed authorization rules. True means authorization was successful; false means authorization failed or was bypassed | [optional] 
**Phase** | **string** | The authorizationPhase indicates which system was responsible for authorising the transaction. This is typically only available for advice messages. This field is particularly relevant when a Stand-In | [optional] 
**RuleOverride** | **bool?** | Indicates that authorisation rule processing upstream of ARIC was bypassed or checks were ignored during authorisation processing: true – Authorisation Rules were bypassed  false – Authorisation Rules  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

