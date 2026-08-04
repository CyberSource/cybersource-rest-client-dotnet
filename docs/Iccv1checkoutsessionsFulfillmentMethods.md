# CyberSource.Model.Iccv1checkoutsessionsFulfillmentMethods
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique fulfillment method identifier. | [optional] 
**Type** | **string** | Fulfillment method type (e.g. &#x60;shipping&#x60;, &#x60;pickup&#x60;, &#x60;delivery&#x60;). | [optional] 
**LineItemIds** | **List&lt;string&gt;** | IDs of line items fulfilled by this method. | [optional] 
**Destinations** | [**List&lt;Iccv1checkoutsessionsFulfillmentDestinations&gt;**](Iccv1checkoutsessionsFulfillmentDestinations.md) | Available delivery destinations for this method. | [optional] 
**SelectedDestinationId** | **string** | ID of the currently selected destination. | [optional] 
**Groups** | [**List&lt;Iccv1checkoutsessionsFulfillmentGroups&gt;**](Iccv1checkoutsessionsFulfillmentGroups.md) | Groups of line items with their associated shipping options. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

