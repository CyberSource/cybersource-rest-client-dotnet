# CyberSource.Api.VerificationApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ValidateExportCompliance**](VerificationApi.md#validateexportcompliance) | **POST** /risk/v1/export-compliance-inquiries | Validate export compliance
[**VerifyCustomerAddress**](VerificationApi.md#verifycustomeraddress) | **POST** /risk/v1/address-verifications | Verify customer address


<a name="validateexportcompliance"></a>
# **ValidateExportCompliance**
> RiskV1ExportComplianceInquiriesPost201Response ValidateExportCompliance (ValidateExportComplianceRequest validateExportComplianceRequest)

Validate export compliance

This call checks customer data against specified watch lists to ensure export compliance. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ValidateExportComplianceExample
    {
        public void main()
        {
            var apiInstance = new VerificationApi();
            var validateExportComplianceRequest = new ValidateExportComplianceRequest(); // ValidateExportComplianceRequest | 

            try
            {
                // Validate export compliance
                RiskV1ExportComplianceInquiriesPost201Response result = apiInstance.ValidateExportCompliance(validateExportComplianceRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.ValidateExportCompliance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **validateExportComplianceRequest** | [**ValidateExportComplianceRequest**](ValidateExportComplianceRequest.md)|  | 

### Return type

[**RiskV1ExportComplianceInquiriesPost201Response**](RiskV1ExportComplianceInquiriesPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifycustomeraddress"></a>
# **VerifyCustomerAddress**
> RiskV1AddressVerificationsPost201Response VerifyCustomerAddress (VerifyCustomerAddressRequest verifyCustomerAddressRequest)

Verify customer address

This call verifies that the customer address submitted is valid.

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class VerifyCustomerAddressExample
    {
        public void main()
        {
            var apiInstance = new VerificationApi();
            var verifyCustomerAddressRequest = new VerifyCustomerAddressRequest(); // VerifyCustomerAddressRequest | 

            try
            {
                // Verify customer address
                RiskV1AddressVerificationsPost201Response result = apiInstance.VerifyCustomerAddress(verifyCustomerAddressRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.VerifyCustomerAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **verifyCustomerAddressRequest** | [**VerifyCustomerAddressRequest**](VerifyCustomerAddressRequest.md)|  | 

### Return type

[**RiskV1AddressVerificationsPost201Response**](RiskV1AddressVerificationsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

