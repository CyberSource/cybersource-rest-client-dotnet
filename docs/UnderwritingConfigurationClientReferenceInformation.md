# CyberSource.Model.UnderwritingConfigurationClientReferenceInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientRequestId** | **string** | client-generated request reference or tracking number. It is recommended that you send a unique value for each request so that you can perform meaningful searches for the request.  | [optional] 
**ApplicationName** | **string** | The name of the application (such as Boarding Workflow or Anet Boarding) that the client uses to send a request to merchant evaluation service.        | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

