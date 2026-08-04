# CyberSource.Model.TssV2TransactionsGet200ResponseTokenInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Customer** | [**PtsV2PaymentsPost201ResponseTokenInformationCustomer**](PtsV2PaymentsPost201ResponseTokenInformationCustomer.md) |  | [optional] 
**PaymentInstrument** | [**PtsV2PaymentsPost201ResponseTokenInformationPaymentInstrument**](PtsV2PaymentsPost201ResponseTokenInformationPaymentInstrument.md) |  | [optional] 
**ShippingAddress** | [**PtsV2PaymentsPost201ResponseTokenInformationShippingAddress**](PtsV2PaymentsPost201ResponseTokenInformationShippingAddress.md) |  | [optional] 
**InstrumentIdentifier** | [**TssV2TransactionsGet200ResponsePaymentInformationInstrumentIdentifier**](TssV2TransactionsGet200ResponsePaymentInformationInstrumentIdentifier.md) |  | [optional] 
**Jti** | **string** | TMS Transient Token, 64 hexadecimal id value representing captured payment credentials (including Sensitive Authentication Data, e.g. CVV).  | [optional] 
**TransientTokenJwt** | **string** | Flex API Transient Token encoded as JWT (JSON Web Token), e.g. Flex microform or Unified Payment checkout result.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

