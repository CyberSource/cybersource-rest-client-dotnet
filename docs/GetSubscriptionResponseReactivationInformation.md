# CyberSource.Model.GetSubscriptionResponseReactivationInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MissedPaymentsCount** | **string** | Number of payments that should have occurred while the subscription was in a suspended status.  | [optional] 
**MissedPaymentsTotalAmount** | **string** | Total amount that will be charged upon reactivation if &#x60;processMissedPayments&#x60; is set to &#x60;true&#x60;.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

