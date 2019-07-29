# CyberSource.Model.RequestBody1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrganizationId** | **string** | Valid CyberSource organizationId | [optional] 
**ReportDefinitionName** | **string** | Valid Report Definition Name | 
**ReportFields** | **List&lt;string&gt;** |  | 
**ReportMimeType** | **string** | Valid values: - application/xml - text/csv  | 
**ReportFrequency** | **string** | &#39;The frequency for which subscription is created.&#39;  Valid values: - &#39;DAILY&#39; - &#39;WEEKLY&#39; - &#39;MONTHLY&#39; - &#39;ADHOC&#39;  | 
**ReportName** | **string** |  | 
**Timezone** | **string** |  | 
**StartTime** | **string** | The hour at which the report generation should start. It should be in hhmm format. | 
**StartDay** | **int?** | This is the start day if the frequency is WEEKLY or MONTHLY. The value varies from 1-7 for WEEKLY and 1-31 for MONTHLY. For WEEKLY 1 means Sunday and 7 means Saturday. By default the value is 1. | [optional] 
**ReportFilters** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | List of filters to apply | [optional] 
**ReportPreferences** | [**Reportingv3reportsReportPreferences**](Reportingv3reportsReportPreferences.md) |  | [optional] 
**GroupName** | **string** | Valid GroupName | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

