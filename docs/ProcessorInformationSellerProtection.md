# CyberSource.Model.ProcessorInformationSellerProtection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The kind of seller protection in force for the transaction. This field is returned only when the protection eligibility value is set to ELIGIBLE or PARTIALLY_ELIGIBLE. Possible values - ITEM_NOT_RECEIVED_ELIGIBLE: Sellers are protected against claims for items not received. - UNAUTHORIZED_PAYMENT_ELIGIBLE: Sellers are protected against claims for unauthorized payments. One or both values can be returned.  | [optional] 
**Eligibility** | **string** | Indicates whether the transaction is eligible for seller protection. The values returned are described below. Possible values: - &#x60;ELIGIBLE&#x60; - &#x60;PARTIALLY_ELIGIBLE&#x60; - &#x60;INELIGIBLE&#x60; - &#x60;NOT_ELIGIBLE&#x60;  | [optional] 
**DisputeCategories** | **List&lt;string&gt;** | An array of conditions that are covered for the transaction.  | [optional] 
**EligibilityType** | **string** | The kind of seller protection in force for the transaction. This field is returned only when the protection_eligibility property is set to ELIGIBLE or PARTIALLY_ELIGIBLE. Possible values: - &#x60;ITEM_NOT_RECEIVED_ELIGIBLE: Sellers are protected against claims for items not received.&#x60; - &#x60;UNAUTHORIZED_PAYMENT_ELIGIBLE: Sellers are protected against claims for unauthorized payments.&#x60; One or both values can be returned.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

