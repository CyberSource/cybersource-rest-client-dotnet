# CyberSource.Model.MerchantDefinedFieldDefinitionRequest
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

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

