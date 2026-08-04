# CyberSource.Model.PaymentsConfigurationSetupAlternativePaymentMethods
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationStatus** | [**PaymentsConfigurationSetupAlternativePaymentMethodsConfigurationStatus**](PaymentsConfigurationSetupAlternativePaymentMethodsConfigurationStatus.md) |  | [optional] 
**SubscriptionStatus** | [**PaymentsConfigurationSetupAlternativePaymentMethodsConfigurationStatus**](PaymentsConfigurationSetupAlternativePaymentMethodsConfigurationStatus.md) |  | [optional] 
**Status** | **string** | Possible values: - PROCESSED - PARTIAL_PROCESSED | [optional] 
**SubmitTimeUtc** | **DateTime?** | Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60; Example: 2024-09-08T09:37:38+0000  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

