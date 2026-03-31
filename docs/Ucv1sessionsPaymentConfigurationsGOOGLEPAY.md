# CyberSource.Model.Ucv1sessionsPaymentConfigurationsGOOGLEPAY
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedAuthMethods** | **List&lt;string&gt;** | When you enable Google Pay on Unified Checkout you can specify optional parameters that define the types of card authentication you receive from Google Pay.&lt;br&gt;&lt;br&gt; By default, Google sends both authentication types.  When the complete mandate is used and Google Pay does not authenticate the transaction, then Unified Checkout completes the authentication request as part of the complete mandate.&lt;br&gt;&lt;br&gt; Possible values: - PAN_ONLY: Google returns primary account number (PAN) values - CRYPTOGRAM_3DS: Google returns fully authenticated network token values.&lt;br&gt;&lt;br&gt;  Optional field:   This field can be configured through the Merchant Experience Screens in the Business Center.  The configured value may be overridden on a per transaction basis in the uc/v1/sessions API request.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

