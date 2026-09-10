# CyberSource.Model.UnifiedriskPaymentCounterparty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | Counterparty account identifier | [optional] 
**AccountFormat** | **string** | Counterparty account format | [optional] 
**BranchId** | **string** | Counterparty branch identifier | [optional] 
**Name** | **string** | Full legal name of the counterparty (individual or business) used for identity matching, beneficiary validation, and fraud screening | [optional] 
**Type** | **string** | Classification of the counterparty entity type (e.g., INDIVIDUAL, BUSINESS, FINANCIAL_INSTITUTION). Used for AML screening and beneficiary risk assessment | [optional] 
**AgentId** | **string** | Unique identifier for the financial agent or correspondent bank through which the counterparty payment is being routed | [optional] 
**AgentName** | **string** | Name of the financial agent or correspondent institution facilitating the payment to the counterparty | [optional] 
**BranchAddress** | [**UnifiedriskPaymentCounterpartyBranchAddress**](UnifiedriskPaymentCounterpartyBranchAddress.md) |  | [optional] 
**Address** | [**UnifiedriskPaymentCounterpartyAddress**](UnifiedriskPaymentCounterpartyAddress.md) |  | [optional] 
**CreationTime** | **string** | Timestamp when the counterparty record was created in the system, expressed in ISO 8601 format. Used for new payee fraud detection | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

