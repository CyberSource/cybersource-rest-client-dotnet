# CyberSource.Model.Ptsv2billingagreementsPaymentInformationPaymentType
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | [**Ptsv2billingagreementsPaymentInformationPaymentTypeMethod**](Ptsv2billingagreementsPaymentInformationPaymentTypeMethod.md) |  | [optional] 
**Name** | **string** | A Payment Type is an agreed means for a payee to receive legal tender from a payer. The way one pays for a commercial financial transaction. Examples: Card, Bank Transfer, Digital, Direct Debit. Possible values: - &#x60;EWALLET&#x60; - &#x60;directDebitSepa&#x60; - &#x60;directDebitBacs&#x60; #### SEPA/BACS Required for mandates services #### Paypal Required for billing agreements  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

