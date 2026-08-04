# CyberSource.Model.Tmsv2TokenizedCardMetadataIssuerCapabilities
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceBindingSupported** | **bool?** | Indicates if the issuer supports device binding.  | [optional] 
**CardholderVerificationSupported** | **bool?** | Indicates if the issuer participates in step-up authentication that requires cardholder verification.  | [optional] 
**TrustedBeneficiaryEnrollmentSupported** | **bool?** | Indicates if the issuer supports trusted beneficiary enrollment. e.g allowing cardholders to designate trusted merchants or payment recipients that can be exempt from step-up authentication.  | [optional] 
**DelegatedAuthenticationSupported** | **bool?** | Indicates if the issuer supports delegated authentication. e.g allowing approved thrird parties to perform authentication on behalf of the issuer.  | [optional] 
**OboDeviceBindingSupported** | **bool?** | Indicates if the issuer supports on-behalf-of device binding. e.g allowing approved third parties to perform device binding on behalf of the issuer.  | [optional] 
**TokenLcmNotificationsSupported** | **bool?** | Indicates if the issuer supports receiving token lifecycle management notifications. e.g receiving updates on changes to the token&#39;s status or attributes.  | [optional] 
**FpanLcmNotificationsSupported** | **bool?** | Indicates if the issuer supports receiving PAN lifecycle management notifications. e.g receiving updates on changes to the underlying card&#39;s status or attributes.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

