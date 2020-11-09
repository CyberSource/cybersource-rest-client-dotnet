# CyberSource.Api.CustomerShippingAddressApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCustomerShippingAddress**](CustomerShippingAddressApi.md#deletecustomershippingaddress) | **DELETE** /tms/v2/customers/{customerTokenId}/shipping-addresses/{shippingAddressTokenId} | Delete a Customer Shipping Address
[**GetCustomerShippingAddress**](CustomerShippingAddressApi.md#getcustomershippingaddress) | **GET** /tms/v2/customers/{customerTokenId}/shipping-addresses/{shippingAddressTokenId} | Retrieve a Customer Shipping Address
[**GetCustomerShippingAddressesList**](CustomerShippingAddressApi.md#getcustomershippingaddresseslist) | **GET** /tms/v2/customers/{customerTokenId}/shipping-addresses | List Shipping Addresses for a Customer
[**PatchCustomersShippingAddress**](CustomerShippingAddressApi.md#patchcustomersshippingaddress) | **PATCH** /tms/v2/customers/{customerTokenId}/shipping-addresses/{shippingAddressTokenId} | Update a Customer Shipping Address
[**PostCustomerShippingAddress**](CustomerShippingAddressApi.md#postcustomershippingaddress) | **POST** /tms/v2/customers/{customerTokenId}/shipping-addresses | Create a Customer Shipping Address


<a name="deletecustomershippingaddress"></a>
# **DeleteCustomerShippingAddress**
> void DeleteCustomerShippingAddress (string customerTokenId, string shippingAddressTokenId, string profileId = null)

Delete a Customer Shipping Address

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteCustomerShippingAddressExample
    {
        public void main()
        {
            var apiInstance = new CustomerShippingAddressApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var shippingAddressTokenId = shippingAddressTokenId_example;  // string | The TokenId of an shipping address.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Delete a Customer Shipping Address
                apiInstance.DeleteCustomerShippingAddress(customerTokenId, shippingAddressTokenId, profileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerShippingAddressApi.DeleteCustomerShippingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerTokenId** | **string**| The TokenId of a customer. | 
 **shippingAddressTokenId** | **string**| The TokenId of an shipping address. | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomershippingaddress"></a>
# **GetCustomerShippingAddress**
> Tmsv2customersEmbeddedDefaultShippingAddress GetCustomerShippingAddress (string customerTokenId, string shippingAddressTokenId, string profileId = null)

Retrieve a Customer Shipping Address

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetCustomerShippingAddressExample
    {
        public void main()
        {
            var apiInstance = new CustomerShippingAddressApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var shippingAddressTokenId = shippingAddressTokenId_example;  // string | The TokenId of an shipping address.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Retrieve a Customer Shipping Address
                Tmsv2customersEmbeddedDefaultShippingAddress result = apiInstance.GetCustomerShippingAddress(customerTokenId, shippingAddressTokenId, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerShippingAddressApi.GetCustomerShippingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerTokenId** | **string**| The TokenId of a customer. | 
 **shippingAddressTokenId** | **string**| The TokenId of an shipping address. | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**Tmsv2customersEmbeddedDefaultShippingAddress**](Tmsv2customersEmbeddedDefaultShippingAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomershippingaddresseslist"></a>
# **GetCustomerShippingAddressesList**
> ShippingAddressListForCustomer GetCustomerShippingAddressesList (string customerTokenId, string profileId = null, long? offset = null, long? limit = null)

List Shipping Addresses for a Customer

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetCustomerShippingAddressesListExample
    {
        public void main()
        {
            var apiInstance = new CustomerShippingAddressApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 
            var offset = 789;  // long? | Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional)  (default to 0)
            var limit = 789;  // long? | The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional)  (default to 20)

            try
            {
                // List Shipping Addresses for a Customer
                ShippingAddressListForCustomer result = apiInstance.GetCustomerShippingAddressesList(customerTokenId, profileId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerShippingAddressApi.GetCustomerShippingAddressesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerTokenId** | **string**| The TokenId of a customer. | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 
 **offset** | **long?**| Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0. | [optional] [default to 0]
 **limit** | **long?**| The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. | [optional] [default to 20]

### Return type

[**ShippingAddressListForCustomer**](ShippingAddressListForCustomer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchcustomersshippingaddress"></a>
# **PatchCustomersShippingAddress**
> Tmsv2customersEmbeddedDefaultShippingAddress PatchCustomersShippingAddress (string customerTokenId, string shippingAddressTokenId, PatchCustomerShippingAddressRequest patchCustomerShippingAddressRequest, string profileId = null, string ifMatch = null)

Update a Customer Shipping Address

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PatchCustomersShippingAddressExample
    {
        public void main()
        {
            var apiInstance = new CustomerShippingAddressApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var shippingAddressTokenId = shippingAddressTokenId_example;  // string | The TokenId of an shipping address.
            var patchCustomerShippingAddressRequest = new PatchCustomerShippingAddressRequest(); // PatchCustomerShippingAddressRequest | 
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 
            var ifMatch = ifMatch_example;  // string | Contains an ETag value from a GET request to make the request conditional. (optional) 

            try
            {
                // Update a Customer Shipping Address
                Tmsv2customersEmbeddedDefaultShippingAddress result = apiInstance.PatchCustomersShippingAddress(customerTokenId, shippingAddressTokenId, patchCustomerShippingAddressRequest, profileId, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerShippingAddressApi.PatchCustomersShippingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerTokenId** | **string**| The TokenId of a customer. | 
 **shippingAddressTokenId** | **string**| The TokenId of an shipping address. | 
 **patchCustomerShippingAddressRequest** | [**PatchCustomerShippingAddressRequest**](PatchCustomerShippingAddressRequest.md)|  | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 
 **ifMatch** | **string**| Contains an ETag value from a GET request to make the request conditional. | [optional] 

### Return type

[**Tmsv2customersEmbeddedDefaultShippingAddress**](Tmsv2customersEmbeddedDefaultShippingAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcustomershippingaddress"></a>
# **PostCustomerShippingAddress**
> Tmsv2customersEmbeddedDefaultShippingAddress PostCustomerShippingAddress (string customerTokenId, PostCustomerShippingAddressRequest postCustomerShippingAddressRequest, string profileId = null)

Create a Customer Shipping Address

Include an existing TMS Customer token id in the request URI. * A Customer token can be created by calling: **POST *_/tms/v2/customers*** 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostCustomerShippingAddressExample
    {
        public void main()
        {
            var apiInstance = new CustomerShippingAddressApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var postCustomerShippingAddressRequest = new PostCustomerShippingAddressRequest(); // PostCustomerShippingAddressRequest | 
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Create a Customer Shipping Address
                Tmsv2customersEmbeddedDefaultShippingAddress result = apiInstance.PostCustomerShippingAddress(customerTokenId, postCustomerShippingAddressRequest, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerShippingAddressApi.PostCustomerShippingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerTokenId** | **string**| The TokenId of a customer. | 
 **postCustomerShippingAddressRequest** | [**PostCustomerShippingAddressRequest**](PostCustomerShippingAddressRequest.md)|  | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**Tmsv2customersEmbeddedDefaultShippingAddress**](Tmsv2customersEmbeddedDefaultShippingAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

