# CyberSource.Model.PullFundsReversal201ResponseProcessorInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SystemTraceAuditNumber** | **string** | This field is returned by authorization and incremental authorization services. System trace number that must be printed on the customer&#39;s receipt.  | [optional] 
**ApprovalCode** | **string** | Issuer-generated approval code for the transaction.  | [optional] 
**ResponseCode** | **string** | Transaction status from the processor.  | [optional] 
**TransactionId** | **string** | Network transaction identifier (TID). This value can be used to identify a specific transaction when you are discussing the transaction with your processor.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

