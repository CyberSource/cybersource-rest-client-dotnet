# CyberSource.Model.CapturePaymentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Ptsv2paymentsClientReferenceInformation**](Ptsv2paymentsClientReferenceInformation.md) |  | [optional] 
**ProcessingInformation** | [**Ptsv2paymentsidcapturesProcessingInformation**](Ptsv2paymentsidcapturesProcessingInformation.md) |  | [optional] 
**PaymentInformation** | [**Ptsv2paymentsidcapturesPaymentInformation**](Ptsv2paymentsidcapturesPaymentInformation.md) |  | [optional] 
**OrderInformation** | [**Ptsv2paymentsidcapturesOrderInformation**](Ptsv2paymentsidcapturesOrderInformation.md) |  | [optional] 
**BuyerInformation** | [**Ptsv2paymentsidcapturesBuyerInformation**](Ptsv2paymentsidcapturesBuyerInformation.md) |  | [optional] 
**DeviceInformation** | [**Ptsv2paymentsidcapturesDeviceInformation**](Ptsv2paymentsidcapturesDeviceInformation.md) |  | [optional] 
**MerchantInformation** | [**Ptsv2paymentsidcapturesMerchantInformation**](Ptsv2paymentsidcapturesMerchantInformation.md) |  | [optional] 
**AggregatorInformation** | [**Ptsv2paymentsidcapturesAggregatorInformation**](Ptsv2paymentsidcapturesAggregatorInformation.md) |  | [optional] 
**PointOfSaleInformation** | [**Ptsv2paymentsidcapturesPointOfSaleInformation**](Ptsv2paymentsidcapturesPointOfSaleInformation.md) |  | [optional] 
**MerchantDefinedInformation** | [**List&lt;Ptsv2paymentsMerchantDefinedInformation&gt;**](Ptsv2paymentsMerchantDefinedInformation.md) | The object containing the custom data that the merchant defines.  | [optional] 
**MerchantDefinedSecureInformation** | [**Ptsv2paymentsMerchantDefinedSecureInformation**](Ptsv2paymentsMerchantDefinedSecureInformation.md) |  | [optional] 
**InstallmentInformation** | [**Ptsv2paymentsidcapturesInstallmentInformation**](Ptsv2paymentsidcapturesInstallmentInformation.md) |  | [optional] 
**TravelInformation** | [**Ptsv2paymentsTravelInformation**](Ptsv2paymentsTravelInformation.md) |  | [optional] 
**PromotionInformation** | [**Ptsv2paymentsPromotionInformation**](Ptsv2paymentsPromotionInformation.md) |  | [optional] 
**ProcessorInformation** | [**Ptsv2paymentsidcapturesProcessorInformation**](Ptsv2paymentsidcapturesProcessorInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

