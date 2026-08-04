# CyberSource.Model.PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status for the call can be: - COMPLETED - INVALID_REQUEST - DECLINED  | [optional] 
**Reason** | **string** | The reason of the status. Value can be   - &#x60;CUSTOMER_WATCHLIST_MATCH&#x60;   - &#x60;ADDRESS_COUNTRY_WATCHLIST_MATCH&#x60;   - &#x60;EMAIL_COUNTRY_WATCHLIST_MATCH&#x60;   - &#x60;IP_COUNTRY_WATCHLIST_MATCH&#x60;   - &#x60;INVALID_MERCHANT_CONFIGURATION&#x60;  | [optional] 
**Message** | **string** | The message describing the reason of the status. Value can be   - The customer matched the Denied Parties List   - The Export bill_country/ship_country  match   - Export email_country match   - Export hostname_country/ip_country match  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

