# CyberSource.Model.Ptsv2payoutsfxratesAcquirerInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcquirerBin** | **string** | Acquirer bank ID number that corresponds to a certificate that Cybersource already has.This ID has this format:   - &#x60;4XXXXX&#x60; for Visa - &#x60;5XXXXX&#x60; for Mastercard.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

