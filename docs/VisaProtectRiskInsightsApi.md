# CyberSource.Api.VisaProtectRiskInsightsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubmitVpri**](VisaProtectRiskInsightsApi.md#submitvpri) | **POST** /unifiedrisk | Visa Protect Risk Insights


<a name="submitvpri"></a>
# **SubmitVpri**
> UnifiedRiskPost201Response SubmitVpri (VpriRequest vpriRequest)

Visa Protect Risk Insights

VPRI delivers real-time, AI-driven risk scores and insights via a data-only API to enrich existing fraud strategies and improve decisioning. It integrates easily into existing workflows and provides immediate value by identifying legitimate behavior across Visa's global network—helping reduce false declines and increase acceptance.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class SubmitVpriExample
    {
        public void main()
        {
            var apiInstance = new VisaProtectRiskInsightsApi();
            var vpriRequest = new VpriRequest(); // VpriRequest | VPRI request for Transaction Risk Scoring or Transaction Risk Labeling

            try
            {
                // Visa Protect Risk Insights
                UnifiedRiskPost201Response result = apiInstance.SubmitVpri(vpriRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VisaProtectRiskInsightsApi.SubmitVpri: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vpriRequest** | [**VpriRequest**](VpriRequest.md)| VPRI request for Transaction Risk Scoring or Transaction Risk Labeling | 

### Return type

[**UnifiedRiskPost201Response**](UnifiedRiskPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

