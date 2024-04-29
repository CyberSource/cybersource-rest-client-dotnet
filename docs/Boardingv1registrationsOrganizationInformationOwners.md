# CyberSource.Model.Boardingv1registrationsOrganizationInformationOwners
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** |  | 
**MiddleName** | **string** |  | [optional] 
**LastName** | **string** |  | 
**BirthDate** | **DateTime?** | &#x60;Format: YYYY-MM-DD&#x60; Example 2016-08-11 equals August 11, 2016  | 
**IsPrimary** | **bool?** | Determines whether the owner is the Primary owner of the organization | 
**Ssn** | **string** | Social Security Number | [optional] 
**PassportNumber** | **string** | Passport number | [optional] 
**PassportCountry** | **string** |  | [optional] 
**JobTitle** | **string** |  | 
**HasSignificantResponsability** | **bool?** | Determines whether owner has significant responsibility to control, manage or direct the company | 
**OwnershipPercentage** | **decimal?** | Determines the percentage of ownership this owner has. For the primary owner the percentage can be from 0-100; for other owners the percentage can be from 25-100 and the sum of ownership accross owners cannot exceed 100 | 
**PhoneNumber** | **string** |  | 
**Email** | **string** |  | 
**Address** | [**Boardingv1registrationsOrganizationInformationBusinessInformationAddress**](Boardingv1registrationsOrganizationInformationBusinessInformationAddress.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

