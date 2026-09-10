# CyberSource.Model.UnifiedriskMerchantMerchantDescriptorExpectedMonthlySales
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpectedMonthlySales** | **Object** | Nested container for expected monthly sales data | [optional] 
**BaseCurrency** | **string** | ISO 4217 3-letter code for the base reference currency for monthly sales | [optional] 
**BaseValue** | **int?** | Expected monthly sales value in the base currency, in minor units | [optional] 
**Currency** | **string** | ISO 4217 3-letter currency code for the expected monthly sales amount | [optional] 
**MerchantCurrency** | **string** | ISO 4217 3-letter code for the merchant&#39;s local currency for monthly sales | [optional] 
**MerchantValue** | **int?** | Expected monthly sales in the merchant&#39;s local currency, in minor units | [optional] 
**Value** | **int?** | Expected monthly sales amount in the specified currency, in minor units | [optional] 
**ExpectedMonthlyVolume** | **int?** | Expected number of transactions per month for velocity monitoring and anomaly detection | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

