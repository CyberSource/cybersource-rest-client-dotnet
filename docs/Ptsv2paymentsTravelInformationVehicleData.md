# CyberSource.Model.Ptsv2paymentsTravelInformationVehicleData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectorType** | **string** | This field will contain connector type values for electric vehicle transactions.  Possible Values: 001 (AC - J1772 Type 1) 002 (AC - Mennekes - Type 2) 003 (AC - GB/T) 100 (DC - CCS1) 101 (DC - CHAdeMO) 102 (DC - CCS2) 103 (DC - GB/T) 200 (NACS – Tesla)  | [optional] 
**ChargingReasonCode** | **string** | This field will contain charging reason code values for electric vehicle transactions.  Possible Values: 010 (Other Error) 011 (Connector Lock Failure) 012 (EV Communication Error) 013 (Ground Failure) 014 (High Temperature) 015 (Internal Error) 016 (Over Current Failure) 017 (Over Voltage) 018 (Power Meter Failure) 019 (Power Switch Failure) 020 (Reader Failure) 021 (Reset Failure) 022 (Under Voltage) 023 (Weak Signal) 100 (No Error) 200 (Payment Related Error)  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

