# CyberSource.Model.Ptsv2paymentsAgreementInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgreementId** | **string** | Identifier for the mandate being signed for. This mandate id is required for all the subsequent transactions.  | [optional] 
**Id** | **string** | The processor specific billing agreement ID. References an approved recurring payment for goods or services. This value is sent by merchant via Cybersource to processor. The value sent in this field is procured by the merchant from the processor.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

