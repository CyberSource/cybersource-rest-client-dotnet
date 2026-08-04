# CyberSource.Model.Ptsv2intentsOrderInformationAmountDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalAmount** | **string** | Grand total for the order. This value cannot be negative. You can include a decimal point (.), but you cannot include any other special characters. CyberSource truncates the amount to the correct number of decimal places  | [optional] 
**Currency** | **string** | Currency used for the order  | [optional] 
**DiscountAmount** | **string** | Discount amount for the transaction.   | [optional] 
**ShippingAmount** | **string** | Aggregate shipping charges for the transactions.  | [optional] 
**ShippingDiscountAmount** | **string** | Shipping discount amount for the transaction.   | [optional] 
**TaxAmount** | **string** | Total tax amount.   | [optional] 
**InsuranceAmount** | **string** | Amount being charged for the insurance fee.   | [optional] 
**DutyAmount** | **string** | Amount being charged as duty amount.              | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

