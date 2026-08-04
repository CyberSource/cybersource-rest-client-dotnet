# CyberSource.Model.PtsV2PaymentsPost201ResponseConsumerAuthenticationInformationStrongAuthentication
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IssuerInformation** | [**PaymentsStrongAuthIssuerInformation**](PaymentsStrongAuthIssuerInformation.md) |  | [optional] 
**OutageExemptionIndicator** | **string** | This field will contain the outage exemption indicator with one of the following values: Possible values: - &#x60;0&#x60;  (Outage Authentication exemption does not apply to the transaction) - &#x60;1&#x60; (Outage exempt from SCA as authentication could not be done due to outage)  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

