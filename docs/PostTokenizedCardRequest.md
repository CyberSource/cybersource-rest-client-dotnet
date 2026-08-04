# CyberSource.Model.PostTokenizedCardRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountReferenceId** | **string** | An identifier provided by the issuer for the account. **Required when source is ISSUER.**  | [optional] 
**ConsumerId** | **string** | Identifier of the consumer within the wallet. Maximum 24 characters for VTS. | [optional] 
**CreatePanInstrumentIdentifier** | **bool?** | Specifies whether the Instrument Identifier should be created (true) or not (false) with the PAN provided for the Network Token Provision request. Possible Values: - &#x60;true&#x60;: The InstrumentIdentifier should be created. - &#x60;false&#x60;: The InstrumentIdentifier should not be created.  | [optional] 
**Source** | **string** | Source of the card details. Possible Values: - ONFILE - TOKEN - ISSUER  | 
**Card** | [**Tmsv2tokenizedcardsCard**](Tmsv2tokenizedcardsCard.md) |  | [optional] 
**Passcode** | [**Tmsv2tokenizedcardsPasscode**](Tmsv2tokenizedcardsPasscode.md) |  | [optional] 
**BillTo** | [**Tmsv2tokenizedcardsBillTo**](Tmsv2tokenizedcardsBillTo.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

