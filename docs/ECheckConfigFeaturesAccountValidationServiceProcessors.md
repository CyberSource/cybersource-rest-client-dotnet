# CyberSource.Model.ECheckConfigFeaturesAccountValidationServiceProcessors
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AvsAccountOwnershipService** | **bool?** | *NEW* Determined in WF eTicket if account has opted into the Account Ownership Service. | [optional] 
**AvsAccountStatusService** | **bool?** | *NEW* Determined in WF eTicket if account has opted into the Account Status Service. | [optional] 
**AvsSignedAgreement** | **bool?** | *NEW* Taken from Addendum Agreement Column in boarding form. | [optional] 
**AvsCalculatedResponseBehavior** | **string** | *NEW*  Possible values: - continue | [optional] [default to "continue"]
**AvsAdditionalId** | **string** | *NEW* Also known as the Additional ID. Taken from the boarding form. | [optional] 
**EnableAvs** | **bool?** | *NEW* | [optional] [default to true]
**AvsEntityId** | **string** | *NEW* Also known as the AVS Gateway Entity ID. | [optional] 
**AvsResultMode** | **string** | *NEW*  Possible values: - FULL_RESPONSE - LOGIC_BOX | [optional] 
**EnableAvsTokenCreation** | **bool?** | *NEW* Applicable if the merchant wants to run AVS on token creation requests only. | [optional] [default to false]

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

