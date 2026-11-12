# CyberSource.Api.CreateNewWebhooksApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWebhookSubscription**](CreateNewWebhooksApi.md#createwebhooksubscription) | **POST** /notification-subscriptions/v2/webhooks | Create a New Webhook Subscription
[**FindProductsToSubscribe**](CreateNewWebhooksApi.md#findproductstosubscribe) | **GET** /notification-subscriptions/v2/products/{organizationId} | Find Products You Can Subscribe To
[**SaveSymEgressKey**](CreateNewWebhooksApi.md#savesymegresskey) | **POST** /kms/egress/v2/keys-sym | Create Webhook Security Keys


<a name="createwebhooksubscription"></a>
# **CreateWebhookSubscription**
> CreateWebhookSubscriptionResponse CreateWebhookSubscription (CreateWebhook createWebhook = null)

Create a New Webhook Subscription

Create a new webhook subscription. Before creating a webhook, ensure that a signature key has been created.  For the example \"Create Webhook using oAuth with Client Credentials\" - for clients who have more than one oAuth Provider and have different client secrets that they would like to config for a given webhook, they may do so by overriding the keyId inside security config of webhook subscription. See the Developer Center examples section titled \"Webhook Security - Create or Store Egress Symmetric Key - Store oAuth Credentials For Symmetric Key\" to store these oAuth credentials that CYBS will need for oAuth.  For JWT authentication, attach your oAuth details to the webhook subscription. See the example \"Create Webhook using oAuth with JWT\" 

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
            var createWebhook = new CreateWebhook(); // CreateWebhook | The webhook payload (optional) 

            try
            {
                // Create a New Webhook Subscription
                CreateWebhookSubscriptionResponse result = apiInstance.CreateWebhookSubscription(createWebhook);
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
 **createWebhook** | [**CreateWebhook**](CreateWebhook.md)| The webhook payload | [optional] 

### Return type

[**CreateWebhookSubscriptionResponse**](CreateWebhookSubscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findproductstosubscribe"></a>
# **FindProductsToSubscribe**
> List<ProductCatalogProduct> FindProductsToSubscribe (string organizationId)

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
                List&lt;ProductCatalogProduct&gt; result = apiInstance.FindProductsToSubscribe(organizationId);
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

[**List<ProductCatalogProduct>**](ProductCatalogProduct.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savesymegresskey"></a>
# **SaveSymEgressKey**
> SaveSymEgressKeyResponse SaveSymEgressKey (string vCCorrelationId = null, string vCSenderOrganizationId = null, string vCPermissions = null, SaveSymEgressKey saveSymEgressKey = null)

Create Webhook Security Keys

Create security keys that CyberSource will use internally to connect to your servers and validate messages using a digital signature.  Select the CREATE example for CyberSource to generate the key on our server and maintain it for you as well. Remember to save the key in the API response, so that you can use it to validate messages later. 

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
            var vCCorrelationId = vCCorrelationId_example;  // string | A globally unique id associated with your request (optional) 
            var vCSenderOrganizationId = vCSenderOrganizationId_example;  // string | Sender organization id (optional) 
            var vCPermissions = vCPermissions_example;  // string | Encoded user permissions returned by the CGK, for the entity user who initiated the boarding (optional) 
            var saveSymEgressKey = new SaveSymEgressKey(); // SaveSymEgressKey | Provide egress Symmetric key information to save (create or store or refresh) (optional) 

            try
            {
                // Create Webhook Security Keys
                SaveSymEgressKeyResponse result = apiInstance.SaveSymEgressKey(vCCorrelationId, vCSenderOrganizationId, vCPermissions, saveSymEgressKey);
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
 **vCCorrelationId** | **string**| A globally unique id associated with your request | [optional] 
 **vCSenderOrganizationId** | **string**| Sender organization id | [optional] 
 **vCPermissions** | **string**| Encoded user permissions returned by the CGK, for the entity user who initiated the boarding | [optional] 
 **saveSymEgressKey** | [**SaveSymEgressKey**](SaveSymEgressKey.md)| Provide egress Symmetric key information to save (create or store or refresh) | [optional] 

### Return type

[**SaveSymEgressKeyResponse**](SaveSymEgressKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

