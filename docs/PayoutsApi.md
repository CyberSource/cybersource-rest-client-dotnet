# CyberSource.Api.PayoutsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OctCreatePayment**](PayoutsApi.md#octcreatepayment) | **POST** /pts/v2/payouts | Process a Payout


<a name="octcreatepayment"></a>
# **OctCreatePayment**
> void OctCreatePayment (OctCreatePaymentRequest octCreatePaymentRequest)

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
            var apiInstance = new PayoutsApi();
            var octCreatePaymentRequest = new OctCreatePaymentRequest(); // OctCreatePaymentRequest | 

            try
            {
                // Process a Payout
                apiInstance.OctCreatePayment(octCreatePaymentRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.OctCreatePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **octCreatePaymentRequest** | [**OctCreatePaymentRequest**](OctCreatePaymentRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

