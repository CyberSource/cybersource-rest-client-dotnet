# CyberSource.Model.InlineResponse2009
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Version** | **string** |  | [optional] 
**ReportCreatedDate** | **string** | ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ | [optional] 
**BatchId** | **string** | Unique identification number assigned to the submitted request. | [optional] 
**BatchSource** | **string** | Valid Values:   * SCHEDULER   * TOKEN_API   * CREDIT_CARD_FILE_UPLOAD   * AMEX_REGSITRY   * AMEX_REGISTRY_API   * AMEX_MAINTENANCE  | [optional] 
**BatchCaEndpoints** | **string** |  | [optional] 
**BatchCreatedDate** | **string** | ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ | [optional] 
**MerchantReference** | **string** | Reference used by merchant to identify batch. | [optional] 
**Totals** | [**InlineResponse2007EmbeddedTotals**](InlineResponse2007EmbeddedTotals.md) |  | [optional] 
**Billing** | [**InlineResponse2008Billing**](InlineResponse2008Billing.md) |  | [optional] 
**Records** | [**List&lt;InlineResponse2009Records&gt;**](InlineResponse2009Records.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

