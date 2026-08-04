# CyberSource.Model.Ptsv2payoutsAggregatorInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AggregatorId** | **string** | Value that identifies you as a payment aggregator. Get this value from the processor.  | [optional] 
**Name** | **string** | Your payment aggregator business name. This field is conditionally required when aggregator id is present.  | [optional] 
**IndependentSalesOrganizationID** | **string** | Independent sales organization ID. This field is only used for Mastercard transactions submitted through PPGS.  | [optional] 
**SubMerchant** | [**Ptsv2payoutsAggregatorInformationSubMerchant**](Ptsv2payoutsAggregatorInformationSubMerchant.md) |  | [optional] 
**StreetAddress** | **string** | Acquirer street name. | [optional] 
**City** | **string** | Acquirer city. | [optional] 
**State** | **string** | Acquirer state. | [optional] 
**PostalCode** | **string** | Acquirer postal code. | [optional] 
**Country** | **string** | Acquirer country. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

