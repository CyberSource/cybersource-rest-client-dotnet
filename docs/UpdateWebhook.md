# CyberSource.Model.UpdateWebhook
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Client friendly webhook name. | [optional] 
**OrganizationId** | **string** | Organization Id. | [optional] 
**Description** | **string** | Client friendly webhook description. | [optional] 
**Products** | [**List&lt;Notificationsubscriptionsv2webhooksProducts&gt;**](Notificationsubscriptionsv2webhooksProducts.md) |  | [optional] 
**WebhookUrl** | **string** | The client&#39;s endpoint (URL) to receive webhooks. | [optional] 
**HealthCheckUrl** | **string** | The client&#39;s health check endpoint (URL). This should be as close as possible to the actual webhookUrl. | [optional] 
**SecurityPolicy** | [**Notificationsubscriptionsv2webhooksSecurityPolicy**](Notificationsubscriptionsv2webhooksSecurityPolicy.md) |  | [optional] 
**AdditionalAttributes** | **List&lt;Dictionary&lt;string, string&gt;&gt;** | Additional, free form configuration data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

