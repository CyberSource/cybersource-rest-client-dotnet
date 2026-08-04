# CyberSource.Model.InlineResponse20113FulfillmentAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Full name of the recipient. | 
**LineOne** | **string** | Street address line 1. | 
**LineTwo** | **string** | Street address line 2 (apartment, suite). Optional. | [optional] 
**City** | **string** | City or town. | 
**State** | **string** | State or province code per ISO 3166-1. | 
**Country** | **string** | Country code per ISO 3166-1. | 
**PostalCode** | **string** | ZIP or postal code. | 
**PhoneNumber** | **string** | Optional. Contact phone number in E.164 format. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

