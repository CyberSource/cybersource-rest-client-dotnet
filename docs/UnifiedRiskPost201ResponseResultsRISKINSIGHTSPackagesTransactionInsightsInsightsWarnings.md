# CyberSource.Model.UnifiedRiskPost201ResponseResultsRISKINSIGHTSPackagesTransactionInsightsInsightsWarnings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Machine-readable warning code identifier (e.g., SCORE-01, BIN-01, CARD-01, EMAIL-01). Use this code for programmatic handling and filtering of specific warning categories. | [optional] 
**Description** | **string** | Human-readable explanation of the warning, providing context on why the warning was raised and its potential impact on the risk assessment result. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

