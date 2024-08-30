# CyberSource.Api.MerchantBoardingApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRegistration**](MerchantBoardingApi.md#getregistration) | **GET** /boarding/v1/registrations/{registrationId} | Gets all the information on a boarding registration
[**PostRegistration**](MerchantBoardingApi.md#postregistration) | **POST** /boarding/v1/registrations | Create a boarding registration


<a name="getregistration"></a>
# **GetRegistration**
> InlineResponse2001 GetRegistration (string registrationId)

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
                InlineResponse2001 result = apiInstance.GetRegistration(registrationId);
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postregistration"></a>
# **PostRegistration**
> InlineResponse2012 PostRegistration (PostRegistrationBody postRegistrationBody, string vCIdempotencyId = null)

Create a boarding registration

Create a registration to board merchant  If you have  Card Processing product enabled in your boarding request, select payment processor from Configuration -> Sample Request. You may unselect attributes from the Request Builder tree which you do not need in the request. For VPC, CUP and EFTPOS processors, replace the processor name from VPC or CUP or EFTPOS to the actual processor name in the sample request. e.g. replace VPC with &lt;your vpc processor&gt; 

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
                InlineResponse2012 result = apiInstance.PostRegistration(postRegistrationBody, vCIdempotencyId);
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

[**InlineResponse2012**](InlineResponse2012.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

