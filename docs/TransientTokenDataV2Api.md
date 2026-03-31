# CyberSource.Api.TransientTokenDataV2Api

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPaymentCredentialsForTransientToken**](TransientTokenDataV2Api.md#getpaymentcredentialsfortransienttoken) | **GET** /flex/v2/payment-credentials/{paymentCredentialsReference} | Get Payment Credentials
[**GetTransactionForTransientToken**](TransientTokenDataV2Api.md#gettransactionfortransienttoken) | **GET** /up/v1/payment-details/{transientToken} | Get Transient Token Data
[**GetTransactionForTransientTokenJTI**](TransientTokenDataV2Api.md#gettransactionfortransienttokenjti) | **GET** /flex/v2/payment-details/{jti} | Get Transient Token Data v2


<a name="getpaymentcredentialsfortransienttoken"></a>
# **GetPaymentCredentialsForTransientToken**
> string GetPaymentCredentialsForTransientToken (string paymentCredentialsReference)

Get Payment Credentials

Retrieve the Payment data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will return PCI payment data captured by the Unified Checkout platform.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetPaymentCredentialsForTransientTokenExample
    {
        public void main()
        {
            var apiInstance = new TransientTokenDataV2Api();
            var paymentCredentialsReference = paymentCredentialsReference_example;  // string | The paymentCredentialsReference field contained within the Transient token returned from a successful Unified Checkout transaction. 

            try
            {
                // Get Payment Credentials
                string result = apiInstance.GetPaymentCredentialsForTransientToken(paymentCredentialsReference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransientTokenDataV2Api.GetPaymentCredentialsForTransientToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentCredentialsReference** | **string**| The paymentCredentialsReference field contained within the Transient token returned from a successful Unified Checkout transaction.  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/jwt

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionfortransienttoken"></a>
# **GetTransactionForTransientToken**
> void GetTransactionForTransientToken (string transientToken)

Get Transient Token Data

Retrieve the data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will not return PCI payment data (PAN). Include the Request ID in the GET request to retrieve the transaction details.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetTransactionForTransientTokenExample
    {
        public void main()
        {
            var apiInstance = new TransientTokenDataV2Api();
            var transientToken = transientToken_example;  // string | Transient Token returned by the Unified Checkout application. 

            try
            {
                // Get Transient Token Data
                apiInstance.GetTransactionForTransientToken(transientToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransientTokenDataV2Api.GetTransactionForTransientToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transientToken** | **string**| Transient Token returned by the Unified Checkout application.  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionfortransienttokenjti"></a>
# **GetTransactionForTransientTokenJTI**
> void GetTransactionForTransientTokenJTI (string jti)

Get Transient Token Data v2

Retrieve data captured through Unified Checkout. This API retrieves the detailed information associated with a Transient Token by looking it up in TMS and using its ID (the jti claim from the /flex/v2/tokens JWT response). The response returns a decrypted version of the Transient Token; however, PCI-sensitive payment data (PAN) is never returned and is always masked.<br><br> Example jti value: 1D42LRF04LYTMO3I1G8JX6GO6S1PUFM2R4CQLU51267E0EOQ7X2169A99674E16E

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetTransactionForTransientTokenJTIExample
    {
        public void main()
        {
            var apiInstance = new TransientTokenDataV2Api();
            var jti = jti_example;  // string | The jti within the Transient Token jwt returned by the Unified Checkout application 

            try
            {
                // Get Transient Token Data v2
                apiInstance.GetTransactionForTransientTokenJTI(jti);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransientTokenDataV2Api.GetTransactionForTransientTokenJTI: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jti** | **string**| The jti within the Transient Token jwt returned by the Unified Checkout application  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

