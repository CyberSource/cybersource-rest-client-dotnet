# CyberSource.Model.Ptsv2payoutsMerchantInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CategoryCode** | **int?** | Four-digit number that the payment card industry uses to classify merchants into market segments. Visa assigned one or more of these values to your business when you started accepting Visa cards.  If you do not include this field in your request, CyberSource uses the value in your CyberSource account.  For processor-specific information, see the merchant_category_code field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  See \&quot;Aggregator Support,\&quot; page 100.  **CyberSource through VisaNet**\\ The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCR4 - Position: 150-153 - Field: Merchant Category Code  | [optional] 
**SubmitLocalDateTime** | **string** | Time that the transaction was submitted in local time. The time is in hhmmss format.  | [optional] 
**VatRegistrationNumber** | **string** | Your government-assigned tax identification number.  For CtV processors, the maximum length is 20.  For other processor-specific information, see the merchant_vat_registration_number field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html)  | [optional] 
**MerchantDescriptor** | [**Ptsv2payoutsMerchantInformationMerchantDescriptor**](Ptsv2payoutsMerchantInformationMerchantDescriptor.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

