# CyberSource.Model.Ptsv2paymentsPaymentInformationPaymentAccountReference
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A Payment Account Reference number (PAR) is a unique reference value associated with a specific card holder PAN. It identifies the card account, not just a card. PAR is a non-payment identifier that can be associated to PANs and tokens, as defined by EMVCo. PAR allows all participants in the payments chain to have a single, non-sensitive value assigned to a consumer. This value can be used in place of sensitive card holder identification fields, and transmitted across the payments ecosystem to facilitate card holder identification.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

