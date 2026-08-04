# CyberSource.Model.InlineResponse4013
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**InlineResponse4013Links**](InlineResponse4013Links.md) |  | [optional] 
**Code** | **string** | Valid Values:   * FORBIDDEN_RESPONSE   * VALIDATION_ERROR   * UNSUPPORTED_MEDIA_TYPE   * MALFORMED_PAYLOAD_ERROR   * SERVER_ERROR  | [optional] 
**CorrelationId** | **string** |  | [optional] 
**Detail** | **string** |  | [optional] 
**Fields** | [**List&lt;InlineResponse4013Fields&gt;**](InlineResponse4013Fields.md) |  | [optional] 
**LocalizationKey** | **string** | Valid Values:   * cybsapi.forbidden.response   * cybsapi.validation.error   * cybsapi.media.notsupported  | [optional] 
**Message** | **string** |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

