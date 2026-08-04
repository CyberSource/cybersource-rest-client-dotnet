# CyberSource.Model.Iccv1checkoutsessionsPaymentHandlers
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique handler identifier. | [optional] 
**Name** | **string** | Human-readable handler name. | [optional] 
**Version** | **string** | Handler spec version. | [optional] 
**Spec** | **string** | Handler specification identifier. | [optional] 
**ConfigSchema** | **Object** | JSON schema describing handler configuration options. | [optional] 
**InstrumentSchemas** | **List&lt;Object&gt;** | Schemas describing the instrument types this handler supports. | [optional] 
**Config** | **Object** | Handler-specific runtime configuration data. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

