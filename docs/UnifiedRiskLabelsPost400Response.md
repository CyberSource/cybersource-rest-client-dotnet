# CyberSource.Model.UnifiedRiskLabelsPost400Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestId** | **string** | Echoes the unique request identifier from the original request. May be absent if the request could not be parsed (e.g., malformed JSON). | 
**SubmitTimeUtc** | **DateTime?** | UTC timestamp indicating when the failed request was received by the server. | 
**Errors** | [**List&lt;UnifiedRiskLabelsPost400ResponseErrors&gt;**](UnifiedRiskLabelsPost400ResponseErrors.md) | Root-level list of action-level errors describing what failed and why. | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

