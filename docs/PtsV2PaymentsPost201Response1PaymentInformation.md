# CyberSource.Model.PtsV2PaymentsPost201Response1PaymentInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentType** | [**PtsV2PaymentsPost201Response1PaymentInformationPaymentType**](PtsV2PaymentsPost201Response1PaymentInformationPaymentType.md) |  | [optional] 
**EWallet** | [**PtsV2PaymentsPost201Response1PaymentInformationEWallet**](PtsV2PaymentsPost201Response1PaymentInformationEWallet.md) |  | [optional] 
**Customer** | [**Ptsv2refreshpaymentstatusidPaymentInformationCustomer**](Ptsv2refreshpaymentstatusidPaymentInformationCustomer.md) |  | [optional] 
**Bank** | [**PtsV2PaymentsPost201Response1PaymentInformationBank**](PtsV2PaymentsPost201Response1PaymentInformationBank.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

