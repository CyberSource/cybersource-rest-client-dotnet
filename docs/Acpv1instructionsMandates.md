# CyberSource.Model.Acpv1instructionsMandates
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MandateId** | **string** | Unique identifier with in the context of a purchase-intent for the mandate.   Assigned by Partner. Id shall not be reused when a mandate is updated/deleted.  | 
**PreferredMerchantName** | **string** | User merchant preference. | [optional] 
**MerchantCategory** | **string** | Merchant category Description. | [optional] 
**MerchantCategoryCode** | **string** | Merchant category Code. Once it is checked, it has to be valid merchant category code. Ex:\&quot; 5311\&quot; | [optional] 
**DeclineThreshold** | [**Acpv1instructionsDeclineThreshold**](Acpv1instructionsDeclineThreshold.md) |  | 
**RecurringPaymentInformation** | [**Acpv1instructionsRecurringPaymentInformation**](Acpv1instructionsRecurringPaymentInformation.md) |  | [optional] 
**EffectiveUntilTime** | **string** | UTC time in Unix epoch format. | 
**Quantity** | **string** | Quantity of the product. | [optional] 
**Description** | **string** | Description of the product. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

