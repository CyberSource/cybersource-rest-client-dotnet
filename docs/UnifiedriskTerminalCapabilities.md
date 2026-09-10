# CyberSource.Model.UnifiedriskTerminalCapabilities
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardReading** | **string** | Card reading capabilities of the terminal performing the transaction. ISO 8583:93 bit 22-2; ISO 8583:2003 bit 27-1 CDFL CardOnFile Card information are stored on a file ICPY ICCProximity ICC contactle | [optional] 
**CardWriting** | **string** | Card writing or output capabilities of the terminal performing the transaction. ISO 8583:93 bit 22-10, ISO 8583:2003 bit 27-8_9 ICPY ICCProximity ICC contactless proximity MGST MagneticStripe Magnetic | [optional] 
**CardholderVerification** | **string** | Cardholder verification capabilities performing the transaction at the point of service. ISO 8583:93 bit 22-2, ISO 8583:2003-1 bit 27-2 APKI AccountDigitalSignature Account based digital signature  NO | [optional] 
**Online** | **string** | Capability of the terminal to go online OFLN OffLine Off-line only capable ONLN OnLine On-line only capable BOTH BothOnLineAndOffLine Both online and offline | [optional] 
**PinPadInoperative** | **bool?** | If true then pin pad is inoperative | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

