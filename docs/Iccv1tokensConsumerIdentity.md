# CyberSource.Model.Iccv1tokensConsumerIdentity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentityType** | **string** | Type of Consumer Identity transmitted or collected.   Possible values:     - &#x60;EMAIL_ADDRESS&#x60;   - &#x60;MOBILE_PHONE_NUMBER&#x60;  | 
**IdentityValue** | **string** | Consumer Identity value that corresponds to the Consumer Identity Type. | 
**IdentityProvider** | **string** | Identity provider of the Consumer Identity.   Possible values:     - &#x60;VISA&#x60;   - &#x60;PARTNER&#x60; (Default)  | [optional] 
**IdentityProviderUrl** | **string** | Domain Name/URL(iss) of the Identity provider of the Consumer Identity. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

