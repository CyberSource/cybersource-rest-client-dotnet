# CyberSource.Model.InlineResponse20113Messages
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Message severity — &#x60;info&#x60; for informational, &#x60;error&#x60; for actionable errors.  Possible values: - info - error | 
**Code** | **string** | Machine-readable error code. Present only when &#x60;type&#x60; is &#x60;error&#x60;. | [optional] 
**Param** | **string** | JSONPath to the request field that caused the error. Present only on validation errors. | [optional] 
**ContentType** | **string** | Format of the &#x60;content&#x60; field.  Possible values: - plain - markdown | 
**Content** | **string** | Human-readable message text formatted according to &#x60;content_type&#x60;. | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

