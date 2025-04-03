# CyberSource.Api.ManageWebhooksApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NotificationSubscriptionsV1WebhooksWebhookIdPost**](ManageWebhooksApi.md#notificationsubscriptionsv1webhookswebhookidpost) | **POST** /notification-subscriptions/v1/webhooks/{webhookId} | Test a Webhook Configuration
[**SaveAsymEgressKey**](ManageWebhooksApi.md#saveasymegresskey) | **POST** /kms/egress/v2/keys-asym | Message Level Encryption


<a name="notificationsubscriptionsv1webhookswebhookidpost"></a>
# **NotificationSubscriptionsV1WebhooksWebhookIdPost**
> InlineResponse2014 NotificationSubscriptionsV1WebhooksWebhookIdPost (string webhookId)

Test a Webhook Configuration

Test the webhook configuration by sending a sample webhook. Calling this endpoint sends a sample webhook to the endpoint identified in the user's subscription.   It will contain sample values for the product & eventType based on values present in your subscription along with a sample message in the payload.   Based on the webhook response users can make any necessary modifications or rest assured knowing their setup is configured correctly. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class NotificationSubscriptionsV1WebhooksWebhookIdPostExample
    {
        public void main()
        {
            var apiInstance = new ManageWebhooksApi();
            var webhookId = webhookId_example;  // string | The Webhook Identifier.

            try
            {
                // Test a Webhook Configuration
                InlineResponse2014 result = apiInstance.NotificationSubscriptionsV1WebhooksWebhookIdPost(webhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageWebhooksApi.NotificationSubscriptionsV1WebhooksWebhookIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookId** | **string**| The Webhook Identifier. | 

### Return type

[**InlineResponse2014**](InlineResponse2014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveasymegresskey"></a>
# **SaveAsymEgressKey**
> InlineResponse2015 SaveAsymEgressKey (string vCSenderOrganizationId, string vCPermissions, SaveAsymEgressKey saveAsymEgressKey, string vCCorrelationId = null)

Message Level Encryption

Store and manage certificates that will be used to preform Message Level Encryption (MLE). Each new webhook will need its own unique asymmetric certificate. You can either use a digital certificate issued/signed by a CA or self-sign your own using the documentation available on the Developer Guide. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class SaveAsymEgressKeyExample
    {
        public void main()
        {
            var apiInstance = new ManageWebhooksApi();
            var vCSenderOrganizationId = vCSenderOrganizationId_example;  // string | Sender organization id
            var vCPermissions = vCPermissions_example;  // string | Encoded user permissions returned by the CGK, for the entity user who initiated the boarding
            var saveAsymEgressKey = new SaveAsymEgressKey(); // SaveAsymEgressKey | Provide egress Asymmetric key information to save (create or store)
            var vCCorrelationId = vCCorrelationId_example;  // string | A globally unique id associated with your request (optional) 

            try
            {
                // Message Level Encryption
                InlineResponse2015 result = apiInstance.SaveAsymEgressKey(vCSenderOrganizationId, vCPermissions, saveAsymEgressKey, vCCorrelationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageWebhooksApi.SaveAsymEgressKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vCSenderOrganizationId** | **string**| Sender organization id | 
 **vCPermissions** | **string**| Encoded user permissions returned by the CGK, for the entity user who initiated the boarding | 
 **saveAsymEgressKey** | [**SaveAsymEgressKey**](SaveAsymEgressKey.md)| Provide egress Asymmetric key information to save (create or store) | 
 **vCCorrelationId** | **string**| A globally unique id associated with your request | [optional] 

### Return type

[**InlineResponse2015**](InlineResponse2015.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

