# CyberSource.Model.Ptsv2paymentsOrderInformationAmountDetailsOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalAmount** | **string** | Grand total for the order. This value cannot be negative. You can include a decimal point (.), but you cannot include any other special characters. CyberSource truncates the amount to the correct number of decimal places  | [optional] 
**Currency** | **string** | Currency used for the order  | [optional] 
**SubTotalAmount** | **string** | Shipping discount amount for the transaction. If this amount has changed since the initial sessions request, you must include the new value in the order request. You must also include all additional amount fields that apply to the order and ensure the total amount equals the purchaseTotals_grandTotalAmount value.  | [optional] 
**HandlingAmount** | **string** | Aggregate handling charges for the transaction. If this amount has changed since the initial sessions request, you must include the new value in the order request. You must also include all additional amount fields that apply to the order and ensure the total amount equals the purchaseTotals_grandTotalAmount value.  | [optional] 
**ShippingAmount** | **string** | Aggregate shipping charges for the transaction If this amount has changed since the initial sessions request, you must include the new value in the order request. You must also include all additional amount fields that apply to the order and ensure the total amount equals the purchaseTotals_grandTotalAmount value.  | [optional] 
**ShippingDiscountAmount** | **string** | Shipping discount amount for the transaction. If this amount has changed since the initial sessions request, you must include the new value in the order request. You must also include all additional amount fields that apply to the order and ensure the total amount equals the purchaseTotals_grandTotalAmount value.  | [optional] 
**TaxAmount** | **string** | Total tax amount. When the purchaseTotals_ taxAmount and ap_subtotalAmount fields are included in the request, do not include the tax amount as part of the subtotal amount calculation.  | [optional] 
**InsuranceAmount** | **string** | Amount being charged for the insurance fee. Only supported when the payment_method is set to paypal.  | [optional] 
**GiftWrapAmount** | **string** | Amount being charged as gift wrap fee.             | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

