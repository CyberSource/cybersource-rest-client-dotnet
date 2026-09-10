# CyberSource.Model.UnifiedriskCustomerAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | First line of the customer&#39;s postal address, typically including the street number and street name (e.g., 12 Main Street) | [optional] 
**AddressLine2** | **string** | Second line of the customer&#39;s postal address for additional details such as apartment, suite, or floor number | [optional] 
**AddressLine3** | **string** | Third line of the customer&#39;s postal address for further address details or care-of information | [optional] 
**Country** | **string** | Country of the customer&#39;s address, expressed as an ISO 3166-1 alpha-3 three-letter country code (e.g., USA, GBR, IND) | [optional] 
**AdministrativeArea** | **string** | State, province, county or region of the customer&#39;s address (e.g., California, South Yorkshire, Bavaria) | [optional] 
**Latitude** | **string** | Geographic latitude coordinate of the customer&#39;s address in decimal degrees (e.g., 51.509865 for London) | [optional] 
**Longitude** | **string** | Geographic longitude coordinate of the customer&#39;s address in decimal degrees (e.g., -0.118092 for London) | [optional] 
**PostalCode** | **string** | Postal or ZIP code of the customer&#39;s address used for geographic sorting and delivery (e.g., 94105 or W1A 1AA) | [optional] 
**Locality** | **string** | City, town or locality of the customer&#39;s address (e.g., San Francisco, Sheffield, Barcelona) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

