# CyberSource.Model.InlineResponse20019GoogleMerchantProducts
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemId** | **string** | Product item ID. | [optional] 
**Title** | **string** | Product title. | [optional] 
**UcpValid** | **bool?** | Whether the product passed UCP validation. | [optional] 
**UcpErrors** | **List&lt;string&gt;** | UCP validation errors (empty if ucpValid is true). | [optional] 
**GoogleUploadStatus** | **string** | Google upload status for this product.   Possible values: - UPLOADED - SKIPPED - FAILED | [optional] 
**GoogleResourceName** | **string** | Google Merchant resource name assigned after upload. | [optional] 
**GoogleError** | **string** | Error message from Google if upload failed. Null on success. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

