# CyberSource.Model.VirtualTerminalGlobalPaymentSettingsBasicInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultStandardEntryClassCode** | **string** |  | [optional] 
**DefaultCountryCode** | **string** | ISO 4217 format | [optional] 
**DefaultCurrencyCode** | **string** | Three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf) | [optional] 
**DefaultTransactionType** | **string** | Possible values: - AUTHORIZATION - SALE | [optional] 
**DefaultPaymentType** | **string** | Possible values: - CREDIT_CARD - ECHECK | [optional] 
**DefaultTransactionSource** | **string** |  | [optional] 
**DisplayRetail** | **bool?** |  | [optional] 
**DisplayMoto** | **bool?** |  | [optional] 
**DisplayInternet** | **bool?** |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

