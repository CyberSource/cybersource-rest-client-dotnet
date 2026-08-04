# CyberSource.Model.Ptsv1pullfundstransferSenderInformationPaymentInformationPaymentInstrument
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for the Payment Instrument token used in the transaction. When you include this value in your request, many of the fields that are normally required become optional.  If you intend on using more than one token, please take note of the following conditions:  - In case a Payment Instrument token is accompanied by an Instrument Identifier token, the card number from the Instrument Identifier token will take precedence over the Payment Instrument token. - The Customer token and the Payment Instrument token are mutually exclusive. If both are present, you will receive an error.   For more information on TMS, please see our originator-facing documentation.  Conditional: If the card and customer object information is incomplete, this field becomes mandatory to retrieve missing information.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

