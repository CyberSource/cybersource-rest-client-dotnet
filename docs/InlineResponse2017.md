# CyberSource.Model.InlineResponse2017
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**SubmitTimeUtc** | **DateTime?** | Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC.  | [optional] 
**Status** | **string** | The status of Registration request Possible Values:   - &#39;INITIALIZED&#39;   - &#39;RECEIVED&#39;   - &#39;PROCESSING&#39;   - &#39;SUCCESS&#39;   - &#39;FAILURE&#39;   - &#39;PARTIAL&#39;  | [optional] 
**RegistrationInformation** | [**InlineResponse2017RegistrationInformation**](InlineResponse2017RegistrationInformation.md) |  | [optional] 
**IntegrationInformation** | [**InlineResponse2017IntegrationInformation**](InlineResponse2017IntegrationInformation.md) |  | [optional] 
**OrganizationInformation** | [**InlineResponse2017OrganizationInformation**](InlineResponse2017OrganizationInformation.md) |  | [optional] 
**ProductInformationSetups** | [**List&lt;InlineResponse2017ProductInformationSetups&gt;**](InlineResponse2017ProductInformationSetups.md) |  | [optional] 
**Message** | **string** |  | [optional] 
**Details** | **Dictionary&lt;string, List&lt;Object&gt;&gt;** |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

