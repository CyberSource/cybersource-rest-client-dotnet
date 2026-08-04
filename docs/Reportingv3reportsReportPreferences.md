# CyberSource.Model.Reportingv3reportsReportPreferences
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SignedAmounts** | **bool?** | Indicator to determine whether negative sign infront of amount for all refunded transaction | [optional] 
**FieldNameConvention** | **string** | Specify the field naming convention to be followed in reports (applicable to only csv report formats)  Valid values: - SOAPI - SCMP  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

