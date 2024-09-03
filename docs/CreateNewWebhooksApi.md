# CyberSource.Api.CreateNewWebhooksApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWebhookSubscription**](CreateNewWebhooksApi.md#createwebhooksubscription) | **POST** /notification-subscriptions/v1/webhooks | Create a Webhook
[**FindProductsToSubscribe**](CreateNewWebhooksApi.md#findproductstosubscribe) | **GET** /notification-subscriptions/v1/products/{organizationId} | Find Products You Can Subscribe To
[**SaveSymEgressKey**](CreateNewWebhooksApi.md#savesymegresskey) | **POST** /kms/egress/v2/keys-sym | Create Webhook Security Keys


<a name="createwebhooksubscription"></a>
# **CreateWebhookSubscription**
> InlineResponse2014 CreateWebhookSubscription (CreateWebhookRequest createWebhookRequest = null)

Create a Webhook

Create a new webhook subscription. Before creating a webhook, ensure that a security key has been created at the top of this developer center section. You will not need to pass us back the key during the creation of the webhook, but you will receive an error if you did not already create a key or store one on file. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateWebhookSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new CreateNewWebhooksApi();
            var createWebhookRequest = new CreateWebhookRequest(); // CreateWebhookRequest | The webhook payload (optional) 

            try
            {
                // Create a Webhook
                InlineResponse2014 result = apiInstance.CreateWebhookSubscription(createWebhookRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreateNewWebhooksApi.CreateWebhookSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWebhookRequest** | [**CreateWebhookRequest**](CreateWebhookRequest.md)| The webhook payload | [optional] 

### Return type

[**InlineResponse2014**](InlineResponse2014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findproductstosubscribe"></a>
# **FindProductsToSubscribe**
> List<InlineResponse2002> FindProductsToSubscribe (string organizationId)

Find Products You Can Subscribe To

Retrieve a list of products and event types that your account is eligible for. These products and events are the ones that you may subscribe to in the next step of creating webhooks.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class FindProductsToSubscribeExample
    {
        public void main()
        {
            var apiInstance = new CreateNewWebhooksApi();
            var organizationId = organizationId_example;  // string | The Organization Identifier.

            try
            {
                // Find Products You Can Subscribe To
                List&lt;InlineResponse2002&gt; result = apiInstance.FindProductsToSubscribe(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreateNewWebhooksApi.FindProductsToSubscribe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| The Organization Identifier. | 

### Return type

[**List<InlineResponse2002>**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savesymegresskey"></a>
# **SaveSymEgressKey**
> InlineResponse2013 SaveSymEgressKey (string vCSenderOrganizationId, string vCPermissions, string vCCorrelationId = null, SaveSymEgressKey saveSymEgressKey = null)

Create Webhook Security Keys

Create security keys that CyberSource will use internally to connect to your servers and validate messages using a digital signature.  Select the CREATE example for CyberSource to generate the key on our server and maintain it for you as well. Remeber to save the key in the API response, so that you can use it to validate messages later. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class SaveSymEgressKeyExample
    {
        public void main()
        {
            var apiInstance = new CreateNewWebhooksApi();
            var vCSenderOrganizationId = vCSenderOrganizationId_example;  // string | Sender organization id
            var vCPermissions = vCPermissions_example;  // string | Encoded user permissions returned by the CGK, for the entity user who initiated the boarding
            var vCCorrelationId = vCCorrelationId_example;  // string | A globally unique id associated with your request (optional) 
            var saveSymEgressKey = new SaveSymEgressKey(); // SaveSymEgressKey | Provide egress Symmetric key information to save (create or store or refresh) (optional) 

            try
            {
                // Create Webhook Security Keys
                InlineResponse2013 result = apiInstance.SaveSymEgressKey(vCSenderOrganizationId, vCPermissions, vCCorrelationId, saveSymEgressKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreateNewWebhooksApi.SaveSymEgressKey: " + e.Message );
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
 **vCCorrelationId** | **string**| A globally unique id associated with your request | [optional] 
 **saveSymEgressKey** | [**SaveSymEgressKey**](SaveSymEgressKey.md)| Provide egress Symmetric key information to save (create or store or refresh) | [optional] 

### Return type

[**InlineResponse2013**](InlineResponse2013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

