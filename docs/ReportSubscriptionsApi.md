# CyberSource.Api.ReportSubscriptionsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscription**](ReportSubscriptionsApi.md#createsubscription) | **PUT** /reporting/v3/report-subscriptions | Create Report Subscription for a report name by organization
[**DeleteSubscription**](ReportSubscriptionsApi.md#deletesubscription) | **DELETE** /reporting/v3/report-subscriptions/{reportName} | Delete subscription of a report name by organization
[**GetAllSubscriptions**](ReportSubscriptionsApi.md#getallsubscriptions) | **GET** /reporting/v3/report-subscriptions | Get all subscriptions
[**GetSubscription**](ReportSubscriptionsApi.md#getsubscription) | **GET** /reporting/v3/report-subscriptions/{reportName} | Get subscription for report name
[**ReportingV3PredefinedReportSubscriptionsPut**](ReportSubscriptionsApi.md#reportingv3predefinedreportsubscriptionsput) | **PUT** /reporting/v3/predefined-report-subscriptions | Create a Standard or Classic subscription


<a name="createsubscription"></a>
# **CreateSubscription**
> void CreateSubscription (CreateReportSubscriptionRequest createReportSubscriptionRequest, string organizationId = null)

Create Report Subscription for a report name by organization

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
            var organizationId = organizationId_example;  // string | Valid Cybersource Organization Id (optional) 

            try
            {
                // Create Report Subscription for a report name by organization
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
 **organizationId** | **string**| Valid Cybersource Organization Id | [optional] 

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

Get all subscriptions

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

            try
            {
                // Get all subscriptions
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

Get subscription for report name

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

            try
            {
                // Get subscription for report name
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

<a name="reportingv3predefinedreportsubscriptionsput"></a>
# **ReportingV3PredefinedReportSubscriptionsPut**
> void ReportingV3PredefinedReportSubscriptionsPut (PredefinedSubscriptionRequestBean predefinedSubscriptionRequestBean, string organizationId = null)

Create a Standard or Classic subscription

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
    public class ReportingV3PredefinedReportSubscriptionsPutExample
    {
        public void main()
        {
            var apiInstance = new ReportSubscriptionsApi();
            var predefinedSubscriptionRequestBean = new PredefinedSubscriptionRequestBean(); // PredefinedSubscriptionRequestBean | Report subscription request payload
            var organizationId = organizationId_example;  // string | Valid Cybersource Organization Id (optional) 

            try
            {
                // Create a Standard or Classic subscription
                apiInstance.ReportingV3PredefinedReportSubscriptionsPut(predefinedSubscriptionRequestBean, organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportSubscriptionsApi.ReportingV3PredefinedReportSubscriptionsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predefinedSubscriptionRequestBean** | [**PredefinedSubscriptionRequestBean**](PredefinedSubscriptionRequestBean.md)| Report subscription request payload | 
 **organizationId** | **string**| Valid Cybersource Organization Id | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

