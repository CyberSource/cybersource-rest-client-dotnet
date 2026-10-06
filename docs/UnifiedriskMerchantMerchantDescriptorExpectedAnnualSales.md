# CyberSource.Model.UnifiedriskMerchantMerchantDescriptorExpectedAnnualSales
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpectedAnnualSales** | **Object** | Nested container for expected annual sales data | [optional] 
**BaseCurrency** | **string** | ISO 4217 3-letter code for the base reference currency for annual sales | [optional] 
**BaseValue** | **string** | Expected annual sales value in the base currency, in minor units | [optional] 
**Currency** | **string** | ISO 4217 3-letter currency code for the expected annual sales amount | [optional] 
**MerchantCurrency** | **string** | ISO 4217 3-letter code for the merchant&#39;s local currency for annual sales | [optional] 
**MerchantValue** | **string** | Expected annual sales in the merchant&#39;s local currency, in minor units | [optional] 
**Value** | **string** | Expected annual sales amount in the specified currency, in minor units | [optional] 
**ExpectedAnnualVolume** | **int?** | Expected number of transactions per year, used alongside sales value for per-transaction risk profiling | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

