# CyberSource.Model.PtsV2PaymentsPost201ResponseRiskInformationVelocity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Morphing** | [**List&lt;PtsV2PaymentsPost201ResponseRiskInformationVelocityMorphing&gt;**](PtsV2PaymentsPost201ResponseRiskInformationVelocityMorphing.md) | List of information codes triggered by the order. These information codes were generated when you created the order and product velocity rules and are returned so that you can associate them with the rules.  Returned by scoring service.  | [optional] 
**Address** | **List&lt;string&gt;** |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

