# CyberSource.Model.Upv1capturecontextsDataMerchantInformationMerchantDescriptor
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the merchant | [optional] 
**AlternateName** | **string** | The alternate name of the merchant | [optional] 
**Locality** | **string** | The locality of the merchant | [optional] 
**Phone** | **string** | The phone number of the merchant | [optional] 
**Country** | **string** | The country code of the merchant | [optional] 
**PostalCode** | **string** | The postal code of the merchant | [optional] 
**AdministrativeArea** | **string** | The administrative area of the merchant | [optional] 
**Address1** | **string** | The first line of the merchant&#39;s address | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

