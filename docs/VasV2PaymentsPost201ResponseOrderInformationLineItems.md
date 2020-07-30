# CyberSource.Model.VasV2PaymentsPost201ResponseOrderInformationLineItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaxDetails** | [**List&lt;VasV2PaymentsPost201ResponseOrderInformationTaxDetails&gt;**](VasV2PaymentsPost201ResponseOrderInformationTaxDetails.md) |  | [optional] 
**Jurisdiction** | [**List&lt;VasV2PaymentsPost201ResponseOrderInformationJurisdiction&gt;**](VasV2PaymentsPost201ResponseOrderInformationJurisdiction.md) |  | [optional] 
**ExemptAmount** | **string** | Exempt amount for the lineItem. Returned only if the &#x60;taxInformation.showTaxPerLineItem&#x60; field is set to &#x60;Yes&#x60;.  | [optional] 
**TaxableAmount** | **string** | Portion of the item amount that is taxable.  | [optional] 
**TaxAmount** | **string** | Total tax for the item. This value is the sum of all taxes applied to the item.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

