# CyberSource.Model.UpdatePayments
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingCyclesToSkip** | **List&lt;int?&gt;** | A list of billing cycles that are marked to be skipped. The payment cannot be added to the list if it is a retry attempt. The payment cannot be added to or removed from the list if it is on the same day as its scheduled processing time.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

