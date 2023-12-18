# CyberSource.Model.Ptsv1pushfundstransferRecipientInformationPaymentInformationCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Three-digit value that indicates the card type. Mandatory if not present in a token.  Possible values:  Visa Platform Connect - &#x60;001&#x60;: Visa - &#x60;002&#x60;: Mastercard, Eurocard, which is a European regional brand of Mastercard. - &#x60;033&#x60;: Visa Electron - &#x60;024&#x60;: Maestro  Mastercard Send: - &#x60;002&#x60;: Mastercard, Eurocard, which is a European regional brand of Mastercard.  FDC Compass: - &#x60;001&#x60;: Visa - &#x60;002&#x60;: Mastercard, Eurocard, which is a European regional brand of Mastercard.  Chase Paymentech: - &#x60;001&#x60;: Visa - &#x60;002&#x60;: Mastercard, Eurocard, which is a European regional brand of Mastercard.  | [optional] 
**SecurityCode** | **string** | 3-digit value that indicates the cardCvv2Value. Values can be 0-9.  | [optional] 
**Number** | **string** | The customer&#39;s payment card number, also known as the Primary Account Number (PAN).  Conditional: this field is required if not using tokens.  | [optional] 
**ExpirationMonth** | **string** | Two-digit month in which the payment card expires.  Format: MM.  Valid values: 01 through 12. Leading 0 is required.  | [optional] 
**ExpirationYear** | **string** | Four-digit year in which the payment card expires.  Format: YYYY.  | [optional] 
**Customer** | [**Ptsv1pushfundstransferRecipientInformationPaymentInformationCardCustomer**](Ptsv1pushfundstransferRecipientInformationPaymentInformationCardCustomer.md) |  | [optional] 
**PaymentInstrument** | [**Ptsv1pushfundstransferRecipientInformationPaymentInformationCardPaymentInstrument**](Ptsv1pushfundstransferRecipientInformationPaymentInformationCardPaymentInstrument.md) |  | [optional] 
**InstrumentIdentifier** | [**Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier**](Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

