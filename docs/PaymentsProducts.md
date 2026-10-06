# CyberSource.Model.PaymentsProducts
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardProcessing** | [**PaymentsProductsCardProcessing**](PaymentsProductsCardProcessing.md) |  | [optional] 
**AlternativePaymentMethods** | [**PaymentsProductsAlternativePaymentMethods**](PaymentsProductsAlternativePaymentMethods.md) |  | [optional] 
**CardPresentConnect** | [**PaymentsProductsCardPresentConnect**](PaymentsProductsCardPresentConnect.md) |  | [optional] 
**CybsReadyTerminal** | [**PaymentsProductsCybsReadyTerminal**](PaymentsProductsCybsReadyTerminal.md) |  | [optional] 
**ECheck** | [**PaymentsProductsECheck**](PaymentsProductsECheck.md) |  | [optional] 
**PayerAuthentication** | [**PaymentsProductsPayerAuthentication**](PaymentsProductsPayerAuthentication.md) |  | [optional] 
**DigitalPayments** | [**PaymentsProductsDigitalPayments**](PaymentsProductsDigitalPayments.md) |  | [optional] 
**SecureAcceptance** | [**PaymentsProductsSecureAcceptance**](PaymentsProductsSecureAcceptance.md) |  | [optional] 
**VirtualTerminal** | [**PaymentsProductsVirtualTerminal**](PaymentsProductsVirtualTerminal.md) |  | [optional] 
**CurrencyConversion** | [**PaymentsProductsCurrencyConversion**](PaymentsProductsCurrencyConversion.md) |  | [optional] 
**Tax** | [**PaymentsProductsTax**](PaymentsProductsTax.md) |  | [optional] 
**CustomerInvoicing** | [**PaymentsProductsTax**](PaymentsProductsTax.md) |  | [optional] 
**RecurringBilling** | [**PaymentsProductsTax**](PaymentsProductsTax.md) |  | [optional] 
**PaymentOrchestration** | [**PaymentsProductsTax**](PaymentsProductsTax.md) |  | [optional] 
**Payouts** | [**PaymentsProductsPayouts**](PaymentsProductsPayouts.md) |  | [optional] 
**DifferentialFee** | [**PaymentsProductsDifferentialFee**](PaymentsProductsDifferentialFee.md) |  | [optional] 
**PayByLink** | [**PaymentsProductsTax**](PaymentsProductsTax.md) |  | [optional] 
**UnifiedCheckout** | [**PaymentsProductsUnifiedCheckout**](PaymentsProductsUnifiedCheckout.md) |  | [optional] 
**ReceivablesManager** | [**PaymentsProductsTax**](PaymentsProductsTax.md) |  | [optional] 
**ServiceFee** | [**PaymentsProductsServiceFee**](PaymentsProductsServiceFee.md) |  | [optional] 
**BatchUpload** | [**PaymentsProductsTax**](PaymentsProductsTax.md) |  | [optional] 
**PaymentEvents** | [**PaymentsProductsTax**](PaymentsProductsTax.md) |  | [optional] 
**TransactGuard** | [**PaymentsProductsTax**](PaymentsProductsTax.md) |  | [optional] 
**Microform** | [**PaymentsProductsMicroform**](PaymentsProductsMicroform.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

