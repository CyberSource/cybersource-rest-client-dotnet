# CyberSource.Model.Ptsv2paymentsidvoidsMerchantInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionLocalDateTime** | **string** | Local Time of the transaction Set the timestamp for the exchange rate by ISO 8601 UTC format. Format: \&quot;YYYYMMdd&#39;T&#39;HHmmss&#39;Z&#39;\&quot;  (20151103T123456Z)  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

