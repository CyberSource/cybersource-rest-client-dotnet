# CyberSource.Model.Ptsv2paymentreferencesOrderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillTo** | [**Ptsv2paymentreferencesOrderInformationBillTo**](Ptsv2paymentreferencesOrderInformationBillTo.md) |  | [optional] 
**ShipTo** | [**Ptsv2paymentreferencesOrderInformationShipTo**](Ptsv2paymentreferencesOrderInformationShipTo.md) |  | [optional] 
**AmountDetails** | [**Ptsv2paymentreferencesOrderInformationAmountDetails**](Ptsv2paymentreferencesOrderInformationAmountDetails.md) |  | [optional] 
**LineItems** | [**List&lt;Ptsv2paymentreferencesOrderInformationLineItems&gt;**](Ptsv2paymentreferencesOrderInformationLineItems.md) |  | [optional] 
**InvoiceDetails** | [**Ptsv2paymentreferencesOrderInformationInvoiceDetails**](Ptsv2paymentreferencesOrderInformationInvoiceDetails.md) |  | [optional] 
**ShippingDetails** | [**PtsV2PaymentsOrderPost201ResponseOrderInformationShippingDetails**](PtsV2PaymentsOrderPost201ResponseOrderInformationShippingDetails.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

