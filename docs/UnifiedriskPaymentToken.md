# CyberSource.Model.UnifiedriskPaymentToken
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | The actual token string or transient token JWT value used as a payment reference. This replaces the raw payment credential in tokenized payment flows | [optional] 
**ExpiryDate** | **string** | Expiry date of the payment token, in MMYYYY or MMYY format. Expired tokens must not be used for payment processing | [optional] 
**Jti** | **string** | JWT ID (jti claim) from the transient token, providing a unique identifier for the token JWT for nonce validation and replay prevention | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

