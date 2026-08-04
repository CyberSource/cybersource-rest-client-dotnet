# CyberSource.Model.Body
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Valid Values:   * oneOff   * amexRegistration  | [optional] [default to "oneOff"]
**Included** | [**Accountupdaterv1batchesIncluded**](Accountupdaterv1batchesIncluded.md) |  | 
**MerchantReference** | **string** | Reference used by merchant to identify batch. | [optional] 
**NotificationEmail** | **string** | Email used to notify the batch status. | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

