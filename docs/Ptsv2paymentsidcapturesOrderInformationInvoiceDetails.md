# CyberSource.Model.Ptsv2paymentsidcapturesOrderInformationInvoiceDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PurchaseOrderNumber** | **string** | Value used by your customer to identify the order. This value is typically a purchase order number. CyberSource recommends that you do not populate the field with all zeros or nines.  | [optional] 
**PurchaseOrderDate** | **string** | Date the order was processed. &#x60;Format: YYYY-MM-DD&#x60;.  | [optional] 
**PurchaseContactName** | **string** | The name of the individual or the company contacted for company authorized purchases.  | [optional] 
**Taxable** | **bool?** | Flag that indicates whether an order is taxable. This value must be true if the sum of all _lineItems[].taxAmount_ values &gt; 0.  If you do not include any &#x60;lineItems[].taxAmount&#x60; values in your request, CyberSource does not include &#x60;invoiceDetails.taxable&#x60; in the data it sends to the processor.  Possible values:  - **true**  - **false**  | [optional] 
**VatInvoiceReferenceNumber** | **string** | VAT invoice number associated with the transaction.  | [optional] 
**CommodityCode** | **string** | International description code of the overall order&#39;s goods or services or the Categorizes purchases for VAT reporting. Contact your acquirer for a list of codes.  | [optional] 
**TransactionAdviceAddendum** | [**List&lt;Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum&gt;**](Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

