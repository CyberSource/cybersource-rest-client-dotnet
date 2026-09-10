# CyberSource.Model.InlineResponse2013OrderInformationAmountDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarkupRate** | **string** | The markup between the offer exchange rate and wholesale rates, i.e. the mark up. Expressed as a percentage of 100, e.g. 3.75.  If the markup value is not supplied in the API, and the Acquiring BIN is provided, the markup configured during onboarding will be picked up and applied to the transaction. To override any markup defaults set up on the account, always send a markup value of 0.00 to indicate 0% markup.   Supported by Visa Direct.  | [optional] 
**ExchangeRate** | **string** | Exchange rate returned by the card network. | [optional] 
**OriginalAmount** | **string** | Amount in your original local pricing currency.  This value cannot be negative. You can include a decimal point (.) in this field to denote the currency exponent, but you cannot include any other special characters.  If needed, CyberSource truncates the amount to the correct number of decimal places.  | [optional] 
**DestinationAmount** | **string** | Amount in your destination&#39;s local pricing currency.  This value cannot be negative. You can include a decimal point (.) in this field to denote the currency exponent, but you cannot include any other special characters.  If needed, CyberSource truncates the amount to the correct number of decimal places.  | [optional] 
**OriginalAmountWithoutMarkup** | **string** | Original Transaction Amount excluding markup in source currency. This field will be returned in a source-to-destination inquiry response when markup is applicable.  Supported by Visa Direct  | [optional] 
**SettlementAmount** | **string** | The transaction amount in settlement currency. | [optional] 
**SettlementCurrency** | **string** | The currency in which Visa or Mastercard settles with the acquirer/acquirer.  Use [ISO 4217 3-Alpha Currency Codes](https://developer.cybersource.com/content/dam/docs/cybs/en-us/currency-codes/reference/all/na/currency-codes.pdf).  | [optional] 
**SettlementExchangeRate** | **string** | Exchange rate returned by the card network for settlement. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

