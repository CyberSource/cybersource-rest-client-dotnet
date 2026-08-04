# CyberSource.Model.AgentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Agent name | 
**Domain** | **string** | Agent domain URL | 
**Description** | **string** | Agent description | 
**ContactEmail** | **string** | Contact email | 
**TokenRequestorId** | **string** | Unique token requestor identifier | 
**AgentMetadata** | **Dictionary&lt;string, string&gt;** | Optional metadata (e.g., framework, version) | [optional] 
**Keys** | [**List&lt;Iccv1agentsKeys&gt;**](Iccv1agentsKeys.md) | Optional list of keys to create with the agent | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

