# CyberSource.Model.UnifiedriskTerminalAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | First line of the terminal&#39;s physical address (street number and name), used for geographic risk analysis and terminal location verification | [optional] 
**AddressLine2** | **string** | Second line of the terminal&#39;s address for additional location details (building name, floor, suite) | [optional] 
**AddressLine3** | **string** | Third line of the terminal&#39;s address for further location details | [optional] 
**AddressType** | **string** | Type classification of the terminal address (e.g., BRANCH, ATM_INDOOR, ATM_OUTDOOR, KIOSK). Used for terminal risk profiling | [optional] 
**Country** | **string** | ISO 3166-1 alpha-3 country code for the terminal&#39;s physical location (e.g., GBR, USA, AUS) | [optional] 
**AdministrativeArea** | **string** | State, province, or region of the terminal&#39;s physical location, used for regional fraud pattern analysis | [optional] 
**Latitude** | **decimal?** | Geographic latitude coordinate of the terminal&#39;s physical location in decimal degrees, used for proximity and geolocation risk signals | [optional] 
**Longitude** | **decimal?** | Geographic longitude coordinate of the terminal&#39;s physical location in decimal degrees, used for proximity and geolocation risk signals | [optional] 
**PostalCode** | **string** | Postal code of the terminal&#39;s physical location, used for geographic risk clustering and distance-to-home fraud signals | [optional] 
**Locality** | **string** | City or town of the terminal&#39;s physical location, used for regional risk analysis and cardholder distance calculation | [optional] 
**FullAddress** | **string** | Complete concatenated address of the terminal as a single string, including all lines, locality, postcode, and country | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

