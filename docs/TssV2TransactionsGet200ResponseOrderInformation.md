# CyberSource.Model.TssV2TransactionsGet200ResponseOrderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillTo** | [**TssV2TransactionsGet200ResponseOrderInformationBillTo**](TssV2TransactionsGet200ResponseOrderInformationBillTo.md) |  | [optional] 
**ShipTo** | [**TssV2TransactionsGet200ResponseOrderInformationShipTo**](TssV2TransactionsGet200ResponseOrderInformationShipTo.md) |  | [optional] 
**LineItems** | [**List&lt;TssV2TransactionsGet200ResponseOrderInformationLineItems&gt;**](TssV2TransactionsGet200ResponseOrderInformationLineItems.md) | Transaction Line Item data. | [optional] 
**AmountDetails** | [**TssV2TransactionsGet200ResponseOrderInformationAmountDetails**](TssV2TransactionsGet200ResponseOrderInformationAmountDetails.md) |  | [optional] 
**ShippingDetails** | [**TssV2TransactionsGet200ResponseOrderInformationShippingDetails**](TssV2TransactionsGet200ResponseOrderInformationShippingDetails.md) |  | [optional] 
**InvoiceDetails** | [**TssV2TransactionsGet200ResponseOrderInformationInvoiceDetails**](TssV2TransactionsGet200ResponseOrderInformationInvoiceDetails.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

