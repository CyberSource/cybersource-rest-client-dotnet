# CyberSource.Model.InlineResponse20011Devices
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReaderId** | **string** |  | [optional] 
**SerialNumber** | **string** |  | [optional] 
**Model** | **string** |  | [optional] 
**Make** | **string** |  | [optional] 
**HardwareRevision** | **string** |  | [optional] 
**Status** | **string** | Status of the device. Possible Values:   - &#39;ACTIVE&#39;   - &#39;INACTIVE&#39;  | [optional] 
**StatusChangeReason** | **string** | Reason for change in status. | [optional] 
**MerchantId** | **string** | ID of the merchant to whom this device is assigned. | [optional] 
**AccountId** | **string** | ID of the account to whom the device assigned. | [optional] 
**TerminalCreationDate** | **DateTime?** | Timestamp in which the device was created. | [optional] 
**TerminalUpdationDate** | **DateTime?** | Timestamp in which the device was updated/modified. | [optional] 
**PaymentProcessorToTerminalMap** | [**InlineResponse20011PaymentProcessorToTerminalMap**](InlineResponse20011PaymentProcessorToTerminalMap.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

