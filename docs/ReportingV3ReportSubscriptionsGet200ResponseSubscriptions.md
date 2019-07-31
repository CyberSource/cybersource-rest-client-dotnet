# CyberSource.Model.ReportingV3ReportSubscriptionsGet200ResponseSubscriptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrganizationId** | **string** | Selected Organization Id | [optional] 
**ReportDefinitionId** | **string** | Report Definition Id | [optional] 
**ReportDefinitionName** | **string** | Report Definition Class | [optional] 
**ReportMimeType** | **string** | Report Format                          Valid values: - application/xml - text/csv  | [optional] 
**ReportFrequency** | **string** | &#39;Report Frequency&#39;  Valid values: - DAILY - WEEKLY - MONTHLY - ADHOC  | [optional] 
**ReportName** | **string** | Report Name | [optional] 
**Timezone** | **string** | Time Zone | [optional] 
**StartTime** | **DateTime?** | Start Time | [optional] 
**StartDay** | **int?** | Start Day | [optional] 
**ReportFields** | **List&lt;string&gt;** | List of all fields String values | [optional] 
**ReportFilters** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | List of filters to apply | [optional] 
**ReportPreferences** | [**Reportingv3reportsReportPreferences**](Reportingv3reportsReportPreferences.md) |  | [optional] 
**GroupId** | **string** | Id for the selected group. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

