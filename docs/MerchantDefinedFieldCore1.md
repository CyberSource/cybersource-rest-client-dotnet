# CyberSource.Model.MerchantDefinedFieldCore1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldType** | **string** | Possible values: - text - select | 
**Label** | **string** |  | 
**CustomerVisible** | **bool?** |  | [optional] [default to false]
**TextMinLength** | **int?** | Should be used only if fieldType &#x3D; \&quot;text\&quot; | [optional] 
**TextMaxLength** | **int?** | Should be used only if fieldType &#x3D; \&quot;text\&quot; | [optional] 
**TextDefaultValue** | **string** | Should be used only if fieldType &#x3D; \&quot;text\&quot; | [optional] 
**PossibleValues** | **string** | Should be mandatory and used only if fieldType &#x3D; \&quot;select\&quot; | [optional] 
**ReadOnly** | **bool?** |  | [optional] [default to false]
**MerchantDefinedDataIndex** | **int?** |  | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

