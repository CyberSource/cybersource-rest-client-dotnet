# CyberSource.Api.ProcessAPayoutApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OctCreatePayment**](ProcessAPayoutApi.md#octcreatepayment) | **POST** /pts/v2/payouts/ | Process a Payout


<a name="octcreatepayment"></a>
# **OctCreatePayment**
> PtsV2PayoutsPost201Response OctCreatePayment (PtsV2PayoutsPostResponse octCreatePaymentRequest)

Process a Payout

Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class OctCreatePaymentExample
    {
        public void main()
        {
            var apiInstance = new ProcessAPayoutApi();
            var octCreatePaymentRequest = new PtsV2PayoutsPostResponse(); // PtsV2PayoutsPostResponse | 

            try
            {
                // Process a Payout
                PtsV2PayoutsPost201Response result = apiInstance.OctCreatePayment(octCreatePaymentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessAPayoutApi.OctCreatePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **octCreatePaymentRequest** | [**PtsV2PayoutsPostResponse**](PtsV2PayoutsPostResponse.md)|  | 

### Return type

[**PtsV2PayoutsPost201Response**](PtsV2PayoutsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

