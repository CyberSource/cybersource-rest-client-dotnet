# CyberSource.Model.UnifiedriskRiskAssessment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ThirdPartyIndicators** | **string** | Any risk indicators provided by a third party provider that is integrated with ARIC. This is a free text field, and if there are multiple risk indicators, they should each be separated by a comma. | [optional] 
**ThirdPartyScore** | **decimal?** | Risk Score provided by a third party that is integrated with ARIC. | [optional] 
**ThirdPartyScores** | **Object** |  | [optional] 
**BuyerHistory** | [**UnifiedriskRiskAssessmentBuyerHistory**](UnifiedriskRiskAssessmentBuyerHistory.md) |  | [optional] 
**AuxiliaryData** | **Object** |  | [optional] 
**Vital4** | [**UnifiedriskRiskAssessmentVital4**](UnifiedriskRiskAssessmentVital4.md) |  | [optional] 
**IsConfirmedRisk** | **bool?** | Indicates whether this transaction has been confirmed as fraudulent or high-risk through post-transaction investigation. True flags the transaction for model feedback and alert closure | [optional] 
**ReportedBy** | **string** | Identifier or name of the entity (customer, merchant, or internal team) that reported this transaction as fraudulent or suspicious | [optional] 
**MerchantScore** | **string** | Risk score specific to the merchant&#39;s fraud exposure level, derived from the merchant&#39;s historical fraud rates, chargeback ratio, and industry risk profile | [optional] 
**MerchantFraudRate** | **string** | The merchant&#39;s fraud rate expressed as a percentage or basis points, representing the ratio of confirmed fraudulent transactions to total transactions over a rolling period | [optional] 
**TrustlistStatus** | **string** | Indicates whether the payer or payee appears on a trust list, reducing friction for known-good entities. Values - TRUSTED, UNTRUSTED, UNKNOWN | [optional] 
**TrustlistSource** | **string** | The source system or registry that determined the trustlist status (e.g., MERCHANT_WHITELIST, NETWORK_WHITELIST, INTERNAL_TRUSTLIST) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

