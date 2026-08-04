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

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

