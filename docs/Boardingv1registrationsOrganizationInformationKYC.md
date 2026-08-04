# CyberSource.Model.Boardingv1registrationsOrganizationInformationKYC
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WhenIsCustomerCharged** | **string** | Possible values: - ONETIMEBEFORE - ONETIMEAFTER - OTHER | 
**WhenIsCustomerChargedDescription** | **string** |  | [optional] 
**OfferSubscriptions** | **bool?** |  | 
**MonthlySubscriptionPercent** | **decimal?** |  | [optional] 
**QuarterlySubscriptionPercent** | **decimal?** |  | [optional] 
**SemiAnnualSubscriptionPercent** | **decimal?** |  | [optional] 
**AnnualSubscriptionPercent** | **decimal?** |  | [optional] 
**TimeToProductDelivery** | **string** | Possible values: - INSTANT - UPTO2 - UPTO5 - UPTO10 - GREATERTHAN10 | 
**EstimatedMonthlySales** | **decimal?** |  | 
**AverageOrderAmount** | **decimal?** |  | 
**LargestExpectedOrderAmount** | **decimal?** |  | 
**DepositBankAccount** | [**Boardingv1registrationsOrganizationInformationKYCDepositBankAccount**](Boardingv1registrationsOrganizationInformationKYCDepositBankAccount.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

