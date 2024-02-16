# CyberSource.Model.UpdateWebhookRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Client friendly webhook name. | [optional] 
**Description** | **string** | Client friendly webhook description.\\ | [optional] 
**OrganizationId** | **string** | Organization Id. | [optional] 
**ProductId** | **string** | The product you are receiving a webhook for. | [optional] 
**EventTypes** | **List&lt;string&gt;** | Array of the different events for a given product id. | [optional] 
**WebhookUrl** | **string** | The client&#39;s endpoint (URL) to receive webhooks. | [optional] 
**HealthCheckUrl** | **string** | The client&#39;s health check endpoint (URL). This should be as close as possible to the actual webhookUrl. | [optional] 
**Status** | **string** | Webhook status. | [optional] [default to "INACTIVE"]
**NotificationScope** | [**Notificationsubscriptionsv1webhooksNotificationScope**](Notificationsubscriptionsv1webhooksNotificationScope.md) |  | [optional] 
**RetryPolicy** | [**Notificationsubscriptionsv1webhooksRetryPolicy**](Notificationsubscriptionsv1webhooksRetryPolicy.md) |  | [optional] 
**SecurityPolicy** | [**Notificationsubscriptionsv1webhooksSecurityPolicy**](Notificationsubscriptionsv1webhooksSecurityPolicy.md) |  | [optional] 
**AdditionalAttributes** | **List&lt;Dictionary&lt;string, string&gt;&gt;** | Additional, free form configuration data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

