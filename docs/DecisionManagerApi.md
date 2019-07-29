# CyberSource.Api.DecisionManagerApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDecisionManagerCase**](DecisionManagerApi.md#createdecisionmanagercase) | **POST** /risk/v1/decisions | Create Decision Manager Case


<a name="createdecisionmanagercase"></a>
# **CreateDecisionManagerCase**
> RiskV1DecisionsPost201Response CreateDecisionManagerCase (CreateDecisionManagerCaseRequest createDecisionManagerCaseRequest)

Create Decision Manager Case

This is the combined request to the Decision Manager Service for a transaction sent to Cybersource. Decision Manager will return a decision based on the request values. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateDecisionManagerCaseExample
    {
        public void main()
        {
            var apiInstance = new DecisionManagerApi();
            var createDecisionManagerCaseRequest = new CreateDecisionManagerCaseRequest(); // CreateDecisionManagerCaseRequest | 

            try
            {
                // Create Decision Manager Case
                RiskV1DecisionsPost201Response result = apiInstance.CreateDecisionManagerCase(createDecisionManagerCaseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DecisionManagerApi.CreateDecisionManagerCase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createDecisionManagerCaseRequest** | [**CreateDecisionManagerCaseRequest**](CreateDecisionManagerCaseRequest.md)|  | 

### Return type

[**RiskV1DecisionsPost201Response**](RiskV1DecisionsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

