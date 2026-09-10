# CyberSource.Model.UnifiedriskMerchantTradingAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | First line of the merchant&#39;s trading (physical store or operating) address, including street number and name | [optional] 
**AddressLine2** | **string** | Second line of the merchant&#39;s trading address for suite, unit, or floor details | [optional] 
**AddressLine3** | **string** | Third line of the merchant&#39;s trading address for additional location information | [optional] 
**AddressType** | **string** | Type of the trading address (e.g., TRADING, PHYSICAL, OPERATING) identifying its business use | [optional] 
**Country** | **string** | ISO 3166-1 alpha-3 country code for the merchant&#39;s trading address (e.g., GBR, USA, DEU) | [optional] 
**CountrySubDivision** | **string** | ISO 3166-2 subdivision code for the merchant&#39;s trading address state, province, or region (e.g., US-CA, GB-ENG) | [optional] 
**FullAddress** | **string** | Complete concatenated trading address as a single string, including all lines, locality, postcode, and country | [optional] 
**Latitude** | **string** | Geographic latitude coordinate of the merchant&#39;s trading location in decimal degrees, used for proximity risk signals | [optional] 
**Longitude** | **string** | Geographic longitude coordinate of the merchant&#39;s trading location in decimal degrees, used for proximity risk signals | [optional] 
**PostalCode** | **string** | Postal or ZIP code of the merchant&#39;s trading address (e.g., SW1A 1AA, 10001) | [optional] 
**Locality** | **string** | City or town of the merchant&#39;s trading address (e.g., London, New York, Berlin) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

