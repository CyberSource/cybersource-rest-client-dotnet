# CyberSource.Model.ReportingV3PurchaseRefundDetailsGet200ResponseOthers
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestId** | **string** | An unique identification number assigned by CyberSource to identify the submitted request. | [optional] 
**MerchantData1** | **string** | Merchant Defined Data | [optional] 
**MerchantData2** | **string** | Merchant Defined Data | [optional] 
**MerchantData3** | **string** | Merchant Defined Data | [optional] 
**MerchantData4** | **string** | Merchant Defined Data | [optional] 
**FirstName** | **string** | First Name | [optional] 
**LastName** | **string** | Last Name | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

