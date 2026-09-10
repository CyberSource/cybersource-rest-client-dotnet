# CyberSource.Model.UnifiedRiskPost201ResponseResultsRISKINSIGHTSPackagesTransactionInsights
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the VPRI package. | [optional] 
**Name** | **string** | Human-readable display name of the VPRI package. | [optional] 
**Type** | **string** | Category of the VPRI package indicating the type of assessment performed. | [optional] 
**Score** | **int?** | Risk score produced by the AIP engine, ranging from 0 (lowest risk) to 100 (highest risk). Absent when the AIP service was not invoked. | [optional] 
**Insights** | [**UnifiedRiskPost201ResponseResultsRISKINSIGHTSPackagesTransactionInsightsInsights**](UnifiedRiskPost201ResponseResultsRISKINSIGHTSPackagesTransactionInsightsInsights.md) |  | [optional] 
**AdditionalData** | [**VpriTransactionInsightsAdditionalData**](VpriTransactionInsightsAdditionalData.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

