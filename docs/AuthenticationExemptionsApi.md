# CyberSource.Api.AuthenticationExemptionsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthenticationExemptions**](AuthenticationExemptionsApi.md#authenticationexemptions) | **POST** /risk/v1/authentication-exemptions | Authentication exemptions service


<a name="authenticationexemptions"></a>
# **AuthenticationExemptions**
> RiskV1AuthenticationExemptionsPost201Response AuthenticationExemptions (AuthenticationExemptionsRequest authenticationExemptionsRequest)

Authentication exemptions service

A new CYBS branded service to connect to VISA’s REST API to enable Visa Transaction Advisor (VTA) as a standalone service for merchants to support PSD2/SCA adoption and exemptions processing startegy in Europe.VTA Provides intelligent risk data to merchants as inputs to their in-house fraud management tools for fraud mitigation on Visa transactions. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class AuthenticationExemptionsExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationExemptionsApi();
            var authenticationExemptionsRequest = new AuthenticationExemptionsRequest(); // AuthenticationExemptionsRequest | 

            try
            {
                // Authentication exemptions service
                RiskV1AuthenticationExemptionsPost201Response result = apiInstance.AuthenticationExemptions(authenticationExemptionsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationExemptionsApi.AuthenticationExemptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authenticationExemptionsRequest** | [**AuthenticationExemptionsRequest**](AuthenticationExemptionsRequest.md)|  | 

### Return type

[**RiskV1AuthenticationExemptionsPost201Response**](RiskV1AuthenticationExemptionsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

