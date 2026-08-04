# CyberSource.Model.ModifyBillingAgreement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgreementInformation** | [**Ptsv2billingagreementsidAgreementInformation**](Ptsv2billingagreementsidAgreementInformation.md) |  | [optional] 
**ClientReferenceInformation** | [**Ptsv2billingagreementsClientReferenceInformation**](Ptsv2billingagreementsClientReferenceInformation.md) |  | [optional] 
**AggregatorInformation** | [**Ptsv2billingagreementsAggregatorInformation**](Ptsv2billingagreementsAggregatorInformation.md) |  | [optional] 
**ConsumerAuthenticationInformation** | [**Ptsv2billingagreementsConsumerAuthenticationInformation**](Ptsv2billingagreementsConsumerAuthenticationInformation.md) |  | [optional] 
**DeviceInformation** | [**Ptsv2billingagreementsDeviceInformation**](Ptsv2billingagreementsDeviceInformation.md) |  | [optional] 
**InstallmentInformation** | [**Ptsv2billingagreementsInstallmentInformation**](Ptsv2billingagreementsInstallmentInformation.md) |  | [optional] 
**MerchantInformation** | [**Ptsv2billingagreementsMerchantInformation**](Ptsv2billingagreementsMerchantInformation.md) |  | [optional] 
**OrderInformation** | [**Ptsv2billingagreementsOrderInformation**](Ptsv2billingagreementsOrderInformation.md) |  | [optional] 
**PaymentInformation** | [**Ptsv2billingagreementsPaymentInformation**](Ptsv2billingagreementsPaymentInformation.md) |  | [optional] 
**ProcessingInformation** | [**Ptsv2billingagreementsidProcessingInformation**](Ptsv2billingagreementsidProcessingInformation.md) |  | [optional] 
**BuyerInformation** | [**Ptsv2billingagreementsidBuyerInformation**](Ptsv2billingagreementsidBuyerInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

