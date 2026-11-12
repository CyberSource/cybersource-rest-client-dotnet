# CyberSource.Model.Ucv1sessionsDataInstallmentInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sequence** | **int?** | Installment number when making payments in installments. Used along with &#x60;totalCount&#x60; to track which payment is being processed.  For example, the second of 5 payments would be passed to CyberSource as &#x60;sequence&#x60; &#x3D; 2 and &#x60;totalCount&#x60; &#x3D; 5.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

