# CyberSource.Model.InlineResponse401
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identification number to identify the submitted request. It is also appended to the endpoint of the resource.  | [optional] 
**SubmitTimeStampUtc** | **string** | Time of request in UTC. Format: &#x60;YYYY-MM-DD&#39;T&#39;HH:mm:ssZ&#x60;  Example: &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC.  | [optional] 
**Reason** | **string** | The reason of the status.  Possible values: - UNAUTHORIZED  | [optional] 
**Message** | **string** | The detail message related to the status and reason listed above.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

