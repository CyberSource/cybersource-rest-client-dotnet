# CyberSource.Model.Iccv1instructionsinstructionIdconfirmationsOrderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** | Unique identifier for the order | [optional] 
**OrderStatus** | **string** | Status of the order | [optional] 
**OrderDate** | **string** | Order date (UTC time in Epoch format) | [optional] 
**ExpectedDeliveryDate** | **string** | Expected delivery date for the order (UTC time in Epoch format) | [optional] 
**AmountDetail** | [**IccAmountDetail**](IccAmountDetail.md) |  | [optional] 
**ShipTo** | [**Iccv1instructionsinstructionIdcredentialsOrderInformationShipTo**](Iccv1instructionsinstructionIdcredentialsOrderInformationShipTo.md) |  | [optional] 
**ShippingDetails** | [**IccShippingDetails**](IccShippingDetails.md) |  | [optional] 
**TrackingId** | **string** | Tracking ID for the shipment | [optional] 
**Carrier** | **string** | Shipping carrier or provider | [optional] 
**LineItems** | [**List&lt;Iccv1instructionsinstructionIdcredentialsOrderInformationLineItems&gt;**](Iccv1instructionsinstructionIdcredentialsOrderInformationLineItems.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

