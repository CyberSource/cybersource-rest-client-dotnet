# CyberSource.Model.PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **string** | Categorization of response message from processor  Possible Values: - &#x60;ISSUER_WILL_NEVER_APPROVE&#x60; - &#x60;ISSUER_CANNOT_APPROVE_AT_THIS_TIME&#x60; - &#x60;ISSUER_CANNOT_APPROVE_WITH_THESE_DETAILS&#x60; - &#x60;GENERIC_ERROR&#x60; - &#x60;PAYMENT_INSIGHTS_INTERNAL_ERROR&#x60; - &#x60;OTHERS&#x60; - &#x60;PAYMENT_INSIGHTS_RESPONSE_CATEGORY_MATCH_NOT_FOUND&#x60;  | [optional] 
**CategoryCode** | **string** | Categorization Code of response message from processor  Possible Values: - &#x60;01&#x60; : ISSUER_WILL_NEVER_APPROVE - &#x60;02&#x60; : ISSUER_CANNOT_APPROVE_AT_THIS_TIME - &#x60;03&#x60; : ISSUER_CANNOT_APPROVE_WITH_THESE_DETAILS - &#x60;04&#x60; : GENERIC_ERROR - &#x60;97&#x60; : PAYMENT_INSIGHTS_INTERNAL_ERROR - &#x60;98&#x60; : OTHERS - &#x60;99&#x60; : PAYMENT_INSIGHTS_RESPONSE_CATEGORY_MATCH_NOT_FOUND  | [optional] 
**ProcessorRawName** | **string** | Raw name of the processor used for the transaction processing, especially useful during acquirer swing to see which processor transaction settled with  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

