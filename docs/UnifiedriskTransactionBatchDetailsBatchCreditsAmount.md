# CyberSource.Model.UnifiedriskTransactionBatchDetailsBatchCreditsAmount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseCurrency** | **string** | ISO 4217 3-letter base reference currency for batch credit amounts | [optional] 
**BaseValue** | **string** | Total value of batch credit entries in the base reference currency | [optional] 
**Currency** | **string** | ISO 4217 3-letter transaction currency for batch credit totals | [optional] 
**Value** | **string** | Total monetary value of all credit entries in this batch in the transaction currency | [optional] 
**MerchantCurrency** | **string** | ISO 4217 3-letter code for the merchant&#39;s local currency used to express the batch credits total | [optional] 
**MerchantValue** | **string** | Total batch credit amount expressed in the merchant&#39;s local currency for reconciliation | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

