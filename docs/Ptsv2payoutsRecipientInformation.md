# CyberSource.Model.Ptsv2payoutsRecipientInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | First name of recipient. characters. * CTV (14) * Paymentech (30)  | [optional] 
**MiddleName** | **string** | Recipient&#39;s middle name. This field is a _passthrough_, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  | [optional] 
**LastName** | **string** | Last name of recipient. characters. * CTV (14) * Paymentech (30)  | [optional] 
**Address1** | **string** | Recipient address information. Required only for FDCCompass. | [optional] 
**Locality** | **string** | Recipient city. Required only for FDCCompass. | [optional] 
**AdministrativeArea** | **string** | Recipient State. Required only for FDCCompass. | [optional] 
**Country** | **string** | Recipient country code. Required only for FDCCompass. | [optional] 
**PostalCode** | **string** | Recipient postal code. Required only for FDCCompass. | [optional] 
**PhoneNumber** | **string** | Recipient phone number. Required only for FDCCompass. | [optional] 
**AliasName** | **string** | Account owner alias name.  | [optional] 
**Nationality** | **string** | Account Owner Nationality | [optional] 
**CountryOfBirth** | **string** | Account Owner Country of Birth | [optional] 
**Occupation** | **string** | Account Owner Occupation | [optional] 
**Email** | **string** | Account Owner email address | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

