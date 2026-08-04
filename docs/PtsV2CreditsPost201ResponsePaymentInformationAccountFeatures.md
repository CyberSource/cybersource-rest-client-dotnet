# CyberSource.Model.PtsV2CreditsPost201ResponsePaymentInformationAccountFeatures
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **string** | Card type category. Type of card used in the transaction. Possible values: - &#x60;B&#x60;: Business card. - &#x60;O&#x60;: Noncommercial card. - &#x60;R&#x60;: Corporate card. - &#x60;S&#x60;: Purchase card. - &#x60;X&#x60;: Visa B2B Virtual Payments - &#x60;X1&#x60;: Flexible Rate B2B Virtual Program - &#x60;Blank&#x60;: Purchase card not supported.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

