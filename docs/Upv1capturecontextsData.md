# CyberSource.Model.Upv1capturecontextsData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderInformation** | [**Upv1capturecontextsDataOrderInformation**](Upv1capturecontextsDataOrderInformation.md) |  | [optional] 
**BuyerInformation** | [**Upv1capturecontextsDataBuyerInformation**](Upv1capturecontextsDataBuyerInformation.md) |  | [optional] 
**ClientReferenceInformation** | [**Upv1capturecontextsDataClientReferenceInformation**](Upv1capturecontextsDataClientReferenceInformation.md) |  | [optional] 
**ConsumerAuthenticationInformation** | [**Upv1capturecontextsDataConsumerAuthenticationInformation**](Upv1capturecontextsDataConsumerAuthenticationInformation.md) |  | [optional] 
**MerchantInformation** | [**Upv1capturecontextsDataMerchantInformation**](Upv1capturecontextsDataMerchantInformation.md) |  | [optional] 
**ProcessingInformation** | [**Upv1capturecontextsDataProcessingInformation**](Upv1capturecontextsDataProcessingInformation.md) |  | [optional] 
**RecipientInformation** | [**Upv1capturecontextsDataRecipientInformation**](Upv1capturecontextsDataRecipientInformation.md) |  | [optional] 
**MerchantDefinedInformation** | [**List&lt;Upv1capturecontextsDataMerchantDefinedInformation&gt;**](Upv1capturecontextsDataMerchantDefinedInformation.md) |  | [optional] 
**DeviceInformation** | [**Upv1capturecontextsDataDeviceInformation**](Upv1capturecontextsDataDeviceInformation.md) |  | [optional] 
**PaymentInformation** | [**Upv1capturecontextsDataPaymentInformation**](Upv1capturecontextsDataPaymentInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

