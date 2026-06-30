# CyberSource.Model.PaymentInstrument
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**DefaultPaymentInstrumentLinks**](DefaultPaymentInstrumentLinks.md) |  | [optional] 
**Id** | **string** | The Id of the Payment Instrument Token. | [optional] 
**Object** | **string** | The type.  Possible Values: - paymentInstrument  | [optional] 
**Default** | **bool?** | Flag that indicates whether customer payment instrument is the dafault. Possible Values:  - &#x60;true&#x60;: Payment instrument is customer&#39;s default.  - &#x60;false&#x60;: Payment instrument is not customer&#39;s default.  | [optional] 
**State** | **string** | Issuers state for the card number. Possible Values: - ACTIVE - CLOSED : The account has been closed.  | [optional] 
**Type** | **string** | The type of Payment Instrument. Possible Values: - cardHash  | [optional] 
**BankAccount** | [**DefaultPaymentInstrumentBankAccount**](DefaultPaymentInstrumentBankAccount.md) |  | [optional] 
**Card** | [**DefaultPaymentInstrumentCard**](DefaultPaymentInstrumentCard.md) |  | [optional] 
**BuyerInformation** | [**DefaultPaymentInstrumentBuyerInformation**](DefaultPaymentInstrumentBuyerInformation.md) |  | [optional] 
**BillTo** | [**DefaultPaymentInstrumentBillTo**](DefaultPaymentInstrumentBillTo.md) |  | [optional] 
**ProcessingInformation** | [**TmsPaymentInstrumentProcessingInfo**](TmsPaymentInstrumentProcessingInfo.md) |  | [optional] 
**MerchantInformation** | [**TmsMerchantInformation**](TmsMerchantInformation.md) |  | [optional] 
**InstrumentIdentifier** | [**DefaultPaymentInstrumentInstrumentIdentifier**](DefaultPaymentInstrumentInstrumentIdentifier.md) |  | [optional] 
**Metadata** | [**DefaultPaymentInstrumentMetadata**](DefaultPaymentInstrumentMetadata.md) |  | [optional] 
**Embedded** | [**PaymentInstrumentListEmbeddedEmbedded**](PaymentInstrumentListEmbeddedEmbedded.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

