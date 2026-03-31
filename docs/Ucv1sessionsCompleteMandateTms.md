# CyberSource.Model.Ucv1sessionsCompleteMandateTms
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenCreate** | **bool?** | Use this when you want to create a token from the card/bank data in your payment request.   Possible values:   - True   - False&lt;br&gt;&lt;br&gt;  Optional field: This field can be configured through the Merchant Experience screens in the Business Center. The configured value may be overridden on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**TokenTypes** | **List&lt;string&gt;** | Cybersource tokens types you are performing a create on. If not supplied the default token type for the merchants token vault will be used.  Possible values: - Customer - paymentInstrument - instrumentIdentifier - shippingAddress&lt;br&gt;&lt;br&gt;  Optional field: This field can be configured through the Merchant Experience screens in the Business Center. The configured value may be overridden on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

