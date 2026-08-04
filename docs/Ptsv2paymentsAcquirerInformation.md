# CyberSource.Model.Ptsv2paymentsAcquirerInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcquirerBin** | **string** | Acquirer bank ID number that  corresponds to a certificate that Cybersource already has.This ID has this format. 4XXXXX for Visa and 5XXXXX for Mastercard.  | [optional] 
**Country** | **string** | Issuers need to be aware of the Acquirer&#39;s Country Code when the Acquirer country differs from the Merchant country and the Acquirer is in the EEA (European Economic Area).  | [optional] 
**Password** | **string** | Registered password for the Visa directory server.  | [optional] 
**MerchantId** | **string** | Username for the visa directory server that is created when your acquirer sets up your account. This ID might be the same as your merchant ID. the username can be 15 or 23 characters.  | [optional] 
**AcquirerMerchantId** | **string** | Acquirer assigned merchant id. Check if your processor supports this field.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

