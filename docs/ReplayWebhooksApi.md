# CyberSource.Api.ReplayWebhooksApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReplayPreviousWebhooks**](ReplayWebhooksApi.md#replaypreviouswebhooks) | **POST** /nrtf/v1/webhooks/{webhookId}/replays | Replay Previous Webhooks


<a name="replaypreviouswebhooks"></a>
# **ReplayPreviousWebhooks**
> void ReplayPreviousWebhooks (string webhookId, ReplayWebhooksRequest replayWebhooksRequest = null)

Replay Previous Webhooks

Initiate a webhook replay request to replay transactions that happened in the past.  Cannot execute more than 1 replay request at a time. While one request is processing, you will not be allowed to execute another replay.  The difference between Start and End time cannot exceed a 24 hour window, and 1 month is the farthest date back that is eligible for replay. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ReplayPreviousWebhooksExample
    {
        public void main()
        {
            var apiInstance = new ReplayWebhooksApi();
            var webhookId = webhookId_example;  // string | The webhook uuid identifier.
            var replayWebhooksRequest = new ReplayWebhooksRequest(); // ReplayWebhooksRequest | The request query (optional) 

            try
            {
                // Replay Previous Webhooks
                apiInstance.ReplayPreviousWebhooks(webhookId, replayWebhooksRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReplayWebhooksApi.ReplayPreviousWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookId** | **string**| The webhook uuid identifier. | 
 **replayWebhooksRequest** | [**ReplayWebhooksRequest**](ReplayWebhooksRequest.md)| The request query | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

