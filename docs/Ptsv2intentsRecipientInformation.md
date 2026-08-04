# CyberSource.Model.Ptsv2intentsRecipientInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The account ID of the recipient.  | [optional] 
**CreateDate** | **string** | The date when the recipient&#39;s account was created.  | [optional] 
**Email** | **string** | The email address of the recipient  | [optional] 
**CountryCode** | **string** | The country code of the recipient.  | [optional] 
**BusinessName** | **string** | The business name of the recipient.  | [optional] 
**RiskPopularityScore** | **string** | The risk popularity score of the recipient.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

