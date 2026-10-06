# CyberSource.Model.AgentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Display name for the agent | 
**Domain** | **string** | Fully-qualified HTTPS URL of the agent&#39;s home domain. Must be unique — registration raises 409 if it already exists. | 
**Description** | **string** | Description of the agent&#39;s purpose or capabilities | 
**ContactEmail** | **string** | Contact email for the team or individual responsible for this agent | 
**TokenRequestorId** | **string** | Token Requestor ID (TRID) assigned by Visa | 
**AgentMetadata** | **Object** | Free-form metadata object for agent context (e.g., AI framework, language, runtime). Max 10KB. | [optional] 
**Keys** | [**List&lt;Iccv1agentsKeys&gt;**](Iccv1agentsKeys.md) | Optional array of public keys to register alongside the agent. Keys are created in ***deactivated*** state and must be activated separately via POST /agents/{agentId}/keys/{keyId}/activate.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

