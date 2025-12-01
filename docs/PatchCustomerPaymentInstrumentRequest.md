# CyberSource.Model.PatchCustomerPaymentInstrumentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentLinks**](Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentLinks.md) |  | [optional] 
**Id** | **string** | The Id of the Payment Instrument Token. | [optional] 
**Object** | **string** | The type.  Possible Values: - paymentInstrument  | [optional] 
**Default** | **bool?** | Flag that indicates whether customer payment instrument is the dafault. Possible Values:  - &#x60;true&#x60;: Payment instrument is customer&#39;s default.  - &#x60;false&#x60;: Payment instrument is not customer&#39;s default.  | [optional] 
**State** | **string** | Issuers state for the card number. Possible Values: - ACTIVE - CLOSED : The account has been closed.  | [optional] 
**Type** | **string** | The type of Payment Instrument. Possible Values: - cardHash  | [optional] 
**BankAccount** | [**Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentBankAccount**](Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentBankAccount.md) |  | [optional] 
**Card** | [**Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentCard**](Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentCard.md) |  | [optional] 
**BuyerInformation** | [**Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentBuyerInformation**](Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentBuyerInformation.md) |  | [optional] 
**BillTo** | [**Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentBillTo**](Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentBillTo.md) |  | [optional] 
**ProcessingInformation** | [**TmsPaymentInstrumentProcessingInfo**](TmsPaymentInstrumentProcessingInfo.md) |  | [optional] 
**MerchantInformation** | [**TmsMerchantInformation**](TmsMerchantInformation.md) |  | [optional] 
**InstrumentIdentifier** | [**Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentInstrumentIdentifier**](Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentInstrumentIdentifier.md) |  | [optional] 
**Metadata** | [**Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentMetadata**](Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentMetadata.md) |  | [optional] 
**Embedded** | [**Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentEmbedded**](Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrumentEmbedded.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

