# CyberSource.Model.MitReversalRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Ptsv2paymentsClientReferenceInformation**](Ptsv2paymentsClientReferenceInformation.md) |  | [optional] 
**ReversalInformation** | [**Ptsv2paymentsidreversalsReversalInformation**](Ptsv2paymentsidreversalsReversalInformation.md) |  | [optional] 
**ProcessingInformation** | [**Ptsv2paymentsidreversalsProcessingInformation**](Ptsv2paymentsidreversalsProcessingInformation.md) |  | [optional] 
**OrderInformation** | [**Ptsv2paymentsidreversalsOrderInformation**](Ptsv2paymentsidreversalsOrderInformation.md) |  | [optional] 
**PointOfSaleInformation** | [**Ptsv2paymentsidreversalsPointOfSaleInformation**](Ptsv2paymentsidreversalsPointOfSaleInformation.md) |  | [optional] 
**DeviceInformation** | [**Ptsv2paymentsidreversalsDeviceInformation**](Ptsv2paymentsidreversalsDeviceInformation.md) |  | [optional] 
**ProcessorInformation** | [**Ptsv2reversalsProcessorInformation**](Ptsv2reversalsProcessorInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

