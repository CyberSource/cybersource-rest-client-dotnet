# CyberSource.Model.UnifiedriskAcquirerMerchantAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantAccountBranchId** | **string** | Unique identifier for the specific branch or location of the merchant&#39;s account within the acquiring bank&#39;s organizational structure | [optional] 
**MerchantAccountId** | **string** | The primary account identifier assigned by the acquirer to the merchant for payment processing and settlement purposes | [optional] 
**MerchantAccountIdFormat** | **string** | Describes the format or standard used for the merchant account identifier (e.g., ISO, Proprietary, Numeric) | [optional] 
**SecurityAmount** | [**UnifiedriskAcquirerMerchantAccountSecurityAmount**](UnifiedriskAcquirerMerchantAccountSecurityAmount.md) |  | [optional] 
**SettlementFrequency** | **int?** | The number of days between settlement cycles defining how often funds are transferred from the acquirer to the merchant&#39;s account (e.g., 1 for daily, 7 for weekly) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

