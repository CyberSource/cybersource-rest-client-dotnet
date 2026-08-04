# CyberSource.Model.PtsV2PaymentsPost201ResponseProcessingInformationCaptureOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FinalCapture** | **string** | Indicates whether you can make additional captures against the authorized payment. Set to true if you do not intend to capture additional payments against the authorization. Set to false if you intend to capture additional payments Possible Values: - &#x60;true&#x60; - &#x60;false&#x60;  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

