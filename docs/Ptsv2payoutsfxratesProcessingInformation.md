# CyberSource.Model.Ptsv2payoutsfxratesProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionType** | **string** | Indicate that the FX rate is for a push (OCT) or pull (AFT) transaction. If the field is not passed, it defaults to PUSH (OCT).  Enum: &#x60;PUSH&#x60;, &#x60;PULL&#x60;  Supported for Visa Direct.  | [optional] 
**ClearingSystem** | **string** | System used for clearing.  Values: - &#x60;SINGLE&#x60; - &#x60;DUAL&#x60;  Supported for Mastercard Send.  | [optional] 
**TransactionTypeIndicator** | **string** | The Mastercard Transaction Type Indicator is an alphanumeric or numeric code that identifies the business purpose and transaction category for Mastercard‑routed payments. It is used by the Mastercard network to support correct processing, compliance controls, risk evaluation, and reporting.  This field is treated as a pass‑through parameter. The indicator is forwarded as provided to downstream processors and the Mastercard network, where validation and interpretation occur. Supplying an incorrect or missing value may result in network declines, misclassification, or compliance issues with Mastercard.  Example values: - &#x60;C07&#x60; or &#x60;204&#x60; – General person‑to‑person - &#x60;C55&#x60; or &#x60;208&#x60; – Business disbursement - &#x60;C65&#x60; or &#x60;213&#x60; – Business‑to‑business transfer - &#x60;P70&#x60; or &#x60;231&#x60; – Cryptocurrency  Important: Clients are responsible for ensuring the value accurately reflects the transaction intent and complies with Mastercard network requirements.  | [optional] 
**Routing** | [**Ptsv2payoutsfxratesProcessingInformationRouting**](Ptsv2payoutsfxratesProcessingInformationRouting.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

