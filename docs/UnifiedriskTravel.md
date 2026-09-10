# CyberSource.Model.UnifiedriskTravel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActualFinalDestination** | **string** | IATA Code for the actual final destination that the customer intends to travel to. It should be a destination on the completeRoute. | [optional] 
**CompleteRoute** | **string** | Concatenation of individual travel legs in the format ORIG1-DEST1[:ORIG2-DEST2...:ORIGn-DESTn], for example, SFO-JFK:JFK-LHR:LHR-CDG. For airport codes, see the IATA Airline and Airport Code Search. Note In your request, send either the complete route or the individual legs (_leg#_orig and _leg#_dest). If you send all the fields, the value of _complete_route takes precedence over that of the _leg# fields. | [optional] 
**DepartureTime** | **string** | Departure date and time of the first leg of the trip. Use one of the following formats:   - yyyy-MM-dd HH:mm z   - yyyy-MM-dd hh:mm a z   - yyyy-MM-dd hh:mma z   HH &#x3D; hour in 24-hour format   hh &#x3D; hou   | [optional] 
**JourneyType** | **string** | Type of travel, for example one way or round trip. | [optional] 
**NumberOfPassengers** | **int?** | Number of passengers for whom the ticket was issued. If you do not include this field in your request, CyberSource uses a default value of 1. Required for American Express SafeKey (U.S.) for travel-related requests. | [optional] 
**Legs** | **Object** |  | [optional] 
**Passengers** | **Object** |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

