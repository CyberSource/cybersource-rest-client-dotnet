# CyberSource.Model.Ptsv2paymentsidcapturesProcessingInformationJapanPaymentOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentMethod** | **string** | This value is a 2-digit code indicating the payment method. Use Payment Method Code value that applies to the tranasction. - 10 (One-time payment) - 21, 22, 23, 24  (Bonus(one-time)payment) - 61 (Installment payment) - 31, 32, 33, 34  (Integrated (Bonus + Installment)payment) - 80 (Revolving payment)  | [optional] 
**Bonuses** | **string** | Field contains the number of bonuses.  | [optional] 
**Installments** | **string** | Number of Installments.  | [optional] 
**FirstBillingMonth** | **string** | Billing month in MM format.  | [optional] 
**BonusAmount** | **string** | This field contains the bonus amount.  | [optional] 
**BonusMonth** | **string** | This field contains the Japan specific first bonus month.  | [optional] 
**SecondBonusAmount** | **string** | Field contains the second bonus amount.  | [optional] 
**SecondBonusMonth** | **string** | Field contains the Japan specific second bonus month.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

