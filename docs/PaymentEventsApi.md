# CyberSource.Api.PaymentEventsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfirmTransactionEvents**](PaymentEventsApi.md#confirmtransactionevents) | **POST** /icc/v1/instructions/{instructionId}/confirmations | Confirm transaction events
[**RetrievePaymentCredentials**](PaymentEventsApi.md#retrievepaymentcredentials) | **POST** /icc/v1/instructions/{instructionId}/credentials | Retrieve payment credentials


<a name="confirmtransactionevents"></a>
# **ConfirmTransactionEvents**
> AgenticConfirmTransactionEventsResponse202 ConfirmTransactionEvents (string instructionId, AgenticConfirmTransactionEventsRequest agenticConfirmTransactionEventsRequest)

Confirm transaction events

Confirm transaction events for a completed purchase. The agent calls this endpoint after the payment has been submitted to notify the Intelligent Commerce Connect of the transaction outcome. The request includes processor information (transaction type, status, approval codes), order details (shipping, tracking, product information), and merchant information. Returns HTTP 202 acknowledging receipt of the confirmation.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ConfirmTransactionEventsExample
    {
        public void main()
        {
            var apiInstance = new PaymentEventsApi();
            var instructionId = instructionId_example;  // string | Unique identifier for the purchase intent instruction.
            var agenticConfirmTransactionEventsRequest = new AgenticConfirmTransactionEventsRequest(); // AgenticConfirmTransactionEventsRequest | 

            try
            {
                // Confirm transaction events
                AgenticConfirmTransactionEventsResponse202 result = apiInstance.ConfirmTransactionEvents(instructionId, agenticConfirmTransactionEventsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentEventsApi.ConfirmTransactionEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instructionId** | **string**| Unique identifier for the purchase intent instruction. | 
 **agenticConfirmTransactionEventsRequest** | [**AgenticConfirmTransactionEventsRequest**](AgenticConfirmTransactionEventsRequest.md)|  | 

### Return type

[**AgenticConfirmTransactionEventsResponse202**](AgenticConfirmTransactionEventsResponse202.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievepaymentcredentials"></a>
# **RetrievePaymentCredentials**
> AgenticRetrievePaymentCredentialsResponse200 RetrievePaymentCredentials (string instructionId, AgenticRetrievePaymentCredentialsRequest agenticRetrievePaymentCredentialsRequest)

Retrieve payment credentials

Retrieve tokenized payment credentials for a purchase intent to complete the transaction at a merchant. The agent calls this endpoint after a purchase intent has been created and approved, providing transaction-level details including order information, merchant details, payment options, and production information. Returns COMPLETED (HTTP 200) with a signed payload containing encrypted payment credentials (authorization token and JWS-signed payload), or PENDING (HTTP 202) with pendingEvents if additional cardholder authentication is required. The signed payload is used by the merchant's payment processor to complete the transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class RetrievePaymentCredentialsExample
    {
        public void main()
        {
            var apiInstance = new PaymentEventsApi();
            var instructionId = instructionId_example;  // string | Unique identifier for the purchase intent instruction.
            var agenticRetrievePaymentCredentialsRequest = new AgenticRetrievePaymentCredentialsRequest(); // AgenticRetrievePaymentCredentialsRequest | 

            try
            {
                // Retrieve payment credentials
                AgenticRetrievePaymentCredentialsResponse200 result = apiInstance.RetrievePaymentCredentials(instructionId, agenticRetrievePaymentCredentialsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentEventsApi.RetrievePaymentCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instructionId** | **string**| Unique identifier for the purchase intent instruction. | 
 **agenticRetrievePaymentCredentialsRequest** | [**AgenticRetrievePaymentCredentialsRequest**](AgenticRetrievePaymentCredentialsRequest.md)|  | 

### Return type

[**AgenticRetrievePaymentCredentialsResponse200**](AgenticRetrievePaymentCredentialsResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

