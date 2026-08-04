# CyberSource.Model.Riskv1decisionsTravelInformationPassengers
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | First name of the passenger to whom the ticket was issued. If there are multiple passengers, include all listed on the ticket. Do not include special characters such as commas, hyphens, or apostrophes. Only ASCII characters are supported. Required for American Express SafeKey (U.S.) for travel-related requests.  | [optional] 
**LastName** | **string** | Last name of the passenger to whom the ticket was issued. If there are multiple passengers, include all listed on the ticket. Do not include special characters such as commas, hyphens, or apostrophes. Only ASCII characters are supported. Required for American Express SafeKey (U.S.) for travel-related requests.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

