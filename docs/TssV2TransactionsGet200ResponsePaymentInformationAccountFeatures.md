# CyberSource.Model.TssV2TransactionsGet200ResponsePaymentInformationAccountFeatures
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BalanceAmount** | **string** | Remaining balance on the account.  Returned by authorization service.  #### PIN debit Remaining balance on the prepaid card.  Returned by PIN debit purchase.  | [optional] 
**PreviousBalanceAmount** | **string** | Remaining balance on the account.  Returned by authorization service.  #### PIN debit Remaining balance on the prepaid card.  Returned by PIN debit purchase.  | [optional] 
**Currency** | **string** | Currency of the remaining balance on the account. For the possible values, see the [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  Returned by authorization service.  #### PIN debit Currency of the remaining balance on the prepaid card.  Returned by PIN debit purchase.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

