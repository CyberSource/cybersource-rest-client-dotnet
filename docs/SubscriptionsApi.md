# CyberSource.Api.SubscriptionsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateSubscription**](SubscriptionsApi.md#activatesubscription) | **POST** /rbs/v1/subscriptions/{id}/activate | Activate a Subscription
[**CancelSubscription**](SubscriptionsApi.md#cancelsubscription) | **POST** /rbs/v1/subscriptions/{id}/cancel | Cancel a Subscription
[**CreateSubscription**](SubscriptionsApi.md#createsubscription) | **POST** /rbs/v1/subscriptions | Create a Subscription
[**GetAllSubscriptions**](SubscriptionsApi.md#getallsubscriptions) | **GET** /rbs/v1/subscriptions | Get a List of Subscriptions
[**GetSubscription**](SubscriptionsApi.md#getsubscription) | **GET** /rbs/v1/subscriptions/{id} | Get a Subscription
[**GetSubscriptionCode**](SubscriptionsApi.md#getsubscriptioncode) | **GET** /rbs/v1/subscriptions/code | Get a Subscription Code
[**SuspendSubscription**](SubscriptionsApi.md#suspendsubscription) | **POST** /rbs/v1/subscriptions/{id}/suspend | Suspend a Subscription
[**UpdateSubscription**](SubscriptionsApi.md#updatesubscription) | **PATCH** /rbs/v1/subscriptions/{id} | Update a Subscription


<a name="activatesubscription"></a>
# **ActivateSubscription**
> ActivateSubscriptionResponse ActivateSubscription (string id)

Activate a Subscription

Activate a `CANCELLED` Or `SUSPENDED` Subscription 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ActivateSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | Subscription Id

            try
            {
                // Activate a Subscription
                ActivateSubscriptionResponse result = apiInstance.ActivateSubscription(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.ActivateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Subscription Id | 

### Return type

[**ActivateSubscriptionResponse**](ActivateSubscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelsubscription"></a>
# **CancelSubscription**
> CancelSubscriptionResponse CancelSubscription (string id)

Cancel a Subscription

Cancel a Subscription

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CancelSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | Subscription Id

            try
            {
                // Cancel a Subscription
                CancelSubscriptionResponse result = apiInstance.CancelSubscription(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.CancelSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Subscription Id | 

### Return type

[**CancelSubscriptionResponse**](CancelSubscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubscription"></a>
# **CreateSubscription**
> CreateSubscriptionResponse CreateSubscription (CreateSubscriptionRequest createSubscriptionRequest)

Create a Subscription

Create a Recurring Billing Subscription

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var createSubscriptionRequest = new CreateSubscriptionRequest(); // CreateSubscriptionRequest | 

            try
            {
                // Create a Subscription
                CreateSubscriptionResponse result = apiInstance.CreateSubscription(createSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.CreateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createSubscriptionRequest** | [**CreateSubscriptionRequest**](CreateSubscriptionRequest.md)|  | 

### Return type

[**CreateSubscriptionResponse**](CreateSubscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallsubscriptions"></a>
# **GetAllSubscriptions**
> GetAllSubscriptionsResponse GetAllSubscriptions (int? offset = null, int? limit = null, string code = null, string status = null)

Get a List of Subscriptions

Retrieve Subscriptions by Subscription Code & Subscription Status. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetAllSubscriptionsExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var offset = 56;  // int? | Page offset number. (optional) 
            var limit = 56;  // int? | Number of items to be returned. Default - `20`, Max - `100`  (optional) 
            var code = code_example;  // string | Filter by Subscription Code (optional) 
            var status = status_example;  // string | Filter by Subscription Status (optional) 

            try
            {
                // Get a List of Subscriptions
                GetAllSubscriptionsResponse result = apiInstance.GetAllSubscriptions(offset, limit, code, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetAllSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| Page offset number. | [optional] 
 **limit** | **int?**| Number of items to be returned. Default - &#x60;20&#x60;, Max - &#x60;100&#x60;  | [optional] 
 **code** | **string**| Filter by Subscription Code | [optional] 
 **status** | **string**| Filter by Subscription Status | [optional] 

### Return type

[**GetAllSubscriptionsResponse**](GetAllSubscriptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscription"></a>
# **GetSubscription**
> GetSubscriptionResponse GetSubscription (string id)

Get a Subscription

Get a Subscription by Subscription Id

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | Subscription Id

            try
            {
                // Get a Subscription
                GetSubscriptionResponse result = apiInstance.GetSubscription(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Subscription Id | 

### Return type

[**GetSubscriptionResponse**](GetSubscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptioncode"></a>
# **GetSubscriptionCode**
> GetSubscriptionCodeResponse GetSubscriptionCode ()

Get a Subscription Code

Get a Unique Subscription Code

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetSubscriptionCodeExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();

            try
            {
                // Get a Subscription Code
                GetSubscriptionCodeResponse result = apiInstance.GetSubscriptionCode();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetSubscriptionCode: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetSubscriptionCodeResponse**](GetSubscriptionCodeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suspendsubscription"></a>
# **SuspendSubscription**
> SuspendSubscriptionResponse SuspendSubscription (string id)

Suspend a Subscription

Suspend a Subscription

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class SuspendSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | Subscription Id

            try
            {
                // Suspend a Subscription
                SuspendSubscriptionResponse result = apiInstance.SuspendSubscription(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SuspendSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Subscription Id | 

### Return type

[**SuspendSubscriptionResponse**](SuspendSubscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesubscription"></a>
# **UpdateSubscription**
> UpdateSubscriptionResponse UpdateSubscription (string id, UpdateSubscription updateSubscription)

Update a Subscription

Update a Subscription by Subscription Id

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | Subscription Id
            var updateSubscription = new UpdateSubscription(); // UpdateSubscription | Update Subscription

            try
            {
                // Update a Subscription
                UpdateSubscriptionResponse result = apiInstance.UpdateSubscription(id, updateSubscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.UpdateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Subscription Id | 
 **updateSubscription** | [**UpdateSubscription**](UpdateSubscription.md)| Update Subscription | 

### Return type

[**UpdateSubscriptionResponse**](UpdateSubscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

