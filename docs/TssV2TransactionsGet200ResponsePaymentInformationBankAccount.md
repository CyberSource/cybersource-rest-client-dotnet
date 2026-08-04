# CyberSource.Model.TssV2TransactionsGet200ResponsePaymentInformationBankAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Suffix** | **string** | Last four digits of the customer&#39;s payment account number.  | [optional] 
**Prefix** | **string** | Bank Identification Number (BIN). This is the initial four to six numbers on a credit card account number.  | [optional] 
**CheckNumber** | **string** | Check number.  Chase Paymentech Solutions - Optional. CyberSource ACH Service - Not used. RBS WorldPay Atlanta - Optional on debits. Required on credits. TeleCheck - Strongly recommended on debit requests. Optional on credits.  | [optional] 
**Type** | **string** | Account type.  Possible values:  - **C**: Checking.  - **G**: General ledger. This value is supported only on Wells Fargo ACH.  - **S**: Savings (U.S. dollars only).  - **X**: Corporate checking (U.S. dollars only).  | [optional] 
**Name** | **string** | Name used on the bank account. You can use this field only when scoring a direct debit transaction  | [optional] 
**CheckDigit** | **string** | Code used to validate the customer&#39;s account number. Required for some countries if you do not or are not allowed to provide the IBAN instead. You may use this field only when scoring a direct debit transaction.  | [optional] 
**EncoderId** | **string** | Identifier for the bank that provided the customer&#39;s encoded account number.  To obtain the bank identifier, contact your processor.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

