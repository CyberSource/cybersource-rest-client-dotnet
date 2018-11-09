# CyberSource.Model.TssV2TransactionsPost201Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | An unique identification number assigned by CyberSource to identify the submitted request. | [optional] 
**Save** | **bool?** | save or not save. | [optional] 
**Name** | **string** | The description for this field is not available.  | [optional] 
**Timezone** | **string** | Time Zone. | [optional] 
**Query** | **string** | transaction search query string. | [optional] 
**Offset** | **int?** | offset. | [optional] 
**Limit** | **int?** | limit on number of results. | [optional] 
**Sort** | **string** | A comma separated list of the following form - fieldName1 asc or desc, fieldName2 asc or desc, etc. | [optional] 
**Count** | **int?** | Results for this page, this could be below the limit. | [optional] 
**TotalCount** | **int?** | total number of results. | [optional] 
**SubmitTimeUtc** | **string** | Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC.  | [optional] 
**Embedded** | [**TssV2TransactionsPost201ResponseEmbedded**](TssV2TransactionsPost201ResponseEmbedded.md) |  | [optional] 
**Links** | [**PtsV2PaymentsReversalsPost201ResponseLinks**](PtsV2PaymentsReversalsPost201ResponseLinks.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

