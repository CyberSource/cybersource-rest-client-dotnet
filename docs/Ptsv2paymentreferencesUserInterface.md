# CyberSource.Model.Ptsv2paymentreferencesUserInterface
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BorderRadius** | **string** | Border Radius, Allowed Values - Number, Chars, SPACE, Percentage(%), DOT(.), Example &#39;25px 10px 25px 10px&#39;; &#39;2em 1em 0.5em 3em&#39;  | [optional] 
**Theme** | **string** | UI Theme Name/Design Name - Allowed Chars: Alpha Numeric, Dot (.), Hyphen (-), Underscore (_)  | [optional] 
**Color** | [**Ptsv2paymentreferencesUserInterfaceColor**](Ptsv2paymentreferencesUserInterfaceColor.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

