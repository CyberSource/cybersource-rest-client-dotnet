# CyberSource.Api.OffersApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOffer**](OffersApi.md#createoffer) | **POST** /vas/v1/currencyconversion | Create an Offer
[**GetOffer**](OffersApi.md#getoffer) | **GET** /vas/v1/currencyconversion/{id} | Retrieve an Offer


<a name="createoffer"></a>
# **CreateOffer**
> InlineResponse2019 CreateOffer (string contentType, string xRequestid, string vCMerchantId, string vCCorrelationId, string vCOrganizationId, OfferRequest offerRequest)

Create an Offer

Empower global transactions with transparency and choice. Our Dynamic Currency Conversion API lets merchants offer customers the option to pay in their home currency at checkout, delivering real-time exchange rates.  <div style=\"display: flex; gap: 2rem;\"> <div style=\"flex: 1;\">  **Key Benefits:** - **Enhanced Customer Experience:** Provide clarity and convenience for international shoppers. - **Real-Time Rates:** Accurate currency conversion with all the data required for acquirers and their merchants to maintain compliance with card network rules. - **Seamless Integration:** Flexible API endpoints for rate lookup, authorization, and capture. - **Regulatory Compliance:** Provides the data required for acquirers and merchants to meet and maintain card scheme requirements for disclosure and consent.  <br>  Ideal for merchants and payment partners seeking to boost trust and conversion in cross-border commerce.  <br>  **Key Features:** - **Rate Lookup:** Retrieves the most up-to-date exchange rate for eligible cards before authorization. - **Currency Choice:** Enables the merchant to offer customers the option to select between the merchant's local currency and their card's billing currency. - **Compliance:** Ensures merchants have the data required to adhere to card network regulations; exchange rates, markups, etc.  <div style=\"margin-top: 1.5rem;\">  **Supported Scenarios:** - Dynamic Currency Conversion when cardholder's billing currency differs from merchant's pricing currency. - Merchant and acquirer must support the cardholder's billing currency. </div>  <div style=\"margin-top: 1.5rem;\">  **Supported Processors:** - VPC - FDI Global </div>  <div style=\"margin-top: 1.5rem;\">  **Compliance & Disclosure:**  Merchants must: - Adhere to card network rules for Dynamic Currency Conversion (DCC) transactions. - Display the converted amount, exchange rate, and markup percentage and other required disclosures. - Obtain explicit cardholder consent before applying DCC. - Work with your acquirer to obtain full set of compliance requirements. </div>  </div> <div style=\"flex: 1;\">  **Core API Endpoints:**  **Currency Conversion API**  Returns eligibility and exchange rate details, including: - exchangeRate - marginRate - reconciliationId and Id (for subsequent payment requests)  <div style=\"margin-top: 1.5rem;\">  **Payment Authorization with DCC***  POST /pts/v2/payments  Required fields include: - orderInformation.amountDetails.currency - orderInformation.amountDetails.originalCurrency - orderInformation.amountDetails.originalAmount - orderInformation.amountDetails.exchangeRate - currencyConversion.indicator (e.g., 1 = Converted, 2 = Nonconvertible, 3 = Declined) </div>  <div style=\"margin-top: 1.5rem;\">  **Capture with DCC***  POST /pts/v2/payments/{id}/captures  Maps from original authorization and includes original and converted amounts. </div>  <div style=\"margin-top: 1.5rem;\">  **Refund with DCC***  POST /pts/v2/captures/{id}/refunds  Maps from original authorization and includes original and converted amounts.  *Note: DCC is only supported on select processors. Contact your acquirer or account manager for more information.* </div>  </div> </div>  <br>  For more information, see the [Currency Conversion Developer Guide](https://developer.cybersource.com/docs/cybs/en-us/currency-conversion/developer/all/rest/currency-conversion/cc-intro.html). 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateOfferExample
    {
        public void main()
        {
            var apiInstance = new OffersApi();
            var contentType = contentType_example;  // string | 
            var xRequestid = xRequestid_example;  // string | 
            var vCMerchantId = vCMerchantId_example;  // string | 
            var vCCorrelationId = vCCorrelationId_example;  // string | 
            var vCOrganizationId = vCOrganizationId_example;  // string | 
            var offerRequest = new OfferRequest(); // OfferRequest | 

            try
            {
                // Create an Offer
                InlineResponse2019 result = apiInstance.CreateOffer(contentType, xRequestid, vCMerchantId, vCCorrelationId, vCOrganizationId, offerRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.CreateOffer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **xRequestid** | **string**|  | 
 **vCMerchantId** | **string**|  | 
 **vCCorrelationId** | **string**|  | 
 **vCOrganizationId** | **string**|  | 
 **offerRequest** | [**OfferRequest**](OfferRequest.md)|  | 

### Return type

[**InlineResponse2019**](InlineResponse2019.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoffer"></a>
# **GetOffer**
> InlineResponse20016 GetOffer (string contentType, string xRequestid, string vCMerchantId, string vCCorrelationId, string vCOrganizationId, string id)

Retrieve an Offer

Retrieves an offer record from the system. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetOfferExample
    {
        public void main()
        {
            var apiInstance = new OffersApi();
            var contentType = contentType_example;  // string | 
            var xRequestid = xRequestid_example;  // string | 
            var vCMerchantId = vCMerchantId_example;  // string | 
            var vCCorrelationId = vCCorrelationId_example;  // string | 
            var vCOrganizationId = vCOrganizationId_example;  // string | 
            var id = id_example;  // string | Request ID generated by Cybersource. This was sent in the header on the request. Echo value from v-c-request-id

            try
            {
                // Retrieve an Offer
                InlineResponse20016 result = apiInstance.GetOffer(contentType, xRequestid, vCMerchantId, vCCorrelationId, vCOrganizationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.GetOffer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **xRequestid** | **string**|  | 
 **vCMerchantId** | **string**|  | 
 **vCCorrelationId** | **string**|  | 
 **vCOrganizationId** | **string**|  | 
 **id** | **string**| Request ID generated by Cybersource. This was sent in the header on the request. Echo value from v-c-request-id | 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

