# CyberSource.Api.ReportSubscriptionsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStandardOrClassicSubscription**](ReportSubscriptionsApi.md#createstandardorclassicsubscription) | **PUT** /reporting/v3/predefined-report-subscriptions | Create a Standard or Classic Subscription
[**CreateSubscription**](ReportSubscriptionsApi.md#createsubscription) | **PUT** /reporting/v3/report-subscriptions | Create Report Subscription for a Report Name by Organization
[**DeleteSubscription**](ReportSubscriptionsApi.md#deletesubscription) | **DELETE** /reporting/v3/report-subscriptions/{reportName} | Delete Subscription of a Report Name by Organization
[**GetAllSubscriptions**](ReportSubscriptionsApi.md#getallsubscriptions) | **GET** /reporting/v3/report-subscriptions | Get All Subscriptions
[**GetSubscription**](ReportSubscriptionsApi.md#getsubscription) | **GET** /reporting/v3/report-subscriptions/{reportName} | Get Subscription for Report Name


<a name="createstandardorclassicsubscription"></a>
# **CreateStandardOrClassicSubscription**
> void CreateStandardOrClassicSubscription (PredefinedSubscriptionRequestBean predefinedSubscriptionRequestBean, string organizationId = null)

Create a Standard or Classic Subscription

Create or update an already existing classic or standard subscription. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateStandardOrClassicSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new ReportSubscriptionsApi();
            var predefinedSubscriptionRequestBean = new PredefinedSubscriptionRequestBean(); // PredefinedSubscriptionRequestBean | Report subscription request payload
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 

            try
            {
                // Create a Standard or Classic Subscription
                apiInstance.CreateStandardOrClassicSubscription(predefinedSubscriptionRequestBean, organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportSubscriptionsApi.CreateStandardOrClassicSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predefinedSubscriptionRequestBean** | [**PredefinedSubscriptionRequestBean**](PredefinedSubscriptionRequestBean.md)| Report subscription request payload | 
 **organizationId** | **string**| Valid Organization Id | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubscription"></a>
# **CreateSubscription**
> void CreateSubscription (CreateReportSubscriptionRequest createReportSubscriptionRequest, string organizationId = null)

Create Report Subscription for a Report Name by Organization

Create a report subscription for your organization. The report name must be unique. 

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
            var createReportSubscriptionRequest = new CreateReportSubscriptionRequest(); // CreateReportSubscriptionRequest | Report subscription request payload
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 

            try
            {
                // Create Report Subscription for a Report Name by Organization
                apiInstance.CreateSubscription(createReportSubscriptionRequest, organizationId);
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
 **createReportSubscriptionRequest** | [**CreateReportSubscriptionRequest**](CreateReportSubscriptionRequest.md)| Report subscription request payload | 
 **organizationId** | **string**| Valid Organization Id | [optional] 

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
> void DeleteSubscription (string reportName, string organizationId = null)

Delete Subscription of a Report Name by Organization

Delete a report subscription for your organization. You must know the unique name of the report you want to delete. 

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
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 

            try
            {
                // Delete Subscription of a Report Name by Organization
                apiInstance.DeleteSubscription(reportName, organizationId);
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
 **organizationId** | **string**| Valid Organization Id | [optional] 

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
> ReportingV3ReportSubscriptionsGet200Response GetAllSubscriptions (string organizationId = null)

Get All Subscriptions

View a summary of all report subscriptions. 

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
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 

            try
            {
                // Get All Subscriptions
                ReportingV3ReportSubscriptionsGet200Response result = apiInstance.GetAllSubscriptions(organizationId);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Valid Organization Id | [optional] 

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
> ReportingV3ReportSubscriptionsGet200ResponseSubscriptions GetSubscription (string reportName, string organizationId = null)

Get Subscription for Report Name

View the details of a report subscription, such as the report format or report frequency, using the report’s unique name. 

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
            var organizationId = organizationId_example;  // string | Valid Organization Id (optional) 

            try
            {
                // Get Subscription for Report Name
                ReportingV3ReportSubscriptionsGet200ResponseSubscriptions result = apiInstance.GetSubscription(reportName, organizationId);
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
 **organizationId** | **string**| Valid Organization Id | [optional] 

### Return type

[**ReportingV3ReportSubscriptionsGet200ResponseSubscriptions**](ReportingV3ReportSubscriptionsGet200ResponseSubscriptions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

