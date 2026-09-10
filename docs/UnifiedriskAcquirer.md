# CyberSource.Model.UnifiedriskAcquirer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcquirerBin** | **string** | Acquirer bank ID number that  corresponds to a certificate that Cybersource already has.This ID has this format. 4XXXXX for Visa and 5XXXXX for Mastercard. | [optional] 
**Country** | **string** | Two-letter ISO 3166-1 country code for the acquirer. Used for jurisdiction, regulatory, and risk evaluation when acquirer country may differ from merchant country (including EEA scenarios). | [optional] 
**Password** | **string** | Registered password for the Visa directory server. | [optional] 
**MerchantId** | **string** | A unique identifier assigned to the merchant by the acquirer or payment processor | [optional] 
**AcquirerId** | **string** | A unique identifier for the acquirer in a transaction. | A unique identifier for the acquirer in a transaction. This is only relevant if the originating event was a card transaction. | [optional] 
**Name** | **string** | Short name of the acquirer in acquirerId | [optional] 
**MerchantAccount** | [**UnifiedriskAcquirerMerchantAccount**](UnifiedriskAcquirerMerchantAccount.md) |  | [optional] 
**DeclinedPhase** | **string** | Indicates the phase or stage in the transaction processing flow at which the authorization was declined (e.g., ISSUER, ACQUIRER, NETWORK, MERCHANT) | [optional] 
**CountrySource** | **string** | The source system or database from which the acquirer&#39;s country code was derived or validated (e.g., BIN table, registration data) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

