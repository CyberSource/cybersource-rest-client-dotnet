# CyberSource.Model.Ptsv2intentsTravelInformationAgency
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDate** | **string** | The start date of the agency&#39;s service.  | [optional] 
**EndDate** | **string** | The end date of the agency&#39;s service.  | [optional] 
**ChangeOfGuest** | **string** | Indicates if there is a change of guest.  | [optional] 
**CountryCode** | **string** | The country code of the agency.  | [optional] 
**Locality** | **string** | The locality of the agency.  | [optional] 
**PostalCode** | **string** | The postal code of the agency.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

