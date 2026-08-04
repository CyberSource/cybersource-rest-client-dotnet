# CyberSource.Model.IccLineItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductSku** | **string** | Unique identifier for the product. | [optional] 
**ProductName** | **string** | Name of the product. | [optional] 
**Quantity** | **string** | (Conditional) Quantity of the product. | [optional] 
**UnitPrice** | **string** | The price of a single unit. | [optional] 
**UnitPriceCurrency** | **string** | ISO 4217 currency code. Currency in which the unit price is expressed. | [optional] 
**AmountDetail** | [**IccAmountDetail**](IccAmountDetail.md) |  | [optional] 
**ProductUrl** | **string** | URL of the product. | [optional] 
**Policies** | [**IccLineItemPolicies**](IccLineItemPolicies.md) |  | [optional] 
**AdditionalInfo** | [**List&lt;IccLineItemAdditionalInfo&gt;**](IccLineItemAdditionalInfo.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

