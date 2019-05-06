# CyberSource.Model.TssV2TransactionsGet200ResponseProcessorInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Processor** | [**TssV2TransactionsGet200ResponseProcessorInformationProcessor**](TssV2TransactionsGet200ResponseProcessorInformationProcessor.md) |  | [optional] 
**TransactionId** | **string** | Network transaction identifier (TID). You can use this value to identify a specific transaction when you are discussing the transaction with your processor. Not all processors provide this value.  | [optional] 
**NetworkTransactionId** | **string** | The description for this field is not available. | [optional] 
**ResponseId** | **string** | The description for this field is not available. | [optional] 
**ProviderTransactionId** | **string** | The description for this field is not available. | [optional] 
**ApprovalCode** | **string** | Authorization code. Returned only when the processor returns this value.  | [optional] 
**ResponseCode** | **string** | For most processors, this is the error message sent directly from the bank. Returned only when the processor returns this value.  Important Do not use this field to evaluate the result of the authorization.  | [optional] 
**Avs** | [**PtsV2PaymentsPost201ResponseProcessorInformationAvs**](PtsV2PaymentsPost201ResponseProcessorInformationAvs.md) |  | [optional] 
**CardVerification** | [**Riskv1decisionsCardVerification**](Riskv1decisionsCardVerification.md) |  | [optional] 
**AchVerification** | [**PtsV2PaymentsPost201ResponseProcessorInformationAchVerification**](PtsV2PaymentsPost201ResponseProcessorInformationAchVerification.md) |  | [optional] 
**ElectronicVerificationResults** | [**TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults**](TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults.md) |  | [optional] 
**SystemTraceAuditNumber** | **string** | This field is returned only for **American Express Direct** and **CyberSource through VisaNet**.  **American Express Direct**  System trace audit number (STAN). This value identifies the transaction and is useful when investigating a chargeback dispute.  **CyberSource through VisaNet**  System trace number that must be printed on the customer’s receipt.  | [optional] 
**ResponseCodeSource** | **string** | Used by Visa only and contains the response source/reason code that identifies the source of the response decision.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

