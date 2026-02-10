# CyberSource.Api.MerchantBoardingApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRegistration**](MerchantBoardingApi.md#getregistration) | **GET** /boarding/v1/registrations/{registrationId} | Gets all the information on a boarding registration
[**PostRegistration**](MerchantBoardingApi.md#postregistration) | **POST** /boarding/v1/registrations | Create a boarding registration


<a name="getregistration"></a>
# **GetRegistration**
> InlineResponse2005 GetRegistration (string registrationId)

Gets all the information on a boarding registration

This end point will get all information of a boarding registration 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetRegistrationExample
    {
        public void main()
        {
            var apiInstance = new MerchantBoardingApi();
            var registrationId = registrationId_example;  // string | Identifies the boarding registration to be updated

            try
            {
                // Gets all the information on a boarding registration
                InlineResponse2005 result = apiInstance.GetRegistration(registrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantBoardingApi.GetRegistration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registrationId** | **string**| Identifies the boarding registration to be updated | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postregistration"></a>
# **PostRegistration**
> InlineResponse2014 PostRegistration (PostRegistrationBody postRegistrationBody, string vCIdempotencyId = null)

Create a boarding registration

Boarding Product is specifically for resellers who onboard merchants to resell their services to merchants and help integrate REST API into their systems.  The Boarding API is designed to simplify and streamline the onboarding process of merchants by enabling administrators and developers to: 1. Enable and Configure Products: The API helps in adding new products to an existing organization and configuring them to suit specific needs. 2. Update Merchant Information: The API allows for updating an organization's information efficiently. 3. Manage Payment Integration: It provides templates for secure payment integration and management. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostRegistrationExample
    {
        public void main()
        {
            var apiInstance = new MerchantBoardingApi();
            var postRegistrationBody = new PostRegistrationBody(); // PostRegistrationBody | Boarding registration data
            var vCIdempotencyId = vCIdempotencyId_example;  // string | defines idempotency of the request (optional) 

            try
            {
                // Create a boarding registration
                InlineResponse2014 result = apiInstance.PostRegistration(postRegistrationBody, vCIdempotencyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantBoardingApi.PostRegistration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postRegistrationBody** | [**PostRegistrationBody**](PostRegistrationBody.md)| Boarding registration data | 
 **vCIdempotencyId** | **string**| defines idempotency of the request | [optional] 

### Return type

[**InlineResponse2014**](InlineResponse2014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

