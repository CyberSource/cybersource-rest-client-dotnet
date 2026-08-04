# CyberSource.Model.TmsMerchantInformationMerchantDescriptor
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AlternateName** | **string** | Alternate contact information for your business,such as an email address or URL. This value might be displayed on the cardholder&#39;s statement. When you do not include this value in your capture or credit request, the merchant URL from your CyberSource account is used. Important This value must consist of English characters  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

