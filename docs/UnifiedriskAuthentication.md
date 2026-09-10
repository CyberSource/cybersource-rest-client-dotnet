# CyberSource.Model.UnifiedriskAuthentication
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthenticationId** | **string** | Unique identifier assigned to an authentication attempt | [optional] 
**Method** | **string** | Authentication method used during the authentication/MFA process | [optional] 
**MfaSuccessful** | **bool?** | Whether multi-factor authentication was completed successfully | [optional] 
**PhoneNumber** | **string** | Phone number used for authentication (e.g., SMS/voice MFA) | [optional] 
**Email** | **string** | Email address used for authentication (e.g., verification code delivery) | [optional] 
**Other** | **string** | Additional authentication-related information not captured by other fields | [optional] 
**ThreeDSRequestorId** | **string** | Unique identifier assigned to the 3D Secure requestor (typically the merchant or payment service provider) by the directory server for authentication routing | [optional] 
**ThreeDSRequestorName** | **string** | The business or brand name of the 3D Secure requestor as registered with the card network directory server | [optional] 
**Challenge** | [**UnifiedriskAuthenticationChallenge**](UnifiedriskAuthenticationChallenge.md) |  | [optional] 
**DecoupledIndicator** | **string** | Indicates whether decoupled authentication is requested or supported, allowing the cardholder to authenticate outside the main transaction flow. Values - \&quot;Y\&quot; (supported and preferred), \&quot;N\&quot; (do not use) | [optional] 
**DecoupledMaxTime** | **string** | Maximum time in minutes allowed for the cardholder to complete a decoupled authentication, after which the session expires | [optional] 
**ThreeRIIndicator** | **string** | Indicates the reason for the 3DS Requestor Initiated (3RI) transaction - a merchant-initiated authentication without active cardholder participation. Values defined by EMVCo 3DS specification | [optional] 
**AuthenticationIndicator** | **string** | Indicates the type of authentication request being made, such as payment authentication, non-payment authentication, or recurring/installment transactions | [optional] 
**AuthenticationDate** | **string** | The date and time when the cardholder completed authentication, used for tracking authentication timing and fraud analysis | [optional] 
**LanguagePreference** | **List&lt;string&gt;** | The cardholder&#39;s preferred language for the authentication challenge interface, expressed as an IETF BCP 47 language tag (e.g., en-US, fr-FR) | [optional] 
**SpcSupport** | **string** | Indicates whether the merchant&#39;s environment supports the Secure Payment Confirmation (SPC) protocol for frictionless authentication using FIDO2/WebAuthn credentials | [optional] 
**SpcIncompleteIndicator** | **string** | Indicates the reason why an SPC (Secure Payment Confirmation) transaction was not completed, helping distinguish cardholder-initiated abandonment from technical failures | [optional] 
**Version** | **string** | The 3D Secure protocol version used for this authentication attempt (e.g., \&quot;2.1.0\&quot;, \&quot;2.2.0\&quot;), which determines which fields and features are supported | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

