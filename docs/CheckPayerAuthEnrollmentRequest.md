# CyberSource.Model.CheckPayerAuthEnrollmentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Riskv1decisionsClientReferenceInformation**](Riskv1decisionsClientReferenceInformation.md) |  | [optional] 
**OrderInformation** | [**Riskv1authenticationsOrderInformation**](Riskv1authenticationsOrderInformation.md) |  | [optional] 
**PaymentInformation** | [**Riskv1authenticationsPaymentInformation**](Riskv1authenticationsPaymentInformation.md) |  | [optional] 
**ProcessingInformation** | [**Riskv1authenticationsetupsProcessingInformation**](Riskv1authenticationsetupsProcessingInformation.md) |  | [optional] 
**TokenInformation** | [**Riskv1authenticationsetupsTokenInformation**](Riskv1authenticationsetupsTokenInformation.md) |  | [optional] 
**BuyerInformation** | [**Riskv1authenticationsBuyerInformation**](Riskv1authenticationsBuyerInformation.md) |  | [optional] 
**DeviceInformation** | [**Riskv1authenticationsDeviceInformation**](Riskv1authenticationsDeviceInformation.md) |  | [optional] 
**MerchantInformation** | [**Riskv1decisionsMerchantInformation**](Riskv1decisionsMerchantInformation.md) |  | [optional] 
**AcquirerInformation** | [**Riskv1decisionsAcquirerInformation**](Riskv1decisionsAcquirerInformation.md) |  | [optional] 
**RecurringPaymentInformation** | [**Ptsv2paymentsRecurringPaymentInformation**](Ptsv2paymentsRecurringPaymentInformation.md) |  | [optional] 
**ConsumerAuthenticationInformation** | [**Riskv1decisionsConsumerAuthenticationInformation**](Riskv1decisionsConsumerAuthenticationInformation.md) |  | [optional] 
**RiskInformation** | [**Riskv1authenticationsRiskInformation**](Riskv1authenticationsRiskInformation.md) |  | [optional] 
**TravelInformation** | [**Riskv1authenticationsTravelInformation**](Riskv1authenticationsTravelInformation.md) |  | [optional] 
**MerchantDefinedInformation** | [**List&lt;Riskv1decisionsMerchantDefinedInformation&gt;**](Riskv1decisionsMerchantDefinedInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

