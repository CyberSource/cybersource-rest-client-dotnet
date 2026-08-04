# CyberSource.Model.Ucv1sessionsDataSenderInformationAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | The account number of the entity funding the transaction. The value for this field can be a payment card account number or bank account number.  | [optional] 
**FundsSource** | **string** | Source of funds. Possible Values:  - &#x60;01&#x60;: Credit.  - &#x60;02&#x60;: Debit.  - &#x60;03&#x60;: Prepaid.  - &#x60;04&#x60;: Deposit Account.  - &#x60;05&#x60;: Mobile Money Account.  - &#x60;06&#x60;: Cash.  - &#x60;07&#x60;: Other.  - &#x60;V5&#x60;: Debits / deposit access other than those linked to the cardholders&#39; scheme.  - &#x60;V6&#x60;: Credit accounts other than those linked to the cardholder&#39;s scheme.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

