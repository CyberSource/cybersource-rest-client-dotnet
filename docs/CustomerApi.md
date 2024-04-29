# CyberSource.Api.CustomerApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCustomer**](CustomerApi.md#deletecustomer) | **DELETE** /tms/v2/customers/{customerId} | Delete a Customer
[**GetCustomer**](CustomerApi.md#getcustomer) | **GET** /tms/v2/customers/{customerId} | Retrieve a Customer
[**PatchCustomer**](CustomerApi.md#patchcustomer) | **PATCH** /tms/v2/customers/{customerId} | Update a Customer
[**PostCustomer**](CustomerApi.md#postcustomer) | **POST** /tms/v2/customers | Create a Customer


<a name="deletecustomer"></a>
# **DeleteCustomer**
> void DeleteCustomer (string customerId, string profileId = null)

Delete a Customer

|  |  |  | | - -- | - -- | - -- | |**Customers**<br>A Customer represents your tokenized customer information.<br>You should associate the Customer Id with the customer account on your systems.<br>A Customer can have one or more [Payment Instruments](#token-management_customer-payment-instrument_create-a-customer-payment-instrumentl) or [Shipping Addresses](#token-management_customer-shipping-address_create-a-customer-shipping-address) with one allocated as the Customers default.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Deleting a Customer**<br>Your system can use this API to delete a complete Customer.<br>When a Customer is deleted all associated Payment Instruments & Shipping Addresses are deleted.<br>Any Instrument Identifiers representing the card number will also be deleted if they are not associated with any other Payment Instruments.<br>Note: Individual [Payment Instruments](#token-management_customer-payment-instrument_delete-a-customer-payment-instrument) or [Shipping Addresses](#token-management_customer-shipping-address_delete-a-customer-shipping-address) can be deleted via their own dedicated API resources. 

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
            var customerId = customerId_example;  // string | The Id of a Customer.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Delete a Customer
                apiInstance.DeleteCustomer(customerId, profileId);
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
 **customerId** | **string**| The Id of a Customer. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

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
> PostCustomerRequest GetCustomer (string customerId, string profileId = null)

Retrieve a Customer

|  |  |  | | - -- | - -- | - -- | |**Customers**<br>A Customer represents your tokenized customer information.<br>You should associate the Customer Id with the customer account on your systems.<br>A Customer can have one or more [Payment Instruments](#token-management_customer-payment-instrument_create-a-customer-payment-instrumentl) or [Shipping Addresses](#token-management_customer-shipping-address_create-a-customer-shipping-address) with one allocated as the Customers default.<br><br>**Retrieving a Customer**<br>When your customer signs into their account, your system can use this API to retrieve the Customers default Payment Instrument and Shipping Address.<br>**Note: the actual card data will be masked.**<br>If your customer wants to see other available Payment Instruments, your system can [retrieve all Payment Instruments](#token-management_customer-payment-instrument_list-payment-instruments-for-a-customer) associated with the Customer.<br>The same applies to [Shipping Addresses](#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer).|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Network Tokens**<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.<br>A Payment Network Token can also be [provisioned for an existing Instrument Identifier](#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token).<br>For more information about Payment Network Tokens see the Developer Guide.<br><br>**Payments with Customers**<br>To perform a payment with the Customers default details specify the [Customer Id in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-token-id_liveconsole-tab-request-body).<br>To perform a payment with a particular Payment Instrument or Shipping Address <br>specify the [Payment Instrument or Shipping Address Ids in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body). 

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
            var customerId = customerId_example;  // string | The Id of a Customer.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Retrieve a Customer
                PostCustomerRequest result = apiInstance.GetCustomer(customerId, profileId);
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
 **customerId** | **string**| The Id of a Customer. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**PostCustomerRequest**](PostCustomerRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchcustomer"></a>
# **PatchCustomer**
> PatchCustomerRequest PatchCustomer (string customerId, PatchCustomerRequest patchCustomerRequest, string profileId = null, string ifMatch = null)

Update a Customer

|  |  |  | | - -- | - -- | - -- | |**Customers**<br>A Customer represents your tokenized customer information.<br>You should associate the Customer Id with the customer account on your systems.<br>A Customer can have one or more [Payment Instruments](#token-management_customer-payment-instrument_create-a-customer-payment-instrumentl) or [Shipping Addresses](#token-management_customer-shipping-address_create-a-customer-shipping-address) with one allocated as the Customers default.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Updating a Customer**<br>Your system can use this API to update a Customers details including selecting a  [default Payment Instrument](#token-management_customer_update-a-customer_samplerequests-dropdown_update-customers-default-payment-instrument_liveconsole-tab-request-body) or [default Shipping Address](#token-management_customer_update-a-customer_samplerequests-dropdown_update-customers-default-shipping-address_liveconsole-tab-request-body) for use in payments.<br>Note: Updating a Customers [Payment Instrument](#token-management_customer-payment-instrument_update-a-customer-payment-instrument) or [Shipping Address](#token-management_customer-shipping-address_update-a-customer-shipping-address) details is performed using their own dedicated API resources. 

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
            var customerId = customerId_example;  // string | The Id of a Customer.
            var patchCustomerRequest = new PatchCustomerRequest(); // PatchCustomerRequest | 
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 
            var ifMatch = ifMatch_example;  // string | Contains an ETag value from a GET request to make the request conditional. (optional) 

            try
            {
                // Update a Customer
                PatchCustomerRequest result = apiInstance.PatchCustomer(customerId, patchCustomerRequest, profileId, ifMatch);
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
 **customerId** | **string**| The Id of a Customer. | 
 **patchCustomerRequest** | [**PatchCustomerRequest**](PatchCustomerRequest.md)|  | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 
 **ifMatch** | **string**| Contains an ETag value from a GET request to make the request conditional. | [optional] 

### Return type

[**PatchCustomerRequest**](PatchCustomerRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcustomer"></a>
# **PostCustomer**
> PostCustomerRequest PostCustomer (PostCustomerRequest postCustomerRequest, string profileId = null)

Create a Customer

|  |  |  | | - -- | - -- | - -- | |**Customers**<br>A Customer represents your tokenized customer information.<br>You should associate the Customer Id with the customer account on your systems.<br>A Customer can have one or more [Payment Instruments](#token-management_customer-payment-instrument_create-a-customer-payment-instrumentl) or [Shipping Addresses](#token-management_customer-shipping-address_create-a-customer-shipping-address) with one allocated as the Customers default.<br><br>**Creating a Customer**<br>It is recommended you [create a Customer via a Payment Authorization](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-customer-token-creation_liveconsole-tab-request-body), this can be for a zero amount.<br>The Customer will be created with a Payment Instrument and Shipping Address.<br>You can also [add additional Payment Instruments to a Customer via a Payment Authorization](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-create-default-payment-instrument-shipping-address-for-existing-customer_liveconsole-tab-request-body).<br>In Europe: You should perform Payer Authentication alongside the Authorization.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Network Tokens**<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.<br>A Payment Network Token can also be [provisioned for an existing Instrument Identifier](#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token).<br>For more information about Payment Network Tokens see the Developer Guide.<br><br>**Payments with Customers**<br>To perform a payment with the Customers default details specify the [Customer Id in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-token-id_liveconsole-tab-request-body).<br>To perform a payment with a particular Payment Instrument or Shipping Address <br>specify the [Payment Instrument or Shipping Address Ids in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body). 

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
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Create a Customer
                PostCustomerRequest result = apiInstance.PostCustomer(postCustomerRequest, profileId);
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
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**PostCustomerRequest**](PostCustomerRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

