# CyberSource.Model.TssV2TransactionsGet200ResponseProcessorInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Processor** | [**TssV2TransactionsGet200ResponseProcessorInformationProcessor**](TssV2TransactionsGet200ResponseProcessorInformationProcessor.md) |  | [optional] 
**TransactionId** | **string** | Network transaction identifier (TID). You can use this value to identify a specific transaction when you are discussing the transaction with your processor. Not all processors provide this  value.  | [optional] 
**NetworkTransactionId** | **string** | The description for this field is not available. | [optional] 
**ResponseId** | **string** | The description for this field is not available. | [optional] 
**ProviderTransactionId** | **string** | The description for this field is not available. | [optional] 
**ApprovalCode** | **string** | Authorization code. Returned only when the processor returns this value.  | [optional] 
**ResponseCode** | **string** | For most processors, this is the error message sent directly from the bank. Returned only when the processor returns this value.  Important Do not use this field to evaluate the result of the authorization.  | [optional] 
**Avs** | [**PtsV2PaymentsPost201ResponseProcessorInformationAvs**](PtsV2PaymentsPost201ResponseProcessorInformationAvs.md) |  | [optional] 
**CardVerification** | [**TssV2TransactionsGet200ResponseProcessorInformationCardVerification**](TssV2TransactionsGet200ResponseProcessorInformationCardVerification.md) |  | [optional] 
**AchVerification** | [**TssV2TransactionsGet200ResponseProcessorInformationAchVerification**](TssV2TransactionsGet200ResponseProcessorInformationAchVerification.md) |  | [optional] 
**ElectronicVerificationResults** | [**TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults**](TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

