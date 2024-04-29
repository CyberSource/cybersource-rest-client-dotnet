# CyberSource.Api.CustomerShippingAddressApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCustomerShippingAddress**](CustomerShippingAddressApi.md#deletecustomershippingaddress) | **DELETE** /tms/v2/customers/{customerId}/shipping-addresses/{shippingAddressId} | Delete a Customer Shipping Address
[**GetCustomerShippingAddress**](CustomerShippingAddressApi.md#getcustomershippingaddress) | **GET** /tms/v2/customers/{customerId}/shipping-addresses/{shippingAddressId} | Retrieve a Customer Shipping Address
[**GetCustomerShippingAddressesList**](CustomerShippingAddressApi.md#getcustomershippingaddresseslist) | **GET** /tms/v2/customers/{customerId}/shipping-addresses | List Shipping Addresses for a Customer
[**PatchCustomersShippingAddress**](CustomerShippingAddressApi.md#patchcustomersshippingaddress) | **PATCH** /tms/v2/customers/{customerId}/shipping-addresses/{shippingAddressId} | Update a Customer Shipping Address
[**PostCustomerShippingAddress**](CustomerShippingAddressApi.md#postcustomershippingaddress) | **POST** /tms/v2/customers/{customerId}/shipping-addresses | Create a Customer Shipping Address


<a name="deletecustomershippingaddress"></a>
# **DeleteCustomerShippingAddress**
> void DeleteCustomerShippingAddress (string customerId, string shippingAddressId, string profileId = null)

Delete a Customer Shipping Address

|  |  |  | | - -- | - -- | - -- | |**Customer Shipping Address**<br>A Customer Shipping Address represents tokenized customer shipping information.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Shipping Addresses](#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer), with one allocated as the Customers default for use in payments.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Deleting a Customers Shipping Address**<br>Your system can use this API to delete an existing Shipping Address for a Customer.<br>If a customer has more than one Shipping Address then the default Shipping Address cannot be deleted without first selecting a [new default Shipping Address](#token-management_customer-shipping-address_update-a-customer-shipping-address_samplerequests-dropdown_make-customer-shipping-address-the-default_liveconsole-tab-request-body). 

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
            var customerId = customerId_example;  // string | The Id of a Customer.
            var shippingAddressId = shippingAddressId_example;  // string | The Id of a shipping address.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Delete a Customer Shipping Address
                apiInstance.DeleteCustomerShippingAddress(customerId, shippingAddressId, profileId);
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
 **customerId** | **string**| The Id of a Customer. | 
 **shippingAddressId** | **string**| The Id of a shipping address. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

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
> PostCustomerShippingAddressRequest GetCustomerShippingAddress (string customerId, string shippingAddressId, string profileId = null)

Retrieve a Customer Shipping Address

|  |  |  | | - -- | - -- | - -- | |**Customer Shipping Address**<br>A Customer Shipping Address represents tokenized customer shipping information.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Shipping Addresses](#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer), with one allocated as the Customers default for use in payments.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Retrieving a Customer Shipping Address**<br>Your system can use this API to retrieve an existing Shipping Address for a Customer.<br>To perform a payment with a particular Shipping Address simply specify the [Shipping Address Id in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body). 

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
            var customerId = customerId_example;  // string | The Id of a Customer.
            var shippingAddressId = shippingAddressId_example;  // string | The Id of a shipping address.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Retrieve a Customer Shipping Address
                PostCustomerShippingAddressRequest result = apiInstance.GetCustomerShippingAddress(customerId, shippingAddressId, profileId);
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
 **customerId** | **string**| The Id of a Customer. | 
 **shippingAddressId** | **string**| The Id of a shipping address. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**PostCustomerShippingAddressRequest**](PostCustomerShippingAddressRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomershippingaddresseslist"></a>
# **GetCustomerShippingAddressesList**
> ShippingAddressListForCustomer GetCustomerShippingAddressesList (string customerId, string profileId = null, long? offset = null, long? limit = null)

List Shipping Addresses for a Customer

|  |  |  | | - -- | - -- | - -- | |**Customer Shipping Address**<br>A Customer Shipping Address represents tokenized customer shipping information.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Shipping Addresses](#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer), with one allocated as the Customers default for use in payments.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Retrieving all Customer Shipping Addresses**<br>Your system can use this API to retrieve all existing Shipping Addresses for a Customer. 

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
            var customerId = customerId_example;  // string | The Id of a Customer.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 
            var offset = 789;  // long? | Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional)  (default to 0)
            var limit = 789;  // long? | The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional)  (default to 20)

            try
            {
                // List Shipping Addresses for a Customer
                ShippingAddressListForCustomer result = apiInstance.GetCustomerShippingAddressesList(customerId, profileId, offset, limit);
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
 **customerId** | **string**| The Id of a Customer. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 
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
> PatchCustomerShippingAddressRequest PatchCustomersShippingAddress (string customerId, string shippingAddressId, PatchCustomerShippingAddressRequest patchCustomerShippingAddressRequest, string profileId = null, string ifMatch = null)

Update a Customer Shipping Address

|  |  |  | | - -- | - -- | - -- | |**Customer Shipping Address**<br>A Customer Shipping Address represents tokenized customer shipping information.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Shipping Addresses](#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer), with one allocated as the Customers default for use in payments.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Updating a Customers Shipping Address**<br>Your system can use this API to update an existing Shipping Addresses for a Customer, including selecting a [default Shipping Address](#token-management_customer-shipping-address_update-a-customer-shipping-address_samplerequests-dropdown_make-customer-shipping-address-the-default_liveconsole-tab-request-body) for use in payments. 

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
            var customerId = customerId_example;  // string | The Id of a Customer.
            var shippingAddressId = shippingAddressId_example;  // string | The Id of a shipping address.
            var patchCustomerShippingAddressRequest = new PatchCustomerShippingAddressRequest(); // PatchCustomerShippingAddressRequest | 
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 
            var ifMatch = ifMatch_example;  // string | Contains an ETag value from a GET request to make the request conditional. (optional) 

            try
            {
                // Update a Customer Shipping Address
                PatchCustomerShippingAddressRequest result = apiInstance.PatchCustomersShippingAddress(customerId, shippingAddressId, patchCustomerShippingAddressRequest, profileId, ifMatch);
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
 **customerId** | **string**| The Id of a Customer. | 
 **shippingAddressId** | **string**| The Id of a shipping address. | 
 **patchCustomerShippingAddressRequest** | [**PatchCustomerShippingAddressRequest**](PatchCustomerShippingAddressRequest.md)|  | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 
 **ifMatch** | **string**| Contains an ETag value from a GET request to make the request conditional. | [optional] 

### Return type

[**PatchCustomerShippingAddressRequest**](PatchCustomerShippingAddressRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcustomershippingaddress"></a>
# **PostCustomerShippingAddress**
> PostCustomerShippingAddressRequest PostCustomerShippingAddress (string customerId, PostCustomerShippingAddressRequest postCustomerShippingAddressRequest, string profileId = null)

Create a Customer Shipping Address

|  |  |  | | - -- | - -- | - -- | |**Customer Shipping Address**<br>A Customer Shipping Address represents tokenized customer shipping information.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Shipping Addresses](#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer), with one allocated as the Customers default for use in payments.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Creating a Customer Shipping Address**<br>Your system can use this API to create an existing Customers default or non default Shipping Address.<br>You can also create additional Customer Shipping Addresses via the [Payments API](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-create-default-payment-instrument-shipping-address-for-existing-customer_liveconsole-tab-request-body). 

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
            var customerId = customerId_example;  // string | The Id of a Customer.
            var postCustomerShippingAddressRequest = new PostCustomerShippingAddressRequest(); // PostCustomerShippingAddressRequest | 
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Create a Customer Shipping Address
                PostCustomerShippingAddressRequest result = apiInstance.PostCustomerShippingAddress(customerId, postCustomerShippingAddressRequest, profileId);
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
 **customerId** | **string**| The Id of a Customer. | 
 **postCustomerShippingAddressRequest** | [**PostCustomerShippingAddressRequest**](PostCustomerShippingAddressRequest.md)|  | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**PostCustomerShippingAddressRequest**](PostCustomerShippingAddressRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

