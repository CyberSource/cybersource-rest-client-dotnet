# CyberSource.Model.Ptsv1pushfundstransferMerchantInformationMerchantDescriptor
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Merchant name. | [optional] 
**Locality** | **string** | Merchant&#39;s city. | [optional] 
**Country** | **string** | Merchant&#39;s country. | [optional] 
**AdministrativeArea** | **string** | Merchant&#39;s state. | [optional] 
**PostalCode** | **string** | Merchant&#39;s postal code. | [optional] 
**Contact** | **string** | Merchant&#39;s contact information. | [optional] 
**Address1** | **string** | First line of merchant&#39;s address. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

