# CyberSource.Model.CreateAdhocReportRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrganizationId** | **string** | Valid CyberSource Organization Id | [optional] 
**ReportDefinitionName** | **string** |  | [optional] 
**ReportFields** | **List&lt;string&gt;** | List of fields which needs to get included in a report | [optional] 
**ReportMimeType** | **string** | &#39;Format of the report&#39;                  Valid values: - application/xml - text/csv  | [optional] 
**ReportName** | **string** | Name of the report | [optional] 
**Timezone** | **string** | Timezone of the report | [optional] 
**ReportStartTime** | **DateTime?** | Start time of the report | [optional] 
**ReportEndTime** | **DateTime?** | End time of the report | [optional] 
**ReportFilters** | [**Reportingv3reportsReportFilters**](Reportingv3reportsReportFilters.md) |  | [optional] 
**ReportPreferences** | [**Reportingv3reportsReportPreferences**](Reportingv3reportsReportPreferences.md) |  | [optional] 
**GroupName** | **string** | Specifies the group name | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

