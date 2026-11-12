# CyberSource.Model.Ptsv2paymentsRiskInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | [**Ptsv2paymentsRiskInformationProfile**](Ptsv2paymentsRiskInformationProfile.md) |  | [optional] 
**EventType** | **string** | Specifies one of the following types of events: - login - account_creation - account_update For regular payment transactions, do not send this field.  | [optional] 
**BuyerHistory** | [**Ptsv2paymentsRiskInformationBuyerHistory**](Ptsv2paymentsRiskInformationBuyerHistory.md) |  | [optional] 
**AuxiliaryData** | [**List&lt;Ptsv2paymentsRiskInformationAuxiliaryData&gt;**](Ptsv2paymentsRiskInformationAuxiliaryData.md) |  | [optional] 
**Store** | [**Ptsv2paymentsRiskInformationStore**](Ptsv2paymentsRiskInformationStore.md) |  | [optional] 
**AuthenticationType** | **string** | • 01 &#x3D; Static Passcode • 02 &#x3D; SMS OTP • 03 &#x3D; Key fob or EMV card reader OTP • 04 &#x3D; App OTP • 05 &#x3D; OTP Other • 07 &#x3D; OOB Biometrics • 08 &#x3D; OOB Login • 09 &#x3D; OOB Other • 10 &#x3D; Other • 11 &#x3D; Push Confirmation • 12 &#x3D; Decoupled • 13 &#x3D; WebAuthn • 14 &#x3D; SPC • 15 &#x3D; Behavioural biometrics  | [optional] 
**PickupDays** | **decimal?** | Number of days between transaction date and rental pickup date  | [optional] 
**ExternalScore** | [**Ptsv2paymentsRiskInformationExternalScore**](Ptsv2paymentsRiskInformationExternalScore.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

