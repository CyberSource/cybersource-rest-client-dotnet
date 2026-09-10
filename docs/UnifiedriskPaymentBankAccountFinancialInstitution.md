# CyberSource.Model.UnifiedriskPaymentBankAccountFinancialInstitution
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Financial institution identifier     | [optional] 
**Name** | **string** | Financial institution name     | [optional] 
**Brand** | **string** | Brand or product line of the financial institution (e.g., \&quot;Chase Sapphire\&quot;, \&quot;Citi Premier\&quot;). Used to associate the bank account with a specific branded banking product for risk profiling | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

