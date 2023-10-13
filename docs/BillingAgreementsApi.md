# CyberSource.Api.BillingAgreementsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BillingAgreementsDeRegistration**](BillingAgreementsApi.md#billingagreementsderegistration) | **PATCH** /pts/v2/billing-agreements/{id} | Standing Instruction Cancellation or Modification
[**BillingAgreementsIntimation**](BillingAgreementsApi.md#billingagreementsintimation) | **POST** /pts/v2/billing-agreements/{id}/intimations | Standing Instruction intimation
[**BillingAgreementsRegistration**](BillingAgreementsApi.md#billingagreementsregistration) | **POST** /pts/v2/billing-agreements | Standing Instruction completion registration


<a name="billingagreementsderegistration"></a>
# **BillingAgreementsDeRegistration**
> PtsV2CreditsPost201Response1 BillingAgreementsDeRegistration (ModifyBillingAgreement modifyBillingAgreement, string id)

Standing Instruction Cancellation or Modification

Standing Instruction with or without Token

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class BillingAgreementsDeRegistrationExample
    {
        public void main()
        {
            var apiInstance = new BillingAgreementsApi();
            var modifyBillingAgreement = new ModifyBillingAgreement(); // ModifyBillingAgreement | 
            var id = id_example;  // string | ID for de-registration or cancellation of Billing Agreement

            try
            {
                // Standing Instruction Cancellation or Modification
                PtsV2CreditsPost201Response1 result = apiInstance.BillingAgreementsDeRegistration(modifyBillingAgreement, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingAgreementsApi.BillingAgreementsDeRegistration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modifyBillingAgreement** | [**ModifyBillingAgreement**](ModifyBillingAgreement.md)|  | 
 **id** | **string**| ID for de-registration or cancellation of Billing Agreement | 

### Return type

[**PtsV2CreditsPost201Response1**](PtsV2CreditsPost201Response1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingagreementsintimation"></a>
# **BillingAgreementsIntimation**
> PtsV2CreditsPost201Response1 BillingAgreementsIntimation (IntimateBillingAgreement intimateBillingAgreement, string id)

Standing Instruction intimation

Standing Instruction with or without Token.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class BillingAgreementsIntimationExample
    {
        public void main()
        {
            var apiInstance = new BillingAgreementsApi();
            var intimateBillingAgreement = new IntimateBillingAgreement(); // IntimateBillingAgreement | 
            var id = id_example;  // string | ID for intimation of Billing Agreement

            try
            {
                // Standing Instruction intimation
                PtsV2CreditsPost201Response1 result = apiInstance.BillingAgreementsIntimation(intimateBillingAgreement, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingAgreementsApi.BillingAgreementsIntimation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **intimateBillingAgreement** | [**IntimateBillingAgreement**](IntimateBillingAgreement.md)|  | 
 **id** | **string**| ID for intimation of Billing Agreement | 

### Return type

[**PtsV2CreditsPost201Response1**](PtsV2CreditsPost201Response1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingagreementsregistration"></a>
# **BillingAgreementsRegistration**
> PtsV2CreditsPost201Response1 BillingAgreementsRegistration (CreateBillingAgreement createBillingAgreement)

Standing Instruction completion registration

Standing Instruction with or without Token. Transaction amount in case First payment is coming along with registration. Only 2 decimal places allowed

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class BillingAgreementsRegistrationExample
    {
        public void main()
        {
            var apiInstance = new BillingAgreementsApi();
            var createBillingAgreement = new CreateBillingAgreement(); // CreateBillingAgreement | 

            try
            {
                // Standing Instruction completion registration
                PtsV2CreditsPost201Response1 result = apiInstance.BillingAgreementsRegistration(createBillingAgreement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingAgreementsApi.BillingAgreementsRegistration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createBillingAgreement** | [**CreateBillingAgreement**](CreateBillingAgreement.md)|  | 

### Return type

[**PtsV2CreditsPost201Response1**](PtsV2CreditsPost201Response1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

