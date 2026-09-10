# CyberSource.Model.UnifiedriskPaymentBankAccountBranchAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | Address line 1     | [optional] 
**AddressLine2** | **string** | Address line 2     | [optional] 
**AddressLine3** | **string** | Address line 3     | [optional] 
**AddressType** | **string** | Identifies the nature of the postal address. Examples are \&quot;Home\&quot; or \&quot;Work\&quot;.     | [optional] 
**Country** | **string** | Nation with its own government, country code in ISO 3166 apha-3 format     | [optional] 
**AdministrativeArea** | **string** | Identifies a subdivision of a country such as state, region, county     | [optional] 
**FullAddress** | **string** | Full string containing all submitted address components.     | [optional] 
**Latitude** | **decimal?** | Latitude of the address     | [optional] 
**Longitude** | **decimal?** | Longitude of the address     | [optional] 
**PostalCode** | **string** | Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail     | [optional] 
**Locality** | **string** | Name of a built-up area, with defined boundaries, and a local government.     | [optional] 
**CountrySubDivision** | **string** | ISO 3166-2 subdivision code for the bank branch address state or province (e.g., US-NY, GB-ENG). Used for branch-level regulatory and geographic risk analysis | [optional] 
**TownName** | **string** | Town or city name of the bank branch used for geographic proximity analysis and branch-level risk profiling | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

