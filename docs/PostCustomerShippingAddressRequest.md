# CyberSource.Model.PostCustomerShippingAddressRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**DefaultShippingAddressLinks**](DefaultShippingAddressLinks.md) |  | [optional] 
**Id** | **string** | The Id of the Shipping Address Token. | [optional] 
**Default** | **bool?** | Flag that indicates whether customer shipping address is the dafault. Possible Values:  - &#x60;true&#x60;: Shipping Address is customer&#39;s default.  - &#x60;false&#x60;: Shipping Address is not customer&#39;s default.  | [optional] 
**ShipTo** | [**DefaultShippingAddressShipTo**](DefaultShippingAddressShipTo.md) |  | [optional] 
**Metadata** | [**DefaultShippingAddressMetadata**](DefaultShippingAddressMetadata.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

