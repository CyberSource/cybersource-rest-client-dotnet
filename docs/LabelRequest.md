# CyberSource.Model.LabelRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Actions** | **List&lt;string&gt;** | Actions to perform. For label submission, specify VISA_PROTECT_RISK_INSIGHTS. | 
**Events** | **List&lt;string&gt;** | Must be LABELS for label submission requests. | 
**RequestId** | **string** | Unique identifier for the label submission request | [optional] 
**EventTime** | **DateTime?** | The time that the real-world event occurred. | [optional] 
**Transaction** | [**UnifiedriskTransaction**](UnifiedriskTransaction.md) |  | 
**Labels** | [**UnifiedriskLabels**](UnifiedriskLabels.md) |  | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

