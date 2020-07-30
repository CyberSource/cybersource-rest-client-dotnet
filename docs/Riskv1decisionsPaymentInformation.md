# CyberSource.Model.Riskv1decisionsPaymentInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Card** | [**Riskv1decisionsPaymentInformationCard**](Riskv1decisionsPaymentInformationCard.md) |  | [optional] 
**TokenizedCard** | [**Riskv1decisionsPaymentInformationTokenizedCard**](Riskv1decisionsPaymentInformationTokenizedCard.md) |  | [optional] 
**Customer** | [**Ptsv2paymentsPaymentInformationCustomer**](Ptsv2paymentsPaymentInformationCustomer.md) |  | [optional] 
**Bank** | [**Ptsv2paymentsPaymentInformationBank**](Ptsv2paymentsPaymentInformationBank.md) |  | [optional] 
**Method** | **string** | Method of payment used for the order. This field can contain one of the following values:   - &#x60;consumer&#x60; (default): Customer credit card   - &#x60;corporate&#x60;: Corporate credit card   - &#x60;debit&#x60;: Debit card, such as a Maestro (UK Domestic) card   - &#x60;cod&#x60;: Collect on delivery   - &#x60;check&#x60;: Electronic check   - &#x60;p2p&#x60;: Person-to-person payment   - &#x60;private1&#x60;: Private label credit card   - &#x60;other&#x60;: Other payment method  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

