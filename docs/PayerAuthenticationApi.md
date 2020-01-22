# CyberSource.Api.PayerAuthenticationApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckPayerAuthEnrollment**](PayerAuthenticationApi.md#checkpayerauthenrollment) | **POST** /risk/v1/authentications | Check payer auth enrollment
[**ValidateAuthenticationResults**](PayerAuthenticationApi.md#validateauthenticationresults) | **POST** /risk/v1/authentication-results | Validate authentication results


<a name="checkpayerauthenrollment"></a>
# **CheckPayerAuthEnrollment**
> RiskV1AuthenticationsPost201Response CheckPayerAuthEnrollment (CheckPayerAuthEnrollmentRequest checkPayerAuthEnrollmentRequest)

Check payer auth enrollment

This call verifies that the card is enrolled in a card authentication program.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CheckPayerAuthEnrollmentExample
    {
        public void main()
        {
            var apiInstance = new PayerAuthenticationApi();
            var checkPayerAuthEnrollmentRequest = new CheckPayerAuthEnrollmentRequest(); // CheckPayerAuthEnrollmentRequest | 

            try
            {
                // Check payer auth enrollment
                RiskV1AuthenticationsPost201Response result = apiInstance.CheckPayerAuthEnrollment(checkPayerAuthEnrollmentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayerAuthenticationApi.CheckPayerAuthEnrollment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **checkPayerAuthEnrollmentRequest** | [**CheckPayerAuthEnrollmentRequest**](CheckPayerAuthEnrollmentRequest.md)|  | 

### Return type

[**RiskV1AuthenticationsPost201Response**](RiskV1AuthenticationsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validateauthenticationresults"></a>
# **ValidateAuthenticationResults**
> RiskV1AuthenticationResultsPost201Response ValidateAuthenticationResults (ValidateRequest validateRequest)

Validate authentication results

This call retrieves and validates the authentication results from issuer and allows the merchant to proceed with processing the payment. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ValidateAuthenticationResultsExample
    {
        public void main()
        {
            var apiInstance = new PayerAuthenticationApi();
            var validateRequest = new ValidateRequest(); // ValidateRequest | 

            try
            {
                // Validate authentication results
                RiskV1AuthenticationResultsPost201Response result = apiInstance.ValidateAuthenticationResults(validateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayerAuthenticationApi.ValidateAuthenticationResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **validateRequest** | [**ValidateRequest**](ValidateRequest.md)|  | 

### Return type

[**RiskV1AuthenticationResultsPost201Response**](RiskV1AuthenticationResultsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

