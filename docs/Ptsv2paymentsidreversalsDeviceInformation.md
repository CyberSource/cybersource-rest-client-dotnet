# CyberSource.Model.Ptsv2paymentsidreversalsDeviceInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceType** | **string** | Account Entry Device Type for Tap to More transactions. This field flows in ISO Field 34 DSID 02 Tag 89.  Valid Values: - &#x60;1&#x60;: Off-the-shelf mobile consumer  Mastercard is introducing changes to support commercialization of Tap to More transactions.  Acquirers globally must be prepared to send a value of 1 (Off-the-shelf mobile-consumer)  in Field 34—Acceptance Environment Data (TLV Format), Dataset ID 02—Acceptance Environment  Additional Data, Tag 89—Account Entry Device Type for Tap to More transactions. Visa will  map this value to a value of 8 (Remote terminal) in Mastercard Data Element 61.10.  #### Mapping - SCMP API Field: customer_device_type - Simple Order API Field: billTo_deviceType - CCS: device.type - NRTF Key: customer_device_type  Optional field.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

