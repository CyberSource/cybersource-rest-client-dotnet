# CyberSource.Api.PaymentInstrumentApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePaymentInstrument**](PaymentInstrumentApi.md#deletepaymentinstrument) | **DELETE** /tms/v1/paymentinstruments/{paymentInstrumentId} | Delete a Payment Instrument
[**GetPaymentInstrument**](PaymentInstrumentApi.md#getpaymentinstrument) | **GET** /tms/v1/paymentinstruments/{paymentInstrumentId} | Retrieve a Payment Instrument
[**PatchPaymentInstrument**](PaymentInstrumentApi.md#patchpaymentinstrument) | **PATCH** /tms/v1/paymentinstruments/{paymentInstrumentId} | Update a Payment Instrument
[**PostPaymentInstrument**](PaymentInstrumentApi.md#postpaymentinstrument) | **POST** /tms/v1/paymentinstruments | Create a Payment Instrument


<a name="deletepaymentinstrument"></a>
# **DeletePaymentInstrument**
> void DeletePaymentInstrument (string paymentInstrumentId, string profileId = null)

Delete a Payment Instrument

|  |  |  | | - -- | - -- | - -- | |**Standalone Payment Instruments**<br>A Payment Instrument represents tokenized payment information such as expiration date, billing address & card type.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>**Standalone Payment Instruments do not belong to a [Customer](#token-management_customer_create-a-customer).**|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Deleting a Payment Instrument**<br>Your system can use this API to delete an existing Payment Instrument.<br>Any Instrument Identifiers representing the card number will also be deleted if they are not associated with any other Payment Instruments. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeletePaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentApi();
            var paymentInstrumentId = paymentInstrumentId_example;  // string | The Id of a payment instrument.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Delete a Payment Instrument
                apiInstance.DeletePaymentInstrument(paymentInstrumentId, profileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentApi.DeletePaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="getpaymentinstrument"></a>
# **GetPaymentInstrument**
> PostPaymentInstrumentRequest GetPaymentInstrument (string paymentInstrumentId, string profileId = null)

Retrieve a Payment Instrument

|  |  |  | | - -- | - -- | - -- | |**Standalone Payment Instruments**<br>A Payment Instrument represents tokenized payment information such as expiration date, billing address & card type.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>**Standalone Payment Instruments do not belong to a [Customer](#token-management_customer_create-a-customer).**|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Retrieving a Payment Instrument**<br>Your system can use this API to retrieve an existing Payment Instrument.<br>To perform a payment with a particular Payment Instrument simply specify the [Payment Instrument Id in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentApi();
            var paymentInstrumentId = paymentInstrumentId_example;  // string | The Id of a payment instrument.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Retrieve a Payment Instrument
                PostPaymentInstrumentRequest result = apiInstance.GetPaymentInstrument(paymentInstrumentId, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentApi.GetPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentInstrumentId** | **string**| The Id of a payment instrument. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**PostPaymentInstrumentRequest**](PostPaymentInstrumentRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchpaymentinstrument"></a>
# **PatchPaymentInstrument**
> PatchPaymentInstrumentRequest PatchPaymentInstrument (string paymentInstrumentId, PatchPaymentInstrumentRequest patchPaymentInstrumentRequest, string profileId = null, string ifMatch = null)

Update a Payment Instrument

|  |  |  | | - -- | - -- | - -- | |**Standalone Payment Instruments**<br>A Payment Instrument represents tokenized payment information such as expiration date, billing address & card type.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>**Standalone Payment Instruments do not belong to a [Customer](#token-management_customer_create-a-customer).**|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Updating a Payment Instrument**<br>Your system can use this API to update an existing Payment Instrument. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PatchPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentApi();
            var paymentInstrumentId = paymentInstrumentId_example;  // string | The Id of a payment instrument.
            var patchPaymentInstrumentRequest = new PatchPaymentInstrumentRequest(); // PatchPaymentInstrumentRequest | 
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 
            var ifMatch = ifMatch_example;  // string | Contains an ETag value from a GET request to make the request conditional. (optional) 

            try
            {
                // Update a Payment Instrument
                PatchPaymentInstrumentRequest result = apiInstance.PatchPaymentInstrument(paymentInstrumentId, patchPaymentInstrumentRequest, profileId, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentApi.PatchPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentInstrumentId** | **string**| The Id of a payment instrument. | 
 **patchPaymentInstrumentRequest** | [**PatchPaymentInstrumentRequest**](PatchPaymentInstrumentRequest.md)|  | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 
 **ifMatch** | **string**| Contains an ETag value from a GET request to make the request conditional. | [optional] 

### Return type

[**PatchPaymentInstrumentRequest**](PatchPaymentInstrumentRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentinstrument"></a>
# **PostPaymentInstrument**
> PostPaymentInstrumentRequest PostPaymentInstrument (PostPaymentInstrumentRequest postPaymentInstrumentRequest, string profileId = null)

Create a Payment Instrument

|  |  |  | | - -- | - -- | - -- | |**Standalone Payment Instruments**<br>A Payment Instrument represents tokenized payment information such as expiration date, billing address & card type.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>**Standalone Payment Instruments do not belong to a [Customer](#token-management_customer_create-a-customer).**<br><br>**Creating a Payment Instrument**<br>It is recommended you [create a Payment Instrument via a Payment Authorization](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-customer-token-creation_liveconsole-tab-request-body), this can be for a zero amount.<br>In Europe: You should perform Payer Authentication alongside the Authorization.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Network Tokens**<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.<br>A Payment Network Token can also be [provisioned for an existing Instrument Identifier](#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token).<br>For more information about Payment Network Tokens see the Developer Guide.<br><br>**Payments with Payment Instruments**<br>To perform a payment with a particular Payment Instrument specify the [Payment Instrument in the payment request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostPaymentInstrumentExample
    {
        public void main()
        {
            var apiInstance = new PaymentInstrumentApi();
            var postPaymentInstrumentRequest = new PostPaymentInstrumentRequest(); // PostPaymentInstrumentRequest | 
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Create a Payment Instrument
                PostPaymentInstrumentRequest result = apiInstance.PostPaymentInstrument(postPaymentInstrumentRequest, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentInstrumentApi.PostPaymentInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postPaymentInstrumentRequest** | [**PostPaymentInstrumentRequest**](PostPaymentInstrumentRequest.md)|  | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**PostPaymentInstrumentRequest**](PostPaymentInstrumentRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

