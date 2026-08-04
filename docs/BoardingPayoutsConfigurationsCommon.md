# CyberSource.Model.BoardingPayoutsConfigurationsCommon
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentTypes** | **List&lt;string&gt;** | List of card types supported by this merchant.  | [optional] 
**BusinessApplicationId** | **List&lt;string&gt;** | List of supported Business Application Indicators.  | [optional] 
**DefaultBusinessApplicationId** | **string** | Default Business Application Indicator. Must match one of the values in businessApplicationId array.   Possible values: - AA - BB - BI - BP - CB - CD - CI - CO - CP - FD - FT - GD - GP - LA - LO - MD - MI - MP - OG - PD - PG - PP - PS - RP - TU - WT | [optional] 
**Aggregator** | [**BoardingPayoutsConfigurationsCommonAggregator**](BoardingPayoutsConfigurationsCommonAggregator.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

