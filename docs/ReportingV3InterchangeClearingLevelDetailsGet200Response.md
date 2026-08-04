# CyberSource.Model.ReportingV3InterchangeClearingLevelDetailsGet200Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDate** | **DateTime?** | Valid report Start Date in **ISO 8601 format**. Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14  **Example:** - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ  | [optional] 
**EndDate** | **DateTime?** | Valid report Start Date in **ISO 8601 format**.  | [optional] 
**InterchangeClearingLevelDetails** | [**List&lt;ReportingV3InterchangeClearingLevelDetailsGet200ResponseInterchangeClearingLevelDetails&gt;**](ReportingV3InterchangeClearingLevelDetailsGet200ResponseInterchangeClearingLevelDetails.md) | List of InterchangeClearingLevelDetail | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

