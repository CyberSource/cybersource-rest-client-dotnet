# CyberSource.Model.PtsV2PaymentsPost201ResponseRiskInformationProfile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the active profile chosen by the profile selector. If no profile selector exists, the default active profile is chosen.  **Note** By default, your default profile is the active profile, or the Profile Selector chooses the active profile. Use this field only if you want to specify the name of a different profile. The passed-in profile will then become the active profile.  | [optional] 
**DesinationQueue** | **string** | Name of the queue where orders that are not automatically accepted are sent.  | [optional] 
**SelectorRule** | **string** | Name of the profile selector rule that chooses the profile to use for the transaction. If no profile selector exists, the value is Default Active Profile.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

