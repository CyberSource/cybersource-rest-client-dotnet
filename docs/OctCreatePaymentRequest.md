# CyberSource.Model.OctCreatePaymentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Ptsv2payoutsClientReferenceInformation**](Ptsv2payoutsClientReferenceInformation.md) |  | [optional] 
**OrderInformation** | [**Ptsv2payoutsOrderInformation**](Ptsv2payoutsOrderInformation.md) |  | [optional] 
**MerchantInformation** | [**Ptsv2payoutsMerchantInformation**](Ptsv2payoutsMerchantInformation.md) |  | [optional] 
**RecipientInformation** | [**Ptsv2payoutsRecipientInformation**](Ptsv2payoutsRecipientInformation.md) |  | [optional] 
**SenderInformation** | [**Ptsv2payoutsSenderInformation**](Ptsv2payoutsSenderInformation.md) |  | [optional] 
**ProcessingInformation** | [**Ptsv2payoutsProcessingInformation**](Ptsv2payoutsProcessingInformation.md) |  | [optional] 
**PaymentInformation** | [**Ptsv2payoutsPaymentInformation**](Ptsv2payoutsPaymentInformation.md) |  | [optional] 
**AggregatorInformation** | [**Ptsv2payoutsAggregatorInformation**](Ptsv2payoutsAggregatorInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

