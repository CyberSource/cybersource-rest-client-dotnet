# CyberSource.Model.InlineResponse200Responses
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Resource** | **string** | TMS token type associated with the response.  Possible Values: - customer - paymentInstrument - instrumentIdentifier - shippingAddress - tokenizedCard  | [optional] 
**HttpStatus** | **int?** | Http status associated with the response.  | [optional] 
**Id** | **string** | TMS token id associated with the response.  | [optional] 
**Errors** | [**List&lt;InlineResponse200Errors&gt;**](InlineResponse200Errors.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

