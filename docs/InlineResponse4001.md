# CyberSource.Model.InlineResponse4001
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** |  | [optional] 
**Details** | [**List&lt;InlineResponse4001Details&gt;**](InlineResponse4001Details.md) |  | [optional] 
**InformationLink** | **string** |  | [optional] 
**Message** | **string** |  | 
**Reason** | **string** | Possible values: - INVALID_APIKEY - INVALID_SHIPPING_INPUT_PARAMS - CAPTURE_CONTEXT_INVALID - CAPTURE_CONTEXT_EXPIRED - SDK_XHR_ERROR - UNIFIEDPAYMENTS_VALIDATION_PARAMS - UNIFIEDPAYMENTS_VALIDATION_FIELDS - UNIFIEDPAYMENT_PAYMENT_PARAMITERS - CREATE_TOKEN_TIMEOUT - CREATE_TOKEN_XHR_ERROR - SHOW_LOAD_CONTAINER_SELECTOR - SHOW_LOAD_INVALID_CONTAINER - SHOW_TOKEN_TIMEOUT - SHOW_TOKEN_XHR_ERROR - SHOW_PAYMENT_TIMEOUT | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

