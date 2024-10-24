# CyberSource.Api.OrdersApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrder**](OrdersApi.md#createorder) | **POST** /pts/v2/intents | Create an Order
[**UpdateOrder**](OrdersApi.md#updateorder) | **PATCH** /pts/v2/intents/{id} | Update an Order


<a name="createorder"></a>
# **CreateOrder**
> PtsV2CreateOrderPost201Response CreateOrder (CreateOrderRequest createOrderRequest)

Create an Order

A create order request enables you to send the itemized details along with the order. This API can be used by merchants initiating their transactions with the create order API.  

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public void main()
        {
            var apiInstance = new OrdersApi();
            var createOrderRequest = new CreateOrderRequest(); // CreateOrderRequest | 

            try
            {
                // Create an Order
                PtsV2CreateOrderPost201Response result = apiInstance.CreateOrder(createOrderRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createOrderRequest** | [**CreateOrderRequest**](CreateOrderRequest.md)|  | 

### Return type

[**PtsV2CreateOrderPost201Response**](PtsV2CreateOrderPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorder"></a>
# **UpdateOrder**
> PtsV2UpdateOrderPatch201Response UpdateOrder (string id, UpdateOrderRequest updateOrderRequest)

Update an Order

This API can be used in two flavours - for updating the order as well as saving the order. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateOrderExample
    {
        public void main()
        {
            var apiInstance = new OrdersApi();
            var id = id_example;  // string | The ID returned from the original create order response.
            var updateOrderRequest = new UpdateOrderRequest(); // UpdateOrderRequest | 

            try
            {
                // Update an Order
                PtsV2UpdateOrderPatch201Response result = apiInstance.UpdateOrder(id, updateOrderRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.UpdateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID returned from the original create order response. | 
 **updateOrderRequest** | [**UpdateOrderRequest**](UpdateOrderRequest.md)|  | 

### Return type

[**PtsV2UpdateOrderPatch201Response**](PtsV2UpdateOrderPatch201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

