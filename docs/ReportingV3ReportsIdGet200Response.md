# CyberSource.Model.ReportingV3ReportsIdGet200Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrganizationId** | **string** | CyberSource merchant id | [optional] 
**ReportId** | **string** | Report ID Value | [optional] 
**ReportDefinitionId** | **string** | Report definition Id | [optional] 
**ReportName** | **string** | Report Name | [optional] 
**ReportMimeType** | **string** | Report Format  Valid values: - application/xml - text/csv  | [optional] 
**ReportFrequency** | **string** | Report Frequency Value  Valid values: - DAILY - WEEKLY - MONTHLY - ADHOC  | [optional] 
**ReportFields** | **List&lt;string&gt;** | List of Integer Values | [optional] 
**ReportStatus** | **string** | Report Status Value  Valid values: - COMPLETED - PENDING - QUEUED - RUNNING - ERROR - NO_DATA - RERUN  | [optional] 
**ReportStartTime** | **DateTime?** | Report Start Time Value | [optional] 
**ReportEndTime** | **DateTime?** | Report End Time Value | [optional] 
**Timezone** | **string** | Time Zone Value | [optional] 
**ReportFilters** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | List of filters to apply | [optional] 
**ReportPreferences** | [**Reportingv3reportsReportPreferences**](Reportingv3reportsReportPreferences.md) |  | [optional] 
**GroupId** | **string** | Id for selected group. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

