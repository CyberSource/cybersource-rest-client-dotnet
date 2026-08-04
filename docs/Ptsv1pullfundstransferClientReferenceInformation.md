# CyberSource.Model.Ptsv1pullfundstransferClientReferenceInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Originator-generated order reference or tracking number. It is recommended that you send a unique value for each transaction so that you can perform meaningful searches for the transaction.  | [optional] 
**ApplicationName** | **string** | The name of the Connection Method that the originator uses to send a transaction request to CyberSource.  | [optional] 
**ApplicationVersion** | **string** | Version of the CyberSource application or integration used for a transaction.  | [optional] 
**ApplicationUser** | **string** | The entity that is responsible for running the transaction and submitting the processing request to CyberSource. This could be a person, a system, or a connection method.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

