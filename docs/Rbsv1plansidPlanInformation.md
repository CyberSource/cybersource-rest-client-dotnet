# CyberSource.Model.Rbsv1plansidPlanInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Plan code is an optional field, If not provided system generates and assign one  | [optional] 
**Name** | **string** | Plan name  | [optional] 
**Description** | **string** | Plan description  | [optional] 
**Status** | **string** | Updating to &#x60;DRAFT&#x60; is not allowed from &#x60;ACTIVE&#x60; and &#x60;INACTIVE&#x60; status.  Plan Status:  - &#x60;DRAFT&#x60;  - &#x60;ACTIVE&#x60;  - &#x60;INACTIVE&#x60;  | [optional] 
**BillingPeriod** | [**GetAllPlansResponsePlanInformationBillingPeriod**](GetAllPlansResponsePlanInformationBillingPeriod.md) |  | [optional] 
**BillingCycles** | [**Rbsv1plansPlanInformationBillingCycles**](Rbsv1plansPlanInformationBillingCycles.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

