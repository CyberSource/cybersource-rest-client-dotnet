# CyberSource.Model.VpriRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Actions** | **List&lt;string&gt;** | Actions to perform. For VPRI, specify VISA_PROTECT_RISK_INSIGHTS. Multiple actions may be included in a single request to invoke additional services simultaneously. | 
**Events** | **List&lt;string&gt;** | The events to be performed under specific actions. For VISA_PROTECT_RISK_INSIGHTS, supported values are LABELS and INSIGHTS. | 
**Transaction** | [**UnifiedriskTransaction**](UnifiedriskTransaction.md) |  | 
**RequestId** | **string** | Unique identifier for the risk assessment request | [optional] 
**EventTime** | **DateTime?** | The time that the real-world event occurred. | 
**Context** | **string** | The context in which the request is made. | [optional] 
**Mode** | **string** | Indicates whether the request is live or a test. | [optional] 
**RequestComments** | **string** | Brief description or comments about the request | [optional] 
**SchemaVersion** | **int?** | Version of the request schema | [optional] 
**Partner** | [**UnifiedriskPartner**](UnifiedriskPartner.md) |  | [optional] 
**Payment** | [**UnifiedriskPayment**](UnifiedriskPayment.md) |  | [optional] 
**Order** | [**UnifiedriskOrder**](UnifiedriskOrder.md) |  | [optional] 
**Customer** | [**UnifiedriskCustomer**](UnifiedriskCustomer.md) |  | [optional] 
**RiskAssessment** | [**UnifiedriskRiskAssessment**](UnifiedriskRiskAssessment.md) |  | [optional] 
**Travel** | [**UnifiedriskTravel**](UnifiedriskTravel.md) |  | [optional] 
**Merchant** | [**UnifiedriskMerchant**](UnifiedriskMerchant.md) |  | [optional] 
**Acquirer** | [**UnifiedriskAcquirer**](UnifiedriskAcquirer.md) |  | [optional] 
**Device** | [**UnifiedriskDevice**](UnifiedriskDevice.md) |  | [optional] 
**Session** | [**UnifiedriskSession**](UnifiedriskSession.md) |  | [optional] 
**SupplementaryData** | **string** | Free-form field for information not catered for by other components. Must not contain cardholder data or sensitive auth data. | [optional] 
**Labels** | [**UnifiedriskLabels**](UnifiedriskLabels.md) |  | [optional] 
**Account** | [**UnifiedriskAccount**](UnifiedriskAccount.md) |  | [optional] 
**Authentication** | [**UnifiedriskAuthentication**](UnifiedriskAuthentication.md) |  | [optional] 
**Authorization** | [**UnifiedriskAuthorization**](UnifiedriskAuthorization.md) |  | [optional] 
**Browser** | [**UnifiedriskBrowser**](UnifiedriskBrowser.md) |  | [optional] 
**InitiatingParty** | [**UnifiedriskInitiatingParty**](UnifiedriskInitiatingParty.md) |  | [optional] 
**Terminal** | [**UnifiedriskTerminal**](UnifiedriskTerminal.md) |  | [optional] 
**ThirdPartyRisk** | [**UnifiedriskThirdPartyRisk**](UnifiedriskThirdPartyRisk.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

