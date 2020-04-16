# CyberSource.Api.CreditApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCredit**](CreditApi.md#createcredit) | **POST** /pts/v2/credits | Process a Credit


<a name="createcredit"></a>
# **CreateCredit**
> PtsV2CreditsPost201Response CreateCredit (CreateCreditRequest createCreditRequest)

Process a Credit

POST to the credit resource to credit funds to a specified credit card.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateCreditExample
    {
        public void main()
        {
            var apiInstance = new CreditApi();
            var createCreditRequest = new CreateCreditRequest(); // CreateCreditRequest | 

            try
            {
                // Process a Credit
                PtsV2CreditsPost201Response result = apiInstance.CreateCredit(createCreditRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.CreateCredit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createCreditRequest** | [**CreateCreditRequest**](CreateCreditRequest.md)|  | 

### Return type

[**PtsV2CreditsPost201Response**](PtsV2CreditsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

