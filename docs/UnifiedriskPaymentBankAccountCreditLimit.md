# CyberSource.Model.UnifiedriskPaymentBankAccountCreditLimit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **decimal?** | Credit limit on account     | [optional] 
**Currency** | **string** | Currency of credit limit     | [optional] 
**BaseCurrency** | **string** | 3 letter ISO 4217 currency code, such as GBP, USD or EUR. A complete list of codes can be found at \&quot;https://www.iso.org/iso-4217-currency-codes.html\&quot; The baseCurrency (the currency the baseValue is ex     | [optional] 
**BaseValue** | **decimal?** | Value of transaction expressed in the currency defined in the baseCurrency field.     | [optional] 
**MerchantCurrency** | **string** | ISO 4217 3-letter code for the merchant&#39;s local currency used to express the credit limit amount (e.g., EUR for EU merchants) | [optional] 
**MerchantValue** | **decimal?** | Credit limit amount expressed in the merchant&#39;s local currency, used for utilization ratio calculations and cross-currency risk assessment | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

