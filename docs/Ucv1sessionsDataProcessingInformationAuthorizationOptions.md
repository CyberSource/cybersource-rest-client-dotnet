# CyberSource.Model.Ucv1sessionsDataProcessingInformationAuthorizationOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AftIndicator** | **bool?** | The AFT indicator&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**AuthIndicator** | **string** | The authorization indicator&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**IgnoreCvResult** | **bool?** | Ignore the CV result&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**IgnoreAvsResult** | **bool?** | Ignore the AVS result&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**Initiator** | [**Ucv1sessionsDataProcessingInformationAuthorizationOptionsInitiator**](Ucv1sessionsDataProcessingInformationAuthorizationOptionsInitiator.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

