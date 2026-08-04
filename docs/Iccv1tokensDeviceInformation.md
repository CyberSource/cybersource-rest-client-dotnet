# CyberSource.Model.Iccv1tokensDeviceInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserAgent** | **string** | Base64 Encoded userAgent string of the connecting client application, with no padding.   User agent string of the connecting client application.   Conditionality:   - Required for browsers - Optional for non-browsers  | [optional] 
**ApplicationName** | **string** | Name of the connecting client application. | 
**FingerprintSessionId** | **string** | Device Fingerprinting Session identifier. | 
**Country** | **string** | ISO 3166-1 alpha-2 country code. The country where the Consumer is accessing the service from. | [optional] 
**DeviceData** | [**Iccv1tokensDeviceInformationDeviceData**](Iccv1tokensDeviceInformationDeviceData.md) |  | 
**IpAddress** | **string** | IP address of the consumer&#39;s device. | 
**ClientDeviceId** | **string** | Unique identifier of the consumer&#39;s device. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

