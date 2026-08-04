# CyberSource.Model.Riskv1decisionsidactionsProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionList** | **List&lt;string&gt;** | Follow-on action to apply to the case after the decision is successfully applied. Possible values are one of the following: - &#x60;CAPTURE&#x60; - &#x60;REVERSE&#x60;  If decision is ACCEPT, then CAPTURE can be used in actionList. If decision is REJECT, then REVERSE can be used.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

