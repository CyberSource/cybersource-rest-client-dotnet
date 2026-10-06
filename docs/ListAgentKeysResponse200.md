# CyberSource.Model.ListAgentKeysResponse200
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgentId** | **string** | Agent identifier (64-char SHA-256 hash) | 
**AgentName** | **string** | Display name of the agent | 
**Keys** | [**List&lt;AgentRegistrationResponse201Keys&gt;**](AgentRegistrationResponse201Keys.md) | Paginated list of public keys belonging to this agent (agentId/agentName/agentType omitted — available at the parent level) | 
**Pagination** | [**ListAgentKeysResponse200Pagination**](ListAgentKeysResponse200Pagination.md) |  | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

