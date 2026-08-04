# CyberSource.Model.Ptsv2paymentsTokenInformationTokenAuthenticationInformationAuthenticatedIdentities
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | **string** | Data related to the authenticated identity. Contains verification payload from the identity provider.  | [optional] 
**Provider** | **string** | Provider of the authenticated identity. Identifies the authentication service or identity provider.   Possible values: - CLIENT_DEVICE_CERT_JWS - VISA_PAYMENT_PASSKEY | [optional] 
**Id** | **string** | Unique identifier for the authenticated identity. A distinctive and non-transparent identifier for correlation purposes.  | [optional] 
**RelyingPartyId** | **string** | Identifier of the relying party that requested the authentication.  | [optional] 
**UserAuthenticationMethod** | **string** | The method used to authenticate the user.   Possible values: - USERNAME_PASSWORD - PASSCODE_PASSWORD - PASSCODE - PASSWORD - PATTERN - BIOMETRIC_FINGERPRINT - BIOMETRIC_FACIAL - BIOMETRIC_IRIS - BIOMETRIC_VOICE - BIOMETRIC_BEHAVIORAL - DEVICE_UNLOCKED_METHOD_UNKNOWN - OTP_SMS - OTP_EMAIL - OTP_SMS_KNOWLEDGE - KNOWLEDGE_BASED_AUTHENTICATION - USER_UNVERIFIED - BIOMETRIC | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

