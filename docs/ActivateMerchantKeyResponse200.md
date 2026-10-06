# CyberSource.Model.ActivateMerchantKeyResponse200
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique key identifier (UUID). Generated from VMRS. | 
**MerchantId** | **string** | Merchant identifier (UUID) | 
**MerchantName** | **string** | Merchant name | 
**KeyName** | **string** | Unique name for the key | 
**EncryptionKey** | **string** | Base64-encoded public key | 
**Algorithm** | **string** | JWE key wrap algorithm  Possible values: - RSA-OAEP - RSA-OAEP-256 - RSA-OAEP-384 - RSA-OAEP-512 | 
**EncryptionType** | **string** | JWE content encryption algorithm  Possible values: - A256GCM - A128GCM - C20P - A256CBC_HS512 - A128CBC_HS256 - A256CCM - A128CCM | 
**ExpirationDate** | **DateTime?** | Key expiration date in UTC | 
**Status** | **string** | Key lifecycle status  Possible values: - active - deactivated - expired | 
**CreatedAt** | **DateTime?** | Creation timestamp | 
**UpdatedAt** | **DateTime?** | Last update timestamp | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

