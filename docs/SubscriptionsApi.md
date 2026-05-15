# CyberSource.Api.SubscriptionsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateSubscription**](SubscriptionsApi.md#activatesubscription) | **POST** /rbs/v1/subscriptions/{id}/activate | Reactivating a Suspended Subscription
[**CancelSubscription**](SubscriptionsApi.md#cancelsubscription) | **POST** /rbs/v1/subscriptions/{id}/cancel | Cancel a Subscription
[**CreateSubscription**](SubscriptionsApi.md#createsubscription) | **POST** /rbs/v1/subscriptions | Create a Subscription
[**GetAllSubscriptions**](SubscriptionsApi.md#getallsubscriptions) | **GET** /rbs/v1/subscriptions | Get a List of Subscriptions
[**GetSubscription**](SubscriptionsApi.md#getsubscription) | **GET** /rbs/v1/subscriptions/{id} | Get a Subscription
[**GetSubscriptionCode**](SubscriptionsApi.md#getsubscriptioncode) | **GET** /rbs/v1/subscriptions/code | Get a Subscription Code
[**SubscriptionsIdPaymentsGet**](SubscriptionsApi.md#subscriptionsidpaymentsget) | **GET** /rbs/v1/subscriptions/{id}/payments | Get Payments for a Subscription
[**SubscriptionsIdPaymentsPut**](SubscriptionsApi.md#subscriptionsidpaymentsput) | **PUT** /rbs/v1/subscriptions/{id}/payments | Update Payments for a subscription
[**SuspendSubscription**](SubscriptionsApi.md#suspendsubscription) | **POST** /rbs/v1/subscriptions/{id}/suspend | Suspend a Subscription
[**UpdateSubscription**](SubscriptionsApi.md#updatesubscription) | **PATCH** /rbs/v1/subscriptions/{id} | Update a Subscription


<a name="activatesubscription"></a>
# **ActivateSubscription**
> ActivateSubscriptionResponse ActivateSubscription (string id, bool? processMissedPayments = null)

Reactivating a Suspended Subscription

# Reactivating a Suspended Subscription  You can reactivate a suspended subscription for the next billing cycle. You cannot reactivate a canceled or completed subscription.  You can specify whether you want to process missed payments for the period during which the subscription was suspended using the `processMissedPayments` query parameter by setting it to true or false.  If no value is specified, the system will default to `true`.  **Important:** The \"processMissedPayments\" query parameter is only effective when the Ask each time before reactivating option is selected in the reactivation settings. If any other option is chosen, the value provided in the request will be ignored by the system. For more information, see the [Recurring Billing User Guide](https://developer.cybersource.com/docs/cybs/en-us/recurring-billing/user/all/rest/recurring-billing-user/recurring-billing-user-about-guide.html).  You can check how many payments were missed and the total amount by retrieving the subscription details, where you will find the `reactivationInformation` object. See: [Retrieving a Subscription](https://developer.cybersource.com/docs/cybs/en-us/recurring-billing/developer/all/rest/recurring-billing-dev/recur-bill-subscriptions/recur-bill-getting-a-subscription.html). 

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
            var processMissedPayments = true;  // bool? | Indicates if missed payments should be processed from the period when the subscription was suspended. By default, this is set to true. When any option other than \"Ask each time before reactivating\" is selected in the reactivation settings, the value that you enter will be ignored.  (optional)  (default to true)

            try
            {
                // Reactivating a Suspended Subscription
                ActivateSubscriptionResponse result = apiInstance.ActivateSubscription(id, processMissedPayments);
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
 **processMissedPayments** | **bool?**| Indicates if missed payments should be processed from the period when the subscription was suspended. By default, this is set to true. When any option other than \&quot;Ask each time before reactivating\&quot; is selected in the reactivation settings, the value that you enter will be ignored.  | [optional] [default to true]

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
> GetAllSubscriptionsResponse GetAllSubscriptions (int? offset = null, int? limit = null, string code = null, string status = null, string customerId = null, string clientReferenceInformationCode = null)

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
            var customerId = customerId_example;  // string | Filter by Customer Id (optional) 
            var clientReferenceInformationCode = clientReferenceInformationCode_example;  // string | Filter by Client Reference Information Code / Merchant Reference Number (optional) 

            try
            {
                // Get a List of Subscriptions
                GetAllSubscriptionsResponse result = apiInstance.GetAllSubscriptions(offset, limit, code, status, customerId, clientReferenceInformationCode);
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
 **customerId** | **string**| Filter by Customer Id | [optional] 
 **clientReferenceInformationCode** | **string**| Filter by Client Reference Information Code / Merchant Reference Number | [optional] 

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

<a name="subscriptionsidpaymentsget"></a>
# **SubscriptionsIdPaymentsGet**
> GetSubscriptionsPaymentsResponse SubscriptionsIdPaymentsGet (string id, int? offset = null, int? limit = null, int? scheduledPaymentsCount = null)

Get Payments for a Subscription

Retrieve a list of payments for a specific subscription by its ID. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class SubscriptionsIdPaymentsGetExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | Subscription Id
            var offset = 56;  // int? | Page offset number. (optional) 
            var limit = 56;  // int? | Number of items to be returned. Default - `20`, Max - `100`  (optional) 
            var scheduledPaymentsCount = 56;  // int? | Number of existing scheduled payments to be returned. Default - `5`, Max - `9999`  (optional) 

            try
            {
                // Get Payments for a Subscription
                GetSubscriptionsPaymentsResponse result = apiInstance.SubscriptionsIdPaymentsGet(id, offset, limit, scheduledPaymentsCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsIdPaymentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Subscription Id | 
 **offset** | **int?**| Page offset number. | [optional] 
 **limit** | **int?**| Number of items to be returned. Default - &#x60;20&#x60;, Max - &#x60;100&#x60;  | [optional] 
 **scheduledPaymentsCount** | **int?**| Number of existing scheduled payments to be returned. Default - &#x60;5&#x60;, Max - &#x60;9999&#x60;  | [optional] 

### Return type

[**GetSubscriptionsPaymentsResponse**](GetSubscriptionsPaymentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsidpaymentsput"></a>
# **SubscriptionsIdPaymentsPut**
> GetSubscriptionsPaymentsResponse1 SubscriptionsIdPaymentsPut (string id, UpdatePayments updatePayments)

Update Payments for a subscription

Modifies the state of a subscription's payments. Currently, the only possible modifications are \"skipping\" and \"restoring\" payments.  Marking a payment as \"skipped\" means it will not be processed when its scheduled time arrives. \"Restoring\" a payment removes it from the list of payments to be skipped. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class SubscriptionsIdPaymentsPutExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | Subscription Id
            var updatePayments = new UpdatePayments(); // UpdatePayments | Modify payments of a subscription

            try
            {
                // Update Payments for a subscription
                GetSubscriptionsPaymentsResponse1 result = apiInstance.SubscriptionsIdPaymentsPut(id, updatePayments);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsIdPaymentsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Subscription Id | 
 **updatePayments** | [**UpdatePayments**](UpdatePayments.md)| Modify payments of a subscription | 

### Return type

[**GetSubscriptionsPaymentsResponse1**](GetSubscriptionsPaymentsResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

