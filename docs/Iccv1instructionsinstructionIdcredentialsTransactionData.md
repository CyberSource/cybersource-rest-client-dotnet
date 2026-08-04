# CyberSource.Model.Iccv1instructionsinstructionIdcredentialsTransactionData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Iccv1instructionsinstructionIdcredentialsClientReferenceInformation**](Iccv1instructionsinstructionIdcredentialsClientReferenceInformation.md) |  | 
**MandateReferenceData** | [**List&lt;Iccv1instructionsinstructionIdcredentialsMandateReferenceData&gt;**](Iccv1instructionsinstructionIdcredentialsMandateReferenceData.md) | Mandate Reference Data. | [optional] 
**Type** | **string** | (Conditional) Type of the transaction. This field is used to determine the type of transaction and the associated processing rules.   Possible values:     - &#x60;PURCHASE&#x60; (Default)   - &#x60;BILL_PAYMENT&#x60;   - &#x60;MONEY_TRANSFER&#x60;   - &#x60;DISBURSEMENT&#x60;   - &#x60;P2P&#x60;  | [optional] 
**OrderInformation** | [**Iccv1instructionsinstructionIdcredentialsOrderInformation**](Iccv1instructionsinstructionIdcredentialsOrderInformation.md) |  | 
**PaymentServiceProviderUrl** | **string** | (Conditional) URL of the payment service provider. | [optional] 
**PaymentServiceProviderName** | **string** | (Conditional) Name of the payment service provider. | [optional] 
**MerchantOrderId** | **string** | (Conditional) Digital Payment Application generated order/invoice number corresponding to a Consumer purchase. | [optional] 
**MerchantInformation** | [**Iccv1instructionsinstructionIdcredentialsMerchantInformation**](Iccv1instructionsinstructionIdcredentialsMerchantInformation.md) |  | 
**PaymentOptions** | [**Iccv1instructionsinstructionIdcredentialsPaymentOptions**](Iccv1instructionsinstructionIdcredentialsPaymentOptions.md) |  | [optional] 
**Attachments** | [**List&lt;Iccv1instructionsinstructionIdcredentialsAttachments&gt;**](Iccv1instructionsinstructionIdcredentialsAttachments.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

