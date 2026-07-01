# CyberSource.Model.Tmsv3tokenstokenIdpaymentcredentialsAuthenticatedIdentities
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id from the authenticated identity.  Base64URL encoded string (RFC4648).   The encoding is the same as Base64, but uses &#39;-&#39; characters instead of &#39;+&#39; and &#39;_&#39; characters instead of &#39;/&#39;.  | [optional] 
**Provider** | **string** | The provider of the authenticated identity.  Possible Values:   - VISA_PAYMENT_PASSKEY   - CLIENT_DEVICE_CERT_JWS  | [optional] 
**Data** | **string** | The data from the authenticated identity. For Passkey this could be the FIDO Attestation. For Classic Cloud Token Framework (CTF) this could be a JWS containing device authentication information signed by a devices private key. Base64URL encoded string (RFC4648). The encoding is the same as Base64, but uses &#39;-&#39; characters instead of &#39;+&#39; and &#39;_&#39; characters instead of &#39;/&#39;.  | [optional] 
**RelyingPartyId** | **string** | The id of the Relying Party.  Base64URL encoded string (RFC4648).  The encoding is the same as Base64, but uses &#39;-&#39; characters instead of &#39;+&#39; and &#39;_&#39; characters instead of &#39;/&#39;.  | [optional] 
**UserAuthenticationMethod** | **string** | The method used to authenticate the user.  Possible Values:   - USERNAME_PASSWORD   - PASSCODE_PASSWORD   - PASSCODE   - PASSWORD   - PATTERN   - BIOMETRIC_FINGERPRINT   - BIOMETRIC_FACIAL   - BIOMETRIC_IRIS   - BIOMETRIC_VOICE   - BIOMETRIC_BEHAVIORAL   - DEVICE_UNLOCKED_METHOD_UNKNOWN   - OTP_SMS   - OTP_EMAIL   - OTP_SMS_KNOWLEDGE   - KNOWLEDGE_BASED_AUTHENTICATION   - USER_UNVERIFIED   - BIOMETRIC  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

