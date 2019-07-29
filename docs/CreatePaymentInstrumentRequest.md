# CyberSource.Model.CreatePaymentInstrumentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**TmsV1InstrumentIdentifiersPost200ResponseLinks**](TmsV1InstrumentIdentifiersPost200ResponseLinks.md) |  | [optional] 
**Id** | **string** | Unique identification number assigned by CyberSource to the submitted request. | [optional] 
**_Object** | **string** | &#39;Describes type of token.&#39;  Valid values: - paymentInstrument  | [optional] 
**State** | **string** | &#39;Current state of the token.&#39;  Valid values: - ACTIVE - CLOSED  | [optional] 
**BankAccount** | [**TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedBankAccount**](TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedBankAccount.md) |  | [optional] 
**Card** | [**TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedCard**](TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedCard.md) |  | [optional] 
**BuyerInformation** | [**TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedBuyerInformation**](TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedBuyerInformation.md) |  | [optional] 
**BillTo** | [**TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedBillTo**](TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedBillTo.md) |  | [optional] 
**ProcessingInformation** | [**TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedProcessingInformation**](TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedProcessingInformation.md) |  | [optional] 
**MerchantInformation** | [**TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedMerchantInformation**](TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedMerchantInformation.md) |  | [optional] 
**MetaData** | [**TmsV1InstrumentIdentifiersPost200ResponseMetadata**](TmsV1InstrumentIdentifiersPost200ResponseMetadata.md) |  | [optional] 
**InstrumentIdentifier** | [**TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedInstrumentIdentifier**](TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedInstrumentIdentifier.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

