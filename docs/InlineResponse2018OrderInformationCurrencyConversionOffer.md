# CyberSource.Model.InlineResponse2018OrderInformationCurrencyConversionOffer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OriginalAmount** | **string** | The amount of the sale in the merchant&#39;s currency.  For DCC this should be the same value as the request. For MCP will be 1 major unit of the merchant&#39;s base currency.  | [optional] 
**OriginalCurrency** | **string** | Currency of the transaction in the merchant&#39;s currency.  For DCC this should be the same value as the request.  For MCP will be the merchant&#39;s base currency as configured on the currency conversion provider&#39;s system. Use three-character alphabetic [ISO 4271 Currency Codes.](https://developer.cybersource.com/docs/cybs/en-us/currency-codes/reference/all/na/currency-codes/currency-codes.html)  | [optional] 
**Amount** | **string** | The offer amount, calculated using the originalAmount and the exchangeRate. For DCC this is the amount in the card issuer&#39;s currency.  | [optional] 
**Currency** | **string** | Currency of the offer. For DCC this is the card&#39;s issuers currency. Use three-character alphabetic  [ISO 4271 Currency Codes.](https://developer.cybersource.com/docs/cybs/en-us/currency-codes/reference/all/na/currency-codes/currency-codes.html)  | [optional] 
**ExchangeRate** | **string** | The exchange rate of the offer from 1 major unit of the sale currency including margin. This will be printed on the receipt. For example, if a USD consumer is purchasing in EUR, this field should return the amount of 1 EUR in USD including mark-up. The receipt will contain the following: &#x60;EUR 1.00 &#x3D; USD 1.09998900010999&#x60; - where 1.09998900010999 is the value returned in this field.  | [optional] 
**ExchangeRateInverted** | **bool?** | An inverted exchange rate is the base currency amount divided by the converted currency amount. Ex. If a USD customer is purchasing in EUR, this field should return the value of USD divided by EUR.  | [optional] 
**MarginRate** | **string** | The margin between the offer exchange rate and wholesale rates, i.e. the mark up. Expressed as a percentage of 100, e.g. 3.75  | [optional] 
**RateSource** | **string** | The source of the rate (excluding mark up). Optional field.  | [optional] 
**ExchangeRateTimeUtc** | **string** | The date and time of exchange rate in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2023-05-17T23:47:57Z&#x60; equals May 17, 2023, at 23:47:57 (11:47:57 PM). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  | [optional] 
**ExchangeRateExpirationTimeUtc** | **string** | The expiration time of the exchange rate in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;  | [optional] 
**RateId** | **string** | A unique MCP rate identifier.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

