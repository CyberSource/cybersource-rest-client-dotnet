# CyberSource.Model.PtsV2PaymentsPost201ResponseRiskInformationProcessorResults
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FraudDecision** | **string** | Type of filter. Possible values: - ACCEPT - PENDING - DENY - REPORT  | [optional] 
**FraudDecisionReason** | **string** | possible values - AVS_NO_MATCH - AVS_PARTIAL_MATCH - AVS_UNAVAILABLE_OR_UNSUPPORTED - CARD_SECURITY_CODE_MISMATCH - MAXIMUM_TRANSACTION_AMOUNT - UNCONFIRMED_ADDRESS - COUNTRY_MONITOR - LARGE_ORDER_NUMBER - BILLING_OR_SHIPPING_ADDRESS_MISMATCH - RISKY_ZIP_CODE - SUSPECTED_FREIGHT_FORWARDER_CHECK - TOTAL_PURCHASE_PRICE_MINIMUM - IP_ADDRESS_VELOCITY - RISKY_EMAIL_ADDRESS_DOMAIN_CHECK - RISKY_BANK_IDENTIFICATION_NUMBER_CHECK, RISKY_IP_ADDRESS_RANGE - PAYPAL_FRAUD_MODEL  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

