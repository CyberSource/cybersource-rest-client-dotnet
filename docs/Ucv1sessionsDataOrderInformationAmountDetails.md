# CyberSource.Model.Ucv1sessionsDataOrderInformationAmountDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalAmount** | **string** | This field defines the total order amount.  | [optional] 
**FreightAmount** | **string** | Total freight or shipping and handling charges for the order.  When you include this field in your request, you must also include the **totalAmount** field.  | [optional] 
**DutyAmount** | **string** | Total charges for any import or export duties included in the order.  | [optional] 
**DiscountAmount** | **string** | Total discount amount applied to the order.  | [optional] 
**TaxAppliedAfterDiscount** | **string** | Flag that indicates how the merchant manages discounts.  Possible values:   - **0**: no invoice level discount included  - **1**: tax calculated on the postdiscount invoice total  - **2**: tax calculated on the prediscount invoice total  | [optional] 
**TaxAppliedLevel** | **string** | Flag that indicates how you calculate tax.  Possible values:   - **0**: net prices with tax calculated at line item level  - **1**: net prices with tax calculated at invoice level  - **2**: gross prices with tax provided at line item level  - **3**: gross prices with tax provided at invoice level  - **4**: no tax applies on the invoice for the transaction  | [optional] 
**Currency** | **string** | This field defines the currency applicable to the order.  | [optional] 
**Surcharge** | [**Upv1capturecontextsDataOrderInformationAmountDetailsSurcharge**](Upv1capturecontextsDataOrderInformationAmountDetailsSurcharge.md) |  | [optional] 
**SubTotalAmount** | **string** | This field defines the sub total amount applicable to the order.  | [optional] 
**ServiceFeeAmount** | **string** | This field defines the service fee amount applicable to the order.  | [optional] 
**TaxAmount** | **string** | This field defines the tax amount applicable to the order.  | [optional] 
**TaxDetails** | [**List&lt;Ucv1sessionsDataOrderInformationAmountDetailsTaxDetails&gt;**](Ucv1sessionsDataOrderInformationAmountDetailsTaxDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

