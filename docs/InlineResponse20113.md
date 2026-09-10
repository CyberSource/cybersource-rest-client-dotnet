# CyberSource.Model.InlineResponse20113
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ucp** | [**InlineResponse20113Ucp**](InlineResponse20113Ucp.md) |  | [optional] 
**Id** | **string** | Unique UCP session identifier. Required for all subsequent UCP calls (update, complete, cancel).  | [optional] 
**Status** | **string** | Current lifecycle state of the session. - &#x60;active&#x60; — open and modifiable - &#x60;completed&#x60; — order placed, immutable - &#x60;cancelled&#x60; — abandoned, no charge made   Possible values: - active - completed - cancelled | [optional] 
**Currency** | **string** | ISO 4217 currency code for this session (e.g. &#x60;USD&#x60;, &#x60;EUR&#x60;). | [optional] 
**Buyer** | [**UcpCheckoutSessionResponseBuyer**](UcpCheckoutSessionResponseBuyer.md) |  | [optional] 
**LineItems** | [**List&lt;InlineResponse20113LineItems&gt;**](InlineResponse20113LineItems.md) | Cart line items with merchant-confirmed pricing. | [optional] 
**Totals** | [**List&lt;Iccv1checkoutsessionsFulfillmentTotals&gt;**](Iccv1checkoutsessionsFulfillmentTotals.md) | Order cost breakdown. Each entry represents one total type (subtotal, tax, shipping, discount, or grand total). Amounts are in **cents** (not micros).  | [optional] 
**Fulfillment** | [**InlineResponse20113Fulfillment**](InlineResponse20113Fulfillment.md) |  | [optional] 
**Payment** | [**InlineResponse20113Payment**](InlineResponse20113Payment.md) |  | [optional] 
**Discounts** | [**InlineResponse20113Discounts**](InlineResponse20113Discounts.md) |  | [optional] 
**Order** | [**InlineResponse20113Order**](InlineResponse20113Order.md) |  | [optional] 
**Links** | [**List&lt;InlineResponse20112Links&gt;**](InlineResponse20112Links.md) | Related resource links (e.g. terms of use, privacy policy). | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

