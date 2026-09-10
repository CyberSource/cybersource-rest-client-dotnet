# CyberSource.Model.UnifiedriskAcquirerMerchantAccountSecurityAmount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseCurrency** | **string** | The primary reference currency used for security deposit or holdback amounts, expressed as an ISO 4217 3-letter currency code (e.g., USD, EUR, GBP) | [optional] 
**BaseValue** | **int?** | The monetary value of the security deposit or holdback amount expressed in the base currency, typically in minor units (e.g., cents) | [optional] 
**Currency** | **string** | The transaction currency in which the security amount is collected or held, expressed as an ISO 4217 3-letter currency code | [optional] 
**MerchantCurrency** | **string** | The merchant&#39;s local or preferred currency for expressing the security amount, expressed as an ISO 4217 3-letter currency code | [optional] 
**MerchantValue** | **int?** | The security deposit or holdback amount expressed in the merchant&#39;s local currency, in minor units | [optional] 
**Value** | **int?** | The security deposit or holdback amount in the transaction currency, in minor units (e.g., cents) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

