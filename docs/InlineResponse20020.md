# CyberSource.Model.InlineResponse20020
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalCount** | **int?** | Total number of products across all pages. | [optional] 
**MerchantId** | **string** | Merchant whose catalog is returned, or \&quot;all\&quot; if no filter applied. | [optional] 
**Products** | [**List&lt;InlineResponse20020Products&gt;**](InlineResponse20020Products.md) | List of product records for the current page. | [optional] 
**Page** | **int?** | Current page number (0-based). | [optional] 
**Size** | **int?** | Page size used in this response. | [optional] 
**TotalPages** | **int?** | Total number of pages available. | [optional] 
**HasNext** | **bool?** | Whether more pages exist after the current page. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

