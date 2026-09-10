# CyberSource.Model.InlineResponse2005
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RegistrationInformation** | [**Boardingv1registrationsRegistrationInformation**](Boardingv1registrationsRegistrationInformation.md) |  | [optional] 
**IntegrationInformation** | [**InlineResponse2005IntegrationInformation**](InlineResponse2005IntegrationInformation.md) |  | [optional] 
**OrganizationInformation** | [**Boardingv1registrationsOrganizationInformation**](Boardingv1registrationsOrganizationInformation.md) |  | [optional] 
**ProductInformation** | [**Boardingv1registrationsProductInformation**](Boardingv1registrationsProductInformation.md) |  | [optional] 
**ProductInformationSetups** | [**List&lt;InlineResponse2016ProductInformationSetups&gt;**](InlineResponse2016ProductInformationSetups.md) |  | [optional] 
**DocumentInformation** | [**Boardingv1registrationsDocumentInformation**](Boardingv1registrationsDocumentInformation.md) |  | [optional] 
**Details** | **Dictionary&lt;string, List&lt;Object&gt;&gt;** |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

