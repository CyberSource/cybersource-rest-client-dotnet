# CyberSource.Model.PtsV2PaymentsPost201ResponseRiskInformationRules
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Description of the rule as it appears in the Profile Editor. | [optional] 
**Decision** | **string** | Summarizes the result for the rule according to the setting that you chose in the Profile Editor. This field can contain one of the following values: - &#x60;IGNORE&#x60; - &#x60;REVIEW&#x60; - &#x60;REJECT&#x60; - &#x60;ACCEPT&#x60;  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

