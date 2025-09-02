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

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

