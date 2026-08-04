# CyberSource.Model.Ptsv2creditsProcessingInformationRefundOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | Must be set to &#x60;pow&#x60; for Mastercard Gaming Payment of Winnings tranactions. | [optional] 
**ReconciliationIdAlternate** | **string** | Alternative reference number that can be up to 12 characters in length. If this field is used, it overrides any data added to the ccCaptureService_reconciliationID field. You can use this value to reconcile Cybersource reports with processor reports. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

