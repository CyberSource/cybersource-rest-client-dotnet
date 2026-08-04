# CyberSource.Model.Iccv1tokensBillTo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | Consumer-provided first name. | [optional] 
**LastName** | **string** | Consumer-provided last name. | [optional] 
**FullName** | **string** | Consumer-provided full name. | [optional] 
**Email** | **string** | Consumer-provided email address. | [optional] 
**CountryCallingCode** | **string** | Phone number country code as defined by the International Telecommunication Union. | 
**PhoneNumber** | **string** | Phone number without country code. | 
**NumberIsVoiceOnly** | **bool?** | Indicates that the phone number provided is not capable of receiving text messages. | [optional] 
**Country** | **string** | Consumer-provided country code. ISO 3166-1 alpha-2 country code. | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

