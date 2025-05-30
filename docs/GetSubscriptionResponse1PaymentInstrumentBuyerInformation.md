# CyberSource.Model.GetSubscriptionResponse1PaymentInstrumentBuyerInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyTaxID** | **string** | Company&#39;s tax identifier. This is only used for eCheck service.  | [optional] 
**Currency** | **string** | Currency used for the order. Use the three-character I[ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### DCC for First Data Your local currency. For details, see the &#x60;currency&#x60; field description in [Dynamic Currency Conversion For First Data Using the SCMP API](http://apps.cybersource.com/library/documentation/dev_guides/DCC_FirstData_SCMP/DCC_FirstData_SCMP_API.pdf).  | [optional] 
**DateOfBirth** | **DateTime?** | Date of birth of the customer. Format: YYYY-MM-DD  | [optional] 
**PersonalIdentification** | [**List&lt;Tmsv2customersEmbeddedDefaultPaymentInstrumentBuyerInformationPersonalIdentification&gt;**](Tmsv2customersEmbeddedDefaultPaymentInstrumentBuyerInformationPersonalIdentification.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

