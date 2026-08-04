# CyberSource.Model.PtsV2PaymentsPost201ResponseEmbeddedActionsCONSUMERAUTHENTICATION
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status for payerAuthentication 201 enroll and validate calls. Possible values are: - &#x60;AUTHENTICATION_SUCCESSFUL&#x60; - &#x60;PENDING_AUTHENTICATION&#x60; - &#x60;AUTHENTICATION_FAILED&#x60;  | [optional] 
**Reason** | **string** | The reason of the status. Possible values are: - &#x60;INVALID_MERCHANT_CONFIGURATION&#x60; - &#x60;CONSUMER_AUTHENTICATION_REQUIRED&#x60; - &#x60;CONSUMER_AUTHENTICATION_FAILED&#x60; - &#x60;AUTHENTICATION_FAILED&#x60;  | [optional] 
**Message** | **string** | The message describing the reason of the status. Value is: - Encountered a Payer Authentication problem. Payer could not be authenticated.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

