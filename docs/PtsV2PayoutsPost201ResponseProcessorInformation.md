# CyberSource.Model.PtsV2PayoutsPost201ResponseProcessorInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApprovalCode** | **string** | Issuer-generated approval code for the transaction. | [optional] 
**ResponseCode** | **string** | Transaction status from the processor. | [optional] 
**TransactionId** | **string** | Network transaction identifier (TID). This value can be used to identify a specific transaction when you are discussing the transaction with your processor.  | [optional] 
**SystemTraceAuditNumber** | **string** | This field is returned only for **American Express Direct** and **CyberSource through VisaNet**. Returned by authorization and incremental authorization services.  #### American Express Direct  System trace audit number (STAN). This value identifies the transaction and is useful when investigating a chargeback dispute.  #### CyberSource through VisaNet  System trace number that must be printed on the customer&#39;s receipt.  | [optional] 
**ResponseCodeSource** | **string** | Used by Visa only and contains the response source/reason code that identifies the source of the response decision.  | [optional] 
**MerchantAdvice** | [**PtsV2PaymentsRefundPost201ResponseProcessorInformationMerchantAdvice**](PtsV2PaymentsRefundPost201ResponseProcessorInformationMerchantAdvice.md) |  | [optional] 
**Avs** | [**PtsV2PayoutsPost201ResponseProcessorInformationAvs**](PtsV2PayoutsPost201ResponseProcessorInformationAvs.md) |  | [optional] 
**Customer** | [**PtsV2PayoutsPost201ResponseProcessorInformationCustomer**](PtsV2PayoutsPost201ResponseProcessorInformationCustomer.md) |  | [optional] 
**ElectronicVerificationResults** | [**PtsV2PayoutsPost201ResponseProcessorInformationElectronicVerificationResults**](PtsV2PayoutsPost201ResponseProcessorInformationElectronicVerificationResults.md) |  | [optional] 
**CardVerification** | [**PtsV2PaymentsPost201ResponseProcessorInformationCardVerification**](PtsV2PaymentsPost201ResponseProcessorInformationCardVerification.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

