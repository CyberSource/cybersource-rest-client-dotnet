# CyberSource.Model.Flexv2sessionsFieldsOrderInformationBillTo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address1** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 
**Address2** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 
**AdministrativeArea** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 
**BuildingNumber** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 
**Country** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 
**District** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 
**Locality** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 
**PostalCode** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 
**Email** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 
**FirstName** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 
**LastName** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 
**PhoneNumber** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 
**Company** | [**Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount**](Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

