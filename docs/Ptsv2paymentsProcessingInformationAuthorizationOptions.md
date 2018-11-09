# CyberSource.Model.Ptsv2paymentsProcessingInformationAuthorizationOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthType** | **string** | Authorization type. Possible values:   - **AUTOCAPTURE**: automatic capture.  - **STANDARDCAPTURE**: standard capture.  - **VERBAL**: forced capture. Include it in the payment request for a forced capture. Include it in the capture  request for a verbal payment.  For processor-specific information, see the auth_type field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  | [optional] 
**VerbalAuthCode** | **string** | Authorization code.  **Forced Capture**  Use this field to send the authorization code you received from a payment that you authorized outside the CyberSource system.  **Verbal Authorization**  Use this field in CAPTURE API to send the verbally received authorization code.  For processor-specific information, see the auth_code field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  | [optional] 
**VerbalAuthTransactionId** | **string** | Transaction ID (TID). | [optional] 
**AuthIndicator** | **string** | Flag that specifies the purpose of the authorization.  Possible values:  - **0**: Preauthorization  - **1**: Final authorization  For processor-specific information, see the auth_indicator field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  | [optional] 
**PartialAuthIndicator** | **bool?** | Flag that indicates whether the transaction is enabled for partial authorization or not. When your request includes this field, this value overrides the information in your CyberSource account.  For processor-specific information, see the auth_partial_auth_indicator field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  | [optional] 
**BalanceInquiry** | **bool?** | Flag that indicates whether to return balance information. | [optional] 
**IgnoreAvsResult** | **bool?** | Flag that indicates whether to allow the capture service to run even when the payment receives an AVS decline.  | [optional] [default to false]
**DeclineAvsFlags** | **List&lt;string&gt;** | An array of AVS flags that cause the reply flag to be returned.  &#x60;Important&#x60; To receive declines for the AVS code N, include the value N in the array.  | [optional] 
**IgnoreCvResult** | **bool?** | Flag that indicates whether to allow the capture service to run even when the payment receives a CVN decline.  | [optional] [default to false]
**Initiator** | [**Ptsv2paymentsProcessingInformationAuthorizationOptionsInitiator**](Ptsv2paymentsProcessingInformationAuthorizationOptionsInitiator.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

