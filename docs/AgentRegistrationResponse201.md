# CyberSource.Model.AgentRegistrationResponse201
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique agent identifier (64-char SHA-256 hash of domain + email + tokenRequestorId) | 
**Name** | **string** | Display name for the agent | 
**Domain** | **string** | Fully-qualified HTTPS URL of the agent&#39;s home domain | 
**Description** | **string** | Description of the agent&#39;s purpose or capabilities | [optional] 
**ContactEmail** | **string** | Contact email for the team or individual responsible for this agent | [optional] 
**TokenRequestorId** | **string** | Token Requestor ID (TRID) assigned by Visa, shared with the parent trusted agent for OSAs | 
**AgentType** | **string** | Agent classification: &#39;trusted&#39; (commercially onboarded via Visa) or &#39;known&#39; (open-source/community agent, unverified)  Possible values: - trusted - known | 
**AgentMetadata** | **Object** | Free-form metadata object for agent context (e.g., AI framework, language, runtime). Max 10KB. | [optional] 
**IsActive** | **bool?** | Whether the agent is currently active. Deactivated agents cannot add or activate keys. | 
**CreatedAt** | **DateTime?** | ISO 8601 UTC timestamp when the agent was registered | 
**UpdatedAt** | **DateTime?** | ISO 8601 UTC timestamp when the agent was last updated | 
**Keys** | [**List&lt;AgentRegistrationResponse201Keys&gt;**](AgentRegistrationResponse201Keys.md) | List of public keys associated with the agent (both active and deactivated) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

