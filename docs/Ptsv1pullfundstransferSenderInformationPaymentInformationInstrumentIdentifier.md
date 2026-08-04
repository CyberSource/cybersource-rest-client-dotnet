# CyberSource.Model.Ptsv1pullfundstransferSenderInformationPaymentInformationInstrumentIdentifier
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for the Instrument Identifier token used in the transaction. When you use this in the request, the card number field becomes optional. Conditional: this field is only required if card number is not sent in through &#x60;senderInformation.paymentInformation.card.number&#x60;.   For more information on TMS, please see our originator-facing documentation.  Conditional: this field is only required if card number is **not** sent in through &#x60;senderInformation.paymentInformation.card.number&#x60;.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

