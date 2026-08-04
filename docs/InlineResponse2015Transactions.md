# CyberSource.Model.InlineResponse2015Transactions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantInformation** | [**InlineResponse2015MerchantInformation**](InlineResponse2015MerchantInformation.md) |  | [optional] 
**OrderInformation** | [**InlineResponse2015OrderInformation**](InlineResponse2015OrderInformation.md) |  | [optional] 
**PaymentInformation** | [**InlineResponse2015PaymentInformation**](InlineResponse2015PaymentInformation.md) |  | [optional] 
**AcquirerInformation** | [**InlineResponse2015AcquirerInformation**](InlineResponse2015AcquirerInformation.md) |  | [optional] 
**ProcessingInformation** | [**InlineResponse2015ProcessingInformation**](InlineResponse2015ProcessingInformation.md) |  | [optional] 
**ProcessorInformation** | [**InlineResponse2015ProcessorInformation**](InlineResponse2015ProcessorInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

