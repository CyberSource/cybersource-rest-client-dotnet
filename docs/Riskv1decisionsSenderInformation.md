# CyberSource.Model.Riskv1decisionsSenderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Sender&#39;s full name, formatted as First Name Last Name.  | [optional] 
**FirstName** | **string** | First name of the sender. This field is applicable for AFT and OCT transactions.   Only alpha numeric values are supported.Special characters not in the standard ASCII character set, are not supported and will be stripped before being sent to the processor.  | [optional] 
**MiddleName** | **string** | Middle name of the sender. This field is applicable for AFT and OCT transactions.   Only alpha numeric values are supported. Special characters not in the standard ASCII character set, are not supported and will be stripped before being sent to sent to the processor.  | [optional] 
**LastName** | **string** | Last name of the sender. This field is applicable for AFT and OCT transactions.  Only alpha numeric values are supported. Special characters not in the standard ASCII character set, are not supported and will be stripped before being sent to sent to the processor.  | [optional] 
**Email** | **string** | Sender&#39;s email address, including the full domain name.  | [optional] 
**PostalCode** | **string** | Postal code of sender.  | [optional] 
**AdministrativeArea** | **string** | The state or province of the sender. This field is applicable for AFT transactions when the sender country is US or CA. Else it is optional.  Must be a two character value  | [optional] 
**Address1** | **string** | The street address of the sender. This field is applicable for AFT transactions.     Only alpha numeric values are supported.  Special characters not in the standard ASCII character set are not supported and will be stripped before being sent to sent to the processor.  | [optional] 
**CountryCode** | **string** | The country associated with the address of the sender. This field is applicable for AFT transactions.   Must be a two character ISO country code.  For example, see [ISO Country Code](https://developer.cybersource.com/docs/cybs/en-us/country-codes/reference/all/na/country-codes/country-codes.html)  | [optional] 
**Locality** | **string** | The city or locality of the sender. This field is applicable for AFT transactions.  Only alpha numeric values are supported.  Special characters not in the standard ASCII character set are not supported and will be stripped before being sent to sent to the processor.  | [optional] 
**ReferenceNumber** | **string** | This field is applicable for AFT transactions.   Contains a transaction reference number provided by the Merchant. Only alpha numeric values are supported.  | [optional] 
**PhoneNumber** | **string** | Sender&#39;s phone number. | [optional] 
**DateOfBirth** | **string** | Sender&#39;s date of birth in YYYYMMDD format. | [optional] 
**VatRegistrationNumber** | **string** | Customer&#39;s government-assigned tax identification number.  | [optional] 
**PersonalIdType** | **string** | #### Visa Platform Connect This tag will contain the type of sender identification. The valid values are: • BTHD (Date of birth) • CUID (Customer identification (unspecified)) • NTID (National identification) • PASN (Passport number) • DRLN (Driver license) • TXIN (Tax identification) • CPNY (Company registration number) • PRXY (Proxy identification) • SSNB (Social security number) • ARNB (Alien registration number) • LAWE (Law enforcement identification) • MILI (Military identification) • TRVL (Travel identification (non-passport)) • EMAL (Email) • PHON (Phone number)  | [optional] 
**Type** | **string** | #### Visa Platform Connect This tag will denote whether the tax ID is a business or individual tax ID when personal ID Type contains the value of TXIN (Tax identification). The valid values are: • B (Business) • I (Individual)  | [optional] 
**IdentificationNumber** | **string** | #### Visa Platform Connect This tag will contain an acquirer-populated value associated with the API : senderInformation.personalIdType which will identify the personal ID type of the sender.  | [optional] 
**Account** | [**Riskv1decisionsSenderInformationAccount**](Riskv1decisionsSenderInformationAccount.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

