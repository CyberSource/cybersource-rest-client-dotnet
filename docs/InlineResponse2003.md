# CyberSource.Model.InlineResponse2003
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**InlineResponse2003Links**](InlineResponse2003Links.md) |  | [optional] 
**BatchId** | **string** | Unique identification number assigned to the submitted request. | [optional] 
**BatchCreatedDate** | **string** | ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ | [optional] 
**BatchSource** | **string** | Valid Values:   * SCHEDULER   * TOKEN_API   * CREDIT_CARD_FILE_UPLOAD   * AMEX_REGSITRY   * AMEX_REGISTRY_API   * AMEX_MAINTENANCE  | [optional] 
**MerchantReference** | **string** | Reference used by merchant to identify batch. | [optional] 
**BatchCaEndpoints** | **string** |  | [optional] 
**Status** | **string** | Valid Values:   * REJECTED   * RECEIVED   * VALIDATED   * DECLINED   * PROCESSING   * COMPLETED  | [optional] 
**Totals** | [**InlineResponse2002EmbeddedTotals**](InlineResponse2002EmbeddedTotals.md) |  | [optional] 
**Billing** | [**InlineResponse2003Billing**](InlineResponse2003Billing.md) |  | [optional] 
**Description** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

