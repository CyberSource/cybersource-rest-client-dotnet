# CyberSource.Model.Ptsv1pushfundstransferMerchantInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CategoryCode** | **int?** | The value for this field is a four-digit number that the payment card industry uses to  classify merchants into market segments. A payment card company assigned one or more of  these values to your business when you started accepting the payment card company&#39;s cards.  When you do not include this field in your request, CyberSource uses the value in your CyberSource account.  | [optional] 
**MerchantDescriptor** | [**Ptsv1pushfundstransferMerchantInformationMerchantDescriptor**](Ptsv1pushfundstransferMerchantInformationMerchantDescriptor.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

