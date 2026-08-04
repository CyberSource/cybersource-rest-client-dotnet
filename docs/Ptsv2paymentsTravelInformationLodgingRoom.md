# CyberSource.Model.Ptsv2paymentsTravelInformationLodgingRoom
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DailyRate** | **string** | Daily cost of the room.  | [optional] 
**NumberOfNights** | **int?** | Number of nights billed at the rate specified by &#x60;travelInformation.lodging.room[].dailyRate&#x60;.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

