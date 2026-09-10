# CyberSource.Model.UnifiedriskPaymentBankAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Account type: CHECKING, SAVINGS, CORPORATE, etc | [optional] 
**Number** | **string** | Masked or tokenized account number | [optional] 
**NumberFormat** | **string** | Account number format: IBAN, BBAN, etc | [optional] 
**RoutingNumber** | **string** | Bank routing/transit number | [optional] 
**Iban** | **string** | International Bank Account Number | [optional] 
**SwiftCode** | **string** | Bank SWIFT/BIC code | [optional] 
**BankCode** | **string** | Bank code | [optional] 
**CheckNumber** | **string** | Check number for check payments | [optional] 
**CheckImageReference** | **string** | Check image reference number | [optional] 
**EncoderId** | **string** | Bank encoder identifier for encoded account numbers | [optional] 
**BranchId** | **string** | Bank branch identifier | [optional] 
**Flags** | **List&lt;string&gt;** | Account flags: VIP, COMPROMISED, etc | [optional] 
**AccountHolderName** | **string** | Full name of the person or business that owns the bank account | [optional] 
**AddedAtCheckout** | **bool?** | Whether the bank account was newly entered during checkout | [optional] 
**FinancialInstitution** | [**UnifiedriskPaymentBankAccountFinancialInstitution**](UnifiedriskPaymentBankAccountFinancialInstitution.md) |  | [optional] 
**BalanceBefore** | [**UnifiedriskPaymentBankAccountBalanceBefore**](UnifiedriskPaymentBankAccountBalanceBefore.md) |  | [optional] 
**CreditLimit** | [**UnifiedriskPaymentBankAccountCreditLimit**](UnifiedriskPaymentBankAccountCreditLimit.md) |  | [optional] 
**BranchAddress** | [**UnifiedriskPaymentBankAccountBranchAddress**](UnifiedriskPaymentBankAccountBranchAddress.md) |  | [optional] 
**SubType** | **string** | Sub-category of the bank account type providing more specific classification (e.g., PERSONAL_CHECKING, BUSINESS_SAVINGS, CORPORATE_CURRENT). Used for risk segmentation within account types | [optional] 
**AccountOpenDate** | **string** | Date when the bank account was originally opened, in ISO 8601 format (YYYY-MM-DD). Account tenure is a key risk factor - newer accounts carry higher fraud risk | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

