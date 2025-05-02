# CyberSource.Model.CreateWebhook
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Client friendly webhook name. | [optional] 
**Description** | **string** | Client friendly webhook description. | [optional] 
**OrganizationId** | **string** | Organization Identifier (OrgId) or Merchant Identifier (MID). | [optional] 
**Products** | [**List&lt;Notificationsubscriptionsv2webhooksProducts1&gt;**](Notificationsubscriptionsv2webhooksProducts1.md) | To see the valid productId and eventTypes, call the \&quot;Create and Manage Webhooks - Retrieve a list of event types\&quot; endpoint. | [optional] 
**WebhookUrl** | **string** | The client&#39;s endpoint (URL) to receive webhooks. | [optional] 
**HealthCheckUrl** | **string** | The client&#39;s health check endpoint (URL). This should be as close as possible to the actual webhookUrl. If the user does not provide the health check URL, it is the user&#39;s responsibility to re-activate the webhook if it is deactivated by calling the test endpoint.  | [optional] 
**RetryPolicy** | [**Notificationsubscriptionsv2webhooksRetryPolicy**](Notificationsubscriptionsv2webhooksRetryPolicy.md) |  | [optional] 
**SecurityPolicy** | [**Notificationsubscriptionsv2webhooksSecurityPolicy1**](Notificationsubscriptionsv2webhooksSecurityPolicy1.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

