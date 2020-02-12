# CyberSource.Api.VerificationApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RiskV1AddressVerificationsPost**](VerificationApi.md#riskv1addressverificationspost) | **POST** /risk/v1/address-verifications | Verify customer address
[**RiskV1ExportComplianceInquiriesPost**](VerificationApi.md#riskv1exportcomplianceinquiriespost) | **POST** /risk/v1/export-compliance-inquiries | Validate export compliance


<a name="riskv1addressverificationspost"></a>
# **RiskV1AddressVerificationsPost**
> RiskV1AddressVerificationsPost201Response RiskV1AddressVerificationsPost (VerifyCustomerAddressRequest verifyCustomerAddressRequest)

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
    public class RiskV1AddressVerificationsPostExample
    {
        public void main()
        {
            var apiInstance = new VerificationApi();
            var verifyCustomerAddressRequest = new VerifyCustomerAddressRequest(); // VerifyCustomerAddressRequest | 

            try
            {
                // Verify customer address
                RiskV1AddressVerificationsPost201Response result = apiInstance.RiskV1AddressVerificationsPost(verifyCustomerAddressRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.RiskV1AddressVerificationsPost: " + e.Message );
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

<a name="riskv1exportcomplianceinquiriespost"></a>
# **RiskV1ExportComplianceInquiriesPost**
> RiskV1ExportComplianceInquiriesPost201Response RiskV1ExportComplianceInquiriesPost (ValidateExportComplianceRequest validateExportComplianceRequest)

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
    public class RiskV1ExportComplianceInquiriesPostExample
    {
        public void main()
        {
            var apiInstance = new VerificationApi();
            var validateExportComplianceRequest = new ValidateExportComplianceRequest(); // ValidateExportComplianceRequest | 

            try
            {
                // Validate export compliance
                RiskV1ExportComplianceInquiriesPost201Response result = apiInstance.RiskV1ExportComplianceInquiriesPost(validateExportComplianceRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.RiskV1ExportComplianceInquiriesPost: " + e.Message );
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

