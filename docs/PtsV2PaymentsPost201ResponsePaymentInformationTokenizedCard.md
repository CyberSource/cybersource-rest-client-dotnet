# CyberSource.Model.PtsV2PaymentsPost201ResponsePaymentInformationTokenizedCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prefix** | **string** | First six digits of token. CyberSource includes this field in the reply message when it decrypts the payment blob for the tokenized transaction.  | [optional] 
**Suffix** | **string** | Last four digits of token. CyberSource includes this field in the reply message when it decrypts the payment blob for the tokenized transaction.  | [optional] 
**Type** | **string** | Type of card to authorize. - 001 Visa - 002 Mastercard - 003 Amex - 004 Discover  | [optional] 
**AssuranceLevel** | **string** | Confidence level of the tokenization. This value is assigned by the token service provider.  &#x60;Note&#x60; This field is supported only for **CyberSource through VisaNet** and **FDC Nashville Global**.  | [optional] 
**ExpirationMonth** | **string** | Two-digit month in which the payment network token expires. &#x60;Format: MM&#x60;. Possible values: 01 through 12.  | [optional] 
**ExpirationYear** | **string** | Four-digit year in which the payment network token expires. &#x60;Format: YYYY&#x60;.  | [optional] 
**RequestorId** | **string** | Value that identifies your business and indicates that the cardholder’s account number is tokenized. This value is assigned by the token service provider and is unique within the token service provider’s database.  &#x60;Note&#x60; This field is supported only for **CyberSource through VisaNet** and **FDC Nashville Global**.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

