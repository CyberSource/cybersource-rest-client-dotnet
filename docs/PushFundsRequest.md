# CyberSource.Model.PushFundsRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AggregatorInformation** | [**Ptsv2payoutsAggregatorInformation**](Ptsv2payoutsAggregatorInformation.md) |  | [optional] 
**ClientReferenceInformation** | [**Ptsv1pushfundstransferClientReferenceInformation**](Ptsv1pushfundstransferClientReferenceInformation.md) |  | [optional] 
**OrderInformation** | [**Ptsv1pushfundstransferOrderInformation**](Ptsv1pushfundstransferOrderInformation.md) |  | 
**ProcessingInformation** | [**Ptsv1pushfundstransferProcessingInformation**](Ptsv1pushfundstransferProcessingInformation.md) |  | [optional] 
**RecipientInformation** | [**Ptsv1pushfundstransferRecipientInformation**](Ptsv1pushfundstransferRecipientInformation.md) |  | [optional] 
**SenderInformation** | [**Ptsv1pushfundstransferSenderInformation**](Ptsv1pushfundstransferSenderInformation.md) |  | [optional] 
**MerchantInformation** | [**Ptsv1pushfundstransferMerchantInformation**](Ptsv1pushfundstransferMerchantInformation.md) |  | [optional] 
**PaymentInformation** | [**Ptsv1pushfundstransferPaymentInformation**](Ptsv1pushfundstransferPaymentInformation.md) |  | [optional] 
**PointOfServiceInformation** | [**Ptsv1pushfundstransferPointOfServiceInformation**](Ptsv1pushfundstransferPointOfServiceInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

