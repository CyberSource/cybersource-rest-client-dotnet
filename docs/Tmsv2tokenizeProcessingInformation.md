# CyberSource.Model.Tmsv2tokenizeProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionList** | **List&lt;string&gt;** | Array of actions (one or more) to be included in the tokenize request.  Possible Values:  - &#x60;TOKEN_CREATE&#x60;: Use this when you want to create a token from the card/bank data in your tokenize request.  | [optional] 
**ActionTokenTypes** | **List&lt;string&gt;** | TMS tokens types you want to perform the action on.  Possible Values: - customer - paymentInstrument - instrumentIdentifier - shippingAddress - tokenizedCard  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

