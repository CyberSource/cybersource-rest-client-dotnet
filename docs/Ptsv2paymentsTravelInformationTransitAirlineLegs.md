# CyberSource.Model.Ptsv2paymentsTravelInformationTransitAirlineLegs
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierCode** | **string** | Carrier Code: IATA1 code for the carrier for this leg of the trip.  | [optional] 
**FlightNumber** | **string** | Flight number for this leg of the trip.  | [optional] 
**OriginatingAirportCode** | **string** | IATA1 code for the originating airport for this leg of the trip.  | [optional] 
**_Class** | **string** | IATA1 code for the class of service for this leg of the trip.  | [optional] 
**StopoverIndicator** | **int?** | Code that indicates whether a stopover is allowed on this leg of the trip. Possible Values: O(capital letter \&quot;O\&quot;): stopover allowed.  X(capital letter \&quot;X\&quot;): Stopover not allowed.  | [optional] 
**DepartureDate** | **int?** | Departure date for the first leg of the trip. Format: YYYYMMDD.  | [optional] 
**DestinationAirportCode** | **string** | IATA1 code for the destination airport for this leg of the trip.  | [optional] 
**FareBasis** | **string** | Code for the fare basis for this leg of the trip. The fare basis is assigned by the carriers and indicates a particular ticket type, such as business class or discounted/nonrefundable.  | [optional] 
**DepartTaxAmount** | **string** | Amount of departure tax for this leg of the trip.  | [optional] 
**ConjunctionTicket** | **string** | Ticket that contains additional coupons for this leg of the trip on an itinerary that has more than four segments.  | [optional] 
**ExchangeTicketNumber** | **string** | New ticket number that is issued when the ticket is exchanged for this leg of the trip.  | [optional] 
**CouponNumber** | **string** | Each leg on the ticket requires a separate coupon, and each coupon is identified by the coupon number.  | [optional] 
**DepartureTime** | **int?** | Time of departure for this leg of the trip. The format is military time and HHMM: If not all zeros, then the hours must be 00-23 and the minutes must be 00-59  | [optional] 
**DepartureTimeMeridian** | **string** | AM or PM for the departure time. Possible values: - A: 12:00 midnight to 11:59 a.m. - P: 12:00 noon to 11:59 p.m  | [optional] 
**ArrivalTime** | **int?** | Time of arrival for this leg of the trip. The format is military time and HHMM: If not all zeros, then the hours must be 00-23 and the minutes must be 00-59  | [optional] 
**ArrivalTimeMeridian** | **string** | AM or PM for the arrival time for this leg of the trip. Possible values: - A: 12:00 midnight to 11:59 a.m. - P: 12:00 noon to 11:59 p.m. Format: English characters only  | [optional] 
**EndorsementsRestrictions** | **string** | Notes or notations about endorsements and restrictions for this leg of the trip. Endorsements can be notations added by the travel agency, including mandatory government required notations such as value added tax. Restrictions are limitations for the ticket based on the type of fare, such as a nonrefundable tic.  | [optional] 
**TotalFareAmount** | **string** | Total fare for this leg of the trip.  | [optional] 
**FeeAmount** | **string** | Fee for this leg of the trip, such as an airport fee or country fee.  | [optional] 
**TaxAmount** | **string** | Tax for this leg of the trip  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

