# CyberSource.Model.AgenticUpdatePurchaseIntentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientCorrelationId** | **string** | Client Correlation Id used during the tokenization or during FIDO assertion. | 
**PaymentInformation** | [**Acpv1tokensPaymentInformation**](Acpv1tokensPaymentInformation.md) |  | 
**DeviceInformation** | [**Acpv1tokensDeviceInformation**](Acpv1tokensDeviceInformation.md) |  | 
**AssuranceData** | [**List&lt;Acpv1tokensAssuranceData&gt;**](Acpv1tokensAssuranceData.md) | Assurance data. | 
**Mandates** | [**List&lt;Acpv1instructionsMandates&gt;**](Acpv1instructionsMandates.md) |  | 
**BuyerInformation** | [**Acpv1tokensBuyerInformation**](Acpv1tokensBuyerInformation.md) |  | [optional] 
**ConsumerPrompt** | **string** | Recap - A summary or condensed version of user prompts that leads to the purchase. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

