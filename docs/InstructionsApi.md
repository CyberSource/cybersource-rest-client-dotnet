# CyberSource.Api.InstructionsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelPurchaseIntent**](InstructionsApi.md#cancelpurchaseintent) | **PUT** /acp/v1/instructions/{instructionId}/cancel | Cancel a purchase intent
[**ConfirmTransactionEvents**](InstructionsApi.md#confirmtransactionevents) | **POST** /acp/v1/instructions/{instructionId}/confirmations | Confirm transaction events
[**InitiatePurchaseIntent**](InstructionsApi.md#initiatepurchaseintent) | **POST** /acp/v1/instructions | Initiate a purchase intent
[**RetrievePaymentCredentials**](InstructionsApi.md#retrievepaymentcredentials) | **POST** /acp/v1/instructions/{instructionId}/credentials | Retrieve payment credentials
[**UpdatePurchaseIntent**](InstructionsApi.md#updatepurchaseintent) | **PUT** /acp/v1/instructions/{instructionId} | Update a purchase intent


<a name="cancelpurchaseintent"></a>
# **CancelPurchaseIntent**
> AgenticCreatePurchaseIntentResponse200 CancelPurchaseIntent (string instructionId, AgenticCancelPurchaseIntentRequest agenticCancelPurchaseIntentRequest)

Cancel a purchase intent

Cancels an existing purchase intent identified by the transaction ID.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CancelPurchaseIntentExample
    {
        public void main()
        {
            var apiInstance = new InstructionsApi();
            var instructionId = instructionId_example;  // string | 
            var agenticCancelPurchaseIntentRequest = new AgenticCancelPurchaseIntentRequest(); // AgenticCancelPurchaseIntentRequest | Unique identifier for the purchase intent instruction.

            try
            {
                // Cancel a purchase intent
                AgenticCreatePurchaseIntentResponse200 result = apiInstance.CancelPurchaseIntent(instructionId, agenticCancelPurchaseIntentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstructionsApi.CancelPurchaseIntent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instructionId** | **string**|  | 
 **agenticCancelPurchaseIntentRequest** | [**AgenticCancelPurchaseIntentRequest**](AgenticCancelPurchaseIntentRequest.md)| Unique identifier for the purchase intent instruction. | 

### Return type

[**AgenticCreatePurchaseIntentResponse200**](AgenticCreatePurchaseIntentResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmtransactionevents"></a>
# **ConfirmTransactionEvents**
> AgenticConfirmTransactionEventsResponse202 ConfirmTransactionEvents (string instructionId, AgenticConfirmTransactionEventsRequest agenticConfirmTransactionEventsRequest)

Confirm transaction events

Agents send the confirm transaction events to notify the payment processing is done

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
            var apiInstance = new InstructionsApi();
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
                Debug.Print("Exception when calling InstructionsApi.ConfirmTransactionEvents: " + e.Message );
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

<a name="initiatepurchaseintent"></a>
# **InitiatePurchaseIntent**
> AgenticCreatePurchaseIntentResponse200 InitiatePurchaseIntent (AgenticCreatePurchaseIntentRequest agenticCreatePurchaseIntentRequest)

Initiate a purchase intent

Creates a new purchase intent with the provided details.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class InitiatePurchaseIntentExample
    {
        public void main()
        {
            var apiInstance = new InstructionsApi();
            var agenticCreatePurchaseIntentRequest = new AgenticCreatePurchaseIntentRequest(); // AgenticCreatePurchaseIntentRequest | 

            try
            {
                // Initiate a purchase intent
                AgenticCreatePurchaseIntentResponse200 result = apiInstance.InitiatePurchaseIntent(agenticCreatePurchaseIntentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstructionsApi.InitiatePurchaseIntent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agenticCreatePurchaseIntentRequest** | [**AgenticCreatePurchaseIntentRequest**](AgenticCreatePurchaseIntentRequest.md)|  | 

### Return type

[**AgenticCreatePurchaseIntentResponse200**](AgenticCreatePurchaseIntentResponse200.md)

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

Retrieve a customer's tokenized payment credentials to complete the transaction.

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
            var apiInstance = new InstructionsApi();
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
                Debug.Print("Exception when calling InstructionsApi.RetrievePaymentCredentials: " + e.Message );
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

<a name="updatepurchaseintent"></a>
# **UpdatePurchaseIntent**
> AgenticCreatePurchaseIntentResponse200 UpdatePurchaseIntent (string instructionId, AgenticUpdatePurchaseIntentRequest agenticUpdatePurchaseIntentRequest)

Update a purchase intent

Updates an existing purchase intent identified by the transaction ID.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdatePurchaseIntentExample
    {
        public void main()
        {
            var apiInstance = new InstructionsApi();
            var instructionId = instructionId_example;  // string | Unique identifier for the purchase intent instruction.
            var agenticUpdatePurchaseIntentRequest = new AgenticUpdatePurchaseIntentRequest(); // AgenticUpdatePurchaseIntentRequest | 

            try
            {
                // Update a purchase intent
                AgenticCreatePurchaseIntentResponse200 result = apiInstance.UpdatePurchaseIntent(instructionId, agenticUpdatePurchaseIntentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstructionsApi.UpdatePurchaseIntent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instructionId** | **string**| Unique identifier for the purchase intent instruction. | 
 **agenticUpdatePurchaseIntentRequest** | [**AgenticUpdatePurchaseIntentRequest**](AgenticUpdatePurchaseIntentRequest.md)|  | 

### Return type

[**AgenticCreatePurchaseIntentResponse200**](AgenticCreatePurchaseIntentResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

