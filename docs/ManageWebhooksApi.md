# CyberSource.Api.ManageWebhooksApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWebhookSubscription**](ManageWebhooksApi.md#deletewebhooksubscription) | **DELETE** /notification-subscriptions/v2/webhooks/{webhookId} | Delete a Webhook Subscription
[**GetWebhookSubscriptionById**](ManageWebhooksApi.md#getwebhooksubscriptionbyid) | **GET** /notification-subscriptions/v2/webhooks/{webhookId} | Get Details On a Single Webhook
[**GetWebhookSubscriptionsByOrg**](ManageWebhooksApi.md#getwebhooksubscriptionsbyorg) | **GET** /notification-subscriptions/v2/webhooks | Get Details On All Created Webhooks
[**NotificationSubscriptionsV1WebhooksWebhookIdPost**](ManageWebhooksApi.md#notificationsubscriptionsv1webhookswebhookidpost) | **POST** /notification-subscriptions/v1/webhooks/{webhookId} | Test a Webhook Configuration
[**NotificationSubscriptionsV2WebhooksWebhookIdPatch**](ManageWebhooksApi.md#notificationsubscriptionsv2webhookswebhookidpatch) | **PATCH** /notification-subscriptions/v2/webhooks/{webhookId} | Update a Webhook Subscription
[**NotificationSubscriptionsV2WebhooksWebhookIdStatusPut**](ManageWebhooksApi.md#notificationsubscriptionsv2webhookswebhookidstatusput) | **PUT** /notification-subscriptions/v2/webhooks/{webhookId}/status | Update a Webhook Status
[**SaveAsymEgressKey**](ManageWebhooksApi.md#saveasymegresskey) | **POST** /kms/egress/v2/keys-asym | Message Level Encryption


<a name="deletewebhooksubscription"></a>
# **DeleteWebhookSubscription**
> void DeleteWebhookSubscription (string webhookId)

Delete a Webhook Subscription

Delete the webhook. Please note that deleting a particular webhook does not delete the history of the webhook notifications.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteWebhookSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new ManageWebhooksApi();
            var webhookId = webhookId_example;  // string | The webhook identifier.

            try
            {
                // Delete a Webhook Subscription
                apiInstance.DeleteWebhookSubscription(webhookId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageWebhooksApi.DeleteWebhookSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookId** | **string**| The webhook identifier. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooksubscriptionbyid"></a>
# **GetWebhookSubscriptionById**
> InlineResponse2016 GetWebhookSubscriptionById (string webhookId)

Get Details On a Single Webhook

Retrieve the details of a specific webhook by supplying the webhook ID in the path.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetWebhookSubscriptionByIdExample
    {
        public void main()
        {
            var apiInstance = new ManageWebhooksApi();
            var webhookId = webhookId_example;  // string | The webhook Identifier

            try
            {
                // Get Details On a Single Webhook
                InlineResponse2016 result = apiInstance.GetWebhookSubscriptionById(webhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageWebhooksApi.GetWebhookSubscriptionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookId** | **string**| The webhook Identifier | 

### Return type

[**InlineResponse2016**](InlineResponse2016.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooksubscriptionsbyorg"></a>
# **GetWebhookSubscriptionsByOrg**
> List<InlineResponse2007> GetWebhookSubscriptionsByOrg (string organizationId, string productId = null, string eventType = null)

Get Details On All Created Webhooks

Retrieve a list of all previously created webhooks.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetWebhookSubscriptionsByOrgExample
    {
        public void main()
        {
            var apiInstance = new ManageWebhooksApi();
            var organizationId = organizationId_example;  // string | The Organization Identifier.
            var productId = productId_example;  // string | The Product Identifier. (optional) 
            var eventType = eventType_example;  // string | The Event Type. (optional) 

            try
            {
                // Get Details On All Created Webhooks
                List&lt;InlineResponse2007&gt; result = apiInstance.GetWebhookSubscriptionsByOrg(organizationId, productId, eventType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageWebhooksApi.GetWebhookSubscriptionsByOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| The Organization Identifier. | 
 **productId** | **string**| The Product Identifier. | [optional] 
 **eventType** | **string**| The Event Type. | [optional] 

### Return type

[**List<InlineResponse2007>**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationsubscriptionsv1webhookswebhookidpost"></a>
# **NotificationSubscriptionsV1WebhooksWebhookIdPost**
> InlineResponse2017 NotificationSubscriptionsV1WebhooksWebhookIdPost (string webhookId)

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
                InlineResponse2017 result = apiInstance.NotificationSubscriptionsV1WebhooksWebhookIdPost(webhookId);
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

[**InlineResponse2017**](InlineResponse2017.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationsubscriptionsv2webhookswebhookidpatch"></a>
# **NotificationSubscriptionsV2WebhooksWebhookIdPatch**
> InlineResponse2008 NotificationSubscriptionsV2WebhooksWebhookIdPatch (string webhookId, UpdateWebhook updateWebhook = null)

Update a Webhook Subscription

Update a Webhook Subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class NotificationSubscriptionsV2WebhooksWebhookIdPatchExample
    {
        public void main()
        {
            var apiInstance = new ManageWebhooksApi();
            var webhookId = webhookId_example;  // string | The Webhook Identifier.
            var updateWebhook = new UpdateWebhook(); // UpdateWebhook | The webhook payload or changes to apply. (optional) 

            try
            {
                // Update a Webhook Subscription
                InlineResponse2008 result = apiInstance.NotificationSubscriptionsV2WebhooksWebhookIdPatch(webhookId, updateWebhook);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageWebhooksApi.NotificationSubscriptionsV2WebhooksWebhookIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookId** | **string**| The Webhook Identifier. | 
 **updateWebhook** | [**UpdateWebhook**](UpdateWebhook.md)| The webhook payload or changes to apply. | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationsubscriptionsv2webhookswebhookidstatusput"></a>
# **NotificationSubscriptionsV2WebhooksWebhookIdStatusPut**
> void NotificationSubscriptionsV2WebhooksWebhookIdStatusPut (string webhookId, UpdateStatus updateStatus = null)

Update a Webhook Status

Users can update the status of a webhook subscription by calling this endpoint.   The webhookId parameter in the URL path identifies the specific webhook subscription to be updated. The request body accepts the values ACTIVE or INACTIVE. If the subscription is set to INACTIVE, webhooks will not be delivered until the subscription is activated again. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class NotificationSubscriptionsV2WebhooksWebhookIdStatusPutExample
    {
        public void main()
        {
            var apiInstance = new ManageWebhooksApi();
            var webhookId = webhookId_example;  // string | The Webhook Identifier.
            var updateStatus = new UpdateStatus(); // UpdateStatus | The status that the subscription should be updated to. (optional) 

            try
            {
                // Update a Webhook Status
                apiInstance.NotificationSubscriptionsV2WebhooksWebhookIdStatusPut(webhookId, updateStatus);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageWebhooksApi.NotificationSubscriptionsV2WebhooksWebhookIdStatusPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookId** | **string**| The Webhook Identifier. | 
 **updateStatus** | [**UpdateStatus**](UpdateStatus.md)| The status that the subscription should be updated to. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveasymegresskey"></a>
# **SaveAsymEgressKey**
> InlineResponse2018 SaveAsymEgressKey (string vCSenderOrganizationId, string vCPermissions, SaveAsymEgressKey saveAsymEgressKey, string vCCorrelationId = null)

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
                InlineResponse2018 result = apiInstance.SaveAsymEgressKey(vCSenderOrganizationId, vCPermissions, saveAsymEgressKey, vCCorrelationId);
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

[**InlineResponse2018**](InlineResponse2018.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

