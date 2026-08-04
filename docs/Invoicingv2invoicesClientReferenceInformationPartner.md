# CyberSource.Model.Invoicingv2invoicesClientReferenceInformationPartner
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeveloperId** | **string** | Identifier for the developer that integrated a partner solution with Cybersource. Send this value with all requests that are sent through a partner solution built by that developer. Cybersource assigns the ID to the developer.  **Note** A developerId set to 999 means the submitted developer ID is incorrect.  | [optional] 
**SolutionId** | **string** | Identifier for the partner that integrated with Cybersource. Send this value with all requests sent through the partner solution. Cybersource assigns the ID to the partner.  **Note** A solutionId set to 999 means the submitted solutionId is incorrect.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

