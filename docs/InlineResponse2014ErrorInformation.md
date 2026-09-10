# CyberSource.Model.InlineResponse2014ErrorInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Details** | [**List&lt;InlineResponse2014ErrorInformationDetails&gt;**](InlineResponse2014ErrorInformationDetails.md) |  | [optional] 
**Message** | **string** | The detail message related to the status and reason listed above.  | [optional] 
**Reason** | **string** | Possible reasons for the error.  Possible values: - &#x60;INVALID_DATA&#x60; - &#x60;SYSTEM_ERROR&#x60; - &#x60;NOT_FOUND&#x60; - &#x60;UNAUTHORIZED&#x60; - &#x60;SYSTEM_TIMEOUT&#x60; - &#x60;PROCESSOR_ERROR&#x60;  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

