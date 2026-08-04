# CyberSource.Model.InlineResponse40014
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubmitTimeUtc** | **string** | Time verification was requested  Format: &#x60;YYYY-MM-DDThhmmssZ&#x60;, where: - &#x60;T&#x60;:  Separates the date and the time - &#x60;Z&#x60;:  Indicates Coordinated Universal Time (UTC), also known as Greenwich Mean Time (GMT)  Example:  &#x60;2020-01-11T224757Z&#x60; equals January 11, 2020, at 22:47:57 (10:47:57 p.m.)  | [optional] 
**Status** | **string** | Possible values:   - &#x60;INVALID_REQUEST&#x60;  | [optional] 
**Message** | **string** | The detail message related to the status and reason | [optional] 
**Reason** | **string** | The reason of the status.  Possible values:   - &#x60;INVALID_REQUEST&#x60;  | [optional] 
**Details** | [**List&lt;InlineResponse40014Details&gt;**](InlineResponse40014Details.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

