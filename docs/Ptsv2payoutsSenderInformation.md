# CyberSource.Model.Ptsv2payoutsSenderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceNumber** | **string** | Reference number generated by you that uniquely identifies the sender. | [optional] 
**Account** | [**Ptsv2payoutsSenderInformationAccount**](Ptsv2payoutsSenderInformationAccount.md) |  | [optional] 
**FirstName** | **string** | First name of sender (Optional). * CTV (14) * Paymentech (30)  | [optional] 
**MiddleInitial** | **string** | Recipient middle initial (Optional).  | [optional] 
**MiddleName** | **string** | Sender&#39;s middle name. This field is a _passthrough_, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  | [optional] 
**LastName** | **string** | Recipient last name (Optional). * CTV (14) * Paymentech (30)  | [optional] 
**Name** | **string** | Name of sender.  **Funds Disbursement**  This value is the name of the originator sending the funds disbursement. * CTV, Paymentech (30)  | [optional] 
**Address1** | **string** | Street address of sender.  **Funds Disbursement**  This value is the address of the originator sending the funds disbursement.  | [optional] 
**Locality** | **string** | City of sender.  **Funds Disbursement**  This value is the city of the originator sending the funds disbursement.  | [optional] 
**AdministrativeArea** | **string** | Sender&#39;s state. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf).  | [optional] 
**CountryCode** | **string** | Country of sender. Use the [ISO Standard Country Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf). * CTV (3)  | [optional] 
**PostalCode** | **string** | Sender&#39;s postal code. Required only for FDCCompass. | [optional] 
**PhoneNumber** | **string** | Sender&#39;s phone number. Required only for FDCCompass. | [optional] 
**DateOfBirth** | **string** | Sender&#39;s date of birth in YYYYMMDD format. Required only for FDCCompass. | [optional] 
**VatRegistrationNumber** | **string** | Customer&#39;s government-assigned tax identification number.  | [optional] 
**PersonalIdType** | **string** | #### Visa Platform Connect This tag will contain the type of sender identification. The valid values are: • BTHD (Date of birth) • CUID (Customer identification (unspecified)) • NTID (National identification) • PASN (Passport number) • DRLN (Driver license) • TXIN (Tax identification) • CPNY (Company registration number) • PRXY (Proxy identification) • SSNB (Social security number) • ARNB (Alien registration number) • LAWE (Law enforcement identification) • MILI (Military identification) • TRVL (Travel identification (non-passport)) • EMAL (Email) • PHON (Phone number)  | [optional] 
**Type** | **string** | #### Visa Platform Connect This tag will denote whether the tax ID is a business or individual tax ID when personal ID Type contains the value of TXIN (Tax identification).  The valid values are: • B (Business) • I (Individual)  | [optional] 
**IdentificationNumber** | **string** | #### Visa Platform Connect This tag will contain an acquirer-populated value associated with the API : senderInformation.personalIdType which will identify the personal ID type of the sender.  | [optional] 
**AliasName** | **string** | Sender&#39;s alias name. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

