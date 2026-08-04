# CyberSource.Model.PtsV2PaymentsPost201ResponseRiskInformationTravel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActualFinalDestination** | [**PtsV2PaymentsPost201ResponseRiskInformationTravelActualFinalDestination**](PtsV2PaymentsPost201ResponseRiskInformationTravelActualFinalDestination.md) |  | [optional] 
**FirstDeparture** | [**PtsV2PaymentsPost201ResponseRiskInformationTravelFirstDeparture**](PtsV2PaymentsPost201ResponseRiskInformationTravelFirstDeparture.md) |  | [optional] 
**FirstDestination** | [**PtsV2PaymentsPost201ResponseRiskInformationTravelFirstDestination**](PtsV2PaymentsPost201ResponseRiskInformationTravelFirstDestination.md) |  | [optional] 
**LastDestination** | [**PtsV2PaymentsPost201ResponseRiskInformationTravelLastDestination**](PtsV2PaymentsPost201ResponseRiskInformationTravelLastDestination.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

