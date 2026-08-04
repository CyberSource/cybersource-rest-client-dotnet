# CyberSource.Model.PatchCustomerRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**Tmsv2tokenizeTokenInformationCustomerLinks**](Tmsv2tokenizeTokenInformationCustomerLinks.md) |  | [optional] 
**Id** | **string** | The Id of the Customer Token. | [optional] 
**ObjectInformation** | [**Tmsv2tokenizeTokenInformationCustomerObjectInformation**](Tmsv2tokenizeTokenInformationCustomerObjectInformation.md) |  | [optional] 
**BuyerInformation** | [**Tmsv2tokenizeTokenInformationCustomerBuyerInformation**](Tmsv2tokenizeTokenInformationCustomerBuyerInformation.md) |  | [optional] 
**ClientReferenceInformation** | [**Tmsv2tokenizeTokenInformationCustomerClientReferenceInformation**](Tmsv2tokenizeTokenInformationCustomerClientReferenceInformation.md) |  | [optional] 
**MerchantDefinedInformation** | [**List&lt;Tmsv2tokenizeTokenInformationCustomerMerchantDefinedInformation&gt;**](Tmsv2tokenizeTokenInformationCustomerMerchantDefinedInformation.md) | Object containing the custom data that the merchant defines.  | [optional] 
**DefaultPaymentInstrument** | [**Tmsv2tokenizeTokenInformationCustomerDefaultPaymentInstrument**](Tmsv2tokenizeTokenInformationCustomerDefaultPaymentInstrument.md) |  | [optional] 
**DefaultShippingAddress** | [**Tmsv2tokenizeTokenInformationCustomerDefaultShippingAddress**](Tmsv2tokenizeTokenInformationCustomerDefaultShippingAddress.md) |  | [optional] 
**Metadata** | [**Tmsv2tokenizeTokenInformationCustomerMetadata**](Tmsv2tokenizeTokenInformationCustomerMetadata.md) |  | [optional] 
**Embedded** | [**Tmsv2customersEmbedded**](Tmsv2customersEmbedded.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

