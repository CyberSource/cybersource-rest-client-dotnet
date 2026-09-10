# CyberSource.Model.UnifiedriskRiskAssessmentBuyerHistoryCustomerAccountAlertnateAuthentication
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthenticationMethod** | **string** | Method used for alternate authentication during the current session (e.g., FRICTIONLESS, OTP, BIOMETRIC, PUSH_NOTIFICATION). Used as a risk signal in the 3DS flow | [optional] 
**AuthenticationDate** | **string** | Date and time of the alternate authentication event in ISO 8601 format. Recency of authentication affects risk scoring and challenge exemption decisions | [optional] 
**AuthenticationData** | **string** | Opaque data payload from the alternate authentication process (e.g., signed assertion, biometric template reference). Value is issuer or method specific | [optional] 
**PriorAuthenticationMethod** | **string** | Authentication method used in the most recent prior authentication for this account (e.g., OTP, PASSWORD, BIOMETRIC). Provides historical authentication context | [optional] 
**PriorAuthenticationDate** | **string** | Date and time of the most recent prior authentication event in ISO 8601 format, used to calculate authentication recency risk signals | [optional] 
**PriorAuthenticationData** | **string** | Opaque data payload from the prior authentication event, providing additional context about the historical authentication assertion | [optional] 
**PriorAuthenticationRef** | **string** | Reference identifier linking back to the prior authentication session or transaction, used for session continuity and risk correlation | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

