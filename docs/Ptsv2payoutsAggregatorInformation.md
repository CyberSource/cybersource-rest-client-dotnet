# CyberSource.Model.Ptsv2payoutsAggregatorInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AggregatorId** | **string** | Value that identifies you as a payment aggregator. Get this value from the processor.  | [optional] 
**Name** | **string** | Your payment aggregator business name. This field is conditionally required when aggregator id is present.  | [optional] 
**IndependentSalesOrganizationID** | **string** | Independent sales organization ID. This field is only used for Mastercard transactions submitted through PPGS.  | [optional] 
**SubMerchant** | [**Ptsv2payoutsAggregatorInformationSubMerchant**](Ptsv2payoutsAggregatorInformationSubMerchant.md) |  | [optional] 
**StreetAddress** | **string** | Acquirer street name. | [optional] 
**City** | **string** | Acquirer city. | [optional] 
**State** | **string** | Acquirer state. | [optional] 
**PostalCode** | **string** | Acquirer postal code. | [optional] 
**Country** | **string** | Acquirer country. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

