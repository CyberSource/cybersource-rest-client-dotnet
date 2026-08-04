# CyberSource.Model.UpdateWebhook
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Client friendly webhook name. | [optional] 
**OrganizationId** | **string** | Organization Id. | [optional] 
**Description** | **string** | Client friendly webhook description. | [optional] 
**Products** | [**List&lt;Notificationsubscriptionsv2webhooksProducts&gt;**](Notificationsubscriptionsv2webhooksProducts.md) |  | [optional] 
**WebhookUrl** | **string** | The client&#39;s endpoint (URL) to receive webhooks. | [optional] 
**NotificationScope** | **string** | The webhook scope. 1. SELF The Webhook is used to deliver webhooks for only this Organization (or Merchant). 2. DESCENDANTS The Webhook is used to deliver webhooks for this Organization and its children. This field is optional.    Possible values: - SELF - DESCENDANTS | [optional] [default to "DESCENDANTS"]
**HealthCheckUrl** | **string** | The client&#39;s health check endpoint (URL). | [optional] 
**SecurityPolicy** | [**Notificationsubscriptionsv2webhooksSecurityPolicy**](Notificationsubscriptionsv2webhooksSecurityPolicy.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

