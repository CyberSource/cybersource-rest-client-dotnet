# CyberSource.Model.Upv1capturecontextsDataProcessingInformationAuthorizationOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AftIndicator** | **bool?** | The AFT indicator | [optional] 
**AuthIndicator** | **string** | The authorization indicator | [optional] 
**IgnoreCvResult** | **bool?** | Ignore the CV result | [optional] 
**IgnoreAvsResult** | **bool?** | Ignore the AVS result | [optional] 
**Initiator** | [**Upv1capturecontextsDataProcessingInformationAuthorizationOptionsInitiator**](Upv1capturecontextsDataProcessingInformationAuthorizationOptionsInitiator.md) |  | [optional] 
**BusinessApplicationId** | **string** | The business application Id | [optional] 
**CommerceIndicator** | **string** | The commerce indicator | [optional] 
**ProcessingInstruction** | **string** | The processing instruction | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

