# CyberSource.Model.UnifiedriskTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | Unique identifier for the transaction being assessed | [optional] 
**Status** | **string** | Transaction status: NEW, APPROVED, DECLINED, REVERSED, FRAUD | [optional] 
**StatusReason** | **string** | Reason code for the transaction status | [optional] 
**MessageType** | **string** | Message type: AUTHORIZATION, INQUIRY, ADVICE, REVERSAL | [optional] 
**Type** | **string** | The type of transaction being processed | [optional] 
**Attribute** | **string** | Transaction attribute: AGGREGATION, CARDLESS_ATM, etc | [optional] 
**Initiator** | **string** | Who initiated transaction: MERCHANT, CUSTOMER | [optional] 
**Channel** | **string** | Channel used: ONLINE, MOBILE, ATM, BRANCH, etc | [optional] 
**Timestamp** | **DateTime?** | Local transaction timestamp without timezone | [optional] 
**CutoffDateTime** | **DateTime?** | Cutoff date/time for event or journey | [optional] 
**IsRecurring** | **bool?** | Indicates if this is a recurring transaction | [optional] 
**PreOrder** | **bool?** | Indicates if this is a pre-order | [optional] 
**PreOrderDate** | **DateTime?** | Expected availability date for pre-order | [optional] 
**Reordered** | **bool?** | Indicates if customer is reordering | [optional] 
**DestinationCountry** | **string** | Destination country for funds | [optional] 
**DeclinePhase** | **string** | Phase where transaction was declined | [optional] 
**TrustedMerchant** | **bool?** | Indicates if merchant is on trusted list | [optional] 
**AdditionalFees** | [**UnifiedriskTransactionAdditionalFees**](UnifiedriskTransactionAdditionalFees.md) |  | [optional] 
**Amount** | [**UnifiedriskTransactionAmount**](UnifiedriskTransactionAmount.md) |  | [optional] 
**RecurringDetails** | [**UnifiedriskTransactionRecurringDetails**](UnifiedriskTransactionRecurringDetails.md) |  | [optional] 
**Direction** | **string** | Direction of the transaction flow relative to the customer&#39;s account (e.g., CREDIT for incoming funds, DEBIT for outgoing funds). Determines risk model orientation and velocity tracking | [optional] 
**IsChargeback** | **bool?** | Indicates whether this transaction represents a chargeback or dispute reversal. True signals a disputed transaction requiring fraud investigation and issuer liability assessment | [optional] 
**FraudLiability** | **string** | Indicates which party bears fraud liability for this transaction (e.g., ISSUER, MERCHANT, ACQUIRER). Liability shifts apply in 3DS-authenticated or EMV chip transactions | [optional] 
**OnUsFlag** | **bool?** | Indicates whether the transaction is an on-us transaction where the issuing and acquiring institutions are the same entity. On-us transactions may follow different risk rules and processing paths | [optional] 
**NumberOfTransactions** | **int?** | Total count of transactions associated with this batch, order, or session. Used for velocity-based risk rules and aggregated fraud monitoring | [optional] 
**BatchDetails** | [**UnifiedriskTransactionBatchDetails**](UnifiedriskTransactionBatchDetails.md) |  | [optional] 
**CheckDetails** | [**UnifiedriskTransactionCheckDetails**](UnifiedriskTransactionCheckDetails.md) |  | [optional] 
**Purpose** | **string** | Business purpose or reason code for this transaction (e.g., PURCH for purchase, SALA for salary, REFND for refund). Used for transaction classification and AML monitoring | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

