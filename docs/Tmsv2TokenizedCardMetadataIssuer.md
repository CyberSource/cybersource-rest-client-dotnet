# CyberSource.Model.Tmsv2TokenizedCardMetadataIssuer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Issuer name.  | [optional] 
**ShortDescription** | **string** | Short description of the card.  | [optional] 
**LongDescription** | **string** | Long description of the card.  | [optional] 
**Email** | **string** | Issuer customer service email address.  | [optional] 
**PhoneNumber** | **string** | Issuer customer service phone number.  | [optional] 
**Url** | **string** | Issuer customer service url.  | [optional] 
**PrivacyPolicyUrl** | **string** | Issuer privacy policy url.  | [optional] 
**Capabilities** | [**Tmsv2TokenizedCardMetadataIssuerCapabilities**](Tmsv2TokenizedCardMetadataIssuerCapabilities.md) |  | [optional] 
**BankApplications** | [**List&lt;Tmsv2TokenizedCardMetadataIssuerBankApplications&gt;**](Tmsv2TokenizedCardMetadataIssuerBankApplications.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

