# CyberSource.Model.Iccv1tokensBuyerInformationPersonalIdentification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of the identification | [optional] 
**Id** | **string** | The value of the identification type | [optional] 
**IssuedBy** | **string** | The government agency that issued the driver&#39;s license or passport.  If &#x60;**type** &#x3D; DRIVER_LICENSE&#x60;, this is the State or province where the customer&#39;s driver&#39;s license was issued.  If &#x60;**type** &#x3D; PASSPORT&#x60;, this is the Issuing country for the cardholder&#39;s passport.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

