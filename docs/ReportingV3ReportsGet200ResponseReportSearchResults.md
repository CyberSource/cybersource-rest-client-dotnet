# CyberSource.Model.ReportingV3ReportsGet200ResponseReportSearchResults
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Link** | [**ReportingV3ReportsGet200ResponseLink**](ReportingV3ReportsGet200ResponseLink.md) |  | [optional] 
**ReportDefinitionId** | **string** | Unique Report Identifier of each report type | [optional] 
**ReportName** | **string** | Name of the report specified by merchant while creating the report | [optional] 
**ReportMimeType** | **string** | Format of the report to get generated Valid Values: - application/xml - text/csv  | [optional] 
**ReportFrequency** | **string** | Frequency of the report to get generated Valid Values: - DAILY - WEEKLY - MONTHLY - ADHOC  | [optional] 
**Status** | **string** | Status of the report Valid Values: - COMPLETED - PENDING - QUEUED - RUNNING - ERROR - NO_DATA  | [optional] 
**ReportStartTime** | **DateTime?** | Specifies the report start time in ISO 8601 format | [optional] 
**ReportEndTime** | **DateTime?** | Specifies the report end time in ISO 8601 format | [optional] 
**Timezone** | **string** | Time Zone | [optional] 
**ReportId** | **string** | Unique identifier generated for every reports | [optional] 
**OrganizationId** | **string** | CyberSource Merchant Id | [optional] 
**QueuedTime** | **DateTime?** | Specifies the time of the report in queued  in ISO 8601 format | [optional] 
**ReportGeneratingTime** | **DateTime?** | Specifies the time of the report started to generate  in ISO 8601 format | [optional] 
**ReportCompletedTime** | **DateTime?** | Specifies the time of the report completed the generation  in ISO 8601 format | [optional] 
**SubscriptionType** | **string** | Specifies whether the subscription created is either Custom, Standard or Classic  | [optional] 
**GroupId** | **string** | Id for selected group. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

