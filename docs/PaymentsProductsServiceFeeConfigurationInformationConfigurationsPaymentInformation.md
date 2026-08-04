# CyberSource.Model.PaymentsProductsServiceFeeConfigurationInformationConfigurationsPaymentInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentType** | **string** | Payment types accepted by this merchant. The supported values are: MASTERDEBIT, MASTERCREDIT, VISACREDIT, VISADEBIT, DISCOVERCREDIT, AMEXCREDIT, ECHECK  Possible values: - MASTERDEBIT - MASTERCREDIT - VISACREDIT - VISADEBIT - DISCOVERCREDIT - AMEXCREDIT - ECHECK | [optional] 
**FeeType** | **string** | Fee type for the selected payment type. Supported values are: Flat or Percentage.   Possible values: - FLAT - PERCENTAGE | [optional] 
**FeeAmount** | **decimal?** | Fee Amount of the selected payment type if you chose Flat fee type.  | [optional] 
**Percentage** | **decimal?** | Percentage of the selected payment type if you chose Percentage Fee type. Supported values use numbers with decimals. For example, 1.0  | [optional] 
**FeeCap** | **decimal?** | Fee cap for the selected payment type. Supported values use numbers with decimals. For example, 1.0  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

