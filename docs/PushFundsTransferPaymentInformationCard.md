# CyberSource.Model.PushFundsTransferPaymentInformationCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | - &#x60;001&#x60;: Visa - &#x60;002&#x60;: Mastercard, Eurocard, which is a European regional brand of Mastercard. - &#x60;033&#x60;: Visa Electron - &#x60;024&#x60;: Maestro - &#x60;042&#x60;: Maestro International  | [optional] 
**SecurityCode** | **string** | 4-digit value that indicates the cardCvv2Value. Values can be 0-9.  | [optional] 
**Number** | **string** | The customer&#39;s payment card number, also known as the Primary Account Number (PAN).  Conditional: this field is required if not using tokens.  | [optional] 
**ExpirationMonth** | **string** | Two-digit month in which the payment card expires.  Format: MM.  Valid values: 01 through 12. Leading 0 is required.  | [optional] 
**ExpirationYear** | **string** | Four-digit year in which the payment card expires.  Format: YYYY.  | [optional] 
**Customer** | [**PushFundsTransferPaymentInformationCardCustomer**](PushFundsTransferPaymentInformationCardCustomer.md) |  | [optional] 
**PaymentInstrument** | [**PushFundsTransferPaymentInformationCardPaymentInstrument**](PushFundsTransferPaymentInformationCardPaymentInstrument.md) |  | [optional] 
**InstrumentIdentifier** | [**PushFundsTransferPaymentInformationCardInstrumentIdentifier**](PushFundsTransferPaymentInformationCardInstrumentIdentifier.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

