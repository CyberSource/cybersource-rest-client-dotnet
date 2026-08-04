# CyberSource.Model.AgenticCardEnrollmentBadRequestResponse400Error
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | HTTP status code to categorize the errors. | 
**Reason** | **string** | Error reason as associated with the HTTP status code | 
**Message** | **string** | Error message as associated with the HTTP status code. | 
**Detail** | [**AgenticCardEnrollmentBadRequestResponse400ErrorDetail**](AgenticCardEnrollmentBadRequestResponse400ErrorDetail.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

