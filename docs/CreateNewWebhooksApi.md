# CyberSource.Api.CreateNewWebhooksApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SaveSymEgressKey**](CreateNewWebhooksApi.md#savesymegresskey) | **POST** /kms/egress/v2/keys-sym | Create Webhook Security Keys


<a name="savesymegresskey"></a>
# **SaveSymEgressKey**
> InlineResponse2013 SaveSymEgressKey (string vCSenderOrganizationId, string vCPermissions, string vCCorrelationId = null, SaveSymEgressKey saveSymEgressKey = null)

Create Webhook Security Keys

Create security keys that CyberSource will use internally to connect to your servers and validate messages using a digital signature.  Select the CREATE example for CyberSource to generate the key on our server and maintain it for you as well. Remember to save the key in the API response, so that you can use it to validate messages later. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class SaveSymEgressKeyExample
    {
        public void main()
        {
            var apiInstance = new CreateNewWebhooksApi();
            var vCSenderOrganizationId = vCSenderOrganizationId_example;  // string | Sender organization id
            var vCPermissions = vCPermissions_example;  // string | Encoded user permissions returned by the CGK, for the entity user who initiated the boarding
            var vCCorrelationId = vCCorrelationId_example;  // string | A globally unique id associated with your request (optional) 
            var saveSymEgressKey = new SaveSymEgressKey(); // SaveSymEgressKey | Provide egress Symmetric key information to save (create or store or refresh) (optional) 

            try
            {
                // Create Webhook Security Keys
                InlineResponse2013 result = apiInstance.SaveSymEgressKey(vCSenderOrganizationId, vCPermissions, vCCorrelationId, saveSymEgressKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreateNewWebhooksApi.SaveSymEgressKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vCSenderOrganizationId** | **string**| Sender organization id | 
 **vCPermissions** | **string**| Encoded user permissions returned by the CGK, for the entity user who initiated the boarding | 
 **vCCorrelationId** | **string**| A globally unique id associated with your request | [optional] 
 **saveSymEgressKey** | [**SaveSymEgressKey**](SaveSymEgressKey.md)| Provide egress Symmetric key information to save (create or store or refresh) | [optional] 

### Return type

[**InlineResponse2013**](InlineResponse2013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

