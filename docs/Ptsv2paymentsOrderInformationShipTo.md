# CyberSource.Model.Ptsv2paymentsOrderInformationShipTo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | First name of the recipient.  **Processor specific maximum length**  - Litle: 25 - All other processors: 60  | [optional] 
**LastName** | **string** | Last name of the recipient.  **Processor-specific maximum length**  - Litle: 25 - All other processors: 60  | [optional] 
**Address1** | **string** | First line of the shipping address. | [optional] 
**Address2** | **string** | Second line of the shipping address. | [optional] 
**Locality** | **string** | City of the shipping address. | [optional] 
**AdministrativeArea** | **string** | State or province of the shipping address. Use the State, Province, and Territory Codes for the United States and Canada.  | [optional] 
**PostalCode** | **string** | Postal code for the shipping address. The postal code must consist of 5 to 9 digits.  When the billing country is the U.S., the 9-digit postal code must follow this format: [5 digits][dash][4 digits]  Example 12345-6789  When the billing country is Canada, the 6-digit postal code must follow this format: [alpha][numeric][alpha][space][numeric][alpha][numeric]  Example A1B 2C3  **American Express Direct**\\ Before sending the postal code to the processor, CyberSource removes all nonalphanumeric characters and, if the remaining value is longer than nine characters, truncates the value starting from the right side.  | [optional] 
**Country** | **string** | Country of the shipping address. Use the two-character ISO Standard Country Codes. | [optional] 
**District** | **string** | Neighborhood, community, or region within a city or municipality. | [optional] 
**BuildingNumber** | **string** | Building number in the street address. For example, the building number is 187 in the following address:  Rua da Quitanda 187  | [optional] 
**PhoneNumber** | **string** | Phone number associated with the shipping address. | [optional] 
**Company** | **string** | Name of the customer’s company.  For processor-specific information, see the company_name field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

