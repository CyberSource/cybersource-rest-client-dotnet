# CyberSource.Model.PostDeviceSearchRequestV3
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | **string** | The Search Query to retrieve the Terminals.(Example :- serialNumber:456345234 AND readerId:509353f0-86ca-4af4-a1c9-c2702bfd7431  AND terminalId:7854922 AND status:Inactive AND statusChangeReason:Other AND organizationId:London Store) | [optional] 
**Sort** | **string** | terminalCreationDate:desc (default) or serialNumber or terminalUpdationDate | [optional] 
**Offset** | **long?** | The offset or page number. | [optional] 
**Limit** | **long?** | Number of devices to retrieve in one request. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

