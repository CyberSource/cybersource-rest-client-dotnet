# CyberSource.Model.Vasv1currencyconversionPointOfSaleInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TerminalId** | **string** | Identifier for the terminal used by the merchant&#39;s to process the transaction. | [optional] 
**EntryMode** | **string** | Valid Values: - &#39;KEYED&#39; - &#39;SWIPED&#39; - &#39;CONTACT&#39; - &#39;CONTACTLESS&#39;  How the transaction information was captured. Optional. &#x60;KEYED&#x60; can refer to MOTO on a terminal, MOTO on a virtual terminal, or eCommerce. All other options refer to card holder present transactions. Optional.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

