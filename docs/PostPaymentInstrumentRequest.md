# CyberSource.Model.PostPaymentInstrumentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**Tmsv2customersEmbeddedDefaultPaymentInstrumentLinks**](Tmsv2customersEmbeddedDefaultPaymentInstrumentLinks.md) |  | [optional] 
**Id** | **string** | The Id of the Payment Instrument Token. | [optional] 
**Object** | **string** | The type.  Possible Values: - paymentInstrument  | [optional] 
**Default** | **bool?** | Flag that indicates whether customer payment instrument is the dafault. Possible Values:  - &#x60;true&#x60;: Payment instrument is customer&#39;s default.  - &#x60;false&#x60;: Payment instrument is not customer&#39;s default.  | [optional] 
**State** | **string** | Issuers state for the card number. Possible Values: - ACTIVE - CLOSED : The account has been closed.  | [optional] 
**Type** | **string** | The type of Payment Instrument. Possible Values: - cardHash  | [optional] 
**BankAccount** | [**Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount**](Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount.md) |  | [optional] 
**Card** | [**Tmsv2customersEmbeddedDefaultPaymentInstrumentCard**](Tmsv2customersEmbeddedDefaultPaymentInstrumentCard.md) |  | [optional] 
**BuyerInformation** | [**Tmsv2customersEmbeddedDefaultPaymentInstrumentBuyerInformation**](Tmsv2customersEmbeddedDefaultPaymentInstrumentBuyerInformation.md) |  | [optional] 
**BillTo** | [**Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo**](Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo.md) |  | [optional] 
**ProcessingInformation** | [**TmsPaymentInstrumentProcessingInfo**](TmsPaymentInstrumentProcessingInfo.md) |  | [optional] 
**MerchantInformation** | [**Tmsv2customersEmbeddedDefaultPaymentInstrumentMerchantInformation**](Tmsv2customersEmbeddedDefaultPaymentInstrumentMerchantInformation.md) |  | [optional] 
**InstrumentIdentifier** | [**Tmsv2customersEmbeddedDefaultPaymentInstrumentInstrumentIdentifier**](Tmsv2customersEmbeddedDefaultPaymentInstrumentInstrumentIdentifier.md) |  | [optional] 
**Metadata** | [**Tmsv2customersEmbeddedDefaultPaymentInstrumentMetadata**](Tmsv2customersEmbeddedDefaultPaymentInstrumentMetadata.md) |  | [optional] 
**Embedded** | [**Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbedded**](Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbedded.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

