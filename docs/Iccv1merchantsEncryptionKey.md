# CyberSource.Model.Iccv1merchantsEncryptionKey
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyName** | **string** | Unique name for the key | 
**EncryptionKey** | **string** | Base64-encoded public key (JWE key wrap public key) | 
**Algorithm** | **string** | JWE key wrap algorithm  Possible values: - RSA-OAEP - RSA-OAEP-256 - RSA-OAEP-384 - RSA-OAEP-512 | [optional] 
**EncryptionType** | **string** | JWE content encryption algorithm (defaults to A256GCM)  Possible values: - A256GCM - A128GCM - C20P - A256CBC-HS512 - A128CBC-HS256 - A256CCM - A128CCM | [optional] 
**ExpirationDate** | **DateTime?** | Key expiration date in UTC (defaults to 14 days from now if not provided) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

