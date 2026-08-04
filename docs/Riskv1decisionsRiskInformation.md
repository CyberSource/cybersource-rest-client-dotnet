# CyberSource.Model.Riskv1decisionsRiskInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | [**Ptsv2paymentsRiskInformationProfile**](Ptsv2paymentsRiskInformationProfile.md) |  | [optional] 
**EventType** | **string** | Specifies one of the following types of events: - login - account_creation - account_update For regular payment transactions, do not send this field.  | [optional] 
**BuyerHistory** | [**Ptsv2paymentsRiskInformationBuyerHistory**](Ptsv2paymentsRiskInformationBuyerHistory.md) |  | [optional] 
**AuxiliaryData** | [**List&lt;Ptsv2paymentsRiskInformationAuxiliaryData&gt;**](Ptsv2paymentsRiskInformationAuxiliaryData.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

