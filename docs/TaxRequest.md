# CyberSource.Model.TaxRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Vasv2taxClientReferenceInformation**](Vasv2taxClientReferenceInformation.md) |  | [optional] 
**TaxInformation** | [**Vasv2taxTaxInformation**](Vasv2taxTaxInformation.md) |  | [optional] 
**OrderInformation** | [**Vasv2taxOrderInformation**](Vasv2taxOrderInformation.md) |  | [optional] 
**MerchantInformation** | [**Vasv2taxMerchantInformation**](Vasv2taxMerchantInformation.md) |  | [optional] 
**BuyerInformation** | [**Vasv2taxBuyerInformation**](Vasv2taxBuyerInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

