# CyberSource.Model.Acpv1instructionsinstructionIdcredentialsTransactionData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Acpv1instructionsinstructionIdcredentialsClientReferenceInformation**](Acpv1instructionsinstructionIdcredentialsClientReferenceInformation.md) |  | 
**MandateReferenceData** | [**List&lt;Acpv1instructionsinstructionIdcredentialsMandateReferenceData&gt;**](Acpv1instructionsinstructionIdcredentialsMandateReferenceData.md) | Mandate Reference Data. | [optional] 
**Type** | **string** | (Conditional) Type of the transaction. This field is used to determine the type of transaction and the associated processing rules.   Possible values:     - &#x60;PURCHASE&#x60; (Default)   - &#x60;BILL_PAYMENT&#x60;   - &#x60;MONEY_TRANSFER&#x60;   - &#x60;DISBURSEMENT&#x60;   - &#x60;P2P&#x60;  | [optional] 
**OrderInformation** | [**Acpv1instructionsinstructionIdcredentialsOrderInformation**](Acpv1instructionsinstructionIdcredentialsOrderInformation.md) |  | 
**PaymentServiceProviderUrl** | **string** | (Conditional) URL of the payment service provider. | [optional] 
**PaymentServiceProviderName** | **string** | (Conditional) Name of the payment service provider. | [optional] 
**MerchantOrderId** | **string** | (Conditional) Digital Payment Application generated order/invoice number corresponding to a Consumer purchase. | [optional] 
**MerchantInformation** | [**Acpv1instructionsinstructionIdcredentialsMerchantInformation**](Acpv1instructionsinstructionIdcredentialsMerchantInformation.md) |  | 
**PaymentOptions** | [**Acpv1instructionsinstructionIdcredentialsPaymentOptions**](Acpv1instructionsinstructionIdcredentialsPaymentOptions.md) |  | [optional] 
**Attachments** | [**List&lt;Acpv1instructionsinstructionIdcredentialsAttachments&gt;**](Acpv1instructionsinstructionIdcredentialsAttachments.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

