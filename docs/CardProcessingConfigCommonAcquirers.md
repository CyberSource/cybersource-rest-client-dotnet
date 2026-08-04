# CyberSource.Model.CardProcessingConfigCommonAcquirers
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstitutionId** | **string** | Identifier of the acquirer. This number is usually assigned by Visa. | [optional] 
**InterbankCardAssociationId** | **string** | Number assigned by MasterCard to banks to identify the member in transactions. | [optional] 
**DiscoverInstitutionId** | **string** | Assigned by Discover to identify the acquirer. | [optional] 
**CountryCode** | **string** | ISO 4217 format. | [optional] 
**FileDestinationBin** | **string** | The BIN to which this capturefile is sent. This field must contain a valid BIN. | [optional] 
**MerchantVerificationValue** | **string** | Identify merchants that participate in Select Merchant Fee (SMF) programs. Unique to the merchant. | [optional] 
**MerchantId** | **string** | Merchant ID assigned by an acquirer or a processor. Should not be overriden by any other party. | [optional] 
**TerminalId** | **string** | The &#39;Terminal Id&#39; aka TID, is an identifier used for with your payments processor. Depending on the processor and payment acceptance type this may also be the default Terminal ID used for Card Present and Virtual Terminal transactions.  | [optional] 
**AllowMultipleBills** | **bool?** | Allows multiple captures for a single authorization transaction.  | [optional] 
**EnableTransactionReferenceNumber** | **bool?** | To enable merchant to send in transaction reference number (unique reconciliation ID). | [optional] 
**PaymentTypes** | [**Dictionary&lt;string, CardProcessingConfigCommonPaymentTypes&gt;**](CardProcessingConfigCommonPaymentTypes.md) | Valid values are: * VISA * MASTERCARD * AMERICAN_EXPRESS * CUP * EFTPOS * DINERS_CLUB * DISCOVER * JCB  | [optional] 
**Currencies** | [**Dictionary&lt;string, CardProcessingConfigCommonCurrencies&gt;**](CardProcessingConfigCommonCurrencies.md) | Three-character [ISO 4217 ALPHA-3 Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

