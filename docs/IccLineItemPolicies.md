# CyberSource.Model.IccLineItemPolicies
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TermsAndConditions** | **string** | Any specific terms and conditions related to the sale, payment, use of the product. | [optional] 
**CancellationPolicy** | **string** | Any specific terms and conditions related to the cancellation of the order. | [optional] 
**RefundPolicy** | **string** | Any specific terms and conditions related to the refund. | [optional] 
**DisputePolicy** | **string** | Any specific terms and conditions related to the dispute. | [optional] 
**ShippingPolicy** | **string** | Any specific terms and conditions related to the shipping. | [optional] 
**DiscountAndPromotions** | **string** | Any specific terms and conditions related to the discount. | [optional] 
**PropertyName** | **Object** |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

