# CyberSource.Model.Ptsv1pullfundstransferAggregatorInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AggregatorId** | **string** | Visa Direct(11 characters)   Value that identifies you as a payment aggregator. Get this value from the processor.  | [optional] 
**Name** | **string** | Visa Direct(25 characters)   Your payment aggregator business name. This field is conditionally required when aggregator id is present.  | [optional] 
**SubMerchant** | [**Ptsv1pullfundstransferAggregatorInformationSubMerchant**](Ptsv1pullfundstransferAggregatorInformationSubMerchant.md) |  | [optional] 
**City** | **string** | Aggregator city.  | [optional] 
**Country** | **string** | Aggregator country.  | [optional] 
**PostalCode** | **string** | Aggregator postal code.  | [optional] 
**State** | **string** | Aggregator state.  | [optional] 
**StreetAddress** | **string** | Aggregator street name.   | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

