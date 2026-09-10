# CyberSource.Model.InlineResponse20113Discounts
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Codes** | **List&lt;string&gt;** | List of discount or promotional codes to apply to the session. | [optional] 
**Applied** | [**List&lt;Iccv1checkoutsessionsDiscountsApplied&gt;**](Iccv1checkoutsessionsDiscountsApplied.md) | Discounts that have been successfully applied to the session. Populated in responses; may be omitted in requests.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

