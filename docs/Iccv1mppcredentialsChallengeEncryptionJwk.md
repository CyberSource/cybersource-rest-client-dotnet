# CyberSource.Model.Iccv1mppcredentialsChallengeEncryptionJwk
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kty** | **string** | Key type. MUST be &#39;RSA&#39;. | 
**Kid** | **string** | Key ID. Identifies the key within a JWKS. | 
**Use** | **string** | Public key use. MUST be &#39;enc&#39;. | 
**Alg** | **string** | Algorithm. MUST be &#39;RSA-OAEP-256&#39;. | 
**N** | **string** | RSA modulus (Base64urlUInt-encoded per RFC 7518 Section 6.3.1.1). | 
**E** | **string** | RSA public exponent (Base64urlUInt-encoded per RFC 7518 Section 6.3.1.2). | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

