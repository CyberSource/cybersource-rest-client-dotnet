# CyberSource.Model.VasV2PaymentsPost201ResponseOrderInformationLineItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaxDetails** | [**List&lt;VasV2PaymentsPost201ResponseOrderInformationTaxDetails&gt;**](VasV2PaymentsPost201ResponseOrderInformationTaxDetails.md) |  | [optional] 
**Jurisdiction** | [**List&lt;VasV2PaymentsPost201ResponseOrderInformationJurisdiction&gt;**](VasV2PaymentsPost201ResponseOrderInformationJurisdiction.md) |  | [optional] 
**ExemptAmount** | **string** | Exempt amount for the lineItem. Returned only if the &#x60;taxInformation.showTaxPerLineItem&#x60; field is set to &#x60;Yes&#x60;.  | [optional] 
**TaxableAmount** | **string** | Portion of the item amount that is taxable.  | [optional] 
**TaxAmount** | **string** | Total tax for the item. This value is the sum of all taxes applied to the item.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

