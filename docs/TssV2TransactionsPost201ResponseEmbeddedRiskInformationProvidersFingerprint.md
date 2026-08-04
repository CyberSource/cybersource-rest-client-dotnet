# CyberSource.Model.TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TrueIpaddress** | **string** | Customer&#39;s true IP address detected by the application.  For details, see the &#x60;true_ipaddress&#x60; field description in _Device Fingerprinting Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Device Fingerprinting Guide_ (PDF link).  | [optional] 
**Hash** | **string** | The unique identifier of the device that is returned in the &#x60;riskInformation.providers.fingerprint.device_fingerprint_hash&#x60; API reply field. For more details about this field, see the &#x60;device_fingerprint_hash&#x60; field description in the _Device Fingerprinting Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Device Fingerprinting Guide_ (PDF link).  | [optional] 
**SmartId** | **string** | The device identifier generated from attributes collected during profiling. Returned by a 3rd party when you use device fingerprinting.  For details, see the &#x60;device_fingerprint_smart_id&#x60; field description in [CyberSource Decision Manager Device Fingerprinting Guide.](https://www.cybersource.com/developers/documentation/fraud_management)  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

