# CyberSource.Model.PushFunds201ResponseProcessorInformationSettlement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResponsibilityFlag** | **bool?** | Settlement Responsibility Flag: VisaNet sets this flag.  This flag is set to true to indicate that VisaNet has settlement responsibility for this transaction. This flag does not indicate the transaction will be settled.  | [optional] 
**ServiceFlag** | **string** | Settlement Service for the transaction.  Values:  VIP: V.I.P. to decide; or not applicable  INTERNATIONAL_SETTLEMENT: International   NATIONAL_NET_SETTLEMENT: National Net Settlement  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

