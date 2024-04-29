# CyberSource.Api.CustomerPaymentInstrumentApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCustomerPaymentInstrument**](CustomerPaymentInstrumentApi.md#deletecustomerpaymentinstrument) | **DELETE** /tms/v2/customers/{customerId}/payment-instruments/{paymentInstrumentId} | Delete a Customer Payment Instrument
[**GetCustomerPaymentInstrument**](CustomerPaymentInstrumentApi.md#getcustomerpaymentinstrument) | **GET** /tms/v2/customers/{customerId}/payment-instruments/{paymentInstrumentId} | Retrieve a Customer Payment Instrument
[**GetCustomerPaymentInstrumentsList**](CustomerPaymentInstrumentApi.md#getcustomerpaymentinstrumentslist) | **GET** /tms/v2/customers/{customerId}/payment-instruments | List Payment Instruments for a Customer
[**PatchCustomersPaymentInstrument**](CustomerPaymentInstrumentApi.md#patchcustomerspaymentinstrument) | **PATCH** /tms/v2/customers/{customerId}/payment-instruments/{paymentInstrumentId} | Update a Customer Payment Instrument
[**PostCustomerPaymentInstrument**](CustomerPaymentInstrumentApi.md#postcustomerpaymentinstrument) | **POST** /tms/v2/customers/{customerId}/payment-instruments | Create a Customer Payment Instrument


<a name="deletecustomerpaymentinstrument"></a>
# **DeleteCustomerPaymentInstrument**
> void DeleteCustomerPaymentInstrument (string customerId, string paymentInstrumentId, string profileId = null)

Delete a Customer Payment Instrument

|  |  |  | | - -- | - -- | - -- | |**Customer Payment Instrument**<br>A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address & card type.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Payment Instruments](#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument), with one allocated as the Customers default for use in payments.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Deleting a Customers Payment Instrument**<br>Your system can use this API to delete an existing Payment Instrument for a Customer.<br>Any Instrument Identifiers representing the card number will also be deleted if they are not associated with any other Payment Instruments.<br>If a customer has more than one Payment Instrument then the default Payment Instrument cannot be deleted without first selecting a [new default Payment Instrument](#token-management_customer-payment-instrument_update-a-customer-payment-instrument_samplerequests-dropdown_make-customer-payment-instrument-the-default_liveconsole-tab-request-body). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteCustomerPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new CustomerPaymentInstrumentApi();
            var customerId = customerId_example;  // string | The Id of a Customer.
            var paymentInstrumentId = paymentInstrumentId_example;  // string | The Id of a payment instrument.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Delete a Customer Payment Instrument
                apiInstance.DeleteCustomerPaymentInstrument(customerId, paymentInstrumentId, profileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerPaymentInstrumentApi.DeleteCustomerPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The Id of a Customer. | 
 **paymentInstrumentId** | **string**| The Id of a payment instrument. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerpaymentinstrument"></a>
# **GetCustomerPaymentInstrument**
> PostCustomerPaymentInstrumentRequest GetCustomerPaymentInstrument (string customerId, string paymentInstrumentId, string profileId = null)

Retrieve a Customer Payment Instrument

|  |  |  | | - -- | - -- | - -- | |**Customer Payment Instrument**<br>A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address & card type.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Payment Instruments](#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument), with one allocated as the Customers default for use in payments.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Retrieving a Customer Payment Instrument**<br>Your system can use this API to retrieve an existing Payment Instrument for a Customer.<br>To perform a payment with a particular Payment Instrument simply specify the [Payment Instrument Id in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetCustomerPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new CustomerPaymentInstrumentApi();
            var customerId = customerId_example;  // string | The Id of a Customer.
            var paymentInstrumentId = paymentInstrumentId_example;  // string | The Id of a payment instrument.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Retrieve a Customer Payment Instrument
                PostCustomerPaymentInstrumentRequest result = apiInstance.GetCustomerPaymentInstrument(customerId, paymentInstrumentId, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerPaymentInstrumentApi.GetCustomerPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The Id of a Customer. | 
 **paymentInstrumentId** | **string**| The Id of a payment instrument. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**PostCustomerPaymentInstrumentRequest**](PostCustomerPaymentInstrumentRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerpaymentinstrumentslist"></a>
# **GetCustomerPaymentInstrumentsList**
> PaymentInstrumentList GetCustomerPaymentInstrumentsList (string customerId, string profileId = null, long? offset = null, long? limit = null)

List Payment Instruments for a Customer

|  |  |  | | - -- | - -- | - -- | |**Customer Payment Instrument**<br>A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address & card type.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Payment Instruments](#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument), with one allocated as the Customers default for use in payments.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Retrieving all Customer Payment Instruments**<br>Your system can use this API to retrieve all existing Payment Instruments for a Customer. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetCustomerPaymentInstrumentsListExample
    {
        public void main()
        {
            var apiInstance = new CustomerPaymentInstrumentApi();
            var customerId = customerId_example;  // string | The Id of a Customer.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 
            var offset = 789;  // long? | Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional)  (default to 0)
            var limit = 789;  // long? | The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional)  (default to 20)

            try
            {
                // List Payment Instruments for a Customer
                PaymentInstrumentList result = apiInstance.GetCustomerPaymentInstrumentsList(customerId, profileId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerPaymentInstrumentApi.GetCustomerPaymentInstrumentsList: " + e.Message );
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

[**PaymentInstrumentList**](PaymentInstrumentList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchcustomerspaymentinstrument"></a>
# **PatchCustomersPaymentInstrument**
> PatchCustomerPaymentInstrumentRequest PatchCustomersPaymentInstrument (string customerId, string paymentInstrumentId, PatchCustomerPaymentInstrumentRequest patchCustomerPaymentInstrumentRequest, string profileId = null, string ifMatch = null)

Update a Customer Payment Instrument

|  |  |  | | - -- | - -- | - -- | |**Customer Payment Instrument**<br>A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address & card type.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Payment Instruments](#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument), with one allocated as the Customers default for use in payments.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Updating a Customers Payment Instrument**<br>Your system can use this API to update an existing Payment Instrument for a Customer, including selecting a [default Payment Instrument](#token-management_customer-payment-instrument_update-a-customer-payment-instrument_samplerequests-dropdown_make-customer-payment-instrument-the-default_liveconsole-tab-request-body) for use in payments. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PatchCustomersPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new CustomerPaymentInstrumentApi();
            var customerId = customerId_example;  // string | The Id of a Customer.
            var paymentInstrumentId = paymentInstrumentId_example;  // string | The Id of a payment instrument.
            var patchCustomerPaymentInstrumentRequest = new PatchCustomerPaymentInstrumentRequest(); // PatchCustomerPaymentInstrumentRequest | 
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 
            var ifMatch = ifMatch_example;  // string | Contains an ETag value from a GET request to make the request conditional. (optional) 

            try
            {
                // Update a Customer Payment Instrument
                PatchCustomerPaymentInstrumentRequest result = apiInstance.PatchCustomersPaymentInstrument(customerId, paymentInstrumentId, patchCustomerPaymentInstrumentRequest, profileId, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerPaymentInstrumentApi.PatchCustomersPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The Id of a Customer. | 
 **paymentInstrumentId** | **string**| The Id of a payment instrument. | 
 **patchCustomerPaymentInstrumentRequest** | [**PatchCustomerPaymentInstrumentRequest**](PatchCustomerPaymentInstrumentRequest.md)|  | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 
 **ifMatch** | **string**| Contains an ETag value from a GET request to make the request conditional. | [optional] 

### Return type

[**PatchCustomerPaymentInstrumentRequest**](PatchCustomerPaymentInstrumentRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcustomerpaymentinstrument"></a>
# **PostCustomerPaymentInstrument**
> PostCustomerPaymentInstrumentRequest PostCustomerPaymentInstrument (string customerId, PostCustomerPaymentInstrumentRequest postCustomerPaymentInstrumentRequest, string profileId = null)

Create a Customer Payment Instrument

|  |  |  | | - -- | - -- | - -- | |**Customer Payment Instrument**<br>A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address & card type.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Payment Instruments](#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument), with one allocated as the Customers default for use in payments.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br><br>**Creating a Customer Payment Instrument**<br>It is recommended you [create a Customer Payment Instrument via a Payment Authorization](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-create-default-payment-instrument-shipping-address-for-existing-customer_liveconsole-tab-request-body), this can be for a zero amount.<br>In Europe: You should perform Payer Authentication alongside the Authorization.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Network Tokens**<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.<br>A Payment Network Token can also be [provisioned for an existing Instrument Identifier](#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token).<br>For more information about Payment Network Tokens see the Developer Guide.<br><br>**Payments with Customers Payment Instrument**<br>To perform a payment with a particular Payment Instrument or Shipping Address specify the [Payment Instrument in the payment request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostCustomerPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new CustomerPaymentInstrumentApi();
            var customerId = customerId_example;  // string | The Id of a Customer.
            var postCustomerPaymentInstrumentRequest = new PostCustomerPaymentInstrumentRequest(); // PostCustomerPaymentInstrumentRequest | 
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Create a Customer Payment Instrument
                PostCustomerPaymentInstrumentRequest result = apiInstance.PostCustomerPaymentInstrument(customerId, postCustomerPaymentInstrumentRequest, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerPaymentInstrumentApi.PostCustomerPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The Id of a Customer. | 
 **postCustomerPaymentInstrumentRequest** | [**PostCustomerPaymentInstrumentRequest**](PostCustomerPaymentInstrumentRequest.md)|  | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**PostCustomerPaymentInstrumentRequest**](PostCustomerPaymentInstrumentRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

