# CyberSource.Model.InlineResponse20012EmbeddedBatches
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**InlineResponse20012EmbeddedLinks**](InlineResponse20012EmbeddedLinks.md) |  | [optional] 
**BatchId** | **string** | Unique identification number assigned to the submitted request. | [optional] 
**BatchCreatedDate** | **string** | ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ | [optional] 
**BatchModifiedDate** | **string** | ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ | [optional] 
**BatchSource** | **string** | Valid Values:   * SCHEDULER   * TOKEN_API   * CREDIT_CARD_FILE_UPLOAD   * AMEX_REGSITRY   * AMEX_REGISTRY_API   * AMEX_REGISTRY_API_SYNC   * AMEX_MAINTENANCE  | [optional] 
**TokenSource** | **string** | Valid Values:   * SECURE_STORAGE   * TMS   * CYBERSOURCE  | [optional] 
**MerchantReference** | **string** | Reference used by merchant to identify batch. | [optional] 
**BatchCaEndpoints** | **List&lt;string&gt;** | Valid Values:   * VISA   * MASTERCARD   * AMEX  | [optional] 
**Status** | **string** | Valid Values:   * REJECTED   * RECEIVED   * VALIDATED   * DECLINED   * PROCESSING   * COMPLETE  | [optional] 
**Totals** | [**InlineResponse20012EmbeddedTotals**](InlineResponse20012EmbeddedTotals.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

