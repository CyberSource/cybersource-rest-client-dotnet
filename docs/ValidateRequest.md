# CyberSource.Model.ValidateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Riskv1decisionsClientReferenceInformation**](Riskv1decisionsClientReferenceInformation.md) |  | [optional] 
**ProcessingInformation** | [**Riskv1authenticationsetupsProcessingInformation**](Riskv1authenticationsetupsProcessingInformation.md) |  | [optional] 
**OrderInformation** | [**Riskv1authenticationresultsOrderInformation**](Riskv1authenticationresultsOrderInformation.md) |  | [optional] 
**PaymentInformation** | [**Riskv1authenticationresultsPaymentInformation**](Riskv1authenticationresultsPaymentInformation.md) |  | [optional] 
**ConsumerAuthenticationInformation** | [**Riskv1authenticationresultsConsumerAuthenticationInformation**](Riskv1authenticationresultsConsumerAuthenticationInformation.md) |  | [optional] 
**DeviceInformation** | [**Riskv1authenticationresultsDeviceInformation**](Riskv1authenticationresultsDeviceInformation.md) |  | [optional] 
**TokenInformation** | [**Riskv1decisionsTokenInformation**](Riskv1decisionsTokenInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

