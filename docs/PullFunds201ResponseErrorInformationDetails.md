# CyberSource.Model.PullFunds201ResponseErrorInformationDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | This is the flattened JSON object field name/path that is either missing or invalid.  | [optional] 
**Reason** | **string** | Possible reasons for the error.   Possible values: - AUTH_ALREADY_REVERSED - CONTACT_PROCESSOR - DEBIT_CARD_USAGE_LIMIT_EXCEEDED - EXCEEDS_AUTH_AMOUNT - EXCEEDS_CREDIT_LIMIT - EXPIRED_CARD - GENERAL_DECLINE - INSUFFICIENT_FUND - INVALID_CVN - INVALID_DATA - MISSING_AUTH - PARTIAL_APPROVAL - PROCESSOR_DECLINED - SERVER_ERROR - STOLEN_LOST_CARD - SUCCESS - UNAUTHORIZED_CARD  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

