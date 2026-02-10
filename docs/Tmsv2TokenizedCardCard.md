# CyberSource.Model.Tmsv2TokenizedCardCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | The latest customer&#39;s payment card number associated to the network token.  | [optional] 
**ExpirationMonth** | **string** | Two-digit month in which the payment card expires.  Format: &#x60;MM&#x60;.  Possible Values: &#x60;01&#x60; through &#x60;12&#x60;.  | [optional] 
**ExpirationYear** | **string** | Four-digit year in which the credit card expires.  Format: &#x60;YYYY&#x60;.  | [optional] 
**Type** | **string** | The type of card (Card Network). Possible Values: - 001: visa  | [optional] 
**Suffix** | **string** | The customer&#39;s latest payment card number suffix.  | [optional] 
**IssueDate** | **DateTime?** | Card issuance date. XML date format: YYYY-MM-DD. | [optional] 
**ActivationDate** | **DateTime?** | Card activation date. XML date format: YYYY-MM-DD | [optional] 
**ExpirationPrinted** | **bool?** | Indicates if the expiration date is printed on the card. | [optional] 
**SecurityCodePrinted** | **bool?** | Indicates if the Card Verification Number is printed on the card. | [optional] 
**TermsAndConditions** | [**Tmsv2TokenizedCardCardTermsAndConditions**](Tmsv2TokenizedCardCardTermsAndConditions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

