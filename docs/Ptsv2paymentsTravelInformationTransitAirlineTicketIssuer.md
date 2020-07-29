# CyberSource.Model.Ptsv2paymentsTravelInformationTransitAirlineTicketIssuer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | IATA2 airline code. Format: English characters only. Required for Mastercard; optional for all other card types.  | [optional] 
**Name** | **string** | Name of the ticket issuer. If you do not include this field, CyberSource uses the value for your merchant name that is in the CyberSource merchant configuration database.  | [optional] 
**Address** | **string** | Address of the company issuing the ticket.  | [optional] 
**Locality** | **string** | City in which the transaction occurred. If the name of the city exceeds 18 characters, use meaningful abbreviations. Format: English characters only. Optional request field.  | [optional] 
**AdministrativeArea** | **string** | State in which transaction occured.  | [optional] 
**PostalCode** | **string** | Zip code of the city in which transaction occured.  | [optional] 
**Country** | **string** | Country in which transaction occured.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

