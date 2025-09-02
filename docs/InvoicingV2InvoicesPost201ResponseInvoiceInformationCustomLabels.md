# CyberSource.Model.InvoicingV2InvoicesPost201ResponseInvoiceInformationCustomLabels
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The invoice field key. Possible values:   - billTo   - invoiceNumber   - customerId   - companyName   - description   - shipping   - partialPayment   - discount   - tax  | [optional] 
**Value** | **string** | The new (overridden) field name | [optional] 
**Hidden** | **bool?** | Hides the specified field. This field is applicable for keys:   - customerId   - companyName   - description   - shipping   - partialPayment  | [optional] [default to false]
**HiddenForInvoice** | **bool?** | Hides the field at invoice level. This field is applicable for keys:   - discount   - tax  | [optional] [default to false]
**HiddenForItem** | **bool?** | Hides the field at invoice item level. This field is applicable for keys:   - discount   - tax  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

