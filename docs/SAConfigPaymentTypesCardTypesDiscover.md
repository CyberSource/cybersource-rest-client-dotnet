# CyberSource.Model.SAConfigPaymentTypesCardTypesDiscover
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardVerificationNumberSupported** | **bool?** | Dictates whether or Card Verification Number is supported by the card type. Usually this is set at system level. | [optional] 
**CardVerificationNumberDisplay** | **bool?** | Toggles whether or Card Verification Number is displayed on the Hosted Checkout. | [optional] 
**PayerAuthenticationSupported** | **bool?** | Dictates whether or Payer Authentication is supported by the card type. Usually this is set at system level. | [optional] 
**SupportedCurrencies** | **List&lt;string&gt;** | Array of the supported  ISO 4217 alphabetic currency codes. | [optional] 
**Method** | **string** |  | [optional] 
**CardVerificationNumberRequired** | **bool?** |  | [optional] 
**PayerAuthenticationEnabled** | **bool?** |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

