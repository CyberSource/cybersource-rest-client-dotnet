# CyberSource.Model.ReportingV3ReportDefinitionsNameGet200Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**ReportDefinitionId** | **int?** |  | [optional] 
**ReportDefintionName** | **string** |  | [optional] 
**Attributes** | [**List&lt;ReportingV3ReportDefinitionsNameGet200ResponseAttributes&gt;**](ReportingV3ReportDefinitionsNameGet200ResponseAttributes.md) |  | [optional] 
**SupportedFormats** | **List&lt;string&gt;** |  | [optional] 
**Description** | **string** |  | [optional] 
**DefaultSettings** | [**ReportDefinitionDefaultSettings**](ReportDefinitionDefaultSettings.md) |  | [optional] 
**SubscriptionType** | **string** | &#39;The subscription type for which report definition is required. By default the type will be CUSTOM.&#39; Valid Values: - &#39;CLASSIC&#39; - &#39;CUSTOM&#39; - &#39;STANDARD&#39;  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

