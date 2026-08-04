# CyberSource.Model.Iccv1tokensDeviceInformationDeviceData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of device being used.   Example values are:   - Mobile Phone - Tablet - Tablet - Laptop - Personal Assistant - Connected Auto - Home Appliance - Wearable - Stationary Computer - E-Reader - Handheld Gaming Devices - Other  | 
**Manufacturer** | **string** | Manufacturer of the device. | [optional] 
**Brand** | **string** | Brand name of the device. | 
**Model** | **string** | Specific model of the device. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

