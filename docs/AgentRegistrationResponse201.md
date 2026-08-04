# CyberSource.Model.AgentRegistrationResponse201
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique agent identifier (64-char SHA-256 hash of domain + email + tokenRequestorId) | 
**Name** | **string** | Agent name | 
**Domain** | **string** | Agent domain URL | 
**Description** | **string** | Agent description | [optional] 
**ContactEmail** | **string** | Contact email | [optional] 
**TokenRequestorId** | **string** | Unique token requestor identifier | 
**AgentType** | **string** | Agent classification: &#39;trusted&#39; (commercially onboarded) or &#39;known&#39; (open-source/unverified)  Possible values: - trusted - known | 
**AgentMetadata** | **Dictionary&lt;string, string&gt;** | Additional agent metadata | [optional] 
**IsActive** | **bool?** | Whether the agent is active | 
**CreatedAt** | **DateTime?** | Creation timestamp | 
**UpdatedAt** | **DateTime?** | Last update timestamp | 
**Keys** | [**List&lt;AgentRegistrationResponse201Keys&gt;**](AgentRegistrationResponse201Keys.md) | List of keys associated with the agent | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

