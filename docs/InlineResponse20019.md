# CyberSource.Model.InlineResponse20019
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobId** | **string** | Unique identifier of the feed submission job. | [optional] 
**Status** | **string** | Overall status of the feed job.  Possible values: - PENDING - PROCESSING - COMPLETED - FAILED | [optional] 
**Processing** | [**InlineResponse20019Processing**](InlineResponse20019Processing.md) |  | [optional] 
**Syndication** | [**Dictionary&lt;string, InlineResponse20019Syndication&gt;**](InlineResponse20019Syndication.md) | Per-protocol syndication status, keyed by lowercase protocol name (e.g. &#x60;acp&#x60;, &#x60;ucp&#x60;).  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

