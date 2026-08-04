# CyberSource.Model.Riskv1authenticationsOrderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountDetails** | [**Riskv1authenticationsOrderInformationAmountDetails**](Riskv1authenticationsOrderInformationAmountDetails.md) |  | [optional] 
**PreOrder** | **string** | Indicates whether cardholder is placing an order with a future availability or release date. This field can contain one of these values: - MERCHANDISE_AVAILABLE: Merchandise available - FUTURE_AVAILABILITY: Future availability  | [optional] 
**PreOrderDate** | **string** | Expected date that a pre-ordered purchase will be available. Format: YYYYMMDD  | [optional] 
**Reordered** | **bool?** | Indicates whether the cardholder is reordering previously purchased merchandise. This field can contain one of these values: - false: First time ordered - true: Reordered  | [optional] 
**ShipTo** | [**Riskv1decisionsOrderInformationShipTo**](Riskv1decisionsOrderInformationShipTo.md) |  | [optional] 
**LineItems** | [**List&lt;Riskv1authenticationsOrderInformationLineItems&gt;**](Riskv1authenticationsOrderInformationLineItems.md) | This array contains detailed information about individual products in the order. | [optional] 
**BillTo** | [**Riskv1authenticationsOrderInformationBillTo**](Riskv1authenticationsOrderInformationBillTo.md) |  | [optional] 
**TotalOffersCount** | **string** | Total number of articles/items in the order as a numeric decimal count. Possible values: 00 - 99  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

