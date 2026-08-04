# CyberSource.Model.Ptsv2creditsRecipientInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | First name of recipient of the funds. * Required for Mastercard Payment of Winnings (POW) transactions. * Must not be all numeric. * Must contain only ASCII characters in range 32-122. * Must not be greater than 35 characters including spaces. * Required for POW on Barclays  | [optional] 
**LastName** | **string** | Last name of recipient of the funds. * Required for Mastercard Payment of Winnings (POW) transactions. * Must not be all numeric. * Must contain only ASCII characters in range 32-122. * Must not be greater than 35 characters including spaces. * Required for POW on Barclays  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

