# CyberSource.Model.CreateBundledDecisionManagerCaseRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Riskv1decisionsClientReferenceInformation**](Riskv1decisionsClientReferenceInformation.md) |  | [optional] 
**ProcessorInformation** | [**Riskv1decisionsProcessorInformation**](Riskv1decisionsProcessorInformation.md) |  | [optional] 
**ProcessingInformation** | [**Riskv1decisionsProcessingInformation**](Riskv1decisionsProcessingInformation.md) |  | [optional] 
**PaymentInformation** | [**Riskv1decisionsPaymentInformation**](Riskv1decisionsPaymentInformation.md) |  | [optional] 
**OrderInformation** | [**Riskv1decisionsOrderInformation**](Riskv1decisionsOrderInformation.md) |  | 
**BuyerInformation** | [**Riskv1decisionsBuyerInformation**](Riskv1decisionsBuyerInformation.md) |  | [optional] 
**DeviceInformation** | [**Riskv1decisionsDeviceInformation**](Riskv1decisionsDeviceInformation.md) |  | [optional] 
**RiskInformation** | [**Riskv1decisionsRiskInformation**](Riskv1decisionsRiskInformation.md) |  | [optional] 
**TravelInformation** | [**Riskv1decisionsTravelInformation**](Riskv1decisionsTravelInformation.md) |  | [optional] 
**MerchantDefinedInformation** | [**List&lt;Riskv1decisionsMerchantDefinedInformation&gt;**](Riskv1decisionsMerchantDefinedInformation.md) |  | [optional] 
**MerchantInformation** | [**Riskv1decisionsMerchantInformation**](Riskv1decisionsMerchantInformation.md) |  | [optional] 
**AcquirerInformation** | [**Riskv1decisionsAcquirerInformation**](Riskv1decisionsAcquirerInformation.md) |  | [optional] 
**RecurringPaymentInformation** | [**Ptsv2paymentsRecurringPaymentInformation**](Ptsv2paymentsRecurringPaymentInformation.md) |  | [optional] 
**ConsumerAuthenticationInformation** | [**Riskv1decisionsConsumerAuthenticationInformation**](Riskv1decisionsConsumerAuthenticationInformation.md) |  | [optional] 
**WatchlistScreeningInformation** | [**Ptsv2paymentsWatchlistScreeningInformation**](Ptsv2paymentsWatchlistScreeningInformation.md) |  | [optional] 
**TokenInformation** | [**Riskv1decisionsTokenInformation**](Riskv1decisionsTokenInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

