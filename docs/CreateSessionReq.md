# CyberSource.Model.CreateSessionReq
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Ptsv2refreshpaymentstatusidClientReferenceInformation**](Ptsv2refreshpaymentstatusidClientReferenceInformation.md) |  | [optional] 
**ProcessingInformation** | [**Ptsv2paymentreferencesProcessingInformation**](Ptsv2paymentreferencesProcessingInformation.md) |  | [optional] 
**PaymentInformation** | [**Ptsv2paymentreferencesPaymentInformation**](Ptsv2paymentreferencesPaymentInformation.md) |  | [optional] 
**OrderInformation** | [**Ptsv2paymentreferencesOrderInformation**](Ptsv2paymentreferencesOrderInformation.md) |  | [optional] 
**OrderHistory** | [**List&lt;Ptsv2paymentsOrderHistory&gt;**](Ptsv2paymentsOrderHistory.md) | Array of the buyer&#39;s previous orders.  | [optional] 
**BuyerInformation** | [**Ptsv2paymentreferencesBuyerInformation**](Ptsv2paymentreferencesBuyerInformation.md) |  | [optional] 
**DeviceInformation** | [**Ptsv2paymentreferencesDeviceInformation**](Ptsv2paymentreferencesDeviceInformation.md) |  | [optional] 
**MerchantInformation** | [**Ptsv2paymentreferencesMerchantInformation**](Ptsv2paymentreferencesMerchantInformation.md) |  | [optional] 
**UserInterface** | [**Ptsv2paymentreferencesUserInterface**](Ptsv2paymentreferencesUserInterface.md) |  | [optional] 
**MerchantDefinedInformation** | [**List&lt;Ptsv2paymentsMerchantDefinedInformation&gt;**](Ptsv2paymentsMerchantDefinedInformation.md) | The object containing the custom data that the merchant defines.  | [optional] 
**AgreementInformation** | [**Ptsv2paymentreferencesAgreementInformation**](Ptsv2paymentreferencesAgreementInformation.md) |  | [optional] 
**TravelInformation** | [**Ptsv2paymentreferencesTravelInformation**](Ptsv2paymentreferencesTravelInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

