# CyberSource.Model.InlineResponse2001
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubmitTimeUtc** | **string** | Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC.  | [optional] 
**TotalCount** | **int?** | Specifies the total number of items found based on the request | [optional] 
**Offset** | **int?** | Specifies the record offset from the records are returned part of the response | [optional] 
**Limit** | **int?** | Specifies the maximum number of records requested part of the response | [optional] 
**Sort** | **string** | Specifies a comma separated list of field names based on which the result is sorted. | [optional] 
**Keys** | [**List&lt;InlineResponse2001Keys&gt;**](InlineResponse2001Keys.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

