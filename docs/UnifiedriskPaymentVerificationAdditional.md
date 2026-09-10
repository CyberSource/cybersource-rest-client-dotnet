# CyberSource.Model.UnifiedriskPaymentVerificationAdditional
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Signature** | **string** | Paper signature verification: SUCCESS, FAILURE     | [optional] 
**AccountHolderAuth** | **string** | Account holder authentication value: SUCCESS, FAILURE     | [optional] 
**AuthenticationToken** | **string** | Authentication token verification: SUCCESS, FAILURE     | [optional] 
**CardholderIdData** | **string** | Cardholder ID data verification: SUCCESS, FAILURE     | [optional] 
**PassiveAuth** | **string** | Passive authentication: SUCCESS, FAILURE     | [optional] 
**SimSwap** | **string** | SIM swap check: NO_SWAP_DETECTED, SWAP_DETECTED     | [optional] 
**SecureCorpPaymentIndicator** | **string** | Secure Corporate Payment Indicator (SCPI) flag assigned by the issuer to indicate a trusted commercial or corporate payment credential. Impacts SCA (Strong Customer Authentication) exemption eligibility under PSD2 | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

