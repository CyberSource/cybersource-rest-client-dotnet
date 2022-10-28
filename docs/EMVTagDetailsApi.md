# CyberSource.Api.EMVTagDetailsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEmvTags**](EMVTagDetailsApi.md#getemvtags) | **GET** /tss/v2/transactions/emvTagDetails | Retrieve the EMV Dictionary
[**ParseEmvTags**](EMVTagDetailsApi.md#parseemvtags) | **POST** /tss/v2/transactions/emvTagDetails | Parse an EMV String


<a name="getemvtags"></a>
# **GetEmvTags**
> TssV2GetEmvTags200Response GetEmvTags ()

Retrieve the EMV Dictionary

Returns the entire EMV tag dictionary

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetEmvTagsExample
    {
        public void main()
        {
            var apiInstance = new EMVTagDetailsApi();

            try
            {
                // Retrieve the EMV Dictionary
                TssV2GetEmvTags200Response result = apiInstance.GetEmvTags();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EMVTagDetailsApi.GetEmvTags: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TssV2GetEmvTags200Response**](TssV2GetEmvTags200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parseemvtags"></a>
# **ParseEmvTags**
> TssV2PostEmvTags200Response ParseEmvTags (Body body)

Parse an EMV String

Pass an EMV Tag-Length-Value (TLV) string for parsing.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ParseEmvTagsExample
    {
        public void main()
        {
            var apiInstance = new EMVTagDetailsApi();
            var body = new Body(); // Body | 

            try
            {
                // Parse an EMV String
                TssV2PostEmvTags200Response result = apiInstance.ParseEmvTags(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EMVTagDetailsApi.ParseEmvTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)|  | 

### Return type

[**TssV2PostEmvTags200Response**](TssV2PostEmvTags200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

