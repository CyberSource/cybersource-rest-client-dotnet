# CyberSource.Api.BankAccountValidationApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BankAccountValidationRequest**](BankAccountValidationApi.md#bankaccountvalidationrequest) | **POST** /bavs/v1/account-validations | Visa Bank Account Validation Service


<a name="bankaccountvalidationrequest"></a>
# **BankAccountValidationRequest**
> InlineResponse20015 BankAccountValidationRequest (AccountValidationsRequest accountValidationsRequest)

Visa Bank Account Validation Service

The Visa Bank Account Validation Service is a new standalone product designed to validate customer's routing and bank account number combination for ACH transactions. Merchant's can use this standalone product to validate their customer's account prior to processing an ACH transaction against the customer's account to comply with Nacha's account validation mandate for Web-debit transactions. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class BankAccountValidationRequestExample
    {
        public void main()
        {
            var apiInstance = new BankAccountValidationApi();
            var accountValidationsRequest = new AccountValidationsRequest(); // AccountValidationsRequest | 

            try
            {
                // Visa Bank Account Validation Service
                InlineResponse20015 result = apiInstance.BankAccountValidationRequest(accountValidationsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountValidationApi.BankAccountValidationRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountValidationsRequest** | [**AccountValidationsRequest**](AccountValidationsRequest.md)|  | 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

