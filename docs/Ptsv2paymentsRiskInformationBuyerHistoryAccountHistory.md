# CyberSource.Model.Ptsv2paymentsRiskInformationBuyerHistoryAccountHistory
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstUseOfShippingAddress** | **bool?** | Applicable when this is not a guest account.  | [optional] 
**ShippingAddressUsageDate** | **string** | Date when the shipping address for this transaction was first used. Recommended for Discover ProtectBuy. If &#x60;firstUseOfShippingAddress&#x60; is false and not a guest account, then this date is entered.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

