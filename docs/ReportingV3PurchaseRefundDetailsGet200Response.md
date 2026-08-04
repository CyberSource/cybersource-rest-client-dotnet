# CyberSource.Model.ReportingV3PurchaseRefundDetailsGet200Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Offset** | **int?** |  | [optional] 
**Limit** | **int?** |  | [optional] 
**PageResults** | **int?** |  | [optional] 
**RequestDetails** | [**List&lt;ReportingV3PurchaseRefundDetailsGet200ResponseRequestDetails&gt;**](ReportingV3PurchaseRefundDetailsGet200ResponseRequestDetails.md) | List of Request Info values | [optional] 
**Settlements** | [**List&lt;ReportingV3PurchaseRefundDetailsGet200ResponseSettlements&gt;**](ReportingV3PurchaseRefundDetailsGet200ResponseSettlements.md) | List of Settlement Info values | [optional] 
**Authorizations** | [**List&lt;ReportingV3PurchaseRefundDetailsGet200ResponseAuthorizations&gt;**](ReportingV3PurchaseRefundDetailsGet200ResponseAuthorizations.md) | List of Authorization Info values | [optional] 
**FeeAndFundingDetails** | [**List&lt;ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails&gt;**](ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails.md) | List of Fee Funding Info values | [optional] 
**Others** | [**List&lt;ReportingV3PurchaseRefundDetailsGet200ResponseOthers&gt;**](ReportingV3PurchaseRefundDetailsGet200ResponseOthers.md) | List of Other Info values | [optional] 
**SettlementStatuses** | [**List&lt;ReportingV3PurchaseRefundDetailsGet200ResponseSettlementStatuses&gt;**](ReportingV3PurchaseRefundDetailsGet200ResponseSettlementStatuses.md) | List of Settlement Status Info values | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

