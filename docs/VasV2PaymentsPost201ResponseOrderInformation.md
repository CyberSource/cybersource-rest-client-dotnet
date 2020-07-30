# CyberSource.Model.VasV2PaymentsPost201ResponseOrderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExemptAmount** | **string** | Total amount of tax exempt amounts. This value is the sum of the values for all the &#x60;orderInformation.lineItems[].exemptAmount&#x60; fields in the tax calculation request.  | [optional] 
**TaxableAmount** | **string** | Total amount of all taxable amounts. This value is the sum of the values for all the &#x60;orderInformation.lineItems[].taxAmount&#x60; fields in the tax calculation request.  | [optional] 
**TaxAmount** | **string** | Total amount of tax for all lineItems in the tax calculation request.  | [optional] 
**LineItems** | [**List&lt;VasV2PaymentsPost201ResponseOrderInformationLineItems&gt;**](VasV2PaymentsPost201ResponseOrderInformationLineItems.md) |  | [optional] 
**TaxDetails** | [**List&lt;VasV2PaymentsPost201ResponseOrderInformationTaxDetails&gt;**](VasV2PaymentsPost201ResponseOrderInformationTaxDetails.md) |  | [optional] 
**AmountDetails** | [**Ptsv2paymentsidreversalsReversalInformationAmountDetails**](Ptsv2paymentsidreversalsReversalInformationAmountDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

