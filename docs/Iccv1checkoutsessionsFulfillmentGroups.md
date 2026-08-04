# CyberSource.Model.Iccv1checkoutsessionsFulfillmentGroups
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique group identifier. | [optional] 
**LineItemIds** | **List&lt;string&gt;** | IDs of line items in this group. | [optional] 
**Options** | [**List&lt;Iccv1checkoutsessionsFulfillmentOptions&gt;**](Iccv1checkoutsessionsFulfillmentOptions.md) | Available shipping or fulfillment options for this group. | [optional] 
**SelectedOptionId** | **string** | ID of the currently selected fulfillment option. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

