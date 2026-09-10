# CyberSource.Model.UnifiedriskOrderShipping
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | First line of the shipping address.Required field for authorization if any shipping address information is included in the request; otherwise, optional.#### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. | [optional] 
**AddressLine2** | **string** | Second line of the shipping address.Optional field.#### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. | [optional] 
**AddressLine3** | **string** | Third line of the shipping address.#### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. | [optional] 
**AdministrativeArea** | **string** | State or province of the shipping address. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf) (maximum length: 2)   Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or Canada; otherwise, optional.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value   | [optional] 
**Country** | **string** | Country of the shipping address. Use the two-character [ISO Standard Country Codes.] | [optional] 
**DestinationTypes** | **string** | Shipping destination of item. Example: Commercial, Residential, Store | [optional] 
**Locality** | **string** | City of the shipping address.Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or Canada; otherwise, optional.#### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. Billing address objects will be used to determine the cardholder&#39;s location when shipTo objects are not present. | [optional] 
**FirstName** | **string** | First name of the recipient.#### Litle Maximum length: 25#### All other processors Maximum length: 60Optional field. | [optional] 
**LastName** | **string** | Last name of the recipient.#### Litle Maximum length: 25#### All other processors Maximum length: 60Optional field. | [optional] 
**MiddleName** | **string** | Middle name of the recipient.#### Litle Maximum length: 25#### All other processors Maximum length: 60Optional field. | [optional] 
**PhoneNumber** | **string** | Phone number associated with the shipping address. | [optional] 
**PostalCode** | **string** | Postal code for the shipping address. The postal code must consist of 5 to 9 digits.Required field for authorization if any shipping address information is included in the request and shipping to the U.S. or Canada; otherwise, optional.When the billing country is the U.S., the 9-digit postal code must follow this format: [5 digits][dash][4 digits]Example 12345-6789When the billing country is Canada, the 6-digit postal code must follow this format: [alpha][numeric][alpha][space][numeric][ | [optional] 
**DestinationCode** | **int?** | Indicates destination chosen for the transaction. Possible values: - 01- Ship to cardholder billing address - 02- Ship to another verified address on file with merchant - 03- Ship to address that is different than billing address - 04- Ship to store (store address should be populated on request) - 05- Digital goods - 06- Travel and event tickets, not shipped - 07- Other | [optional] 
**DeliveryType** | **string** | Delivery/fulfillment method  Possible values: - shipToHome - storePickup - lockerPickup - curbside | [optional] 
**GiftWrap** | **bool?** | Boolean that indicates whether the customer requested gift wrapping for this purchase. This field can contain one of the following values: - true: The customer requested gift wrapping. - false: The customer did not request gift wrapping. | [optional] 
**ShippingMethod** | **string** | Shipping method for the product. Possible values:   - &#x60;lowcost&#x60;: Lowest-cost service  - &#x60;sameday&#x60;: Courier or same-day service  - &#x60;oneday&#x60;: Next-day or overnight service  - &#x60;twoday&#x60;: Two-day service   | [optional] 
**Store** | [**UnifiedriskOrderShippingStore**](UnifiedriskOrderShippingStore.md) |  | [optional] 
**StoreAddress** | [**UnifiedriskOrderShippingStoreAddress**](UnifiedriskOrderShippingStoreAddress.md) |  | [optional] 
**Email** | **string** | Email address of the recipient or shipping contact for order confirmation, dispatch notifications, and delivery tracking | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

