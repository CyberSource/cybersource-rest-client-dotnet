# CyberSource.Api.EnrollmentApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EnrollCard**](EnrollmentApi.md#enrollcard) | **POST** /acp/v1/tokens | Enroll a card


<a name="enrollcard"></a>
# **EnrollCard**
> AgenticCardEnrollmentResponse200 EnrollCard (AgenticCardEnrollmentRequest agenticCardEnrollmentRequest)

Enroll a card

Enroll a payment card for agentic or e-commerce transactions. This is typically the first step in the Intelligent Commerce payment lifecycle — the agent calls this endpoint to register a consumer's card, creating a tokenized reference that can be used in subsequent purchase instructions and payment credential retrieval. Requires device information, consumer identity, billing details, and payment instrument references. Returns a status of ACTIVE (HTTP 200) if enrollment completes immediately, or PENDING (HTTP 202) with pendingEvents if cardholder authentication is required. Call this endpoint when a consumer wants to add a new payment card or when setting up a card for agentic payment flows.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class EnrollCardExample
    {
        public void main()
        {
            var apiInstance = new EnrollmentApi();
            var agenticCardEnrollmentRequest = new AgenticCardEnrollmentRequest(); // AgenticCardEnrollmentRequest | 

            try
            {
                // Enroll a card
                AgenticCardEnrollmentResponse200 result = apiInstance.EnrollCard(agenticCardEnrollmentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnrollmentApi.EnrollCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agenticCardEnrollmentRequest** | [**AgenticCardEnrollmentRequest**](AgenticCardEnrollmentRequest.md)|  | 

### Return type

[**AgenticCardEnrollmentResponse200**](AgenticCardEnrollmentResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

