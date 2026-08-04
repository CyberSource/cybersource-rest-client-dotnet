# CyberSource.Model.Ptsv2paymentsWatchlistScreeningInformationWeights
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | Degree of correlation between a customer&#39;s address and an entry in the DPL before a match occurs. This field can contain one of the following values: - exact: The address must be identical to the entry in the DPL. - high: (default) The address cannot differ significantly from the entry in the DPL. - medium: The address can differ slightly more from the entry in the DPL. - low: The address can differ significantly from the entry in the DPL.  | [optional] 
**Company** | **string** | Degree of correlation between a company address and an entry in the DPL before a match occurs. This field can contain one of the following values: - exact: The company name must be identical to the entry in the DPL. - high: (default) The company name cannot differ significantly from the entry in the DPL. - medium: The company name can differ slightly more from the entry in the DPL. - low: The company name can differ significantly from the entry in the DPL.  | [optional] 
**Name** | **string** | Degree of correlation between a customer&#39;s name and an entry in the DPL before a match occurs. This field can contain one of the following values: - exact: The name must be identical to the entry in the DPL. - high: (default) The name cannot differ significantly from the entry in the DPL. - medium: The name can differ slightly more from the entry in the DPL. - low: The name can differ significantly the entry in the DPL.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

