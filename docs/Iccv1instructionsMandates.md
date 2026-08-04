# CyberSource.Model.Iccv1instructionsMandates
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MandateId** | **string** | Unique identifier with in the context of a purchase-intent for the mandate.   Assigned by Partner. Id shall not be reused when a mandate is updated/deleted.  | 
**PreferredMerchantName** | **string** | User merchant preference. | [optional] 
**MerchantCategory** | **string** | Merchant category Description. | [optional] 
**MerchantCategoryCode** | **string** | Merchant category Code. Once it is checked, it has to be valid merchant category code. Ex:\&quot; 5311\&quot; | [optional] 
**DeclineThreshold** | [**Iccv1instructionsDeclineThreshold**](Iccv1instructionsDeclineThreshold.md) |  | 
**RecurringPaymentInformation** | [**Iccv1instructionsRecurringPaymentInformation**](Iccv1instructionsRecurringPaymentInformation.md) |  | [optional] 
**EffectiveUntilTime** | **string** | UTC time in Unix epoch format. | 
**Quantity** | **string** | Quantity of the product. | [optional] 
**Description** | **string** | Description of the product. | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

