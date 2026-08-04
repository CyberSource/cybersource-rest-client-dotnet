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

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

