# CyberSource.Model.Ptsv2paymentsPromotionInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalCode** | **string** | Additional rental agency marketed coupons for consumers to discount the rate of the vehicle rental agreement.  | [optional] 
**Code** | **string** | Code for a promotion or discount.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

