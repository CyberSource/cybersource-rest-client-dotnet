# CyberSource.Model.UnifiedriskRiskAssessmentBuyerHistory
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountPurchases** | **int?** | Number of purchases with this cardholder account during the previous six months. Recommended for Discover ProtectBuy. | [optional] 
**AddCardAttempts** | **int?** | Number of add card attempts in the last 24 hours. Recommended for Discover ProtectBuy. | [optional] 
**PriorSuspiciousActivity** | **bool?** | Indicates whether the merchant experienced suspicious activity (including previous fraud) on the account. Recommended for Discover ProtectBuy. | [optional] 
**PaymentAccountHistory** | **string** | This only applies for NEW_ACCOUNT and EXISTING_ACCOUNT in creationHistory. Possible values are: - PAYMENT_ACCOUNT_EXISTS - PAYMENT_ACCOUNT_ADDED_NOW | [optional] 
**PaymentAccountDate** | **int?** | Date applicable only for PAYMENT_ACCOUNT_EXISTS in paymentAccountHistory | [optional] 
**TransactionCountDay** | **int?** | Number of transaction (successful or abandoned) for this cardholder account within the last 24 hours. Recommended for Discover ProtectBuy. | [optional] 
**TransactionCountYear** | **int?** | Number of transaction (successful or abandoned) for this cardholder account within the last year. Recommended for Discover ProtectBuy. | [optional] 
**CustomerAccount** | [**UnifiedriskRiskAssessmentBuyerHistoryCustomerAccount**](UnifiedriskRiskAssessmentBuyerHistoryCustomerAccount.md) |  | [optional] 
**AccountHistory** | [**UnifiedriskRiskAssessmentBuyerHistoryAccountHistory**](UnifiedriskRiskAssessmentBuyerHistoryAccountHistory.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

