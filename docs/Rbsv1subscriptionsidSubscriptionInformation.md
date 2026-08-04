# CyberSource.Model.Rbsv1subscriptionsidSubscriptionInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Subscription code is an optional field, If not provided system generates and assign one  | [optional] 
**PlanId** | **string** | Plan Id. Use Plan Id from Create Plan Service.  | [optional] 
**Name** | **string** | Subscription Name  | [optional] 
**StartDate** | **string** | Start date of the Subscription  Start date must be in UTC. Format: YYYY-MM-DDThh:mm:ssZ The T separates the date and the time. The Z indicates UTC.  Note: Subscription starts on the day provided in UTC.  **Example** 2022-08-11T22:47:57Z equals August 11, 2022, at 22:47:57 (10:47:57 p.m.). Subscription will start on August 11,2022.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

