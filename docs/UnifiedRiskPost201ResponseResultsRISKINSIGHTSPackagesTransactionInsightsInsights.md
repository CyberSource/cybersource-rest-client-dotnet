# CyberSource.Model.UnifiedRiskPost201ResponseResultsRISKINSIGHTSPackagesTransactionInsightsInsights
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Codes** | **List&lt;string&gt;** | Array of insight codes returned by the AIP engine, each representing a specific risk signal or behavioral pattern identified for the transaction. Codes follow the pattern {category}-{signal}-{window}-{detail} (e.g., BEH-* for behavioral history codes, RSK-* for real-time risk signals). | [optional] 
**Signals** | **Dictionary&lt;string, decimal?&gt;** | Key-value map of behavioral signals produced by the AIP engine. Keys represent signal identifiers and values represent their computed numeric measurements for the transaction. May be an empty object when no signals are available. | [optional] 
**Warnings** | [**List&lt;UnifiedRiskPost201ResponseResultsRISKINSIGHTSPackagesTransactionInsightsInsightsWarnings&gt;**](UnifiedRiskPost201ResponseResultsRISKINSIGHTSPackagesTransactionInsightsInsightsWarnings.md) | AIP-level warnings issued during risk evaluation. An empty array indicates no warnings. Each warning describes a limitation or anomaly encountered during AIP processing. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

