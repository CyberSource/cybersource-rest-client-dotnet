# CyberSource.Model.MppCredentialsResponse200
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Token** | **string** | Base64-encoded RSA-OAEP encrypted token ciphertext. Must not be parsed by client/server — forwarded opaquely to the Server Enabler. | 
**Network** | **string** | Card network. Possible values:   - &#x60;visa&#x60;   - &#x60;mastercard&#x60;   - &#x60;amex&#x60;   - &#x60;discover&#x60;  | 
**LastFour** | **string** | Last four digits of the card number as displayed to cardholder. | 
**ExpirationMonth** | **string** | Token expiration month (e.g., &#39;06&#39;). Display only. | 
**ExpirationYear** | **string** | Token expiration year, four digits (e.g., &#39;2028&#39;). Display only. | 
**DynamicData** | **string** | Base64-encoded cryptogram from TSP. Present only for network_token type. Display only. | 
**Eci** | **string** | Electronic Commerce Indicator (e.g., &#39;05&#39;, &#39;07&#39;). Present only for network_token type. Display only. | 
**PaymentAccountReference** | **string** | Payment Account Reference — a stable reference to the underlying funding account. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

