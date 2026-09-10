# CyberSource.Model.UnifiedriskMerchantMerchantDescriptorHierarchy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChainId** | **string** | Unique identifier for the merchant chain (a group of outlets under the same brand), used to aggregate risk analysis across multiple locations | [optional] 
**ChainName** | **string** | The name of the merchant chain or brand that this merchant belongs to (e.g., \&quot;Starbucks\&quot;, \&quot;McDonald&#39;s\&quot;) | [optional] 
**GroupId** | **string** | Identifier for a logical grouping of merchants within a chain, used for hierarchical risk reporting and consolidated settlement | [optional] 
**GroupName** | **string** | The descriptive name of the merchant group within the chain hierarchy (e.g., \&quot;EMEA Region\&quot;, \&quot;Western Division\&quot;) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

