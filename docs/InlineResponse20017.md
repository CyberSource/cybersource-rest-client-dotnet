# CyberSource.Model.InlineResponse20017
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The checkout session identifier. | [optional] 
**Status** | **string** | Will always be &#x60;completed&#x60; on a successful response.  Possible values: - completed | [optional] 
**Currency** | **string** | ISO 4217 lowercase currency code. | [optional] 
**Buyer** | [**AcpCompleteCheckoutResponseBuyer**](AcpCompleteCheckoutResponseBuyer.md) |  | [optional] 
**LineItems** | [**List&lt;InlineResponse20112LineItems&gt;**](InlineResponse20112LineItems.md) | Final line items with confirmed pricing. | [optional] 
**FulfillmentAddress** | [**InlineResponse20017FulfillmentAddress**](InlineResponse20017FulfillmentAddress.md) |  | [optional] 
**FulfillmentOptions** | [**List&lt;InlineResponse20112FulfillmentOptions&gt;**](InlineResponse20112FulfillmentOptions.md) |  | [optional] 
**FulfillmentOptionId** | **string** | ID of the selected fulfillment option. | [optional] 
**Totals** | [**List&lt;InlineResponse20112Totals&gt;**](InlineResponse20112Totals.md) | Final order totals as typed total lines. All amounts in minor units (cents). | [optional] 
**Order** | [**InlineResponse20017Order**](InlineResponse20017Order.md) |  | [optional] 
**Messages** | [**List&lt;InlineResponse20112Messages&gt;**](InlineResponse20112Messages.md) | Informational or error messages from the merchant backend. | [optional] 
**Links** | [**List&lt;InlineResponse20112Links&gt;**](InlineResponse20112Links.md) | Related resource links from the merchant (e.g. terms of use, privacy policy). | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

