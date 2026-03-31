# CyberSource.Model.Ptsv1pullfundstransferRecipientInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdministrativeArea** | **string** | Recipient&#39;s state. Use the State, Province, and Territory Codes for the United States and Canada. Value must be an ISO Standard State Code:  https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf  | [optional] 
**PostalCode** | **string** | Recipient&#39;s postal code.  | [optional] 
**Country** | **string** | Recipient&#39;s country code. Check that this field contains 2-character alpha ISO 3166-1 standard values.  | [optional] 
**PersonalIdentification** | [**Ptsv1pullfundstransferRecipientInformationPersonalIdentification**](Ptsv1pullfundstransferRecipientInformationPersonalIdentification.md) |  | [optional] 
**FirstName** | **string** | Recipient&#39;s first name.  | [optional] 
**MiddleInitial** | **string** | Middle Initial of recipient. This field is supported by FDC Compass.  | [optional] 
**MiddleName** | **string** | Recipient&#39;s middle name. This field is a pass through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  | [optional] 
**LastName** | **string** | Recipient&#39;s last name. Conditional field. If &#x60;recipientInformation.sameAsSender&#x60; &#x3D; &#x60;false&#x60;, this field is mandatory.  | [optional] 
**Address1** | **string** | Street address of recipient. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.  | [optional] 
**Address2** | **string** | Second line of the recipient&#39;s address.  | [optional] 
**BuildingNumber** | **string** | This field contains the house or the building number of the recipient address.  | [optional] 
**Locality** | **string** | Recipient city.  | [optional] 
**IdentificationNumber** | **string** | Government-issued identification number.  Conditional: This field is mandatory if the &#x60;processingInformation.businessApplicationId&#x60; is any of the following:   - &#x60;AA&#x60; - &#x60;PP&#x60; - &#x60;TU&#x60; - &#x60;BI&#x60; - &#x60;WT&#x60; - &#x60;FT&#x60; - and country code &#x3D; &#x60;BR&#x60;, &#x60;AR&#x60;, &#x60;CO&#x60;, &#x60;PE&#x60;, in &#x60;recipientInformation.countryCode&#x60; (Argentina, Brazil, Colombia, and Peru)  | [optional] 
**Type** | **string** | &#x60;B&#x60; for Business or &#x60;I&#x60; for individual.  Conditional:  If &#x60;recipientInformation.identificationNumber&#x60; is present, then this field is mandatory.  | [optional] 
**Descriptor** | **string** | Recipient first name, this will be concatenated with the 4-digit originator abbreviation.  | [optional] 
**AccountId** | **string** | Identifier for the recipient&#39;s account.  | [optional] 
**AccountType** | **string** | Identifies the recipient&#39;s account type. This field is applicable for AFT transactions.  Valid values are:  - &#x60;00&#x60; Other - &#x60;01&#x60; Routing transit number (RTN) and bank account - &#x60;02&#x60; IBAN - &#x60;03&#x60; Card account - &#x60;04&#x60; Email - &#x60;05&#x60; Phone number - &#x60;06&#x60; Bank account number (BAN) and bank identification code (BIC) - &#x60;07&#x60; Wallet ID - &#x60;08&#x60; Social network ID  | [optional] 
**AliasName** | **string** | Account owner alias name.  | [optional] 
**CountryOfBirth** | **string** | Account Owner Country of Birth  | [optional] 
**DateOfBirth** | **string** | Recipient&#39;s date of birth. Format: YYYYMMDD.  | [optional] 
**Email** | **string** | Account Owner email address  | [optional] 
**Nationality** | **string** | Account Owner Nationality  | [optional] 
**Occupation** | **string** | Account Owner Occupation  | [optional] 
**StreetName** | **string** | This field contains the street name of the recipient&#39;s address.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

