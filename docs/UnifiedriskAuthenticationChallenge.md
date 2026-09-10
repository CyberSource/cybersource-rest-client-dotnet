# CyberSource.Model.UnifiedriskAuthenticationChallenge
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChallengeIndicator** | **string** | Indicates the merchant&#39;s preference for issuing a 3DS challenge. Values - \&quot;01\&quot; (No preference), \&quot;02\&quot; (No challenge requested), \&quot;03\&quot; (Challenge requested - Merchant Preference), \&quot;04\&quot; (Challenge mandated) | [optional] 
**AcsWindowSize** | **string** | Specifies the desired ACS challenge window size to be displayed during 3DS authentication. Values - \&quot;01\&quot; (250x400), \&quot;02\&quot; (390x400), \&quot;03\&quot; (500x600), \&quot;04\&quot; (600x400), \&quot;05\&quot; (Full screen) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

