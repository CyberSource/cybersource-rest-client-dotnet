# CyberSource.Model.InlineResponse2014SetupsPaymentsCardProcessingSubscriptionStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubmitTimeUtc** | **string** | Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC.  | [optional] 
**Status** | **string** | Possible values: - SUCCESS - FAILURE - PARTIAL - PENDING | [optional] 
**Reason** | **string** | Possible values: - DEPENDENT_PRODUCT_NOT_CONTRACTED - DEPENDENT_FEATURE_NOT_CHOSEN - MISSING_DATA - INVALID_DATA - DUPLICATE_FIELD | [optional] 
**Details** | **List&lt;Dictionary&lt;string, string&gt;&gt;** |  | [optional] 
**Message** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

