# CyberSource.Api.PlansApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivatePlan**](PlansApi.md#activateplan) | **POST** /rbs/v1/plans/{id}/activate | Activate a Plan
[**CreatePlan**](PlansApi.md#createplan) | **POST** /rbs/v1/plans | Create a Plan
[**DeactivatePlan**](PlansApi.md#deactivateplan) | **POST** /rbs/v1/plans/{id}/deactivate | Deactivate a Plan
[**DeletePlan**](PlansApi.md#deleteplan) | **DELETE** /rbs/v1/plans/{id} | Delete a Plan
[**GetPlan**](PlansApi.md#getplan) | **GET** /rbs/v1/plans/{id} | Get a Plan
[**GetPlanCode**](PlansApi.md#getplancode) | **GET** /rbs/v1/plans/code | Get a Plan Code
[**GetPlans**](PlansApi.md#getplans) | **GET** /rbs/v1/plans | Get a List of Plans
[**UpdatePlan**](PlansApi.md#updateplan) | **PATCH** /rbs/v1/plans/{id} | Update a Plan


<a name="activateplan"></a>
# **ActivatePlan**
> ActivateDeactivatePlanResponse ActivatePlan (string id)

Activate a Plan

Activate a Plan

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ActivatePlanExample
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var id = id_example;  // string | Plan Id

            try
            {
                // Activate a Plan
                ActivateDeactivatePlanResponse result = apiInstance.ActivatePlan(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.ActivatePlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Plan Id | 

### Return type

[**ActivateDeactivatePlanResponse**](ActivateDeactivatePlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createplan"></a>
# **CreatePlan**
> CreatePlanResponse CreatePlan (CreatePlanRequest createPlanRequest)

Create a Plan

The recurring billing service enables you to manage payment plans and subscriptions for recurring payment schedules. It securely stores your customer's payment information and personal data within secure Visa data centers, reducing storage risks and PCI DSS scope through the use of *Token Management* (*TMS*).  The three key elements of *Cybersource* Recurring Billing are:  -  **Token**: stores customer billing, shipping, and payment details.  -  **Plan**: stores the billing schedule.  -  **Subscription**: combines the token and plan, and defines the subscription start date, name, and description.  The APIs in this section demonstrate the management of the Plans and Subscriptions. For Tokens please refer to [Token Management](#token-management) 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreatePlanExample
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var createPlanRequest = new CreatePlanRequest(); // CreatePlanRequest | 

            try
            {
                // Create a Plan
                CreatePlanResponse result = apiInstance.CreatePlan(createPlanRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.CreatePlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createPlanRequest** | [**CreatePlanRequest**](CreatePlanRequest.md)|  | 

### Return type

[**CreatePlanResponse**](CreatePlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deactivateplan"></a>
# **DeactivatePlan**
> ActivateDeactivatePlanResponse DeactivatePlan (string id)

Deactivate a Plan

Deactivate a Plan

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeactivatePlanExample
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var id = id_example;  // string | Plan Id

            try
            {
                // Deactivate a Plan
                ActivateDeactivatePlanResponse result = apiInstance.DeactivatePlan(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.DeactivatePlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Plan Id | 

### Return type

[**ActivateDeactivatePlanResponse**](ActivateDeactivatePlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteplan"></a>
# **DeletePlan**
> DeletePlanResponse DeletePlan (string id)

Delete a Plan

Delete a Plan is only allowed: - plan status is in `DRAFT` - plan status is in `ACTIVE`, and `INACTIVE` only allowed when no subscriptions attached to a plan in the lifetime of a plan 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeletePlanExample
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var id = id_example;  // string | Plan Id

            try
            {
                // Delete a Plan
                DeletePlanResponse result = apiInstance.DeletePlan(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.DeletePlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Plan Id | 

### Return type

[**DeletePlanResponse**](DeletePlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplan"></a>
# **GetPlan**
> GetPlanResponse GetPlan (string id)

Get a Plan

Retrieve a Plan details by Plan Id.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetPlanExample
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var id = id_example;  // string | Plan Id

            try
            {
                // Get a Plan
                GetPlanResponse result = apiInstance.GetPlan(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.GetPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Plan Id | 

### Return type

[**GetPlanResponse**](GetPlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplancode"></a>
# **GetPlanCode**
> GetPlanCodeResponse GetPlanCode ()

Get a Plan Code

Get a Unique Plan Code

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetPlanCodeExample
    {
        public void main()
        {
            var apiInstance = new PlansApi();

            try
            {
                // Get a Plan Code
                GetPlanCodeResponse result = apiInstance.GetPlanCode();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.GetPlanCode: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetPlanCodeResponse**](GetPlanCodeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplans"></a>
# **GetPlans**
> GetAllPlansResponse GetPlans (int? offset = null, int? limit = null, string code = null, string status = null, string name = null)

Get a List of Plans

Retrieve Plans by Plan Code & Plan Status. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetPlansExample
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var offset = 56;  // int? | Page offset number. (optional) 
            var limit = 56;  // int? | Number of items to be returned. Default - `20`, Max - `100`  (optional) 
            var code = code_example;  // string | Filter by Plan Code (optional) 
            var status = status_example;  // string | Filter by Plan Status (optional) 
            var name = name_example;  // string | Filter by Plan Name. (First sub string or full string) **[Not Recommended]**  (optional) 

            try
            {
                // Get a List of Plans
                GetAllPlansResponse result = apiInstance.GetPlans(offset, limit, code, status, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.GetPlans: " + e.Message );
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
 **code** | **string**| Filter by Plan Code | [optional] 
 **status** | **string**| Filter by Plan Status | [optional] 
 **name** | **string**| Filter by Plan Name. (First sub string or full string) **[Not Recommended]**  | [optional] 

### Return type

[**GetAllPlansResponse**](GetAllPlansResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateplan"></a>
# **UpdatePlan**
> UpdatePlanResponse UpdatePlan (string id, UpdatePlanRequest updatePlanRequest)

Update a Plan

Update a Plan  Plan in `DRAFT` status - All updates are allowed on Plan with `DRAFT` status  Plan in `ACTIVE` status [Following fields are **Not Updatable**] - `planInformation.billingPeriod` - `planInformation.billingCycles` [Update is only allowed to **increase** billingCycles] - `orderInformation.amountDetails.currency` 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdatePlanExample
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var id = id_example;  // string | Plan Id
            var updatePlanRequest = new UpdatePlanRequest(); // UpdatePlanRequest | 

            try
            {
                // Update a Plan
                UpdatePlanResponse result = apiInstance.UpdatePlan(id, updatePlanRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.UpdatePlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Plan Id | 
 **updatePlanRequest** | [**UpdatePlanRequest**](UpdatePlanRequest.md)|  | 

### Return type

[**UpdatePlanResponse**](UpdatePlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json, application/hal+json, application/json;charset=utf-8, application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

