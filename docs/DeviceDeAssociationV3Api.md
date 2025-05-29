# CyberSource.Api.DeviceDeAssociationV3Api

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostDeAssociateV3Terminal**](DeviceDeAssociationV3Api.md#postdeassociatev3terminal) | **POST** /dms/v3/devices/deassociate | De-associate a device from merchant to account or reseller and from account to reseller V3


<a name="postdeassociatev3terminal"></a>
# **PostDeAssociateV3Terminal**
> List<InlineResponse2005> PostDeAssociateV3Terminal (List<DeviceDeAssociateV3Request> deviceDeAssociateV3Request)

De-associate a device from merchant to account or reseller and from account to reseller V3

A device will be de-associated from its current organization and moved up in the hierarchy. The device's new position will be determined by a specified destination, either an account or a portfolio. If no destination is provided, the device will default to the currently logged-in user. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostDeAssociateV3TerminalExample
    {
        public void main()
        {
            var apiInstance = new DeviceDeAssociationV3Api();
            var deviceDeAssociateV3Request = new List<DeviceDeAssociateV3Request>(); // List<DeviceDeAssociateV3Request> | deviceId that has to be de-associated to the destination organizationId.

            try
            {
                // De-associate a device from merchant to account or reseller and from account to reseller V3
                List&lt;InlineResponse2005&gt; result = apiInstance.PostDeAssociateV3Terminal(deviceDeAssociateV3Request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceDeAssociationV3Api.PostDeAssociateV3Terminal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceDeAssociateV3Request** | [**List&lt;DeviceDeAssociateV3Request&gt;**](DeviceDeAssociateV3Request.md)| deviceId that has to be de-associated to the destination organizationId. | 

### Return type

[**List<InlineResponse2005>**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

