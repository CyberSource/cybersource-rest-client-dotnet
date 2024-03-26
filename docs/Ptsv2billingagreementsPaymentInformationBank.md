# CyberSource.Model.Ptsv2billingagreementsPaymentInformationBank
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | [**Ptsv2billingagreementsPaymentInformationBankAccount**](Ptsv2billingagreementsPaymentInformationBankAccount.md) |  | [optional] 
**Iban** | **string** | International Bank Account Number (IBAN). #### SEPA Required for mandates services  | [optional] 
**SwiftCode** | **string** | Bank&#39;s SWIFT code. You can use this field only when scoring a direct debit transaction. #### BACS Required for mandates services  | [optional] 
**Scheme** | **string** | The scheme that sets the rules for the direct debit process. Possible values:   - SEPA   - BACS #### SEPA/BACS Required for mandates services  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

