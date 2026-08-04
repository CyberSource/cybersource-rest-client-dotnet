# CyberSource.Model.PushFunds201ResponseProcessorInformationRouting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | **string** | Contains the ID of the debit network to which the transaction was routed.  Code: Network  0000 : Priority Routing or Generic File Update  0002: Visa programs, Private Label and non-Visa Authorization Gateway Services  0003: Interlink  0004: Plus  0008: Star  0009: Pulse  0010: Star  0011: Star  0012: Star (primary network ID)  0013: AFFN  0015: Star  0016: Maestro  0017: Pulse (primary network ID)  0018: NYCE (primary network ID)  0019: Pulse  0020: Accel  0023: NETS  0024: CU24  0025: Alaska Option  0027: NYCE  0028: Shazam  0029: EBT POS  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

