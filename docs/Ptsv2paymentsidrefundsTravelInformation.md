# CyberSource.Model.Ptsv2paymentsidrefundsTravelInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Duration** | **string** | Duration of the auto rental or lodging rental.  #### Auto rental This field is supported for Visa, MasterCard, and American Express. **Important** If this field is not included when the &#x60;processingInformation.industryDataType&#x60; is auto rental, the transaction is declined.  | [optional] 
**Agency** | [**Ptsv2paymentsTravelInformationAgency**](Ptsv2paymentsTravelInformationAgency.md) |  | [optional] 
**AutoRental** | [**Ptsv2paymentsTravelInformationAutoRental**](Ptsv2paymentsTravelInformationAutoRental.md) |  | [optional] 
**Lodging** | [**Ptsv2paymentsTravelInformationLodging**](Ptsv2paymentsTravelInformationLodging.md) |  | [optional] 
**Transit** | [**Ptsv2paymentsidrefundsTravelInformationTransit**](Ptsv2paymentsidrefundsTravelInformationTransit.md) |  | [optional] 
**VehicleData** | [**Ptsv2paymentsTravelInformationVehicleData**](Ptsv2paymentsTravelInformationVehicleData.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

