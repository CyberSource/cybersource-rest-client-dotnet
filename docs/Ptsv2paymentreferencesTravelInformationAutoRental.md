# CyberSource.Model.Ptsv2paymentreferencesTravelInformationAutoRental
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyName** | **string** | Merchant to send their auto rental company name  | [optional] 
**AffiliateName** | **string** | When merchant wants to send the affiliate name.  | [optional] 
**RentalAddress** | [**Ptsv2paymentsTravelInformationAutoRentalRentalAddress**](Ptsv2paymentsTravelInformationAutoRentalRentalAddress.md) |  | [optional] 
**ReturnAddress** | [**Ptsv2paymentsTravelInformationAutoRentalReturnAddress**](Ptsv2paymentsTravelInformationAutoRentalReturnAddress.md) |  | [optional] 
**ReturnDateTime** | **string** | Date/time the auto was returned to the rental agency. Format: &#x60;&#x60;yyyy-MM-dd HH-mm-ss z&#x60;&#x60; This field is supported for Visa, MasterCard, and American Express.  | [optional] 
**RentalDateTime** | **string** | Date/time the auto was picked up from the rental agency. Format: &#x60;yyyy-MM-dd HH-mm-ss z&#x60; This field is supported for Visa, MasterCard, and American Express.  | [optional] 
**CustomerName** | **string** | Name of the individual making the rental agreement.  Valid data lengths by card:  |Card Specific Validation|VISA|MasterCard|Discover|AMEX| |- -- |- -- |- -- |- -- | | Filed Length| 40| 40| 29| 26| | Field Type| AN| ANS| AN| AN| | M/O/C| O| M| M| M|  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

