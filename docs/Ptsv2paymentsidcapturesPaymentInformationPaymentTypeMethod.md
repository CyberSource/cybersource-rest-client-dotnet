# CyberSource.Model.Ptsv2paymentsidcapturesPaymentInformationPaymentTypeMethod
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A Payment Type is enabled through a Method. Examples: Visa, Master Card, ApplePay, iDeal, 7Eleven, alfamart, bofaPayByBank, payToPayByBank, etc  For Japan Payment Processing Valid Values: - 1 Banking Data - 2 Authorization Data  #### Via KCP - &#x60;KCP&#x60; : Local Card, Bank Transfer and Carrier Billing. - &#x60;PAYCO&#x60; - &#x60;KAKAOPAY&#x60; - &#x60;NAVERPAY&#x60;  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

