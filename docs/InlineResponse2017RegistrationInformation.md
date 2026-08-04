# CyberSource.Model.InlineResponse2017RegistrationInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BoardingPackageId** | **string** |  | [optional] 
**Mode** | **string** | In case mode is not provided the API will use COMPLETE as default Possible Values:   - &#39;COMPLETE&#39;   - &#39;PARTIAL&#39;  | [optional] 
**SalesRepId** | **string** |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

