# CyberSource.Model.PtsV2PaymentsPost201ResponseEmbeddedActionsTOKENCREATE
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the token create.  Possible value is:   - SUCCESS   - SERVER_ERROR   - INVALID_REQUEST  | [optional] 
**Reason** | **string** | The reason of the status.  Possible values:  - INVALID_DATA  - SYSTEM_ERROR  - MISSING_FIELD  | [optional] 
**Message** | **string** | The detail message related to the status and reason listed above. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

