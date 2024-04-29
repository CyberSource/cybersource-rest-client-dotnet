# CyberSource.Api.InstrumentIdentifierApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteInstrumentIdentifier**](InstrumentIdentifierApi.md#deleteinstrumentidentifier) | **DELETE** /tms/v1/instrumentidentifiers/{instrumentIdentifierId} | Delete an Instrument Identifier
[**GetInstrumentIdentifier**](InstrumentIdentifierApi.md#getinstrumentidentifier) | **GET** /tms/v1/instrumentidentifiers/{instrumentIdentifierId} | Retrieve an Instrument Identifier
[**GetInstrumentIdentifierPaymentInstrumentsList**](InstrumentIdentifierApi.md#getinstrumentidentifierpaymentinstrumentslist) | **GET** /tms/v1/instrumentidentifiers/{instrumentIdentifierId}/paymentinstruments | List Payment Instruments for an Instrument Identifier
[**PatchInstrumentIdentifier**](InstrumentIdentifierApi.md#patchinstrumentidentifier) | **PATCH** /tms/v1/instrumentidentifiers/{instrumentIdentifierId} | Update an Instrument Identifier
[**PostInstrumentIdentifier**](InstrumentIdentifierApi.md#postinstrumentidentifier) | **POST** /tms/v1/instrumentidentifiers | Create an Instrument Identifier
[**PostInstrumentIdentifierEnrollment**](InstrumentIdentifierApi.md#postinstrumentidentifierenrollment) | **POST** /tms/v1/instrumentidentifiers/{instrumentIdentifierId}/enrollment | Enroll an Instrument Identifier for Payment Network Token


<a name="deleteinstrumentidentifier"></a>
# **DeleteInstrumentIdentifier**
> void DeleteInstrumentIdentifier (string instrumentIdentifierId, string profileId = null)

Delete an Instrument Identifier

|  |  |  | | - -- | - -- | - -- | |**Instrument Identifiers**<br>An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing <br>and account numbers.<br>The same token Id is returned for a specific card number or bank account & routing number allowing the <br>Instrument Identifier Id to be used for cross-channel payment tracking.<br>An Instrument Identifier can exist independently but also be associated with a [Customer Payment Instrument](#token-management_customer-payment-instrument_create-a-customer-payment-instrument) <br>or [Standalone Payment Instrument](#token-management_payment-instrument_create-a-payment-instrument).|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Deleting an Instrument Identifier**<br>Your system can use this API to delete an existing Instrument Identifier.<br>An Instrument Identifier cannot be deleted if it is linked to any Payment Instruments.<br>You can [retrieve all Payment Instruments associated with an Instrument Identifier](#token-management_instrument-identifier_list-payment-instruments-for-an-instrument-identifier). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteInstrumentIdentifierExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var instrumentIdentifierId = instrumentIdentifierId_example;  // string | The Id of an Instrument Identifier.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Delete an Instrument Identifier
                apiInstance.DeleteInstrumentIdentifier(instrumentIdentifierId, profileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.DeleteInstrumentIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentIdentifierId** | **string**| The Id of an Instrument Identifier. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentidentifier"></a>
# **GetInstrumentIdentifier**
> PostInstrumentIdentifierRequest GetInstrumentIdentifier (string instrumentIdentifierId, string profileId = null)

Retrieve an Instrument Identifier

|  |  |  | | - -- | - -- | - -- | |**Instrument Identifiers**<br>An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing and account number.<br>The same token Id is returned for a specific card number or bank account & routing number allowing the Instrument Identifier Id to be used for cross-channel payment tracking.<br>An Instrument Identifier can exist independently but also be associated with a [Customer Payment Instrument](#token-management_customer-payment-instrument_create-a-customer-payment-instrument) or [Standalone Payment Instrument](#token-management_payment-instrument_create-a-payment-instrument).<br><br>**Retrieving an Instrument Identifier**<br>Your system can use this API to retrieve an Instrument Identifier.<br>**Note: the actual card data will be masked.**<br>The Instrument Identifier will also be returned when retrieving a [Customer](#token-management_customer_retrieve-a-customer), [Customer Payment Instrument](#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument) or [Standalone Payment Instrument](#token-management_payment-instrument_retrieve-a-payment-instrument).|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Network Tokens**<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.<br>A Payment Network Token can also be [provisioned for an existing Instrument Identifier](#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token).<br>For more information about Payment Network Tokens see the Developer Guide.<br><br>**Payments with Instrument Identifiers**<br>To perform a payment with an Instrument Identifier simply specify the [Instrument Identifier Id in the payments request along with the expiration date, card type, & billing address](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-instrument-identifier-token-id_liveconsole-tab-request-body).<br>When an Instrument Identifier is used in a payment the **_previousTransactionId_** and **_originalAuthorizedAmount_** values are automatically recorded.<br>These values will be added for you to future Merchant Initiated Transaction payments. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetInstrumentIdentifierExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var instrumentIdentifierId = instrumentIdentifierId_example;  // string | The Id of an Instrument Identifier.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Retrieve an Instrument Identifier
                PostInstrumentIdentifierRequest result = apiInstance.GetInstrumentIdentifier(instrumentIdentifierId, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.GetInstrumentIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentIdentifierId** | **string**| The Id of an Instrument Identifier. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**PostInstrumentIdentifierRequest**](PostInstrumentIdentifierRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentidentifierpaymentinstrumentslist"></a>
# **GetInstrumentIdentifierPaymentInstrumentsList**
> PaymentInstrumentList1 GetInstrumentIdentifierPaymentInstrumentsList (string instrumentIdentifierId, string profileId = null, long? offset = null, long? limit = null)

List Payment Instruments for an Instrument Identifier

|  |  |  | | - -- | - -- | - -- | |**Instrument Identifiers**<br>An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing <br>and account numbers.<br>The same token Id is returned for a specific card number or bank account & routing number allowing the <br>Instrument Identifier Id to be used for cross-channel payment tracking.<br>An Instrument Identifier can exist independently but also be associated with a [Customer Payment Instrument](#token-management_customer-payment-instrument_create-a-customer-payment-instrument) <br>or [Standalone Payment Instrument](#token-management_payment-instrument_create-a-payment-instrument).|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Retrieving all Payment Instruments associated with an Instrument Identifier**<br>Your system can use this API to retrieve all Payment Instruments linked to an Instrument Identifier. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetInstrumentIdentifierPaymentInstrumentsListExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var instrumentIdentifierId = instrumentIdentifierId_example;  // string | The Id of an Instrument Identifier.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 
            var offset = 789;  // long? | Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional)  (default to 0)
            var limit = 789;  // long? | The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional)  (default to 20)

            try
            {
                // List Payment Instruments for an Instrument Identifier
                PaymentInstrumentList1 result = apiInstance.GetInstrumentIdentifierPaymentInstrumentsList(instrumentIdentifierId, profileId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.GetInstrumentIdentifierPaymentInstrumentsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentIdentifierId** | **string**| The Id of an Instrument Identifier. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 
 **offset** | **long?**| Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0. | [optional] [default to 0]
 **limit** | **long?**| The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. | [optional] [default to 20]

### Return type

[**PaymentInstrumentList1**](PaymentInstrumentList1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchinstrumentidentifier"></a>
# **PatchInstrumentIdentifier**
> PatchInstrumentIdentifierRequest PatchInstrumentIdentifier (string instrumentIdentifierId, PatchInstrumentIdentifierRequest patchInstrumentIdentifierRequest, string profileId = null, string ifMatch = null)

Update an Instrument Identifier

|  |  |  | | - -- | - -- | - -- | |**Instrument Identifiers**<br>An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing and account number.<br>The same token Id is returned for a specific card number or bank account & routing number allowing the Instrument Identifier Id to be used for cross-channel payment tracking.<br>An Instrument Identifier can exist independently but also be associated with a [Customer Payment Instrument](#token-management_customer-payment-instrument_create-a-customer-payment-instrument) or [Standalone Payment Instrument](#token-management_payment-instrument_create-a-payment-instrument).|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Updating an Instrument Identifier**<br>When an Instrument Identifier is used in a payment the **_previousTransactionId_** and **_originalAuthorizedAmount_** values are automatically recorded.<br>These values will be added for you to future Merchant Initiated Transaction payments.<br>Your system can use this API to update these values. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PatchInstrumentIdentifierExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var instrumentIdentifierId = instrumentIdentifierId_example;  // string | The Id of an Instrument Identifier.
            var patchInstrumentIdentifierRequest = new PatchInstrumentIdentifierRequest(); // PatchInstrumentIdentifierRequest | Specify the previous transaction Id to update.
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 
            var ifMatch = ifMatch_example;  // string | Contains an ETag value from a GET request to make the request conditional. (optional) 

            try
            {
                // Update an Instrument Identifier
                PatchInstrumentIdentifierRequest result = apiInstance.PatchInstrumentIdentifier(instrumentIdentifierId, patchInstrumentIdentifierRequest, profileId, ifMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.PatchInstrumentIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentIdentifierId** | **string**| The Id of an Instrument Identifier. | 
 **patchInstrumentIdentifierRequest** | [**PatchInstrumentIdentifierRequest**](PatchInstrumentIdentifierRequest.md)| Specify the previous transaction Id to update. | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 
 **ifMatch** | **string**| Contains an ETag value from a GET request to make the request conditional. | [optional] 

### Return type

[**PatchInstrumentIdentifierRequest**](PatchInstrumentIdentifierRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinstrumentidentifier"></a>
# **PostInstrumentIdentifier**
> PostInstrumentIdentifierRequest PostInstrumentIdentifier (PostInstrumentIdentifierRequest postInstrumentIdentifierRequest, string profileId = null)

Create an Instrument Identifier

|  |  |  | | - -- | - -- | - -- | |**Instrument Identifiers**<br>An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing and account number.<br>The same token Id is returned for a specific card number or bank account & routing number allowing the Instrument Identifier Id to be used for cross-channel payment tracking.<br>An Instrument Identifier can exist independently but also be associated with a [Customer Payment Instrument](#token-management_customer-payment-instrument_create-a-customer-payment-instrument) or [Standalone Payment Instrument](#token-management_payment-instrument_create-a-payment-instrument).<br><br>**Creating an Instrument Identifier**<br>It is recommended you [create an Instrument Identifier via a Payment Authorization](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-instrument-identifier-token-creation_liveconsole-tab-request-body), this can be for a zero amount.<br>An Instrument Identifier will also be created if you [create a Customer via a Payment Authorization](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-customer-token-creation_liveconsole-tab-request-body)<br>In Europe: You should perform Payer Authentication alongside the Authorization.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Network Tokens**<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.<br>A Payment Network Token can also be [provisioned for an existing Instrument Identifier](#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token).<br>For more information about Payment Network Tokens see the Developer Guide.<br><br>**Payments with Instrument Identifiers**<br>To perform a payment with an Instrument Identifier simply specify the [Instrument Identifier Id in the payments request along with the expiration date, card type, & billing address](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-instrument-identifier-token-id_liveconsole-tab-request-body).<br>When an Instrument Identifier is used in a payment the **_previousTransactionId_** and **_originalAuthorizedAmount_** values are automatically recorded.<br>These values will be added for you to future Merchant Initiated Transaction payments. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostInstrumentIdentifierExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var postInstrumentIdentifierRequest = new PostInstrumentIdentifierRequest(); // PostInstrumentIdentifierRequest | Specify either a Card, Bank Account or Enrollable Card
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Create an Instrument Identifier
                PostInstrumentIdentifierRequest result = apiInstance.PostInstrumentIdentifier(postInstrumentIdentifierRequest, profileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.PostInstrumentIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postInstrumentIdentifierRequest** | [**PostInstrumentIdentifierRequest**](PostInstrumentIdentifierRequest.md)| Specify either a Card, Bank Account or Enrollable Card | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

[**PostInstrumentIdentifierRequest**](PostInstrumentIdentifierRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinstrumentidentifierenrollment"></a>
# **PostInstrumentIdentifierEnrollment**
> void PostInstrumentIdentifierEnrollment (string instrumentIdentifierId, PostInstrumentIdentifierEnrollmentRequest postInstrumentIdentifierEnrollmentRequest, string profileId = null)

Enroll an Instrument Identifier for Payment Network Token

|  |  |  | | - -- | - -- | - -- | |**Instrument Identifiers**<br>An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing and account number.<br>The same token Id is returned for a specific card number or bank account & routing number allowing the Instrument Identifier Id to be used for cross-channel payment tracking.<br>An Instrument Identifier can exist independently but also be associated with a [Customer Payment Instrument](#token-management_customer-payment-instrument_create-a-customer-payment-instrument) or [Standalone Payment Instrument](#token-management_payment-instrument_create-a-payment-instrument).|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Enroll an Instrument Identifier for a Payment Network Token**<br>Your system can use this API to provision a Network token for an existing Instrument Identifier.<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Network token can be [provisioned when creating an Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier_samplerequests-dropdown_create-instrument-identifier-card-enroll-for-network-token_liveconsole-tab-request-body).This will occur automatically when creating a [Customer](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-customer-token-creation_liveconsole-tab-request-body), [Payment Instrument](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-create-default-payment-instrument-shipping-address-for-existing-customer_liveconsole-tab-request-body) or [Instrument Identifier](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-instrument-identifier-token-creation_liveconsole-tab-request-body) via the Payments API.<br>For more information about Payment Network Tokens see the Developer Guide. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PostInstrumentIdentifierEnrollmentExample
    {
        public void main()
        {
            var apiInstance = new InstrumentIdentifierApi();
            var instrumentIdentifierId = instrumentIdentifierId_example;  // string | The Id of an Instrument Identifier.
            var postInstrumentIdentifierEnrollmentRequest = new PostInstrumentIdentifierEnrollmentRequest(); // PostInstrumentIdentifierEnrollmentRequest | Specify Enrollable Card details
            var profileId = profileId_example;  // string | The Id of a profile containing user specific TMS configuration. (optional) 

            try
            {
                // Enroll an Instrument Identifier for Payment Network Token
                apiInstance.PostInstrumentIdentifierEnrollment(instrumentIdentifierId, postInstrumentIdentifierEnrollmentRequest, profileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentIdentifierApi.PostInstrumentIdentifierEnrollment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentIdentifierId** | **string**| The Id of an Instrument Identifier. | 
 **postInstrumentIdentifierEnrollmentRequest** | [**PostInstrumentIdentifierEnrollmentRequest**](PostInstrumentIdentifierEnrollmentRequest.md)| Specify Enrollable Card details | 
 **profileId** | **string**| The Id of a profile containing user specific TMS configuration. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

