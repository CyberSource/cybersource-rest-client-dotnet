# CyberSource.Model.Ptsv2paymentsTokenInformationTokenProvisioningInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConsumerConsentObtained** | **bool?** | Flag that indicates whether the user consented to the tokenization of their credentials. Required for card network tokenization in certain markets, such as India. Possible Values: - &#x60;true&#x60;: Consumer has consented to tokenization of their credentials. - &#x60;false&#x60;: Consumer has not consented to tokenization of their credentials.  | [optional] 
**MultiFactorAuthenticated** | **bool?** | Flag that indicates whether AFA (Additional Factor of Authentication) for the PAN was completed. Required for card network tokenization in certain markets, such as India. Possible Values: - &#x60;true&#x60;: Consumer has been authenticated by the issuer. - &#x60;false&#x60;: Consumer has not been authenticated by the issuer.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

