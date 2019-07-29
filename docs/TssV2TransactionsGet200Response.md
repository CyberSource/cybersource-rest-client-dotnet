# CyberSource.Model.TssV2TransactionsGet200Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | An unique identification number assigned by CyberSource to identify the submitted request. It is also appended to the endpoint of the resource. | [optional] 
**RootId** | **string** | Payment Request Id | [optional] 
**ReconciliationId** | **string** | The reconciliation id for the submitted transaction. This value is not returned for all processors.  | [optional] 
**MerchantId** | **string** | Your CyberSource merchant ID. | [optional] 
**Status** | **string** | The status of the submitted transaction. | [optional] 
**SubmitTimeUTC** | **string** | Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; Example &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  | [optional] 
**ApplicationInformation** | [**TssV2TransactionsGet200ResponseApplicationInformation**](TssV2TransactionsGet200ResponseApplicationInformation.md) |  | [optional] 
**BuyerInformation** | [**TssV2TransactionsGet200ResponseBuyerInformation**](TssV2TransactionsGet200ResponseBuyerInformation.md) |  | [optional] 
**ClientReferenceInformation** | [**TssV2TransactionsGet200ResponseClientReferenceInformation**](TssV2TransactionsGet200ResponseClientReferenceInformation.md) |  | [optional] 
**ConsumerAuthenticationInformation** | [**TssV2TransactionsGet200ResponseConsumerAuthenticationInformation**](TssV2TransactionsGet200ResponseConsumerAuthenticationInformation.md) |  | [optional] 
**DeviceInformation** | [**TssV2TransactionsGet200ResponseDeviceInformation**](TssV2TransactionsGet200ResponseDeviceInformation.md) |  | [optional] 
**ErrorInformation** | [**TssV2TransactionsGet200ResponseErrorInformation**](TssV2TransactionsGet200ResponseErrorInformation.md) |  | [optional] 
**InstallmentInformation** | [**TssV2TransactionsGet200ResponseInstallmentInformation**](TssV2TransactionsGet200ResponseInstallmentInformation.md) |  | [optional] 
**FraudMarkingInformation** | [**TssV2TransactionsGet200ResponseFraudMarkingInformation**](TssV2TransactionsGet200ResponseFraudMarkingInformation.md) |  | [optional] 
**MerchantDefinedInformation** | [**List&lt;Ptsv2paymentsMerchantDefinedInformation&gt;**](Ptsv2paymentsMerchantDefinedInformation.md) | The object containing the custom data that the merchant defines.  | [optional] 
**MerchantInformation** | [**TssV2TransactionsGet200ResponseMerchantInformation**](TssV2TransactionsGet200ResponseMerchantInformation.md) |  | [optional] 
**OrderInformation** | [**TssV2TransactionsGet200ResponseOrderInformation**](TssV2TransactionsGet200ResponseOrderInformation.md) |  | [optional] 
**PaymentInformation** | [**TssV2TransactionsGet200ResponsePaymentInformation**](TssV2TransactionsGet200ResponsePaymentInformation.md) |  | [optional] 
**ProcessingInformation** | [**TssV2TransactionsGet200ResponseProcessingInformation**](TssV2TransactionsGet200ResponseProcessingInformation.md) |  | [optional] 
**ProcessorInformation** | [**TssV2TransactionsGet200ResponseProcessorInformation**](TssV2TransactionsGet200ResponseProcessorInformation.md) |  | [optional] 
**PointOfSaleInformation** | [**TssV2TransactionsGet200ResponsePointOfSaleInformation**](TssV2TransactionsGet200ResponsePointOfSaleInformation.md) |  | [optional] 
**RiskInformation** | [**TssV2TransactionsGet200ResponseRiskInformation**](TssV2TransactionsGet200ResponseRiskInformation.md) |  | [optional] 
**SenderInformation** | [**TssV2TransactionsGet200ResponseSenderInformation**](TssV2TransactionsGet200ResponseSenderInformation.md) |  | [optional] 
**Links** | [**TssV2TransactionsGet200ResponseLinks**](TssV2TransactionsGet200ResponseLinks.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

