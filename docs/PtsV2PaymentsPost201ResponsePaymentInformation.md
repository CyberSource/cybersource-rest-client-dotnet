# CyberSource.Model.PtsV2PaymentsPost201ResponsePaymentInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Card** | [**PtsV2PaymentsPost201ResponsePaymentAccountInformationCard**](PtsV2PaymentsPost201ResponsePaymentAccountInformationCard.md) |  | [optional] 
**TokenizedCard** | [**PtsV2PaymentsPost201ResponsePaymentInformationTokenizedCard**](PtsV2PaymentsPost201ResponsePaymentInformationTokenizedCard.md) |  | [optional] 
**TokenizedPaymentMethod** | [**PtsV2PaymentsPost201ResponsePaymentInformationTokenizedPaymentMethod**](PtsV2PaymentsPost201ResponsePaymentInformationTokenizedPaymentMethod.md) |  | [optional] 
**AccountFeatures** | [**PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures**](PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.md) |  | [optional] 
**Bank** | [**PtsV2PaymentsPost201ResponsePaymentInformationBank**](PtsV2PaymentsPost201ResponsePaymentInformationBank.md) |  | [optional] 
**Customer** | [**Ptsv2paymentsPaymentInformationCustomer**](Ptsv2paymentsPaymentInformationCustomer.md) |  | [optional] 
**PaymentInstrument** | [**Ptsv2paymentsPaymentInformationPaymentInstrument**](Ptsv2paymentsPaymentInformationPaymentInstrument.md) |  | [optional] 
**InstrumentIdentifier** | [**PtsV2PaymentsPost201ResponsePaymentInformationInstrumentIdentifier**](PtsV2PaymentsPost201ResponsePaymentInformationInstrumentIdentifier.md) |  | [optional] 
**ShippingAddress** | [**Ptsv2paymentsPaymentInformationShippingAddress**](Ptsv2paymentsPaymentInformationShippingAddress.md) |  | [optional] 
**Scheme** | **string** | Subtype of card account. This field can contain one of the following values: - Maestro International - Maestro UK Domestic - MasterCard Credit - MasterCard Debit - Visa Credit - Visa Debit - Visa Electron  **Note** Additional values may be present.  | [optional] 
**Bin** | **string** | Credit card BIN (the first six digits of the credit card).Derived either from the &#x60;cc_bin&#x60; request field or from the first six characters of the &#x60;customer_cc_num&#x60; field.  | [optional] 
**AccountType** | **string** | Type of payment card account. This field can refer to a credit card, debit card, or prepaid card account type.  | [optional] 
**Issuer** | **string** | Name of the bank or entity that issued the card account.  | [optional] 
**BinCountry** | **string** | Country (two-digit country code) associated with the BIN of the customer&#39;s card used for the payment. Returned if the information is available. Use this field for additional information when reviewing orders. This information is also displayed in the details page of the CyberSource Business Center.  | [optional] 
**EWallet** | [**PtsV2PaymentsPost201ResponsePaymentInformationEWallet**](PtsV2PaymentsPost201ResponsePaymentInformationEWallet.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

