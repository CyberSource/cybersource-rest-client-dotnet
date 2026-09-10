# CyberSource.Model.UnifiedriskOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalItemsCount** | **int?** | Total number of items in order | [optional] 
**ReturnsAccepted** | **bool?** | Indicates if returns are accepted | [optional] 
**LineItems** | [**List&lt;UnifiedriskOrderLineItems&gt;**](UnifiedriskOrderLineItems.md) |  | [optional] 
**Shipping** | [**UnifiedriskOrderShipping**](UnifiedriskOrderShipping.md) |  | [optional] 
**Billing** | [**UnifiedriskOrderBilling**](UnifiedriskOrderBilling.md) |  | [optional] 
**OrderId** | **string** | Merchant-assigned unique identifier for this order, used for transaction correlation, dispute matching, and fraud monitoring | [optional] 
**OrderDescription** | **string** | Free-text description of the order contents or purpose, provided by the merchant for risk analysis and dispute management | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

