# CyberSource.Api.SubscriptionsFollowOnsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFollowOnSubscription**](SubscriptionsFollowOnsApi.md#createfollowonsubscription) | **POST** /rbs/v1/subscriptions/follow-ons/{requestId} | Create a Follow-On Subscription
[**GetFollowOnSubscription**](SubscriptionsFollowOnsApi.md#getfollowonsubscription) | **GET** /rbs/v1/subscriptions/follow-ons/{requestId} | Get a Follow-On Subscription


<a name="createfollowonsubscription"></a>
# **CreateFollowOnSubscription**
> CreateSubscriptionResponse CreateFollowOnSubscription (string requestId, CreateSubscriptionRequest1 createSubscriptionRequest)

Create a Follow-On Subscription

Create a new Subscription based on the Request Id of an existing successful Transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateFollowOnSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsFollowOnsApi();
            var requestId = requestId_example;  // string | Request Id of an existing successful Transaction
            var createSubscriptionRequest = new CreateSubscriptionRequest1(); // CreateSubscriptionRequest1 | 

            try
            {
                // Create a Follow-On Subscription
                CreateSubscriptionResponse result = apiInstance.CreateFollowOnSubscription(requestId, createSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsFollowOnsApi.CreateFollowOnSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**| Request Id of an existing successful Transaction | 
 **createSubscriptionRequest** | [**CreateSubscriptionRequest1**](CreateSubscriptionRequest1.md)|  | 

### Return type

[**CreateSubscriptionResponse**](CreateSubscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfollowonsubscription"></a>
# **GetFollowOnSubscription**
> GetSubscriptionResponse1 GetFollowOnSubscription (string requestId)

Get a Follow-On Subscription

Get details of the Subscription being created based on the Request Id of an existing successful Transaction. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetFollowOnSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsFollowOnsApi();
            var requestId = requestId_example;  // string | Request Id of an existing successful Transaction

            try
            {
                // Get a Follow-On Subscription
                GetSubscriptionResponse1 result = apiInstance.GetFollowOnSubscription(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsFollowOnsApi.GetFollowOnSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**| Request Id of an existing successful Transaction | 

### Return type

[**GetSubscriptionResponse1**](GetSubscriptionResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

