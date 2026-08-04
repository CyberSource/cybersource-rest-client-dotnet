# CyberSource.Model.InlineResponse2013ResultsRISKINSIGHTS
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestId** | **string** | Echoes the unique identifier from the original label request. | [optional] 
**ResponseTimestamp** | **DateTime?** | ISO 8601 timestamp when the VPRI service processed the label submission. | [optional] 
**Status** | **string** | Processing status of the label submission.  Possible values: - COMPLETED - INVALID_REQUEST - SERVER_ERROR | [optional] 
**Reason** | **string** | Machine-readable reason code when status is not COMPLETED. | [optional] 
**Message** | **string** | Human-readable message when status is not COMPLETED. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

