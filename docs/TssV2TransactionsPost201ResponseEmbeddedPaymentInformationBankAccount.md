# CyberSource.Model.TssV2TransactionsPost201ResponseEmbeddedPaymentInformationBankAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Suffix** | **string** | Last four digits of the customer&#39;s payment account number.  | [optional] 
**Prefix** | **string** | Bank Identification Number (BIN). This is the initial four to six numbers on a credit card account number.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

