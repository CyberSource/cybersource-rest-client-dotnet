# CyberSource.Model.InlineResponse40016
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Error** | **string** | Machine-readable error code (e.g. &#x60;BAD_REQUEST&#x60;, &#x60;NOT_FOUND&#x60;, &#x60;INTERNAL_ERROR&#x60;). | [optional] 
**Message** | **string** | Human-readable description of what went wrong and how to fix it. | [optional] 
**Status** | **int?** | HTTP status code. | [optional] 
**Timestamp** | **DateTime?** | ISO 8601 timestamp when the error occurred. | [optional] 
**Path** | **string** | The request path that produced this error. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

