# CyberSource.Model.InlineResponse2009
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**InlineResponse2009Links**](InlineResponse2009Links.md) |  | [optional] 
**BatchId** | **string** | Unique identification number assigned to the submitted request. | [optional] 
**BatchCreatedDate** | **string** | ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ | [optional] 
**BatchSource** | **string** | Valid Values:   * SCHEDULER   * TOKEN_API   * CREDIT_CARD_FILE_UPLOAD   * AMEX_REGSITRY   * AMEX_REGISTRY_API   * AMEX_MAINTENANCE  | [optional] 
**MerchantReference** | **string** | Reference used by merchant to identify batch. | [optional] 
**BatchCaEndpoints** | **string** |  | [optional] 
**Status** | **string** | Valid Values:   * REJECTED   * RECEIVED   * VALIDATED   * DECLINED   * PROCESSING   * COMPLETED  | [optional] 
**Totals** | [**InlineResponse2008EmbeddedTotals**](InlineResponse2008EmbeddedTotals.md) |  | [optional] 
**Billing** | [**InlineResponse2009Billing**](InlineResponse2009Billing.md) |  | [optional] 
**Description** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

