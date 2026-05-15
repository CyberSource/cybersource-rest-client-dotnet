# CyberSource.Model.Ptsv2paymentsProcessingInformationProgramIndicators
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuickPayment** | **bool?** | Indicator for when a Quick Payment transaction. A Quick Payment Service (QPS) Transaction is a magnetic stripe-based or contact chip-based face-to-face Mastercard POS transaction that occurs at a Peruvian merchant in an eligible merchant category and for an amount equal or less to the CVM limit.  This field is supported for Mastercard transactions in Peru.  Possible values: - &#x60;true&#x60;: This is a Quick Payment Service transaction - &#x60;false&#x60;: This is not a Quick Payment Service transaction  Default: null  | [optional] 
**QrInitiated** | **bool?** | Indicator that the transaction was made via QR Payment.  This field is supported for Mastercard QR e-commerce payment programs in Peru.  Possible values: - &#x60;true&#x60;: Transaction was initiated via QR code - &#x60;false&#x60;: Transaction was not initiated via QR code  Default: null  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

