# CyberSource.Model.UnifiedriskInitiatingParty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the initiating party, where this is not the account ID. This would be expected to be mandatory for commercial use cases. It refers to the initiatingParty involved in the original transaction and | [optional] 
**Name** | **string** | A human readable string identifying the initiator as indentified in the intiatiatingPartyId attribute. | [optional] 
**Type** | **string** | The initiatingPartyId typically represents an individual user in the commercial banking setting. However it can also be used to represent the open banking entity that initiating the action. This attri | [optional] 
**EntityId** | **string** | Unique identifier for the legal or organizational entity initiating the transaction on behalf of the customer, used for commercial or open banking flows (e.g., payment service provider or corporate entity ID) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

