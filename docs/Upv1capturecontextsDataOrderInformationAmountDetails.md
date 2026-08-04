# CyberSource.Model.Upv1capturecontextsDataOrderInformationAmountDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalAmount** | **string** | This field defines the total order amount.  | [optional] 
**Currency** | **string** | This field defines the currency applicable to the order.  | [optional] 
**Surcharge** | [**Upv1capturecontextsDataOrderInformationAmountDetailsSurcharge**](Upv1capturecontextsDataOrderInformationAmountDetailsSurcharge.md) |  | [optional] 
**DiscountAmount** | **string** | This field defines the discount amount applicable to the order.  | [optional] 
**SubTotalAmount** | **string** | This field defines the sub total amount applicable to the order.  | [optional] 
**ServiceFeeAmount** | **string** | This field defines the service fee amount applicable to the order.  | [optional] 
**TaxAmount** | **string** | This field defines the tax amount applicable to the order.  | [optional] 
**TaxDetails** | [**Upv1capturecontextsDataOrderInformationAmountDetailsTaxDetails**](Upv1capturecontextsDataOrderInformationAmountDetailsTaxDetails.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

