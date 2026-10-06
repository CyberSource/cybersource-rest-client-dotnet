# CyberSource.Model.InlineResponse20112Totals
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Total type: - &#x60;items_base_amount&#x60; — sum of all line item base amounts before adjustments - &#x60;subtotal&#x60; — total after discounts - &#x60;tax&#x60; — total tax - &#x60;fulfillment&#x60; — shipping or delivery cost - &#x60;total&#x60; — final amount charged   Possible values: - items_base_amount - subtotal - tax - fulfillment - total | 
**DisplayText** | **string** | Human-readable label for display in checkout UI. | 
**Amount** | **int?** | Amount in minor units (cents). Example: 39998 &#x3D; $399.98 USD. | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

