# CyberSource.Model.Ptsv2paymentsMerchantInformationServiceLocation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Locality** | **string** | #### Visa Platform Connect  Merchant&#39;s service location city name. When merchant provides services from a location other than the location identified as merchant location.  | [optional] 
**CountrySubdivisionCode** | **string** | #### Visa Platform Connect  Merchant&#39;s service location country subdivision code. When merchant provides services from a location other than the location identified as merchant location.  | [optional] 
**CountryCode** | **string** | #### Visa Platform Connect  Merchant&#39;s service location country code. When merchant provides services from a location other than the location identified as merchant location.  | [optional] 
**PostalCode** | **string** | #### Visa Platform Connect  Merchant&#39;s service location postal code. When merchant provides services from a location other than the location identified as merchant location.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

