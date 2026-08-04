# CyberSource.Model.Ucv1sessionsPaymentConfigurationsTMSTOKEN
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Customer** | [**Ucv1sessionsPaymentConfigurationsTMSTOKENCustomer**](Ucv1sessionsPaymentConfigurationsTMSTOKENCustomer.md) |  | [optional] 
**PaymentInstruments** | [**List&lt;Ucv1sessionsPaymentConfigurationsTMSTOKENPaymentInstruments&gt;**](Ucv1sessionsPaymentConfigurationsTMSTOKENPaymentInstruments.md) | List of existing payment instrument tokens associated with the customer.  | [optional] 
**InstrumentIdentifiers** | [**List&lt;Ucv1sessionsPaymentConfigurationsTMSTOKENInstrumentIdentifiers&gt;**](Ucv1sessionsPaymentConfigurationsTMSTOKENInstrumentIdentifiers.md) | List of existing instrument identifier tokens. If not supplied, the default token type for the merchant&#39;s token vault is used.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

