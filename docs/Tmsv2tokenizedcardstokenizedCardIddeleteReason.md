# CyberSource.Model.Tmsv2tokenizedcardstokenizedCardIddeleteReason
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Reason code for deleting the network token.  Possible Values:   - FRAUD: Network token is being deleted due to fraud concerns.   - PAYMENT_METHOD_REMOVED: Network Token is being deleted because the payment method was removed.  Default: PAYMENT_METHOD_REMOVED  | [optional] 
**Description** | **string** | Additional description providing context for the deletion reason.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

