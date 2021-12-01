# CyberSource.Model.Ptsv2payoutsRecipientInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | First name of recipient. characters. * CTV (14) * Paymentech (30)  | [optional] 
**MiddleInitial** | **string** | Middle Initial of recipient. Required only for FDCCompass.  | [optional] 
**MiddleName** | **string** | Recipient’s middle name. This field is a _passthrough_, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  | [optional] 
**LastName** | **string** | Last name of recipient. characters. * CTV (14) * Paymentech (30)  | [optional] 
**Address1** | **string** | Recipient address information. Required only for FDCCompass. | [optional] 
**Locality** | **string** | Recipient city. Required only for FDCCompass. | [optional] 
**AdministrativeArea** | **string** | Recipient State. Required only for FDCCompass. | [optional] 
**Country** | **string** | Recipient country code. Required only for FDCCompass. | [optional] 
**PostalCode** | **string** | Recipient postal code. Required only for FDCCompass. | [optional] 
**PhoneNumber** | **string** | Recipient phone number. Required only for FDCCompass. | [optional] 
**DateOfBirth** | **string** | Recipient date of birth in YYYYMMDD format. Required only for FDCCompass. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

