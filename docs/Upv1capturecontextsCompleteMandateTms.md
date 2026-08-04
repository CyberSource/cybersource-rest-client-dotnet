# CyberSource.Model.Upv1capturecontextsCompleteMandateTms
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenCreate** | **bool?** | Use this when you want to create a token from the card/bank data in your payment request.   Possible values:   - True   - False&lt;br&gt;&lt;br&gt;  | [optional] 
**TokenTypes** | **List&lt;string&gt;** | Cybersource tokens types you are performing a create on. If not supplied the default token type for the merchants token vault will be used.  Possible values: - Customer - paymentInstrument - instrumentIdentifier - shippingAddress  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

