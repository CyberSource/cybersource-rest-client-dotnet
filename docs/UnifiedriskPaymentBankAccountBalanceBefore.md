# CyberSource.Model.UnifiedriskPaymentBankAccountBalanceBefore
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | Account balance before transaction     | [optional] 
**Currency** | **string** | Currency of balance     | [optional] 
**BaseCurrency** | **string** | Base currency for balance     | [optional] 
**BaseValue** | **string** | Balance in base currency     | [optional] 
**MerchantCurrency** | **string** | ISO 4217 3-letter code for the merchant&#39;s local currency used to express the pre-transaction account balance (e.g., EUR for EU merchants) | [optional] 
**MerchantValue** | **string** | Pre-transaction account balance expressed in the merchant&#39;s local currency, used for cross-currency balance comparison and risk analysis | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

