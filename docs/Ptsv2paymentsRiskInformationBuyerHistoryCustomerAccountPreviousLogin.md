# CyberSource.Model.Ptsv2paymentsRiskInformationBuyerHistoryCustomerAccountPreviousLogin
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **string** | Date of last login. Format: &#39;YYYYMMDD&#39;  | [optional] 
**DeviceId** | **string** | Full device ID  | [optional] 
**DeviceType** | **string** | Device type (web, mobile, etc.)  | [optional] 
**IpAddress** | [**Ptsv2paymentsRiskInformationBuyerHistoryCustomerAccountPreviousLoginIpAddress**](Ptsv2paymentsRiskInformationBuyerHistoryCustomerAccountPreviousLoginIpAddress.md) |  | [optional] 
**Type** | **string** | Mode used by customer to login to merchant account - Email, Phone, Password, Biometric, Other  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

