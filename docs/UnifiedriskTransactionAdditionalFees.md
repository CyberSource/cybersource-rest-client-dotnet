# CyberSource.Model.UnifiedriskTransactionAdditionalFees
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **decimal?** | Additional fees amount | [optional] 
**Currency** | **string** | Currency for additional fees | [optional] 
**BaseCurrency** | **string** | Base currency for additional fees | [optional] 
**BaseValue** | **decimal?** | Additional fees in base currency | [optional] 
**MerchantCurrency** | **string** | ISO 4217 3-letter code for the merchant&#39;s local currency used to express the additional fees amount (e.g., EUR for EU merchants) | [optional] 
**MerchantValue** | **string** | Additional fees amount expressed in the merchant&#39;s local currency, used for cross-currency fee reconciliation | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

