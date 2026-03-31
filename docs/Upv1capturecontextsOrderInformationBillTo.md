# CyberSource.Model.Upv1capturecontextsOrderInformationBillTo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address1** | **string** | Payment card billing street address as it appears on the credit card issuer&#39;s records.  | [optional] 
**Address2** | **string** | Used for additional address information. For example: _Attention: Accounts Payable_ Optional field.  | [optional] 
**Address3** | **string** | Additional address information (third line of the billing address) | [optional] 
**Address4** | **string** | Additional address information (fourth line of the billing address)  | [optional] 
**AdministrativeArea** | **string** | State or province of the billing address. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf).  | [optional] 
**BuildingNumber** | **string** | Building number in the street address.  | [optional] 
**Country** | **string** | Payment card billing country. Use the two-character [ISO Standard Country Codes](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf).  | [optional] 
**District** | **string** | Customer&#39;s neighborhood, community, or region (a barrio in Brazil) within the city or municipality  | [optional] 
**Locality** | **string** | Payment card billing city.  | [optional] 
**PostalCode** | **string** | Postal code for the billing address. The postal code must consist of 5 to 9 digits.  | [optional] 
**Company** | [**Upv1capturecontextsOrderInformationBillToCompany**](Upv1capturecontextsOrderInformationBillToCompany.md) |  | [optional] 
**Email** | **string** | Customer&#39;s email address, including the full domain name.  | [optional] 
**FirstName** | **string** | Customer&#39;s first name. This name must be the same as the name on the card | [optional] 
**LastName** | **string** | Customer&#39;s last name. This name must be the same as the name on the card.  | [optional] 
**MiddleName** | **string** | Customer&#39;s middle name.  | [optional] 
**NameSuffix** | **string** | Customer&#39;s name suffix.  | [optional] 
**Title** | **string** | Title.  | [optional] 
**PhoneNumber** | **string** | Customer&#39;s phone number.  | [optional] 
**PhoneType** | **string** | Customer&#39;s phone number type.  #### For Payouts: This field may be sent only for FDC Compass.  Possible Values: * day * home * night * work  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

