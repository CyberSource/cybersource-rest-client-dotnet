# CyberSource.Model.UnifiedriskRiskAssessmentVital4
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScreeningRequired** | **bool?** | Indicates whether Vital4 sanctions and adverse media screening is required for this transaction. When true, the entity details will be submitted to Vital4 for real-time screening | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

