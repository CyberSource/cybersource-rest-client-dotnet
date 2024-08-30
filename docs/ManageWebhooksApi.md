# CyberSource.Api.ManageWebhooksApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWebhookSubscription**](ManageWebhooksApi.md#deletewebhooksubscription) | **DELETE** /notification-subscriptions/v1/webhooks/{webhookId} | Delete a Webhook Subscription
[**GetWebhookSubscriptionById**](ManageWebhooksApi.md#getwebhooksubscriptionbyid) | **GET** /notification-subscriptions/v1/webhooks/{webhookId} | Get Details On a Single Webhook
[**GetWebhookSubscriptionsByOrg**](ManageWebhooksApi.md#getwebhooksubscriptionsbyorg) | **GET** /notification-subscriptions/v1/webhooks | Get Details On All Created Webhooks
[**SaveAsymEgressKey**](ManageWebhooksApi.md#saveasymegresskey) | **POST** /kms/egress/v2/keys-asym | Message Level Encryption
[**UpdateWebhookSubscription**](ManageWebhooksApi.md#updatewebhooksubscription) | **PATCH** /notification-subscriptions/v1/webhooks/{webhookId} | Update a Webhook Subscription


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
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooksubscriptionbyid"></a>
# **GetWebhookSubscriptionById**
> InlineResponse2004 GetWebhookSubscriptionById (string webhookId)

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
                InlineResponse2004 result = apiInstance.GetWebhookSubscriptionById(webhookId);
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

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooksubscriptionsbyorg"></a>
# **GetWebhookSubscriptionsByOrg**
> List<InlineResponse2003> GetWebhookSubscriptionsByOrg (string organizationId, string productId, string eventType)

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
            var productId = productId_example;  // string | The Product Identifier.
            var eventType = eventType_example;  // string | The Event Type.

            try
            {
                // Get Details On All Created Webhooks
                List&lt;InlineResponse2003&gt; result = apiInstance.GetWebhookSubscriptionsByOrg(organizationId, productId, eventType);
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
 **productId** | **string**| The Product Identifier. | 
 **eventType** | **string**| The Event Type. | 

### Return type

[**List<InlineResponse2003>**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

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
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewebhooksubscription"></a>
# **UpdateWebhookSubscription**
> void UpdateWebhookSubscription (string webhookId, UpdateWebhookRequest updateWebhookRequest = null)

Update a Webhook Subscription

Update the webhook subscription using PATCH.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateWebhookSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new ManageWebhooksApi();
            var webhookId = webhookId_example;  // string | The Webhook Identifier.
            var updateWebhookRequest = new UpdateWebhookRequest(); // UpdateWebhookRequest | The webhook payload or changes to apply. (optional) 

            try
            {
                // Update a Webhook Subscription
                apiInstance.UpdateWebhookSubscription(webhookId, updateWebhookRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManageWebhooksApi.UpdateWebhookSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookId** | **string**| The Webhook Identifier. | 
 **updateWebhookRequest** | [**UpdateWebhookRequest**](UpdateWebhookRequest.md)| The webhook payload or changes to apply. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

