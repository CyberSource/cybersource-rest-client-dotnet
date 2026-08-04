# CyberSource.Model.Riskv1authenticationsTravelInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Legs** | [**List&lt;Riskv1decisionsTravelInformationLegs&gt;**](Riskv1decisionsTravelInformationLegs.md) |  | [optional] 
**NumberOfPassengers** | **int?** | Number of passengers for whom the ticket was issued. If you do not include this field in your request, CyberSource uses a default value of 1. Required for American Express SafeKey (U.S.) for travel-related requests.  | [optional] 
**Passengers** | [**List&lt;Riskv1decisionsTravelInformationPassengers&gt;**](Riskv1decisionsTravelInformationPassengers.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

