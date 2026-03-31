# CyberSource.Model.Ptsv1pullfundstransferSenderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PostalCode** | **string** | Sender&#39;s postal code. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.  | [optional] 
**FirstName** | **string** | First name of sender. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.  | [optional] 
**MiddleInitial** | **string** | Middle Initial of sender  | [optional] 
**MiddleName** | **string** | This field contains the middle name of the entity funding the transaction.  | [optional] 
**LastName** | **string** | Last name of sender. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.  | [optional] 
**Address1** | **string** | Street address of sender. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.  | [optional] 
**Address2** | **string** | Second line of the sender&#39;s address.  | [optional] 
**Locality** | **string** | City of sender. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.  | [optional] 
**AdministrativeArea** | **string** | Sender&#39;s state. Use the **State, Province, and Territory Codes for the United States and Canada**. This field is conditional: it is required if in the United States or Canada, and transaction is using neither a Customer nor Payment Instrument token.   Value must be an ISO Standard State Code: [https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf)  | [optional] 
**Country** | **string** | Country of sender. Check that this field contains 2 character alpha ISO 3166-1 standard values. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.  | [optional] 
**PaymentInformation** | [**Ptsv1pullfundstransferSenderInformationPaymentInformation**](Ptsv1pullfundstransferSenderInformationPaymentInformation.md) |  | [optional] 
**ConsumerAuthentication** | [**Ptsv1pullfundstransferSenderInformationConsumerAuthentication**](Ptsv1pullfundstransferSenderInformationConsumerAuthentication.md) |  | [optional] 
**PersonalIdentification** | [**Ptsv1pullfundstransferSenderInformationPersonalIdentification**](Ptsv1pullfundstransferSenderInformationPersonalIdentification.md) |  | [optional] 
**ReferenceNumber** | **string** | Visa Direct(16 characters)   If the transaction is a money transfer, pre-paid load, or credit card bill pay, and if the sender intends to fund the transaction with a non-financial instrument (for example, cash), a reference number unique to the sender is required.   If the transaction is a funds disbursement, the field is required.  | [optional] 
**Account** | [**Ptsv1pullfundstransferSenderInformationAccount**](Ptsv1pullfundstransferSenderInformationAccount.md) |  | [optional] 
**AliasName** | **string** | Sender&#39;s alias name.  | [optional] 
**CountryOfBirth** | **string** | Account Owner Country of Birth.  | [optional] 
**DateOfBirth** | **string** | Sender&#39;s date of birth. Format: YYYYMMDD.  | [optional] 
**Email** | **string** | Account Owner email address  | [optional] 
**Name** | **string** | Name of sender. Use this field if the sender is a business.  | [optional] 
**Nationality** | **string** | Account Owner Nationality  | [optional] 
**Occupation** | **string** | Account Owner Occupation.  | [optional] 
**PhoneNumber** | **string** | Sender&#39;s phone number.  | [optional] 
**Type** | **string** | This field identifies if the sender is a business or an individual.   The valid values are:   • &#x60;B&#x60; (Business)   • &#x60;I&#x60; (Individual)  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

