# CyberSource.Model.Riskv1decisionsOrderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountDetails** | [**Riskv1decisionsOrderInformationAmountDetails**](Riskv1decisionsOrderInformationAmountDetails.md) |  | [optional] 
**PreOrder** | **string** | Indicates whether cardholder is placing an order with a future availability or release date. This field can contain one of these values: - MERCHANDISE_AVAILABLE: Merchandise available - FUTURE_AVAILABILITY: Future availability  | [optional] 
**PreOrderDate** | **string** | Expected date that a pre-ordered purchase will be available. Format: YYYYMMDD  | [optional] 
**Reordered** | **bool?** | Indicates whether the cardholder is reordering previously purchased merchandise. This field can contain one of these values: - false: First time ordered - true: Reordered  | [optional] 
**ShippingDetails** | [**Riskv1decisionsOrderInformationShippingDetails**](Riskv1decisionsOrderInformationShippingDetails.md) |  | [optional] 
**ShipTo** | [**Riskv1decisionsOrderInformationShipTo**](Riskv1decisionsOrderInformationShipTo.md) |  | [optional] 
**ReturnsAccepted** | **bool?** | Boolean that indicates whether returns are accepted for this order. This field can contain one of the following values: - true: Returns are accepted for this order. - false: Returns are not accepted for this order.  | [optional] 
**LineItems** | [**List&lt;Riskv1decisionsOrderInformationLineItems&gt;**](Riskv1decisionsOrderInformationLineItems.md) | This array contains detailed information about individual products in the order. | [optional] 
**BillTo** | [**Riskv1decisionsOrderInformationBillTo**](Riskv1decisionsOrderInformationBillTo.md) |  | [optional] 
**TotalOffersCount** | **string** | Total number of articles/items in the order as a numeric decimal count. Possible values: 00 - 99  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

