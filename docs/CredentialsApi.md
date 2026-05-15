# CyberSource.Api.CredentialsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProvisionMppCredentials**](CredentialsApi.md#provisionmppcredentials) | **POST** /acp/v1/mpp/credentials | Provision MPP credentials


<a name="provisionmppcredentials"></a>
# **ProvisionMppCredentials**
> MppCredentialsResponse200 ProvisionMppCredentials (MppCredentialsRequest mppCredentialsRequest)

Provision MPP credentials

Provisions an encrypted MPP credential for use as the credential payload in an Authorization: Payment header (MPP spec Section 8.2). The caller provides an instrument identifier (referencing a stored card in TMS) and the challenge context from the merchant's 402 response, including the merchant's RSA public encryption key. This service:   1. Calls TMS to retrieve the network token and cryptogram for the instrument.   2. Builds the token plaintext (MPP spec Section 8.3, type: network_token).   3. Encrypts the plaintext using RSA-OAEP with SHA-256 and the merchant's public key.   4. Returns the MPP credential payload fields (MPP spec Section 8.2, Table 4). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ProvisionMppCredentialsExample
    {
        public void main()
        {
            var apiInstance = new CredentialsApi();
            var mppCredentialsRequest = new MppCredentialsRequest(); // MppCredentialsRequest | 

            try
            {
                // Provision MPP credentials
                MppCredentialsResponse200 result = apiInstance.ProvisionMppCredentials(mppCredentialsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.ProvisionMppCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mppCredentialsRequest** | [**MppCredentialsRequest**](MppCredentialsRequest.md)|  | 

### Return type

[**MppCredentialsResponse200**](MppCredentialsResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

