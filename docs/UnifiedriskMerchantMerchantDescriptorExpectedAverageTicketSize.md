# CyberSource.Model.UnifiedriskMerchantMerchantDescriptorExpectedAverageTicketSize
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseCurrency** | **string** | ISO 4217 3-letter code for the base reference currency used to express the expected average transaction ticket size (e.g., USD, EUR) | [optional] 
**BaseValue** | **string** | Expected average transaction value in the base currency, expressed in minor units (e.g., cents) | [optional] 
**Currency** | **string** | ISO 4217 3-letter transaction currency code in which the average ticket size is denominated | [optional] 
**MerchantCurrency** | **string** | ISO 4217 3-letter code for the merchant&#39;s local currency used for expressing the average ticket size | [optional] 
**MerchantValue** | **string** | Expected average transaction value expressed in the merchant&#39;s local currency, in minor units | [optional] 
**Value** | **string** | Expected average transaction value in the transaction currency, in minor units (e.g., cents) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

