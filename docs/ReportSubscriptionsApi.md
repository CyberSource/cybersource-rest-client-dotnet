# CyberSource.Api.ReportSubscriptionsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscription**](ReportSubscriptionsApi.md#createsubscription) | **PUT** /reporting/v3/report-subscriptions/{reportName} | Create Report Subscription for a report name by organization
[**DeleteSubscription**](ReportSubscriptionsApi.md#deletesubscription) | **DELETE** /reporting/v3/report-subscriptions/{reportName} | Delete subscription of a report name by organization
[**GetAllSubscriptions**](ReportSubscriptionsApi.md#getallsubscriptions) | **GET** /reporting/v3/report-subscriptions | Retrieve all subscriptions by organization
[**GetSubscription**](ReportSubscriptionsApi.md#getsubscription) | **GET** /reporting/v3/report-subscriptions/{reportName} | Retrieve subscription for a report name by organization


<a name="createsubscription"></a>
# **CreateSubscription**
> void CreateSubscription (string reportName, RequestBody requestBody)

Create Report Subscription for a report name by organization



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
            var apiInstance = new ReportSubscriptionsApi();
            var reportName = reportName_example;  // string | Name of the Report to Create
            var requestBody = new RequestBody(); // RequestBody | Report subscription request payload

            try
            {
                // Create Report Subscription for a report name by organization
                apiInstance.CreateSubscription(reportName, requestBody);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportSubscriptionsApi.CreateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportName** | **string**| Name of the Report to Create | 
 **requestBody** | [**RequestBody**](RequestBody.md)| Report subscription request payload | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscription"></a>
# **DeleteSubscription**
> void DeleteSubscription (string reportName)

Delete subscription of a report name by organization



### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new ReportSubscriptionsApi();
            var reportName = reportName_example;  // string | Name of the Report to Delete

            try
            {
                // Delete subscription of a report name by organization
                apiInstance.DeleteSubscription(reportName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportSubscriptionsApi.DeleteSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportName** | **string**| Name of the Report to Delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallsubscriptions"></a>
# **GetAllSubscriptions**
> ReportingV3ReportSubscriptionsGet200Response GetAllSubscriptions ()

Retrieve all subscriptions by organization



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
            var apiInstance = new ReportSubscriptionsApi();

            try
            {
                // Retrieve all subscriptions by organization
                ReportingV3ReportSubscriptionsGet200Response result = apiInstance.GetAllSubscriptions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportSubscriptionsApi.GetAllSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ReportingV3ReportSubscriptionsGet200Response**](ReportingV3ReportSubscriptionsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscription"></a>
# **GetSubscription**
> ReportingV3ReportSubscriptionsGet200ResponseSubscriptions GetSubscription (string reportName)

Retrieve subscription for a report name by organization



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
            var apiInstance = new ReportSubscriptionsApi();
            var reportName = reportName_example;  // string | Name of the Report to Retrieve

            try
            {
                // Retrieve subscription for a report name by organization
                ReportingV3ReportSubscriptionsGet200ResponseSubscriptions result = apiInstance.GetSubscription(reportName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportSubscriptionsApi.GetSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportName** | **string**| Name of the Report to Retrieve | 

### Return type

[**ReportingV3ReportSubscriptionsGet200ResponseSubscriptions**](ReportingV3ReportSubscriptionsGet200ResponseSubscriptions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

