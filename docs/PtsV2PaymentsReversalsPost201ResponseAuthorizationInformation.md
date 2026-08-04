# CyberSource.Model.PtsV2PaymentsReversalsPost201ResponseAuthorizationInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApprovalCode** | **string** | The authorization code returned by the processor. | [optional] 
**ReasonCode** | **string** | Reply flag for the original transaction. | [optional] 
**ReversalSubmitted** | **string** | Flag indicating whether a full authorization reversal was successfully submitted.  Possible values: - Y: The authorization reversal was successfully submitted. - N: The authorization reversal was not successfully submitted. You must send a credit request for a refund.  This field is supported only for **FDC Nashville Global**.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

