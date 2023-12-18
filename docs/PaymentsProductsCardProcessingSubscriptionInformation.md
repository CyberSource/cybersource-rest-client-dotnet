# CyberSource.Model.PaymentsProductsCardProcessingSubscriptionInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool?** |  | [optional] 
**SelfServiceability** | **string** | Indicates if the organization can enable this product using self service. | [optional] [default to SelfServiceabilityEnum.NOTSELFSERVICEABLE]
**Features** | [**Dictionary&lt;string, PaymentsProductsCardProcessingSubscriptionInformationFeatures&gt;**](PaymentsProductsCardProcessingSubscriptionInformationFeatures.md) | This is a map. The allowed keys are below. Value should be an object containing a sole boolean property - enabled. &lt;table&gt;    &lt;tr&gt;       &lt;td&gt;cardPresent&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;       &lt;td&gt;cardNotPresent&lt;/td&gt;    &lt;/tr&gt; &lt;/table&gt;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

