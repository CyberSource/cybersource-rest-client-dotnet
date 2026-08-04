# CyberSource.Model.ValidateExportComplianceRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**RiskV1DecisionsPost201ResponseClientReferenceInformation**](RiskV1DecisionsPost201ResponseClientReferenceInformation.md) |  | [optional] 
**OrderInformation** | [**Riskv1exportcomplianceinquiriesOrderInformation**](Riskv1exportcomplianceinquiriesOrderInformation.md) |  | [optional] 
**BuyerInformation** | [**Riskv1addressverificationsBuyerInformation**](Riskv1addressverificationsBuyerInformation.md) |  | [optional] 
**DeviceInformation** | [**Riskv1exportcomplianceinquiriesDeviceInformation**](Riskv1exportcomplianceinquiriesDeviceInformation.md) |  | [optional] 
**ExportComplianceInformation** | [**Riskv1exportcomplianceinquiriesExportComplianceInformation**](Riskv1exportcomplianceinquiriesExportComplianceInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

