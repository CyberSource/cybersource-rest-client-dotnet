# CyberSource.Model.PullFunds201ResponseLinks
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Self** | [**PtsV2PaymentsPost201ResponseLinksSelf5**](PtsV2PaymentsPost201ResponseLinksSelf5.md) |  | [optional] 
**Reversal** | [**PtsV2PaymentsPost201ResponseLinksSelf6**](PtsV2PaymentsPost201ResponseLinksSelf6.md) |  | [optional] 
**Refund** | [**PtsV2PaymentsPost201ResponseLinksSelf7**](PtsV2PaymentsPost201ResponseLinksSelf7.md) |  | [optional] 
**Customer** | [**PtsV2PaymentsPost201ResponseLinksSelf8**](PtsV2PaymentsPost201ResponseLinksSelf8.md) |  | [optional] 
**PaymentInstrument** | [**PtsV2PaymentsPost201ResponseLinksSelf9**](PtsV2PaymentsPost201ResponseLinksSelf9.md) |  | [optional] 
**InstrumentIdentifier** | [**PtsV2PaymentsPost201ResponseLinksSelf10**](PtsV2PaymentsPost201ResponseLinksSelf10.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

