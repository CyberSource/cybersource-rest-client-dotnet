# CyberSource.Model.Ptsv2creditsProcessingInformationElectronicBenefitsTransfer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **string** | Flag that specifies the category for the EBT transaction.  Possible values: - &#x60;CASH&#x60;: Cash benefits, which can be used to purchase any item at a participating retailer, as well as to obtain cash-back or make a cash withdrawal from a participating ATM. - &#x60;FOOD&#x60;: Food stamp benefits, which can be used only to purchase food items authorized by the USDA SNAP program.  #### PIN debit Required field for EBT transactions that use PIN debit credit or PIN debit purchase; otherwise, not used.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

