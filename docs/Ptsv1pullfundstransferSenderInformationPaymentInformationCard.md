# CyberSource.Model.Ptsv1pullfundstransferSenderInformationPaymentInformationCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Three-digit value that indicates the card type. Mandatory if not present in a token.  Possible values: - &#x60;001&#x60;: Visa - &#x60;002&#x60;: Mastercard, Eurocard, which is a European regional brand of Mastercard. - &#x60;033&#x60;: Visa Electron - &#x60;024&#x60;: Maestro  | [optional] 
**SecurityCode** | **string** | 3-digit value that indicates the cardCvv2Value. Values can be 0-9.  | [optional] 
**Number** | **string** | The customer&#39;s payment card number, also known as the Primary Account Number (PAN).  Conditional: this field is required if not using tokens.  | [optional] 
**ExpirationMonth** | **string** | Two-digit month in which the payment card expires.  Format: &#x60;MM&#x60;.  Valid values: &#x60;01&#x60; through &#x60;12&#x60;. Leading 0 is required.   Conditional: this field is required if using neither a Customer nor Payment Instrument token.  | [optional] 
**ExpirationYear** | **string** | Four-digit year in which the payment card expires.  Format: &#x60;YYYY&#x60;.  Conditional: this field is required if using neither a Customer nor Payment Instrument token.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

