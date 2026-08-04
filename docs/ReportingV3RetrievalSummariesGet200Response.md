# CyberSource.Model.ReportingV3RetrievalSummariesGet200Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrganizationId** | **string** | Organization Id | [optional] 
**StartTime** | **DateTime?** | Report Start Date | [optional] 
**EndTime** | **string** | Report Start Date | [optional] 
**RetrievalSummaries** | [**List&lt;ReportingV3ChargebackSummariesGet200ResponseChargebackSummaries&gt;**](ReportingV3ChargebackSummariesGet200ResponseChargebackSummaries.md) | List of Summary values | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

