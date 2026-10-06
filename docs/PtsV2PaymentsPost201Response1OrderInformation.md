# CyberSource.Model.PtsV2PaymentsPost201Response1OrderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceId** | **string** | Merchant-generated order reference or tracking number for the payment.  | [optional] 
**Description** | **string** | Description of the order, as provided by the merchant in the original request.  | [optional] 
**CustomId** | **string** | Merchant-defined custom identifier for the order.  | [optional] 
**MerchantDescriptor** | [**PtsV2PaymentsPost201Response1OrderInformationMerchantDescriptor**](PtsV2PaymentsPost201Response1OrderInformationMerchantDescriptor.md) |  | [optional] 
**BillTo** | [**PtsV2PaymentsPost201Response1OrderInformationBillTo**](PtsV2PaymentsPost201Response1OrderInformationBillTo.md) |  | [optional] 
**ShipTo** | [**PtsV2PaymentsPost201Response1OrderInformationShipTo**](PtsV2PaymentsPost201Response1OrderInformationShipTo.md) |  | [optional] 
**AmountDetails** | [**PtsV2PaymentsPost201Response1OrderInformationAmountDetails**](PtsV2PaymentsPost201Response1OrderInformationAmountDetails.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

