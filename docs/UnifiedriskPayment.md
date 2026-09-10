# CyberSource.Model.UnifiedriskPayment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | **string** | Payment method: CARD, BANK_ACCOUNT, WALLET | [optional] 
**CustomerId** | **string** | Payment customer token ID | [optional] 
**CustomerIdLegacy** | **string** | Legacy customer ID for payment tokenization | [optional] 
**Card** | [**UnifiedriskPaymentCard**](UnifiedriskPaymentCard.md) |  | [optional] 
**Verification** | [**UnifiedriskPaymentVerification**](UnifiedriskPaymentVerification.md) |  | [optional] 
**Wallet** | [**UnifiedriskPaymentWallet**](UnifiedriskPaymentWallet.md) |  | [optional] 
**BankAccount** | [**UnifiedriskPaymentBankAccount**](UnifiedriskPaymentBankAccount.md) |  | [optional] 
**Counterparty** | [**UnifiedriskPaymentCounterparty**](UnifiedriskPaymentCounterparty.md) |  | [optional] 
**Approvals** | [**UnifiedriskPaymentApprovals**](UnifiedriskPaymentApprovals.md) |  | [optional] 
**Bank** | **Object** | Container for additional bank-specific information related to the payment, including routing codes, clearing house details, and bank-specific metadata | [optional] 
**Token** | [**UnifiedriskPaymentToken**](UnifiedriskPaymentToken.md) |  | [optional] 
**Batch** | [**UnifiedriskPaymentBatch**](UnifiedriskPaymentBatch.md) |  | [optional] 
**SubMethod** | **string** | The specific sub-type of the payment method used (e.g., SEPA_CREDIT_TRANSFER, FASTER_PAYMENTS, ACH_NEXT_DAY). Provides granular detail within the broader payment method | [optional] 
**Purpose** | **string** | The business or regulatory purpose code for the payment (e.g., SUPP for supplier payment, SALA for salary, CHAR for charity). Used for AML monitoring and regulatory reporting | [optional] 
**ClearingSpeed** | **string** | Indicates the speed at which the payment will be cleared and settled (e.g., REAL_TIME, SAME_DAY, NEXT_DAY, STANDARD). Faster clearing speeds on large amounts may indicate fraud | [optional] 
**ExecutionTimestamp** | **string** | The date and time when the payment execution was initiated or scheduled by the payer or payment system, in ISO 8601 format | [optional] 
**GroupId** | **string** | An identifier linking multiple related payments into a logical group (e.g., bulk payroll run ID, campaign payment group). Used for aggregated risk monitoring | [optional] 
**Check** | [**UnifiedriskPaymentCheck**](UnifiedriskPaymentCheck.md) |  | [optional] 
**Wire** | [**UnifiedriskPaymentWire**](UnifiedriskPaymentWire.md) |  | [optional] 
**Type** | **string** | Specifies the underlying payment instrument type for this transaction (e.g., CARD, BANK_TRANSFER, CHECK, WIRE, ACH). Used for routing to the appropriate risk model and clearing network | [optional] 
**Sdk** | [**UnifiedriskPaymentSdk**](UnifiedriskPaymentSdk.md) |  | [optional] 
**LocationId** | **string** | Physical location (branch or ATM) in which the activity took place (if that&#39;s a physical branch). Identifier for staff location, site, or service centre. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

