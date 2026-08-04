# CyberSource.Model.InlineResponse2005IntegrationInformationTenantConfigurations
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SolutionId** | **string** | The solutionId is the unique identifier for this system resource. Partner can use it to reference the specific solution through out the system.  | [optional] 
**TenantConfigurationId** | **string** | The tenantConfigurationId is the unique identifier for this system resource. You will see various places where it must be referenced in the URI path, or when querying the hierarchy for ancestors or descendants.  | [optional] 
**Status** | **string** | Possible values: - LIVE - INACTIVE - TEST | [optional] 
**SubmitTimeUtc** | **DateTime?** | Time of request in UTC. | [optional] 
**TenantInformation** | [**TenantInformation**](TenantInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

