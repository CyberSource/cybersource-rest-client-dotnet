# CyberSource.Model.Tmsv2tokenizedcardstokenizedCardIdissuerlifecycleeventsimulationsCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Last4** | **string** | The new last 4 digits of the card number associated to the Tokenized Card.  | [optional] 
**ExpirationMonth** | **string** | The new two-digit month of the card associated to the Tokenized Card. Format: &#x60;MM&#x60;. Possible Values: &#x60;01&#x60; through &#x60;12&#x60;.  | [optional] 
**ExpirationYear** | **string** | The new four-digit year of the card associated to the Tokenized Card. Format: &#x60;YYYY&#x60;.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

