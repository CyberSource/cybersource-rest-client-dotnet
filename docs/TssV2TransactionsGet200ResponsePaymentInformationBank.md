# CyberSource.Model.TssV2TransactionsGet200ResponsePaymentInformationBank
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RoutingNumber** | **string** | Bank routing number. This is also called the transit number.  | [optional] 
**BranchCode** | **string** | Code used to identify the branch of the customer&#39;s bank. Required for some countries if you do not or are not allowed to provide the IBAN. Use this field only when scoring a direct debit transaction.  | [optional] 
**SwiftCode** | **string** | Bank&#39;s SWIFT code. You can use this field only when scoring a direct debit transaction. Required only for crossborder transactions.  | [optional] 
**BankCode** | **string** | Country-specific code used to identify the customer&#39;s bank. Required for some countries if you do not or are not allowed to provide the IBAN instead. You can use this field only when scoring a direct debit transaction.  | [optional] 
**Iban** | **string** | International Bank Account Number (IBAN) for the bank account. For some countries you can provide this number instead of the traditional bank account information. You can use this field only when scoring a direct debit transaction.  | [optional] 
**Account** | [**TssV2TransactionsGet200ResponsePaymentInformationBankAccount**](TssV2TransactionsGet200ResponsePaymentInformationBankAccount.md) |  | [optional] 
**Mandate** | [**TssV2TransactionsGet200ResponsePaymentInformationBankMandate**](TssV2TransactionsGet200ResponsePaymentInformationBankMandate.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

