# CyberSource.Model.TssV2TransactionsGet200ResponseBankAccountValidation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RawValidationCode** | **int?** | Raw Validation Codes for routing number and account number      Possible values:     • -1: Unable to perform validation/Unknown error     • -2: Service Unavailable     • 12 to 16: Validation results  | [optional] 
**ResultCode** | **int?** | Result codes for account number and routing number      Possible values: 00, 04, 98, 99  | [optional] 
**ResultMessage** | **string** |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

