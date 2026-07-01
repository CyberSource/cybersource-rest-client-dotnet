# CyberSource.Model.AgenticCreatePurchaseIntentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientCorrelationId** | **string** | Client Correlation Id used during the tokenization or during FIDO assertion. | 
**PaymentInformation** | [**Iccv1tokensPaymentInformation**](Iccv1tokensPaymentInformation.md) |  | 
**DeviceInformation** | [**Iccv1tokensDeviceInformation**](Iccv1tokensDeviceInformation.md) |  | 
**AssuranceData** | [**List&lt;Iccv1tokensAssuranceData&gt;**](Iccv1tokensAssuranceData.md) | Assurance data. | 
**Mandates** | [**List&lt;Iccv1instructionsMandates&gt;**](Iccv1instructionsMandates.md) | Mandate data. | 
**BuyerInformation** | [**Iccv1tokensBuyerInformation**](Iccv1tokensBuyerInformation.md) |  | [optional] 
**IsRecurring** | **bool?** | Indicates whether the transaction is recurring. Default value is false. | [optional] 
**ConsumerPrompt** | **string** | Recap - A summary or condensed version of user prompts that leads to the purchase. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

