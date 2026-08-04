# CyberSource.Model.PullFundsReversal201ResponseErrorInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | The reason of the status.  Possible values: - EXPIRED_CARD - PROCESSOR_DECLINED - STOLEN_LOST_CARD - UNAUTHORIZED_CARD - CVN_NOT_MATCH - INVALID_CVN - BLACKLISTED_CUSTOMER - INVALID_ACCOUNT - GENERAL_DECLINE - RISK_CONTROL_DECLINE - PROCESSOR_RISK_CONTROL_DECLINE - DEBIT_CARD_USAGE_EXCEEDED_LIMIT  | [optional] 
**Message** | **string** | The detail message related to the status and reason listed above.  | [optional] 
**Details** | [**List&lt;PullFundsReversal201ResponseErrorInformationDetails&gt;**](PullFundsReversal201ResponseErrorInformationDetails.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

