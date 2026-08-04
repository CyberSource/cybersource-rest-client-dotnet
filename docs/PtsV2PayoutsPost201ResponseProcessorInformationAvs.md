# CyberSource.Model.PtsV2PayoutsPost201ResponseProcessorInformationAvs
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | AVS result code.  Code Description - &#39;Y&#39; Full Match - &#39;A&#39; Partial Match (street address only) - &#39;Z&#39; Partial Match (postal/zip only) - &#39;N&#39; Non-Match - &#39;U&#39; Unable to Verify - &#39;R&#39; Indeterminate Outcome (Retry)  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

