# CyberSource.Model.PtsV2PayoutsPost201ResponseProcessorInformationElectronicVerificationResults
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmailRaw** | **string** | Raw Electronic Verification response code from the processor for the customer&#39;s email address.  Valid values: - &#39;1&#39;: Verified - &#39;2&#39;: Failed - &#39;3&#39;: Not performed  | [optional] 
**FirstNameRaw** | **string** | Raw electronic verification response code from the processor for the customer&#39;s first name.  Valid values: - &#39;01&#39;: Match - &#39;50&#39;: Partial Match - &#39;99&#39;: No Match  | [optional] 
**LastNameRaw** | **string** | Raw electronic verification response code from the processor for the customer&#39;s last name.  Valid values: - &#39;01&#39;: Match - &#39;50&#39;: Partial Match - &#39;99&#39;: No Match  | [optional] 
**MiddleNameRaw** | **string** | Raw electronic verification response code from the processor for the customer&#39;s middle name.  Valid values: - &#39;01&#39;: Match - &#39;50&#39;: Partial Match - &#39;99&#39;: No Match  | [optional] 
**NameRaw** | **string** | Raw Electronic Verification response code from the processor for the customer&#39;s name.  Valid values: - &#39;01&#39;: Match - &#39;50&#39;: Partial Match - &#39;99&#39;: No Match  | [optional] 
**PhoneNumberRaw** | **string** | Raw Electronic Verification response code from the processor for the customer&#39;s phone number.  Valid values: - &#39;1&#39;: Verified - &#39;2&#39;: Failed - &#39;3&#39;: Not performed  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

