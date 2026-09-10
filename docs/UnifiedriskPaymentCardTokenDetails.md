# CyberSource.Model.UnifiedriskPaymentCardTokenDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProviderType** | **string** | Token provider type: network_token or merchant_token      Possible values: - network_token - merchant_token | [optional] 
**Type** | **string** | Type of payment credential being used. Visa, MasterCard, AMEX | [optional] 
**Jti** | **string** | Transient Token JWT ID | [optional] 
**Number** | **string** | Token number replacing PAN     | [optional] 
**ExpirationMonth** | **string** | Token expiration month     | [optional] 
**ExpirationYear** | **string** | Token expiration year     | [optional] 
**Bin** | **string** | BIN from underlying card     | [optional] 
**Last4** | **string** | Last 4 digits of card     | [optional] 
**ExpirationDate** | **string** | Combined expiration date of the network token in MMYYYY format, used when the token&#39;s lifecycle is managed separately from the underlying PAN | [optional] 
**RequestorId** | **string** | Unique identifier of the token requestor (e.g., merchant or PSP) registered with the token service provider for DPAN provisioning and lifecycle management | [optional] 
**Cryptogram** | **string** | A cryptographic value generated during tokenization (TAVV or CAVV) that authenticates the token for a specific transaction, preventing token replay attacks | [optional] 
**Status** | **string** | Current lifecycle status of the network token (e.g., ACTIVE, SUSPENDED, DEACTIVATED). Tokens that are not ACTIVE should not be used for payment | [optional] 
**CryptograValidity** | **string** | Indicates the validity or expiry state of the cryptogram, helping detect stale or replayed token authentication attempts | [optional] 
**AssuranceMethod** | **string** | Indicates the authentication assurance level of the token provisioning process (e.g., APP_VERIFIED, CARDHOLDER_VERIFIED), impacting liability shift decisions | [optional] 
**AdditionalData** | **string** | Supplementary data associated with the network token, such as merchant category restrictions, wallet provider metadata, or tokenization service payload extensions | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

