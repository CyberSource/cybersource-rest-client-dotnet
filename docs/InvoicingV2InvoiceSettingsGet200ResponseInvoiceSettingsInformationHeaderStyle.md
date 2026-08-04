# CyberSource.Model.InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FontColor** | **string** | The invoice font color. The format is a valid hexadecimal code prefixed with &#x60;#&#x60;, such as &#x60;#000000&#x60; for black. | [optional] 
**BackgroundColor** | **string** | The invoice background color. The format is a valid hexadecimal code prefixed with &#x60;#&#x60;, such as &#x60;#ffffff&#x60; for white. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

