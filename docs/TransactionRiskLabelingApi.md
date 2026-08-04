# CyberSource.Api.TransactionRiskLabelingApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubmitLabels**](TransactionRiskLabelingApi.md#submitlabels) | **POST** /unifiedrisk | Transaction Risk Labeling


<a name="submitlabels"></a>
# **SubmitLabels**
> InlineResponse2013 SubmitLabels (LabelRequest labelRequest)

Transaction Risk Labeling

The Labels endpoint enables clients to submit post-transaction feedback, including both the decision made on the transaction  (such as accept or reject) and the final outcome (such as confirmed fraud, valid, or suspected).  Consistent label submission is critical to achieving optimal model performance, as it directly drives model accuracy, tuning,  and the quality of client‑specific insights over time

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class SubmitLabelsExample
    {
        public void main()
        {
            var apiInstance = new TransactionRiskLabelingApi();
            var labelRequest = new LabelRequest(); // LabelRequest | Label submission request

            try
            {
                // Transaction Risk Labeling
                InlineResponse2013 result = apiInstance.SubmitLabels(labelRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionRiskLabelingApi.SubmitLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **labelRequest** | [**LabelRequest**](LabelRequest.md)| Label submission request | 

### Return type

[**InlineResponse2013**](InlineResponse2013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

