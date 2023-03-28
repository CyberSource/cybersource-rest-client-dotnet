# CyberSource.Model.GenerateUnifiedCheckoutCaptureContextRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetOrigins** | **List&lt;string&gt;** |  | [optional] 
**ClientVersion** | **string** | version number of Unified Checkout being used | [optional] 
**AllowedCardNetworks** | **List&lt;string&gt;** |  | [optional] 
**AllowedPaymentTypes** | **List&lt;string&gt;** |  | [optional] 
**Country** | **string** | Country the purchase is originating from (e.g. country of the merchant). Use the two- character ISO Standard | [optional] 
**Locale** | **string** | Localization of the User experience conforming to the ISO 639-1 language standards and two-character ISO Standard Country Code | [optional] 
**CaptureMandate** | [**Upv1capturecontextsCaptureMandate**](Upv1capturecontextsCaptureMandate.md) |  | [optional] 
**OrderInformation** | [**Upv1capturecontextsOrderInformation**](Upv1capturecontextsOrderInformation.md) |  | [optional] 
**CheckoutApiInitialization** | [**Upv1capturecontextsCheckoutApiInitialization**](Upv1capturecontextsCheckoutApiInitialization.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

