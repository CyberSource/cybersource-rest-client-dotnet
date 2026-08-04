# CyberSource.Model.CreateOrderRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Ptsv2intentsClientReferenceInformation**](Ptsv2intentsClientReferenceInformation.md) |  | [optional] 
**ProcessingInformation** | [**Ptsv2intentsProcessingInformation**](Ptsv2intentsProcessingInformation.md) |  | [optional] 
**MerchantInformation** | [**Ptsv2intentsMerchantInformation**](Ptsv2intentsMerchantInformation.md) |  | [optional] 
**PaymentInformation** | [**Ptsv2intentsPaymentInformation**](Ptsv2intentsPaymentInformation.md) |  | [optional] 
**OrderInformation** | [**Ptsv2intentsOrderInformation**](Ptsv2intentsOrderInformation.md) |  | [optional] 
**SenderInformation** | [**Ptsv2intentsSenderInformation**](Ptsv2intentsSenderInformation.md) |  | [optional] 
**EventInformation** | [**Ptsv2intentsEventInformation**](Ptsv2intentsEventInformation.md) |  | [optional] 
**TravelInformation** | [**Ptsv2intentsTravelInformation**](Ptsv2intentsTravelInformation.md) |  | [optional] 
**RecipientInformation** | [**Ptsv2intentsRecipientInformation**](Ptsv2intentsRecipientInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

