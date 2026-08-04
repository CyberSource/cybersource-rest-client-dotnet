# CyberSource.Model.PaymentsProductsServiceFeeConfigurationInformationConfigurations
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Products** | [**Dictionary&lt;string, PaymentsProductsServiceFeeConfigurationInformationConfigurationsProducts&gt;**](PaymentsProductsServiceFeeConfigurationInformationConfigurationsProducts.md) | Products enabled for this account. The following values are supported: virtualTerminal paymentTokenizationOtp subscriptionsOtp virtualTerminalCp eCheck  | [optional] 
**TerminalId** | **string** | Identifier of the terminal at the retail location. | [optional] 
**MerchantId** | **string** | Identifier of a merchant account. | [optional] 
**MerchantInformation** | [**PaymentsProductsServiceFeeConfigurationInformationConfigurationsMerchantInformation**](PaymentsProductsServiceFeeConfigurationInformationConfigurationsMerchantInformation.md) |  | [optional] 
**PaymentInformation** | [**List&lt;PaymentsProductsServiceFeeConfigurationInformationConfigurationsPaymentInformation&gt;**](PaymentsProductsServiceFeeConfigurationInformationConfigurationsPaymentInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

