# CyberSource.Model.TssV2TransactionsPost201Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SearchId** | **string** | An unique identification number assigned by CyberSource to identify each Search request. | [optional] 
**Save** | **bool?** | save or not save. | [optional] 
**Name** | **string** | The description for this field is not available.  | [optional] 
**Timezone** | **string** | Time Zone in ISO format. | [optional] 
**Query** | **string** | transaction search query string. | [optional] 
**Offset** | **int?** | offset. | [optional] 
**Limit** | **int?** | Limit on number of results. | [optional] 
**Sort** | **string** | A comma separated list of the following form - fieldName1 asc or desc, fieldName2 asc or desc, etc. | [optional] 
**Count** | **int?** | Results for this page, this could be below the limit. | [optional] 
**TotalCount** | **int?** | Total number of results. | [optional] 
**Status** | **string** | The status of the submitted transaction. | [optional] 
**SubmitTimeUtc** | **string** | Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; Example &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  | [optional] 
**Embedded** | [**TssV2TransactionsPost201ResponseEmbedded**](TssV2TransactionsPost201ResponseEmbedded.md) |  | [optional] 
**Links** | [**PtsV2PaymentsReversalsPost201ResponseLinks**](PtsV2PaymentsReversalsPost201ResponseLinks.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

