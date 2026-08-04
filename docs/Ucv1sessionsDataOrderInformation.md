# CyberSource.Model.Ucv1sessionsDataOrderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountDetails** | [**Ucv1sessionsDataOrderInformationAmountDetails**](Ucv1sessionsDataOrderInformationAmountDetails.md) |  | [optional] 
**BillTo** | [**Ucv1sessionsDataOrderInformationBillTo**](Ucv1sessionsDataOrderInformationBillTo.md) |  | [optional] 
**ShipTo** | [**Ucv1sessionsDataOrderInformationShipTo**](Ucv1sessionsDataOrderInformationShipTo.md) |  | [optional] 
**LineItems** | [**List&lt;Ucv1sessionsDataOrderInformationLineItems&gt;**](Ucv1sessionsDataOrderInformationLineItems.md) |  | [optional] 
**InvoiceDetails** | [**Ucv1sessionsDataOrderInformationInvoiceDetails**](Ucv1sessionsDataOrderInformationInvoiceDetails.md) |  | [optional] 
**ShippingDetails** | [**Ucv1sessionsDataOrderInformationShippingDetails**](Ucv1sessionsDataOrderInformationShippingDetails.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

