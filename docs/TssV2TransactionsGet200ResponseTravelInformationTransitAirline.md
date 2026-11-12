# CyberSource.Model.TssV2TransactionsGet200ResponseTravelInformationTransitAirline
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassengerName** | **string** | Name of the passenger to whom the ticket was issued.  This will always be a single passenger&#39;s name. If there are more than one passengers, provide only the primary passenger&#39;s name. Do not include special characters such as commas, hyphens, or apostrophes. Only ASCII characters are supported. Format: English characters only. Optional request field.  | [optional] 
**TicketNumber** | **string** | Ticket number. Format: English characters only. Restricted string data type that indicates a sequence of letters, numbers, and spaces; special characters are not included. Optional request field.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

