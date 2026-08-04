# CyberSource.Model.InlineResponse2018KeyInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | Provider name  | [optional] 
**Tenant** | **string** | Tenant name  | [optional] 
**OrganizationId** | **string** | Organization Id  | [optional] 
**ClientKeyId** | **string** | Client key Id  | [optional] 
**KeyId** | **string** | Key Serial Number  | [optional] 
**Key** | **string** | Value of the key  | [optional] 
**KeyType** | **string** | Type of the key  | [optional] 
**Status** | **string** | The status of the key  | [optional] 
**ExpirationDate** | **string** | The expiration time in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60; Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC.  | [optional] 
**Message** | **string** | Message in case of failed key  | [optional] 
**ErrorInformation** | [**InlineResponse2018KeyInformationErrorInformation**](InlineResponse2018KeyInformationErrorInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

