# CyberSource.Model.Ptsv2paymentsProcessingInformationCardVerification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckAVS** | **string** | Verification control flag to opt-in or opt-out of Address Verification Service (AVS) for a transaction.  Possible values: - &#x60;Y&#x60;: Enable AVS verification for this transaction - &#x60;N&#x60;: Disable AVS verification for this transaction  #### Used by **Authorization** Optional field for controlling AVS verification at the transaction level.  #### API Ticket ACCAPI-2156  | [optional] 
**CheckANI** | **string** | Verification control flag to opt-in or opt-out of Address Name Inquiry (ANI) for a transaction.  Possible values: - &#x60;Y&#x60;: Enable ANI verification for this transaction - &#x60;N&#x60;: Disable ANI verification for this transaction  #### Used by **Authorization** Optional field for controlling ANI verification at the transaction level.  #### API Ticket ACCAPI-2156  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

