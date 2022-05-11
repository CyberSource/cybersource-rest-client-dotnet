# CyberSource.Model.Ptsv2paymentsOrderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountDetails** | [**Ptsv2paymentsOrderInformationAmountDetails**](Ptsv2paymentsOrderInformationAmountDetails.md) |  | [optional] 
**BillTo** | [**Ptsv2paymentsOrderInformationBillTo**](Ptsv2paymentsOrderInformationBillTo.md) |  | [optional] 
**ShipTo** | [**Ptsv2paymentsOrderInformationShipTo**](Ptsv2paymentsOrderInformationShipTo.md) |  | [optional] 
**LineItems** | [**List&lt;Ptsv2paymentsOrderInformationLineItems&gt;**](Ptsv2paymentsOrderInformationLineItems.md) |  | [optional] 
**InvoiceDetails** | [**Ptsv2paymentsOrderInformationInvoiceDetails**](Ptsv2paymentsOrderInformationInvoiceDetails.md) |  | [optional] 
**ShippingDetails** | [**Ptsv2paymentsOrderInformationShippingDetails**](Ptsv2paymentsOrderInformationShippingDetails.md) |  | [optional] 
**ReturnsAccepted** | **bool?** | This is only needed when you are requesting both payment and DM service at same time.  Boolean that indicates whether returns are accepted for this order. This field can contain one of the following values: - true: Returns are accepted for this order. - false: Returns are not accepted for this order.  | [optional] 
**IsCryptocurrencyPurchase** | **string** | #### Visa Platform Connect : This API will contain the Flag that specifies whether the payment is for the purchase of cryptocurrency. Additional values to add : This API will contain the Flag that specifies whether the payment is for the purchase of cryptocurrency. valid values are - Y/y, true - N/n, false  | [optional] 
**PreOrder** | **string** | Indicates whether cardholder is placing an order with a future availability or release date. This field can contain one of these values: - MERCHANDISE_AVAILABLE: Merchandise available - FUTURE_AVAILABILITY: Future availability  | [optional] 
**PreOrderDate** | **string** | Expected date that a pre-ordered purchase will be available. Format: YYYYMMDD  | [optional] 
**Reordered** | **bool?** | Indicates whether the cardholder is reordering previously purchased merchandise. This field can contain one of these values: - false: First time ordered - true: Reordered  | [optional] 
**TotalOffersCount** | **string** | Total number of articles/items in the order as a numeric decimal count. Possible values: 00 - 99  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

