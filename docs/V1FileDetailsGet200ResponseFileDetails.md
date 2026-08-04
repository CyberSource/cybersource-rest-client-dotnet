# CyberSource.Model.V1FileDetailsGet200ResponseFileDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileId** | **string** | Unique identifier of a file | [optional] 
**Name** | **string** | Name of the file | [optional] 
**CreatedTime** | **DateTime?** | Date and time for the file in PST | [optional] 
**LastModifiedTime** | **DateTime?** | Date and time for the file in PST | [optional] 
**Date** | **DateTime?** | Date and time for the file in PST | [optional] 
**MimeType** | **string** | &#39;File extension&#39;  Valid values: - &#39;application/xml&#39; - &#39;text/csv&#39; - &#39;application/pdf&#39; - &#39;application/octet-stream&#39;  | [optional] 
**Size** | **decimal?** | Size of the file in bytes | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

