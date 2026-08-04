# CyberSource.Model.TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OriginalTransactionId** | **string** | Value that links the previous transaction to the current follow-on request. This value is assigned by the client software that is installed on the POS terminal, which makes it available to the terminal&#39;s software and to CyberSource. Therefore, you can use this value to reconcile transactions between CyberSource and the terminal&#39;s software.  CyberSource does not forward this value to the processor. Instead, the value is forwarded to the CyberSource reporting functionality.  This field is supported only on American Express Direct, FDC Nashville Global, and SIX.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

