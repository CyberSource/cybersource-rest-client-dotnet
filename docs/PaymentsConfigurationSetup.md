# CyberSource.Model.PaymentsConfigurationSetup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardProcessing** | [**PaymentsConfigurationSetupCardProcessing**](PaymentsConfigurationSetupCardProcessing.md) |  | [optional] 
**AlternativePaymentMethods** | [**PaymentsConfigurationSetupAlternativePaymentMethods**](PaymentsConfigurationSetupAlternativePaymentMethods.md) |  | [optional] 
**CardPresentConnect** | [**PaymentsConfigurationSetupCardProcessing**](PaymentsConfigurationSetupCardProcessing.md) |  | [optional] 
**ECheck** | [**PaymentsConfigurationSetupCardProcessing**](PaymentsConfigurationSetupCardProcessing.md) |  | [optional] 
**PayerAuthentication** | [**PaymentsConfigurationSetupCardProcessing**](PaymentsConfigurationSetupCardProcessing.md) |  | [optional] 
**DigitalPayments** | [**PaymentsConfigurationSetupDigitalPayments**](PaymentsConfigurationSetupDigitalPayments.md) |  | [optional] 
**SecureAcceptance** | [**PaymentsConfigurationSetupCardProcessing**](PaymentsConfigurationSetupCardProcessing.md) |  | [optional] 
**VirtualTerminal** | [**PaymentsConfigurationSetupCardProcessing**](PaymentsConfigurationSetupCardProcessing.md) |  | [optional] 
**CurrencyConversion** | [**PaymentsConfigurationSetupCardProcessing**](PaymentsConfigurationSetupCardProcessing.md) |  | [optional] 
**Tax** | [**PaymentsConfigurationSetupDigitalPayments**](PaymentsConfigurationSetupDigitalPayments.md) |  | [optional] 
**CustomerInvoicing** | [**PaymentsConfigurationSetupDigitalPayments**](PaymentsConfigurationSetupDigitalPayments.md) |  | [optional] 
**RecurringBilling** | [**PaymentsConfigurationSetupCardProcessing**](PaymentsConfigurationSetupCardProcessing.md) |  | [optional] 
**CybsReadyTerminal** | [**PaymentsConfigurationSetupCardProcessing**](PaymentsConfigurationSetupCardProcessing.md) |  | [optional] 
**PaymentOrchestration** | [**PaymentsConfigurationSetupDigitalPayments**](PaymentsConfigurationSetupDigitalPayments.md) |  | [optional] 
**Payouts** | [**PaymentsConfigurationSetupCardProcessing**](PaymentsConfigurationSetupCardProcessing.md) |  | [optional] 
**PayByLink** | [**PaymentsConfigurationSetupDigitalPayments**](PaymentsConfigurationSetupDigitalPayments.md) |  | [optional] 
**UnifiedCheckout** | [**PaymentsConfigurationSetupDigitalPayments**](PaymentsConfigurationSetupDigitalPayments.md) |  | [optional] 
**ReceivablesManager** | [**PaymentsConfigurationSetupDigitalPayments**](PaymentsConfigurationSetupDigitalPayments.md) |  | [optional] 
**ServiceFee** | [**PaymentsConfigurationSetupCardProcessing**](PaymentsConfigurationSetupCardProcessing.md) |  | [optional] 
**BatchUpload** | [**PaymentsConfigurationSetupDigitalPayments**](PaymentsConfigurationSetupDigitalPayments.md) |  | [optional] 
**TransactGuard** | [**PaymentsConfigurationSetupDigitalPayments**](PaymentsConfigurationSetupDigitalPayments.md) |  | [optional] 
**Microform** | [**PaymentsConfigurationSetupCardProcessing**](PaymentsConfigurationSetupCardProcessing.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

