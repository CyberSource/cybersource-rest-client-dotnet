# CyberSource.Model.Iccv1checkoutsessionsFulfillmentTotals
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of total this entry represents: - &#x60;subtotal&#x60; — sum of line items before adjustments - &#x60;tax&#x60; — applicable taxes - &#x60;shipping&#x60; — fulfillment cost - &#x60;discount&#x60; — amount saved from promotional codes (negative value) - &#x60;total&#x60; — final amount charged   Possible values: - subtotal - tax - shipping - discount - total | [optional] 
**Amount** | **int?** | Amount in cents. Example: &#x60;2999&#x60; &#x3D; $29.99 USD.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

