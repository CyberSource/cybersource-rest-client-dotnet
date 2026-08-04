# CyberSource.Model.KeyRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyName** | **string** | Unique identifier for the key | 
**PublicKey** | **string** | Base64-encoded public key. Supports PEM (PKCS#8, PKCS#1), JWK, DER, and OpenSSH formats. Max 10000 characters. | 
**Algorithm** | **string** | Signing algorithm. Must match the key type (e.g., an RSA key requires RSA-SHA256 or RSA-SHA512).  Possible values: - RSA-SHA256 - RSA-SHA512 - ECDSA-SHA256 - ECDSA-SHA512 - EdDSA | 
**ExpirationDate** | **DateTime?** | Key expiration date in UTC (defaults to 14 days from now if not provided) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

