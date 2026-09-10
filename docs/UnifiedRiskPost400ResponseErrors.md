# CyberSource.Model.UnifiedRiskPost400ResponseErrors
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | The action that encountered an error (e.g., DECISION, FEATURESPACE, RISK_INSIGHTS, CONSUMER_AUTHENTICATION, VEAS).  Possible values: - DECISION - FEATURESPACE - RISK_INSIGHTS - CONSUMER_AUTHENTICATION - VEAS | [optional] 
**Status** | **string** | Indicates a FAILURE or PARTIAL_FAILURE. | [optional] 
**Reason** | **string** | Machine-readable reason code explaining why the action failed (e.g., SYSTEM_ERROR, INVALID_REQUEST, SERVICE_UNAVAILABLE, TIMEOUT). | [optional] 
**Message** | **string** | Human-readable error message providing additional context about the failure for this specific action. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

