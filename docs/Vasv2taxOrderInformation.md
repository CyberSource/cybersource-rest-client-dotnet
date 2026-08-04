# CyberSource.Model.Vasv2taxOrderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountDetails** | [**RiskV1DecisionsPost201ResponseOrderInformationAmountDetails**](RiskV1DecisionsPost201ResponseOrderInformationAmountDetails.md) |  | [optional] 
**BillTo** | [**Vasv2taxOrderInformationBillTo**](Vasv2taxOrderInformationBillTo.md) |  | [optional] 
**ShippingDetails** | [**Vasv2taxOrderInformationShippingDetails**](Vasv2taxOrderInformationShippingDetails.md) |  | [optional] 
**ShipTo** | [**Vasv2taxOrderInformationShipTo**](Vasv2taxOrderInformationShipTo.md) |  | [optional] 
**LineItems** | [**List&lt;Vasv2taxOrderInformationLineItems&gt;**](Vasv2taxOrderInformationLineItems.md) |  | [optional] 
**InvoiceDetails** | [**Vasv2taxOrderInformationInvoiceDetails**](Vasv2taxOrderInformationInvoiceDetails.md) |  | [optional] 
**OrderAcceptance** | [**Vasv2taxOrderInformationOrderAcceptance**](Vasv2taxOrderInformationOrderAcceptance.md) |  | [optional] 
**OrderOrigin** | [**Vasv2taxOrderInformationOrderOrigin**](Vasv2taxOrderInformationOrderOrigin.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

