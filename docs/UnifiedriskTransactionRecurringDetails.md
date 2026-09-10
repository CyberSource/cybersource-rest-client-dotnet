# CyberSource.Model.UnifiedriskTransactionRecurringDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Frequency** | **int?** | Days between recurring payments | [optional] 
**Occurrence** | **string** | Recurring frequency code: DAILY, WEEKLY, MONTHLY, etc | [optional] 
**EndDate** | **DateTime?** | Date when recurring payments end | [optional] 
**NumberOfPayments** | **int?** | Total number of payments in recurring series | [optional] 
**SequenceNumber** | **int?** | Current sequence number in recurring series | [optional] 
**Type** | **string** | Recurring type: REGISTRATION, SUBSEQUENT, MODIFICATION, CANCELLATION | [optional] 
**ValidationIndicator** | **string** | Indicates if recurring payment was validated | [optional] 
**AmountType** | **string** | Amount type: FIXED, VARIABLE_WITH_MAX | [optional] 
**MaximumAmount** | **decimal?** | Maximum amount for variable recurring payments | [optional] 
**OriginalPurchaseDate** | **DateTime?** | Date of original recurring purchase | [optional] 
**ReferenceNumber** | **string** | Reference number for recurring payment | [optional] 
**FirstPaymentDate** | **string** | Date of the first payment in a recurring series, in ISO 8601 format (YYYY-MM-DD). Used to establish the anchor date for recurring payment scheduling and risk assessment | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

