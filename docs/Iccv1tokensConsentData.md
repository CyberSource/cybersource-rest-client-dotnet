# CyberSource.Model.Iccv1tokensConsentData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for the consent. | 
**Type** | **string** | Type of the consent.   Possible value:     - &#x60;PERSONALIZATION&#x60;  | 
**Source** | **string** | Source of the consent. | 
**AcceptedTime** | **string** | Date and time when the consent was accepted by the consumer. UTC time in Unix epoch format. | 
**EffectiveUntil** | **string** | Date and time until which the consent remains effective. UTC time in Unix epoch format. | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

