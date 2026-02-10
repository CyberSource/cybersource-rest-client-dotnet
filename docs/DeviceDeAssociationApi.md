# CyberSource.Api.DeviceDeAssociationApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTerminalAssociation**](DeviceDeAssociationApi.md#deleteterminalassociation) | **PATCH** /dms/v2/devices/deassociate | De-associate a device from merchant or account V2
[**PostDeAssociateV3Terminal**](DeviceDeAssociationApi.md#postdeassociatev3terminal) | **POST** /dms/v3/devices/deassociate | De-associate a device from merchant to account or reseller and from account to reseller


<a name="deleteterminalassociation"></a>
# **DeleteTerminalAssociation**
> void DeleteTerminalAssociation (DeAssociationRequestBody deAssociationRequestBody)

De-associate a device from merchant or account V2

The current association of the device will be removed and will be assigned back to parent in the hierarchy based on internal logic

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteTerminalAssociationExample
    {
        public void main()
        {
            var apiInstance = new DeviceDeAssociationApi();
            var deAssociationRequestBody = new DeAssociationRequestBody(); // DeAssociationRequestBody | de association of the deviceId in the request body.

            try
            {
                // De-associate a device from merchant or account V2
                apiInstance.DeleteTerminalAssociation(deAssociationRequestBody);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceDeAssociationApi.DeleteTerminalAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deAssociationRequestBody** | [**DeAssociationRequestBody**](DeAssociationRequestBody.md)| de association of the deviceId in the request body. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdeassociatev3terminal"></a>
# **PostDeAssociateV3Terminal**
> List<InlineResponse20010> PostDeAssociateV3Terminal (List<DeviceDeAssociateV3Request> deviceDeAssociateV3Request)

De-associate a device from merchant to account or reseller and from account to reseller

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
            var apiInstance = new DeviceDeAssociationApi();
            var deviceDeAssociateV3Request = new List<DeviceDeAssociateV3Request>(); // List<DeviceDeAssociateV3Request> | deviceId that has to be de-associated to the destination organizationId.

            try
            {
                // De-associate a device from merchant to account or reseller and from account to reseller
                List&lt;InlineResponse20010&gt; result = apiInstance.PostDeAssociateV3Terminal(deviceDeAssociateV3Request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceDeAssociationApi.PostDeAssociateV3Terminal: " + e.Message );
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

[**List<InlineResponse20010>**](InlineResponse20010.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

