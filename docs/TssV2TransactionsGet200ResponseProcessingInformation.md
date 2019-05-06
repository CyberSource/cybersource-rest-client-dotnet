# CyberSource.Model.TssV2TransactionsGet200ResponseProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentSolution** | **string** | Type of digital payment solution for the transaction. Possible Values:   - **visacheckout**: Visa Checkout. This value is required for Visa Checkout transactions. See Visa Checkout Using the SCMP API.  - **005**: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. See \&quot;Masterpass,\&quot; page 153.  | [optional] 
**CommerceIndicator** | **string** | Type of transaction. Some payment card companies use this information when determining discount rates. When you omit this field for **Ingenico ePayments**, the processor uses the default transaction type they have on file for you instead of the default value listed here.  | [optional] 
**BusinessApplicationId** | **string** | The description for this field is not available. | [optional] 
**AuthorizationOptions** | [**TssV2TransactionsGet200ResponseProcessingInformationAuthorizationOptions**](TssV2TransactionsGet200ResponseProcessingInformationAuthorizationOptions.md) |  | [optional] 
**BankTransferOptions** | [**TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions**](TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

