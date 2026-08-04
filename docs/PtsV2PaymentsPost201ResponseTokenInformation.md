# CyberSource.Model.PtsV2PaymentsPost201ResponseTokenInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentidentifierNew** | **bool?** | A value of true means the card number or bank account used to create an Instrument Identifier was new and did not already exist in the token vault. A value of false means the card number or bank account used to create an Instrument Identifier already existed in the token vault.  | [optional] 
**Customer** | [**PtsV2PaymentsPost201ResponseTokenInformationCustomer**](PtsV2PaymentsPost201ResponseTokenInformationCustomer.md) |  | [optional] 
**PaymentInstrument** | [**PtsV2PaymentsPost201ResponseTokenInformationPaymentInstrument**](PtsV2PaymentsPost201ResponseTokenInformationPaymentInstrument.md) |  | [optional] 
**ShippingAddress** | [**PtsV2PaymentsPost201ResponseTokenInformationShippingAddress**](PtsV2PaymentsPost201ResponseTokenInformationShippingAddress.md) |  | [optional] 
**InstrumentIdentifier** | [**PtsV2PaymentsPost201ResponseTokenInformationInstrumentIdentifier**](PtsV2PaymentsPost201ResponseTokenInformationInstrumentIdentifier.md) |  | [optional] 
**ThirdPartyToken** | [**PtsV2PaymentsPost201ResponseTokenInformationThirdPartyToken**](PtsV2PaymentsPost201ResponseTokenInformationThirdPartyToken.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

