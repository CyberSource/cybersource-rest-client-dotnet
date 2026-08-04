# CyberSource.Model.Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | **string** | Four Transaction Advice Addendum (TAA) fields. These fields are used to display descriptive information about a transaction on the customer&#39;s American Express card statement. When you send TAA fields, start with amexdata_taa1, then ...taa2, and so on. Skipping a TAA field causes subsequent TAA fields to be ignored.  To use these fields, contact CyberSource Customer Support to have your account enabled for this feature.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

