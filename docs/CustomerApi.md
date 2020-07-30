# CyberSource.Api.CustomerApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCustomer**](CustomerApi.md#deletecustomer) | **DELETE** /tms/v2/customers/{customerTokenId} | Delete a Customer
[**GetCustomer**](CustomerApi.md#getcustomer) | **GET** /tms/v2/customers/{customerTokenId} | Retrieve a Customer
[**PatchCustomer**](CustomerApi.md#patchcustomer) | **PATCH** /tms/v2/customers/{customerTokenId} | Update a Customer
[**PostCustomer**](CustomerApi.md#postcustomer) | **POST** /tms/v2/customers | Create a Customer


<a name="deletecustomer"></a>
# **DeleteCustomer**
> void DeleteCustomer (string customerTokenId, string profileId = null)

Delete a Customer

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteCustomerExample
    {
        public void main()
        {
            var apiInstance = new CustomerApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Delete a Customer
                apiInstance.DeleteCustomer(customerTokenId, profileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.DeleteCustomer: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomer"></a>
# **GetCustomer**
> TmsV2CustomersResponse GetCustomer (string customerTokenId, string profileId = null)

Retrieve a Customer

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetCustomerExample
    {
        public void main()
        {
            var apiInstance = new CustomerApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Retrieve a Customer
                TmsV2CustomersResponse result = apiInstance.GetCustomer(customerTokenId, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomer: " + e.Message );
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

### Return type

[**TmsV2CustomersResponse**](TmsV2CustomersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchcustomer"></a>
# **PatchCustomer**
> TmsV2CustomersResponse PatchCustomer (string customerTokenId, PatchCustomerRequest patchCustomerRequest, string profileId = null, string ifMatch = null)

Update a Customer

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PatchCustomerExample
    {
        public void main()
        {
            var apiInstance = new CustomerApi();
            var customerTokenId = customerTokenId_example;  // string | The TokenId of a customer.
            var patchCustomerRequest = new PatchCustomerRequest(); // PatchCustomerRequest | 
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 
            var ifMatch = ifMatch_example;  // string | Contains an ETag value from a GET request to make the request conditional. (optional) 

            try
            {
                // Update a Customer
                TmsV2CustomersResponse result = apiInstance.PatchCustomer(customerTokenId, patchCustomerRequest, profileId, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.PatchCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerTokenId** | **string**| The TokenId of a customer. | 
 **patchCustomerRequest** | [**PatchCustomerRequest**](PatchCustomerRequest.md)|  | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 
 **ifMatch** | **string**| Contains an ETag value from a GET request to make the request conditional. | [optional] 

### Return type

[**TmsV2CustomersResponse**](TmsV2CustomersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcustomer"></a>
# **PostCustomer**
> TmsV2CustomersResponse PostCustomer (PostCustomerRequest postCustomerRequest, string profileId = null)

Create a Customer

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostCustomerExample
    {
        public void main()
        {
            var apiInstance = new CustomerApi();
            var postCustomerRequest = new PostCustomerRequest(); // PostCustomerRequest | 
            var profileId = profileId_example;  // string | The id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Create a Customer
                TmsV2CustomersResponse result = apiInstance.PostCustomer(postCustomerRequest, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.PostCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postCustomerRequest** | [**PostCustomerRequest**](PostCustomerRequest.md)|  | 
 **profileId** | **string**| The id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**TmsV2CustomersResponse**](TmsV2CustomersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

