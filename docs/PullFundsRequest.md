# CyberSource.Model.PullFundsRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Ptsv1pullfundstransferClientReferenceInformation**](Ptsv1pullfundstransferClientReferenceInformation.md) |  | [optional] 
**OrderInformation** | [**Ptsv1pullfundstransferOrderInformation**](Ptsv1pullfundstransferOrderInformation.md) |  | [optional] 
**ProcessingInformation** | [**Ptsv1pullfundstransferProcessingInformation**](Ptsv1pullfundstransferProcessingInformation.md) |  | [optional] 
**RecipientInformation** | [**Ptsv1pullfundstransferRecipientInformation**](Ptsv1pullfundstransferRecipientInformation.md) |  | [optional] 
**SenderInformation** | [**Ptsv1pullfundstransferSenderInformation**](Ptsv1pullfundstransferSenderInformation.md) |  | [optional] 
**BuyerInformation** | [**Ptsv1pullfundstransferBuyerInformation**](Ptsv1pullfundstransferBuyerInformation.md) |  | [optional] 
**AggregatorInformation** | [**Ptsv1pullfundstransferAggregatorInformation**](Ptsv1pullfundstransferAggregatorInformation.md) |  | [optional] 
**MerchantInformation** | [**Ptsv1pullfundstransferMerchantInformation**](Ptsv1pullfundstransferMerchantInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

